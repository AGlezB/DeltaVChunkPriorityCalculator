using ChunkPriorityCalculator.Rules;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;

namespace ChunkPriorityCalculator
{
	public partial class SlidingRuleUI : UserControl
	{

		#region Properties & Fields

		/// <summary>
		/// The rule for the control.
		/// </summary>
		public AbstractSlidingRule? Rule
		{
			get => _rule;
			set
			{
				_rule = value;
				FillValues();
				NotifyRuleChanged();
			}
		}
		private AbstractSlidingRule? _rule;

		[Category("Data"), Description("The display name of the rule.")]
		public string RuleDisplayName { get => grpRule.Text; set => grpRule.Text = value; }

		[Category("Data"), Description("The rule description to display as a tooltip.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		public string RuleTooltip { get => toolTip.GetToolTip(grpRule); set => toolTip.SetToolTip(grpRule, value); }

		/// <summary>
		/// Used to retrieve the new value when the slider changes.
		/// </summary>
		public int Value => trkSlider.Value;

		/// <summary>
		/// To avoid firing unnecesary events.
		/// </summary>
		private bool _fillingValues = false;

		#endregion

		#region Constructors

		public SlidingRuleUI()
		{
			InitializeComponent();
		}

		#endregion

		#region Events

		public event EventHandler? RuleChanged;

		private void NotifyRuleChanged()
		{
			if (RuleChanged is not null)
			{
				RuleChanged(this, EventArgs.Empty);
			}
		}

		#endregion

		#region Methods

		private void RefreshValue()
		{
			if (_fillingValues)
			{
				return;
			}
			lblValue.Text = trkSlider.Value.ToString();
		}

		private void FillValues()
		{
			_fillingValues = true;

			if (_rule is null)
			{
				nudWeight.Value = 1;
				trkSlider.Minimum = -10;
				trkSlider.Maximum = 10;
				trkSlider.Value = 0;
			}
			else
			{
				nudWeight.Value = _rule.RuleWeightMultiplier;
				trkSlider.Minimum = _rule.MinSliderValue;
				trkSlider.Maximum = _rule.MaxSliderValue;
				trkSlider.Value = _rule.SliderValue;
			}
			lblMin.Text = trkSlider.Minimum.ToString();
			lblMax.Text = trkSlider.Maximum.ToString();

			_fillingValues = false;

			RefreshValue();
			NotifyRuleChanged();
		}

		#endregion

		#region Event handlers

		private void trkSlider_ValueChanged(object sender, EventArgs e)
		{
			if (_fillingValues || _rule is null)
			{
				return;
			}
			_rule.SliderValue = trkSlider.Value;
			RefreshValue();
			NotifyRuleChanged();
		}

		private void nudWeight_ValueChanged(object sender, EventArgs e)
		{
			if (_fillingValues || _rule is null)
			{
				return;
			}
			_rule.RuleWeightMultiplier = nudWeight.Value;
			NotifyRuleChanged();
		}

		#endregion

	}
}
