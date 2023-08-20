using ChunkPriorityCalculator.Model;

namespace ChunkPriorityCalculator.Rules
{
	public class ChunkSpeedRule : AbstractSlidingRule
	{
		protected override string _tag => nameof(ChunkSpeedRule);
		public override int MinSliderValue => -10;
		public override int MaxSliderValue => 10;

		/// <summary>
		/// Clamps the speed in both directions. Value in m/s.
		/// </summary>
		public const int MaxAbsoluteSpeed = 20;

		public override decimal Evaluate(OreChunk chunk)
		{
			if (SliderValue == 0)
			{
				return 0;
			}
			var valueFactor = CalculateFactor();
			var speedFactor = CalculateFactor(-MaxAbsoluteSpeed, MaxAbsoluteSpeed, chunk.RelativeSpeed);
			var result = speedFactor * valueFactor / 2 + 0.5M; // No need to clamp
			return result;
		}
	}
}
