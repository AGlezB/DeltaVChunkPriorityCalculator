using ChunkPriorityCalculator.Model;

namespace ChunkPriorityCalculator.Rules
{
	public class ChunkPriceRule : AbstractSlidingRule
	{
		protected override string _tag => nameof(ChunkPriceRule);
		public override int MinSliderValue => 0;
		public override int MaxSliderValue => 10;

		/// <summary>
		/// Clamps the price. Value in $.
		/// </summary>
		public const int MaxChunkPrice = 50_000; // 50k

		/// <summary>
		/// The pricing data for the ores.
		/// </summary>
		public Dictionary<OreType, OreMarketPrice>? MarketPrices;

		public override decimal Evaluate(OreChunk chunk)
		{
			if (MarketPrices is null || chunk.OreType is null || !MarketPrices.TryGetValue(chunk.OreType.Value, out var mp))
			{
				return 0;
			}
			var chunkPrice = (decimal)chunk.OreWeightKg / 1000 * mp.Price;
			var priceFactor = CalculateFactor(0, MaxChunkPrice, chunkPrice);
			var valueFactor = CalculateFactor();
			var result = priceFactor * valueFactor;
			return result;
		}
	}
}
