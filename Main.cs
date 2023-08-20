using ChunkPriorityCalculator.Model;
using ChunkPriorityCalculator.Rules;
using System.Reflection;
using System.Text.Json;

namespace ChunkPriorityCalculator
{
	public partial class Main : Form
	{

		#region Fields and Properties

		private RuleEngine? _ruleEngine;
		private Dictionary<OreType, OreMarketPrice>? _marketPrices;
		private ChunkSpeedRule? _chunkSpeedRule;
		private OrePriceRule? _orePriceRule;
		private ChunkPriceRule? _chunkPriceRule;

		/// <summary>
		/// To avoid firing unnecesary events.
		/// </summary>
		private bool _fillingValues = false;

		#endregion

		#region Constructors

		public Main()
		{
			InitializeComponent();

			// This will simplify other parts of the code:
			nudPriceBe.Tag = OreType.Be;
			nudPriceFe.Tag = OreType.Fe;
			nudPricePd.Tag = OreType.Pd;
			nudPricePt.Tag = OreType.Pt;
			nudPriceV.Tag = OreType.V;
			nudPriceW.Tag = OreType.W;

			var exeDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			ofd.InitialDirectory = sfd.InitialDirectory = Path.Combine(exeDir!, "Examples");

			CreateSampleValues();
			Recalculate();
		}

		#endregion

		#region Methods

		private void CreateSampleValues(bool fillValues = true)
		{
			_fillingValues = true;

			// Market prices
			var marketPrices = new List<OreMarketPrice>
			{
				new() { OreType = OreType.Be, Price = 20618.4M },
				new() { OreType = OreType.Fe, Price = 881.28M },
				new() { OreType = OreType.Pd, Price = 2524.42M },
				new() { OreType = OreType.Pt, Price = 2732.13M },
				new() { OreType = OreType.V, Price = 3034.67M },
				new() { OreType = OreType.W, Price = 6274.49M },
			};

			_marketPrices = new();
			foreach (var mp in marketPrices)
			{
				_marketPrices[mp.OreType] = mp;
			}

			// Chunks
			var chunk1 = new OreChunk
			{
				OreType = OreType.Be,
				OreWeightKg = 500,
				WaterWeightKg = 200,
				RelativeSpeed = 15,
			};
			uiChunk1.Chunk = chunk1;

			var chunk2 = new OreChunk
			{
				OreType = OreType.Fe,
				OreWeightKg = 1500,
				WaterWeightKg = 3700,
				RelativeSpeed = -20,
			};
			uiChunk2.Chunk = chunk2;

			// Rules
			_chunkSpeedRule = new ChunkSpeedRule();
			uisChunkSpeed.Rule = _chunkSpeedRule;

			_orePriceRule = new OrePriceRule
			{
				MarketPrices = marketPrices
			};
			_orePriceRule.Precalculate();
			uisOrePrice.Rule = _orePriceRule;

			_chunkPriceRule = new ChunkPriceRule
			{
				MarketPrices = _marketPrices
			};
			uisChunkPrice.Rule = _chunkPriceRule;

			_ruleEngine = new()
			{
				Rules = new IPriorityRule[] {
					_chunkSpeedRule,
					_orePriceRule,
					_chunkPriceRule,
				},
			};

			_fillingValues = false;

			if (fillValues)
			{
				FillValues(true);
			}
		}

		private void FillPrices(IEnumerable<OreMarketPrice>? marketPrices)
		{
			if (marketPrices is null)
			{
				return;
			}
			var nuds = new NumericUpDown[] { nudPriceBe, nudPriceFe, nudPricePd, nudPricePt, nudPriceV, nudPriceW };
			var dic = new Dictionary<OreType, NumericUpDown>();
			foreach (var nud in nuds)
			{
				nud.Value = 0; // Just in case
				var oreType = (OreType)nud.Tag!;
				dic[oreType] = nud;
			}

			foreach (var mp in marketPrices)
			{
				if (dic.TryGetValue(mp.OreType, out var nud))
				{
					nud.Value = Math.Clamp(mp.Price, nud.Minimum, nud.Maximum);
				}
			}
		}

		private void FillValues(bool fillPrices = false)
		{
			_fillingValues = true;

			if (fillPrices)
			{
				FillPrices(_marketPrices?.Values);
			}

			// Comparative Priority
			if (uiChunk1.Priority == uiChunk2.Priority)
			{
				trkComparativePriority.Value = 0;
			}
			else if (uiChunk1.Priority > uiChunk2.Priority)
			{
				trkComparativePriority.Value = trkComparativePriority.Minimum;
			}
			else
			{
				trkComparativePriority.Value = trkComparativePriority.Maximum;
			}

			_fillingValues = false;
		}

