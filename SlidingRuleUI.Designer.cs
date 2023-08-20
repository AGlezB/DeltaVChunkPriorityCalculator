namespace ChunkPriorityCalculator
{
	partial class SlidingRuleUI
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			label1 = new Label();
			nudWeight = new NumericUpDown();
			grpRule = new GroupBox();
			lblMax = new Label();
			lblMin = new Label();
			lblValue = new Label();
			trkSlider = new TrackBar();
			toolTip = new ToolTip(components);
			((System.ComponentModel.ISupportInitialize)nudWeight).BeginInit();
			grpRule.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)trkSlider).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label1.AutoSize = true;
			label1.Location = new Point(394, 19);
			label1.Name = "label1";
			label1.Size = new Size(45, 15);
			label1.TabIndex = 4;
			label1.Text = "Weight";
			// 
			// nudWeight
			// 
			nudWeight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			nudWeight.DecimalPlaces = 1;
			nudWeight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
			nudWeight.Location = new Point(394, 37);
			nudWeight.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
			nudWeight.Name = "nudWeight";
			nudWeight.Size = new Size(46, 23);
			nudWeight.TabIndex = 5;
			nudWeight.TextAlign = HorizontalAlignment.Right;
			toolTip.SetToolTip(nudWeight, "How important is the rule. Affects hown much this rule influences the final priority.\r\nSetting this value to zero will make the rule irrelevant.");
			nudWeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
			nudWeight.ValueChanged += nudWeight_ValueChanged;
			// 
			// grpRule
			// 
			grpRule.Controls.Add(label1);
			grpRule.Controls.Add(lblMax);
			grpRule.Controls.Add(nudWeight);
			grpRule.Controls.Add(lblMin);
			grpRule.Controls.Add(lblValue);
			grpRule.Controls.Add(trkSlider);
			grpRule.Dock = DockStyle.Fill;
			grpRule.Location = new Point(0, 0);
			grpRule.Name = "grpRule";
			grpRule.Size = new Size(450, 82);
			grpRule.TabIndex = 0;
			grpRule.TabStop = false;
			grpRule.Text = "Rule name";
			// 
			// lblMax
			// 
			lblMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			lblMax.Location = new Point(336, 21);
			lblMax.Name = "lblMax";
			lblMax.Size = new Size(46, 23);
			lblMax.TabIndex = 2;
			lblMax.Text = "1000";
			lblMax.TextAlign = ContentAlignment.MiddleCenter;
			toolTip.SetToolTip(lblMax, "Maximun value.");
			// 
			// lblMin
			// 
			lblMin.Location = new Point(12, 21);
			lblMin.Name = "lblMin";
			lblMin.Size = new Size(46, 23);
			lblMin.TabIndex = 0;
			lblMin.Text = "-1000";
			lblMin.TextAlign = ContentAlignment.MiddleCenter;
			toolTip.SetToolTip(lblMin, "Minimum value.");
			// 
			// lblValue
			// 
			lblValue.Anchor = AnchorStyles.Top;
			lblValue.Location = new Point(170, 53);
			lblValue.Name = "lblValue";
			lblValue.Size = new Size(54, 23);
			lblValue.TabIndex = 3;
			lblValue.Text = "0";
			lblValue.TextAlign = ContentAlignment.MiddleCenter;
			toolTip.SetToolTip(lblValue, "Numerical value of the slider.");
			// 
			// trkSlider
			// 
			trkSlider.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			trkSlider.Location = new Point(61, 22);
			trkSlider.Maximum = 100;
			trkSlider.Minimum = -100;
			trkSlider.Name = "trkSlider";
			trkSlider.Size = new Size(272, 45);
			trkSlider.TabIndex = 1;
			toolTip.SetToolTip(trkSlider, "Adjust the value of the rule.");
			trkSlider.ValueChanged += trkSlider_ValueChanged;
			// 
			// SlidingRuleUI
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(grpRule);
			Name = "SlidingRuleUI";
			Size = new Size(450, 82);
			((System.ComponentModel.ISupportInitialize)nudWeight).EndInit();
			grpRule.ResumeLayout(false);
			grpRule.PerformLayout();
			((System.ComponentModel.ISupportInitialize)trkSlider).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private NumericUpDown nudWeight;
		private GroupBox grpRule;
		private TrackBar trkSlider;
		private Label lblMax;
		private Label lblMin;
		private Label lblValue;
		private ToolTip toolTip;
	}
}
