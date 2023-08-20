namespace ChunkPriorityCalculator
{
	partial class Main
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			grpMarketPrices = new GroupBox();
			label6 = new Label();
			nudPriceW = new NumericUpDown();
			label5 = new Label();
			nudPriceV = new NumericUpDown();
			label4 = new Label();
			nudPricePt = new NumericUpDown();
			label3 = new Label();
			nudPricePd = new NumericUpDown();
			label1 = new Label();
			label2 = new Label();
			nudPriceFe = new NumericUpDown();
			nudPriceBe = new NumericUpDown();
			grpRules = new GroupBox();
			uisChunkPrice = new SlidingRuleUI();
			uisOrePrice = new SlidingRuleUI();
			uisChunkSpeed = new SlidingRuleUI();
			grpChunks = new GroupBox();
			groupBox1 = new GroupBox();
			trkComparativePriority = new TrackBar();
			splitContainer1 = new SplitContainer();
			uiChunk1 = new ChunkUI();
			uiChunk2 = new ChunkUI();
			sfd = new SaveFileDialog();
			ofd = new OpenFileDialog();
			btnNew = new Button();
			tooltip = new ToolTip(components);
			btnLoad = new Button();
			btnSaveAs = new Button();
			groupBox2 = new GroupBox();
			txtDescription = new TextBox();
			grpMarketPrices.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nudPriceW).BeginInit();
			((System.ComponentModel.ISupportInitialize)nudPriceV).BeginInit();
			((System.ComponentModel.ISupportInitialize)nudPricePt).BeginInit();
			((System.ComponentModel.ISupportInitialize)nudPricePd).BeginInit();
			((System.ComponentModel.ISupportInitialize)nudPriceFe).BeginInit();
			((System.ComponentModel.ISupportInitialize)nudPriceBe).BeginInit();
			grpRules.SuspendLayout();
			grpChunks.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)trkComparativePriority).BeginInit();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// grpMarketPrices
			// 
			grpMarketPrices.Controls.Add(label6);
			grpMarketPrices.Controls.Add(nudPriceW);
			grpMarketPrices.Controls.Add(label5);
			grpMarketPrices.Controls.Add(nudPriceV);
			grpMarketPrices.Controls.Add(label4);
			grpMarketPrices.Controls.Add(nudPricePt);
			grpMarketPrices.Controls.Add(label3);
			grpMarketPrices.Controls.Add(nudPricePd);
			grpMarketPrices.Controls.Add(label1);
			grpMarketPrices.Controls.Add(label2);
			grpMarketPrices.Controls.Add(nudPriceFe);
			grpMarketPrices.Controls.Add(nudPriceBe);
			grpMarketPrices.Location = new Point(12, 12);
			grpMarketPrices.Name = "grpMarketPrices";
			grpMarketPrices.Size = new Size(616, 72);
			grpMarketPrices.TabIndex = 0;
			grpMarketPrices.TabStop = false;
			grpMarketPrices.Text = "Market Prices (taken when leaving Enceladus for the dive)";
			tooltip.SetToolTip(grpMarketPrices, "Prices are not updated while diving.");
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(512, 19);
			label6.Name = "label6";
			label6.Size = new Size(18, 15);
			label6.TabIndex = 10;
			label6.Text = "W";
			// 
			// nudPriceW
			// 
			nudPriceW.DecimalPlaces = 2;
			nudPriceW.Location = new Point(512, 37);
			nudPriceW.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
			nudPriceW.Name = "nudPriceW";
			nudPriceW.Size = new Size(94, 23);
			nudPriceW.TabIndex = 11;
			nudPriceW.TextAlign = HorizontalAlignment.Right;
			nudPriceW.ThousandsSeparator = true;
			nudPriceW.Value = new decimal(new int[] { 627449, 0, 0, 131072 });
			nudPriceW.ValueChanged += nudPrice_ValueChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(412, 19);
			label5.Name = "label5";
			label5.Size = new Size(14, 15);
			label5.TabIndex = 8;
			label5.Text = "V";
			// 
			// nudPriceV
			// 
			nudPriceV.DecimalPlaces = 2;
			nudPriceV.Location = new Point(412, 37);
			nudPriceV.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
			nudPriceV.Name = "nudPriceV";
			nudPriceV.Size = new Size(94, 23);
			nudPriceV.TabIndex = 9;
			nudPriceV.TextAlign = HorizontalAlignment.Right;
			nudPriceV.ThousandsSeparator = true;
			nudPriceV.Value = new decimal(new int[] { 303467, 0, 0, 131072 });
			nudPriceV.ValueChanged += nudPrice_ValueChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(312, 19);
			label4.Name = "label4";
			label4.Size = new Size(18, 15);
			label4.TabIndex = 6;
			label4.Text = "Pt";
			// 
			// nudPricePt
			// 
			nudPricePt.DecimalPlaces = 2;
			nudPricePt.Location = new Point(312, 37);
			nudPricePt.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
			nudPricePt.Name = "nudPricePt";
			nudPricePt.Size = new Size(94, 23);
			nudPricePt.TabIndex = 7;
			nudPricePt.TextAlign = HorizontalAlignment.Right;
			nudPricePt.ThousandsSeparator = true;
			nudPricePt.Value = new decimal(new int[] { 273213, 0, 0, 131072 });
			nudPricePt.ValueChanged += nudPrice_ValueChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(212, 19);
			label3.Name = "label3";
			label3.Size = new Size(21, 15);
			label3.TabIndex = 4;
			label3.Text = "Pd";
			// 
			// nudPricePd
			// 
			nudPricePd.DecimalPlaces = 2;
			nudPricePd.Location = new Point(212, 37);
			nudPricePd.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
			nudPricePd.Name = "nudPricePd";
			nudPricePd.Size = new Size(94, 23);
			nudPricePd.TabIndex = 5;
			nudPricePd.TextAlign = HorizontalAlignment.Right;
			nudPricePd.ThousandsSeparator = true;
			nudPricePd.Value = new decimal(new int[] { 252442, 0, 0, 131072 });
			nudPricePd.ValueChanged += nudPrice_ValueChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(112, 19);
			label1.Name = "label1";
			label1.Size = new Size(19, 15);
			label1.TabIndex = 2;
			label1.Text = "Fe";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 19);
			label2.Name = "label2";
			label2.Size = new Size(20, 15);
			label2.TabIndex = 0;
			label2.Text = "Be";
			// 
			// nudPriceFe
			// 
			nudPriceFe.DecimalPlaces = 2;
			nudPriceFe.Location = new Point(112, 37);
			nudPriceFe.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
			nudPriceFe.Name = "nudPriceFe";
			nudPriceFe.Size = new Size(94, 23);
			nudPriceFe.TabIndex = 3;
			nudPriceFe.TextAlign = HorizontalAlignment.Right;
			nudPriceFe.ThousandsSeparator = true;
			nudPriceFe.Value = new decimal(new int[] { 88128, 0, 0, 131072 });
			nudPriceFe.ValueChanged += nudPrice_ValueChanged;
			// 
			// nudPriceBe
			// 
			nudPriceBe.DecimalPlaces = 2;
			nudPriceBe.Location = new Point(12, 37);
			nudPriceBe.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
			nudPriceBe.Name = "nudPriceBe";
			nudPriceBe.Size = new Size(94, 23);
			nudPriceBe.TabIndex = 1;
			nudPriceBe.TextAlign = HorizontalAlignment.Right;
			nudPriceBe.ThousandsSeparator = true;
			nudPriceBe.Value = new decimal(new int[] { 206184, 0, 0, 65536 });
			nudPriceBe.ValueChanged += nudPrice_ValueChanged;
			// 
			// grpRules
			// 
			grpRules.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			grpRules.Controls.Add(uisChunkPrice);
			grpRules.Controls.Add(uisOrePrice);
			grpRules.Controls.Add(uisChunkSpeed);
			grpRules.Location = new Point(496, 90);
			grpRules.Name = "grpRules";
			grpRules.Size = new Size(333, 291);
			grpRules.TabIndex = 1;
			grpRules.TabStop = false;
			grpRules.Text = "Rules";
			tooltip.SetToolTip(grpRules, "If you want to test a single rule set the weight in the other rules to zero.");
			// 
			// uisChunkPrice
			// 
			uisChunkPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			uisChunkPrice.Location = new Point(6, 194);
			uisChunkPrice.Name = "uisChunkPrice";
			uisChunkPrice.Rule = null;
			uisChunkPrice.RuleDisplayName = "Market value of the chunk";
			uisChunkPrice.RuleTooltip = "Priority based on the Market Value of the chunk.";
			uisChunkPrice.Size = new Size(321, 80);
			uisChunkPrice.TabIndex = 2;
			uisChunkPrice.RuleChanged += ui_RuleChanged;
			// 
			// uisOrePrice
			// 
			uisOrePrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			uisOrePrice.Location = new Point(6, 108);
			uisOrePrice.Name = "uisOrePrice";
			uisOrePrice.Rule = null;
			uisOrePrice.RuleDisplayName = "Market price of the ore";
			uisOrePrice.RuleTooltip = "Priority based on the relative price of the ore.\r\nFor instance if Be is pricier than Fe then Be has higher priority.";
			uisOrePrice.Size = new Size(321, 80);
			uisOrePrice.TabIndex = 1;
			uisOrePrice.RuleChanged += ui_RuleChanged;
			// 
			// uisChunkSpeed
			// 
			uisChunkSpeed.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			uisChunkSpeed.Location = new Point(6, 22);
			uisChunkSpeed.Name = "uisChunkSpeed";
			uisChunkSpeed.Rule = null;
			uisChunkSpeed.RuleDisplayName = "Speed of the chunk relative to the ship";
			uisChunkSpeed.RuleTooltip = resources.GetString("uisChunkSpeed.RuleTooltip");
			uisChunkSpeed.Size = new Size(321, 80);
			uisChunkSpeed.TabIndex = 0;
			uisChunkSpeed.RuleChanged += ui_RuleChanged;
			// 
			// grpChunks
			// 
			grpChunks.Controls.Add(groupBox1);
			grpChunks.Controls.Add(splitContainer1);
			grpChunks.Location = new Point(12, 90);
			grpChunks.Name = "grpChunks";
			grpChunks.Size = new Size(469, 291);
			grpChunks.TabIndex = 2;
			grpChunks.TabStop = false;
			grpChunks.Text = "Sample Chunks";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(trkComparativePriority);
			groupBox1.Dock = DockStyle.Bottom;
			groupBox1.Location = new Point(3, 229);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(463, 59);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Comparative Priority (shows which chunk would be prioritized)";
			// 
			// trkComparativePriority
			// 
			trkComparativePriority.Dock = DockStyle.Fill;
			trkComparativePriority.Enabled = false;
			trkComparativePriority.LargeChange = 1;
			trkComparativePriority.Location = new Point(3, 19);
			trkComparativePriority.Maximum = 1;
			trkComparativePriority.Minimum = -1;
			trkComparativePriority.Name = "trkComparativePriority";
			trkComparativePriority.Size = new Size(457, 37);
			trkComparativePriority.TabIndex = 0;
			trkComparativePriority.TabStop = false;
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.IsSplitterFixed = true;
			splitContainer1.Location = new Point(3, 19);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(uiChunk1);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(uiChunk2);
			splitContainer1.Size = new Size(463, 269);
			splitContainer1.SplitterDistance = 229;
			splitContainer1.TabIndex = 1;
			// 
			// uiChunk1
			// 
			uiChunk1.Chunk = null;
			uiChunk1.Dock = DockStyle.Fill;
			uiChunk1.Location = new Point(0, 0);
			uiChunk1.Name = "uiChunk1";
			uiChunk1.Priority = new decimal(new int[] { 0, 0, 0, 0 });
			uiChunk1.Size = new Size(229, 269);
			uiChunk1.TabIndex = 0;
			uiChunk1.ChunkChanged += ui_ChunkChanged;
			// 
			// uiChunk2
			// 
			uiChunk2.Chunk = null;
			uiChunk2.Dock = DockStyle.Fill;
			uiChunk2.Location = new Point(0, 0);
			uiChunk2.Name = "uiChunk2";
			uiChunk2.Priority = new decimal(new int[] { 0, 0, 0, 0 });
			uiChunk2.Size = new Size(230, 269);
			uiChunk2.TabIndex = 0;
			uiChunk2.ChunkChanged += ui_ChunkChanged;
			// 
			// sfd
			// 
			sfd.Filter = "JSON Files|*.json";
			// 
			// ofd
			// 
			ofd.FileName = "openFileDialog1";
			ofd.Filter = "JSON Files|*.json";
			// 
			// btnNew
			// 
			btnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnNew.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_document_new_48;
			btnNew.Location = new Point(635, 22);
			btnNew.Name = "btnNew";
			btnNew.Size = new Size(61, 58);
			btnNew.TabIndex = 3;
			tooltip.SetToolTip(btnNew, "Use sample data");
			btnNew.UseVisualStyleBackColor = true;
			btnNew.Click += btnNew_Click;
			// 
			// btnLoad
			// 
			btnLoad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnLoad.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_document_open_48;
			btnLoad.Location = new Point(702, 22);
			btnLoad.Name = "btnLoad";
			btnLoad.Size = new Size(61, 58);
			btnLoad.TabIndex = 4;
			tooltip.SetToolTip(btnLoad, "Load the data from a file");
			btnLoad.UseVisualStyleBackColor = true;
			btnLoad.Click += btnLoad_Click;
			// 
			// btnSaveAs
			// 
			btnSaveAs.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnSaveAs.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_document_save_as_48;
			btnSaveAs.Location = new Point(769, 22);
			btnSaveAs.Name = "btnSaveAs";
			btnSaveAs.Size = new Size(61, 58);
			btnSaveAs.TabIndex = 5;
			tooltip.SetToolTip(btnSaveAs, "Save the data to a file");
			btnSaveAs.UseVisualStyleBackColor = true;
			btnSaveAs.Click += btnSaveAs_Click;
			// 
			// groupBox2
			// 
			groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			groupBox2.Controls.Add(txtDescription);
			groupBox2.Location = new Point(12, 387);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(817, 126);
			groupBox2.TabIndex = 6;
			groupBox2.TabStop = false;
			groupBox2.Text = "Description";
			// 
			// txtDescription
			// 
			txtDescription.Dock = DockStyle.Fill;
			txtDescription.Location = new Point(3, 19);
			txtDescription.Multiline = true;
			txtDescription.Name = "txtDescription";
			txtDescription.ScrollBars = ScrollBars.Vertical;
			txtDescription.Size = new Size(811, 104);
			txtDescription.TabIndex = 0;
			// 
			// Main
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(841, 522);
			Controls.Add(groupBox2);
			Controls.Add(btnSaveAs);
			Controls.Add(btnLoad);
			Controls.Add(btnNew);
			Controls.Add(grpChunks);
			Controls.Add(grpRules);
			Controls.Add(grpMarketPrices);
			MaximizeBox = false;
			MinimumSize = new Size(857, 561);
			Name = "Main";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Chunk Priority Calculator";
			grpMarketPrices.ResumeLayout(false);
			grpMarketPrices.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nudPriceW).EndInit();
			((System.ComponentModel.ISupportInitialize)nudPriceV).EndInit();
			((System.ComponentModel.ISupportInitialize)nudPricePt).EndInit();
			((System.ComponentModel.ISupportInitialize)nudPricePd).EndInit();
			((System.ComponentModel.ISupportInitialize)nudPriceFe).EndInit();
			((System.ComponentModel.ISupportInitialize)nudPriceBe).EndInit();
			grpRules.ResumeLayout(false);
			grpChunks.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)trkComparativePriority).EndInit();
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox grpMarketPrices;
		private GroupBox grpRules;
		private GroupBox grpChunks;
		private SplitContainer splitContainer1;
		private TrackBar trkComparativePriority;
		private ChunkUI uiChunk1;
		private ChunkUI uiChunk2;
		private GroupBox groupBox1;
		private Label label6;
		private NumericUpDown nudPriceW;
		private Label label5;
		private NumericUpDown nudPriceV;
		private Label label4;
		private NumericUpDown nudPricePt;
		private Label label3;
		private NumericUpDown nudPricePd;
		private Label label1;
		private Label label2;
		private NumericUpDown nudPriceFe;
		private NumericUpDown nudPriceBe;
		private SaveFileDialog sfd;
		private OpenFileDialog ofd;
		private SlidingRuleUI uisChunkSpeed;
		private Button btnNew;
		private ToolTip tooltip;
		private Button btnLoad;
		private Button btnSaveAs;
		private SlidingRuleUI uisOrePrice;
		private SlidingRuleUI uisChunkPrice;
		private GroupBox groupBox2;
		private TextBox txtDescription;
	}
}