		private void Recalculate()
		{
			if (_ruleEngine is not null)
			{
				uiChunk1.Priority = _ruleEngine.CalculatePriority(uiChunk1.Chunk);
				uiChunk2.Priority = _ruleEngine.CalculatePriority(uiChunk2.Chunk);
			}

			if (_marketPrices is not null)
			{
				uiChunk1.OreValue = uiChunk1?.Chunk?.OreType is not null && _marketPrices.TryGetValue(uiChunk1.Chunk.OreType.Value, out var mp1) ? mp1.Price * ((decimal)uiChunk1.Chunk.OreWeightKg / 1000) : 0;
				uiChunk2.OreValue = uiChunk2?.Chunk?.OreType is not null && _marketPrices.TryGetValue(uiChunk2.Chunk.OreType.Value, out var mp2) ? mp2.Price * ((decimal)uiChunk2.Chunk.OreWeightKg / 1000) : 0;
			}

			FillValues();
		}

		private void SaveFile(string fileName)
		{
			var saveData = new SaveData()
			{
				Chunk1 = uiChunk1.Chunk,
				Chunk2 = uiChunk2.Chunk,
				MarketPrices = _marketPrices?.Values,
				RuleData = new(),
			};
			if (_ruleEngine?.Rules is not null)
			{
				foreach (var rule in _ruleEngine.Rules)
				{
					rule.Save(saveData.RuleData);
				}
			}
			var json = JsonSerializer.Serialize(saveData, new JsonSerializerOptions() { WriteIndented = true });
			try
			{
				File.WriteAllText(fileName, json);
				ofd.InitialDirectory = sfd.InitialDirectory = Path.GetDirectoryName(fileName);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Could not save", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadFile(string fileName)
		{
			try
			{
				var json = File.ReadAllText(fileName);
				var saveData = JsonSerializer.Deserialize<SaveData>(json);

				// Use the sample values for data missing from the json.
				CreateSampleValues(false);

				if (saveData is null)
				{
					FillValues(true);
					return;
				}

				_fillingValues = true;

				if (saveData.Chunk1 is not null)
				{
					uiChunk1.Chunk = saveData.Chunk1;
				}
				if (saveData.Chunk2 is not null)
				{
					uiChunk2.Chunk = saveData.Chunk2;
				}

				if (saveData.MarketPrices is not null)
				{
					_marketPrices = new();
					foreach (var mp in saveData.MarketPrices)
					{
						_marketPrices[mp.OreType] = mp;
					}

					if (_orePriceRule is not null)
					{
						_orePriceRule.MarketPrices = saveData.MarketPrices;
					}
				}

				if (saveData.RuleData is not null && _ruleEngine?.Rules is not null)
				{
					foreach (var rule in _ruleEngine.Rules)
					{
						rule.Load(saveData.RuleData);
					}
				}

				FillValues(true);
				Recalculate();

				ofd.InitialDirectory = sfd.InitialDirectory = Path.GetDirectoryName(fileName);
			}
			catch (Exception ex)
			{
				_fillingValues = false;
				MessageBox.Show(ex.Message, "Could not load", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#endregion

		#region Event handlers

		private void nudPrice_ValueChanged(object sender, EventArgs e)
		{
			if (_fillingValues)
			{
				return;
			}
			var nud = (NumericUpDown)sender;
			var oreType = (OreType)nud.Tag!;
			if (_marketPrices?.TryGetValue(oreType, out var marketPrice) ?? false)
			{
				marketPrice.Price = nud.Value;
			}
			Recalculate();
		}

		private void ui_ChunkChanged(object sender, EventArgs e)
		{
			if (_fillingValues)
			{
				return;
			}
			Recalculate();
		}

		private void ui_RuleChanged(object sender, EventArgs e)
		{
			if (_fillingValues)
			{
				return;
			}
			Recalculate();
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Fill in sample values?", "Sample values", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (result == DialogResult.OK)
			{
				CreateSampleValues(true);
				Recalculate();
			}
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				LoadFile(ofd.FileName);
			}
		}

		private void btnSaveAs_Click(object sender, EventArgs e)
		{
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				SaveFile(sfd.FileName);
			}
		}

		#endregion

	}
}