using ChunkPriorityCalculator.Model;

namespace ChunkPriorityCalculator.Rules
{
	public class OrePriceRule : AbstractSlidingRule
	{
		protected override string _tag => nameof(OrePriceRule);
		public override int MinSliderValue => 0;
		public override int MaxSliderValue => 10;

		/// <summary>
		/// The pricing data for the ores.
		/// </summary>
		public IEnumerable<OreMarketPrice>? MarketPrices
		{
			get => _marketPrices;
			set
			{
				_marketPrices = value;
				Precalculate();
			}
		}
		protected IEnumerable<OreMarketPrice>? _marketPrices;

		/// <summary>
		/// Contains the precalculated factors as a fraction of the highest price.
		/// </summary>
		protected Dictionary<OreType, decimal>? priceFactors;

		/// <summary>
		/// Precalculates the values to speed up rule processing.
		/// <para>This method is called automatically when setting <see cref="MarketPrices"/>.</para>
		/// <para>Only call this method when changing data in <see cref="MarketPrices"/> after it has been set.</para>
		/// <para>Note to self: not worth the trouble of using observables.</para>
		/// <param name="marketPrices">If specified, replaces current prices.</param>
		/// </summary>
		public void Precalculate(IEnumerable<OreMarketPrice>? marketPrices = null)
		{
			priceFactors = null;
			_marketPrices = marketPrices ?? _marketPrices;
			if (_marketPrices is null || !_marketPrices.Any())
			{
				return;
			}

			var highestPrice = _marketPrices.Max(s => s.Price);
			if (highestPrice <= 0)
			{
				return;
			}

			priceFactors = new();
			foreach (var omp in _marketPrices)
			{
				priceFactors[omp.OreType] = CalculateFactor(0, highestPrice, omp.Price);
			}
		}

		public override decimal Evaluate(OreChunk chunk)
		{
			if (priceFactors is null || chunk.OreType is null || !priceFactors.TryGetValue(chunk.OreType.Value, out var priceFactor))
			{
				return 0;
			}
			var valueFactor = CalculateFactor();
			var result = priceFactor * valueFactor;
			return result;
		}
	}
}
