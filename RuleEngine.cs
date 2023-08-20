using ChunkPriorityCalculator.Rules;

namespace ChunkPriorityCalculator
{
	public class RuleEngine
	{
		/// <summary>
		/// Predefined rules to be evaluated. The order is not relevant.
		/// </summary>
		public IEnumerable<IPriorityRule>? Rules;

		/// <summary>
		/// Evaluates the rules and calculates the priority of the chunk.
		/// </summary>
		/// <param name="chunk">A chunk</param>
		/// <returns>A value representing priority. A higher value indicate higher priority.</returns>
		public decimal CalculatePriority(Model.OreChunk? chunk)
		{
			if (Rules is null || chunk is null)
			{
				return 0;
			}
			var priority = 0M;
			foreach (var rule in Rules)
			{
				priority += rule.Evaluate(chunk) * rule.RuleWeightMultiplier;
			}
			return priority;
		}
	}
}
