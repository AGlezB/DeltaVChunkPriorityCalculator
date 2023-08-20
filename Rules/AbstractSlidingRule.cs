namespace ChunkPriorityCalculator.Rules
{
	public abstract class AbstractSlidingRule : AbstractPriorityRule
	{

		/// <summary>
		/// The smallest value the slider can take. Must be lesser than <see cref="MaxSliderValue"/>
		/// </summary>
		public abstract int MinSliderValue { get; }

		/// <summary>
		/// The biggest value the slider can take. Must be greater than <see cref="MinSliderValue"/>
		/// </summary>
		public abstract int MaxSliderValue { get; }

		/// <summary>
		/// Represents the actual value in the slider.
		/// </summary>
		public int SliderValue
		{
			get => _sliderValue;
			set => _sliderValue = Math.Clamp(value, MinSliderValue, MaxSliderValue);
		}
		protected int _sliderValue;

		/// <summary>
		/// Calculates the proportion of the value in relation to the range.
		/// </summary>
		/// <param name="min">Start of the range.</param>
		/// <param name="max">End of the range.</param>
		/// <param name="value">The value within the range.</param>
		/// <returns>A value in the range <c>[-1..1]</c> if <paramref name="min"/> and <paramref name="max"/> are on opposite sides of the <c>zero</c>
		/// and a value in the range <c>[0..1]</c> if not.</returns>
		protected static decimal CalculateFactor(decimal min, decimal max, decimal value)
		{
			if (min > max)
			{
				(min, max) = (max, min);
			}
			value = Math.Clamp(value, min, max);

			if (min < 0 && max > 0)
			{
				// If the range extends both ways calculate the factor relative to the zero maintaining the sign to indicate direction.
				var sideFactor = value / (value >= 0 ? max : -min);
				return sideFactor;
			}

			decimal shift = 0;
			if (max <= 0)
			{
				// Shift range to the right to the possitive side
				shift = Math.Abs(min);
			}
			else if (min > 0)
			{
				// Shift range to the left to zero
				shift = -min;
			}
			max += shift;
			value += shift;

			var factor = value / max;
			return factor;
		}

		/// <summary>
		/// Calculates the factor using <see cref="MinSliderValue"/>, <see cref="MaxSliderValue"/> and <see cref="SliderValue"/> as parameters.
		/// </summary>
		/// <returns>The result of <see cref="CalculateFactor(decimal, decimal, decimal)"/></returns>
		protected decimal CalculateFactor() => CalculateFactor(MinSliderValue, MaxSliderValue, SliderValue);

		public override void Load(Dictionary<string, string> ruleData)
		{
			base.Load(ruleData);
			SliderValue = (int)(LoadDecimal(ruleData, nameof(SliderValue)) ?? 0);
		}

		public override void Save(Dictionary<string, string> ruleData)
		{
			base.Save(ruleData);
			SaveDecimal(ruleData, nameof(SliderValue), SliderValue);
		}

	}
}
