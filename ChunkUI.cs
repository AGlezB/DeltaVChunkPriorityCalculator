using ChunkPriorityCalculator.Model;

namespace ChunkPriorityCalculator
{
	public partial class ChunkUI : UserControl
	{

		#region Properties & Fields

		/// <summary>
		/// The chunk data for the control.
		/// </summary>
		public OreChunk? Chunk
		{
			get => _chunk;
			set
			{
				_chunk = value;
				FillValues();
				NotifyChunkChanged();
			}
		}
		private OreChunk? _chunk;

		/// <summary>
		/// Updates the priority.
		/// </summary>
		public decimal Priority
		{
			get => _priority;
			set
			{
				_priority = value;
				txtPriority.Text = value.ToString("N3");
			}
		}
		protected decimal _priority;

		/// <summary>
		/// Updates the ore value.
		/// </summary>
		public decimal OreValue { set => txtOreValue.Text = value.ToString("N2"); }

		/// <summary>
		/// To avoid firing unnecesary events.
		/// </summary>
		private bool _fillingValues = false;

		#endregion

		#region Constructors

		public ChunkUI()
		{
			InitializeComponent();

			_fillingValues = true;

			cmbOreType.Items.Clear();
			cmbOreType.Items.AddRange(Enum.GetValues<OreType>().Select(s => s.ToString()).Order().ToArray());
			cmbOreType.SelectedIndex = -1;

			_fillingValues = false;
		}

		#endregion

		#region Events

		public event EventHandler? ChunkChanged;

		private void NotifyChunkChanged()
		{
			if (ChunkChanged is not null)
			{
				ChunkChanged(this, EventArgs.Empty);
			}
		}

		#endregion

		#region Methods

		private void RefreshTotalWeight()
		{
			if (_fillingValues)
			{
				return;
			}
			txtTotalWeight.Text = _chunk?.TotalWeightKg.ToString("N0");
		}

		private void FillValues()
		{
			_fillingValues = true;

			txtPriority.Clear();
			if (_chunk is null)
			{
				cmbOreType.SelectedIndex = -1;
				nudOreWeightKg.Value = 0;
				nudWaterWeightKg.Value = 0;
				txtTotalWeight.Clear();
				nudRelativeSpeed.Value = 0;
			}
			else
			{
				cmbOreType.SelectedItem = _chunk!.OreType?.ToString();
				nudOreWeightKg.Value = Math.Clamp(_chunk.OreWeightKg, nudOreWeightKg.Minimum, nudOreWeightKg.Maximum);
				nudWaterWeightKg.Value = Math.Clamp(_chunk.WaterWeightKg, nudWaterWeightKg.Minimum, nudWaterWeightKg.Maximum);
				nudRelativeSpeed.Value = Math.Clamp(_chunk.RelativeSpeed, nudRelativeSpeed.Minimum, nudRelativeSpeed.Maximum);
			}

			_fillingValues = false;

			RefreshTotalWeight();
			NotifyChunkChanged();
		}


		#endregion

		#region Event handlers

		private void cmbOreType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_fillingValues || _chunk is null)
			{
				return;
			}
			_chunk.OreType = Enum.TryParse<OreType>(cmbOreType.SelectedItem as string ?? string.Empty, out var oreType) ? oreType : null;
			NotifyChunkChanged();
		}

		private void nudOreContent_ValueChanged(object sender, EventArgs e)
		{
			if (_fillingValues || _chunk is null)
			{
				return;
			}
			_chunk.OreWeightKg = (int)nudOreWeightKg.Value;
			RefreshTotalWeight();
			NotifyChunkChanged();
		}

		private void nudWaterContent_ValueChanged(object sender, EventArgs e)
		{
			if (_fillingValues || _chunk is null)
			{
				return;
			}
			_chunk.WaterWeightKg = (int)nudWaterWeightKg.Value;
			RefreshTotalWeight();
			NotifyChunkChanged();
		}

		private void nudRelativeSpeed_ValueChanged(object sender, EventArgs e)
		{
			if (_fillingValues || _chunk is null)
			{
				return;
			}
			_chunk.RelativeSpeed = nudRelativeSpeed.Value;
			NotifyChunkChanged();
		}

		#endregion

	}
}
