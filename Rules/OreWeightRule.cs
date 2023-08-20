using ChunkPriorityCalculator.Model;

namespace ChunkPriorityCalculator.Rules
{
	public class OreWeightRule : AbstractSlidingRule
	{
		protected override string _tag => nameof(OreWeightRule);
		public override int MinSliderValue => -100;
		public override int MaxSliderValue => 100;

		/// <summary>
		/// Clamps the weight. Value in kilograms.
		/// </summary>
		public const int MaxWeightKg = 10_000; // 10 tons

		/// <summary>
		/// The minimum weight in kilograms that will be considered. Values below this have minimal priority.
		/// This is meant to be fed from the geologist's screen.
		/// </summary>
		public int MinWeightKg { get => _minWeightKg; set => _minWeightKg = Math.Clamp(value, 0, MaxWeightKg); }
		private int _minWeightKg;

		public override decimal Evaluate(OreChunk chunk)
		{
			var oreWeight = Math.Clamp(chunk.OreWeightKg, 0, MaxWeightKg);
			if (oreWeight < MinWeightKg)
			{
				return 0;
			}
			var result = oreWeight / MaxWeightKg; // No need to clamp
			return result;
		}

		public override void Load(Dictionary<string, string> ruleData)
		{
			base.Load(ruleData);
			MinWeightKg = (int)(LoadDecimal(ruleData, nameof(MinWeightKg)) ?? 0);
		}

		public override void Save(Dictionary<string, string> ruleData)
		{
			base.Save(ruleData);
			SaveDecimal(ruleData, nameof(MinWeightKg), MinWeightKg);
		}
	}
}
