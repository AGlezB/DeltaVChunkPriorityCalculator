using ChunkPriorityCalculator.Model;
using System.Globalization;

namespace ChunkPriorityCalculator.Rules
{
	public abstract class AbstractPriorityRule : IPriorityRule
	{
		/// <summary>
		/// Class identifier for saving/loading rule data. Don't forget to override in subclasses.
		/// </summary>
		protected abstract string _tag { get; }

		public decimal RuleWeightMultiplier { get; set; } = 1;

		public abstract decimal Evaluate(OreChunk chunk);

		public virtual void Load(Dictionary<string, string> ruleData)
		{
			RuleWeightMultiplier = LoadDecimal(ruleData, $"{_tag}_{nameof(RuleWeightMultiplier)}") ?? 1;
		}

		public virtual void Save(Dictionary<string, string> ruleData)
		{
			SaveDecimal(ruleData, nameof(RuleWeightMultiplier), RuleWeightMultiplier);
		}

		protected decimal? LoadDecimal(Dictionary<string, string> ruleData, string fieldName)
		{
			var key = $"{_tag}_{fieldName}";
			decimal? value = ruleData.TryGetValue(key, out var str)
				&& decimal.TryParse(str, CultureInfo.InvariantCulture, out var val)
				? val : null;
			return value;
		}

		protected void SaveDecimal(Dictionary<string, string> ruleData, string fieldName, decimal? val)
		{
			var key = $"{_tag}_{fieldName}";
			if (val is null)
			{
				ruleData.Remove(key);
			}
			else
			{
				ruleData[key] = val.Value.ToString(CultureInfo.InvariantCulture);
			}
		}

	}
}
