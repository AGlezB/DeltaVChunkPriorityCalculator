namespace ChunkPriorityCalculator.Rules
{
	/// <summary>
	/// The standard interface for all rules.
	/// </summary>
	public interface IPriorityRule
	{
		/// <summary>
		/// This is factor is used by the rule engine to adjoust the result of the evaluation.
		/// Must be a possitive value with 1 being the default.
		/// </summary>
		public decimal RuleWeightMultiplier { get; set; }

		/// <summary>
		/// Evaluates the rule for the given parameters.
		/// </summary>
		/// <param name="chunk">An ore chunk.</param>
		/// <returns>The priority weight calculated for the rule. The value must always be in the [0..1] range with higher values indicate higer priority.</returns>
		public decimal Evaluate(Model.OreChunk chunk);

		/// <summary>
		/// Saves custom rule data.
		/// </summary>
		/// <param name="ruleData">Rule data.</param>
		public void Save(Dictionary<string, string> ruleData);

		/// <summary>
		/// Loads custom rule data.
		/// </summary>
		/// <param name="ruleData">Rule data.</param>
		public void Load(Dictionary<string, string> ruleData);
	}
}
