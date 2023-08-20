namespace ChunkPriorityCalculator
{
	partial class ChunkUI
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
			Label label1;
			Label label2;
			Label label3;
			Label label4;
			Label label5;
			Label label6;
			Label label7;
			Label label8;
			Label label9;
			Label label10;
			Label label11;
			Label label12;
			cmbOreType = new ComboBox();
			nudOreWeightKg = new NumericUpDown();
			nudWaterWeightKg = new NumericUpDown();
			nudRelativeSpeed = new NumericUpDown();
			txtTotalWeight = new TextBox();
			txtPriority = new TextBox();
			txtOreValue = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			label10 = new Label();
			label11 = new Label();
			label12 = new Label();
			((System.ComponentModel.ISupportInitialize)nudOreWeightKg).BeginInit();
			((System.ComponentModel.ISupportInitialize)nudWaterWeightKg).BeginInit();
			((System.ComponentModel.ISupportInitialize)nudRelativeSpeed).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(10, 11);
			label1.Name = "label1";
			label1.Size = new Size(53, 15);
			label1.TabIndex = 0;
			label1.Text = "Ore Type";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(10, 40);
			label2.Name = "label2";
			label2.Size = new Size(72, 15);
			label2.TabIndex = 2;
			label2.Text = "Ore Content";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(10, 69);
			label3.Name = "label3";
			label3.Size = new Size(84, 15);
			label3.TabIndex = 5;
			label3.Text = "Water Content";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(10, 98);
			label4.Name = "label4";
			label4.Size = new Size(73, 15);
			label4.TabIndex = 8;
			label4.Text = "Total Weight";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(10, 127);
			label5.Name = "label5";
			label5.Size = new Size(83, 15);
			label5.TabIndex = 11;
			label5.Text = "Relative Speed";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(10, 185);
			label6.Name = "label6";
			label6.Size = new Size(45, 15);
			label6.TabIndex = 17;
			label6.Text = "Priority";
			// 
			// label7
			// 
			label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label7.AutoSize = true;
			label7.Location = new Point(184, 40);
			label7.Name = "label7";
			label7.Size = new Size(21, 15);
			label7.TabIndex = 4;
			label7.Text = "Kg";
			// 
			// label8
			// 
			label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label8.AutoSize = true;
			label8.Location = new Point(184, 127);
			label8.Name = "label8";
			label8.Size = new Size(28, 15);
			label8.TabIndex = 13;
			label8.Text = "m/s";
			// 
			// label9
			// 
			label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label9.AutoSize = true;
			label9.Location = new Point(184, 69);
			label9.Name = "label9";
			label9.Size = new Size(21, 15);
			label9.TabIndex = 7;
			label9.Text = "Kg";
			// 
			// label10
			// 
			label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label10.AutoSize = true;
			label10.Location = new Point(184, 98);
			label10.Name = "label10";
			label10.Size = new Size(21, 15);
			label10.TabIndex = 10;
			label10.Text = "Kg";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(10, 156);
			label11.Name = "label11";
			label11.Size = new Size(75, 15);
			label11.TabIndex = 14;
			label11.Text = "Market Value";
			// 
			// label12
			// 
			label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label12.AutoSize = true;
			label12.Location = new Point(184, 156);
			label12.Name = "label12";
			label12.Size = new Size(13, 15);
			label12.TabIndex = 16;
			label12.Text = "$";
			// 
			// cmbOreType
			// 
			cmbOreType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			cmbOreType.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbOreType.FormattingEnabled = true;
			cmbOreType.Location = new Point(106, 7);
			cmbOreType.Name = "cmbOreType";
			cmbOreType.Size = new Size(75, 23);
			cmbOreType.TabIndex = 1;
			cmbOreType.SelectedIndexChanged += cmbOreType_SelectedIndexChanged;
			// 
			// nudOreWeightKg
			// 
			nudOreWeightKg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			nudOreWeightKg.Increment = new decimal(new int[] { 100, 0, 0, 0 });
			nudOreWeightKg.Location = new Point(106, 36);
			nudOreWeightKg.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			nudOreWeightKg.Name = "nudOreWeightKg";
			nudOreWeightKg.Size = new Size(75, 23);
			nudOreWeightKg.TabIndex = 3;
			nudOreWeightKg.TextAlign = HorizontalAlignment.Right;
			nudOreWeightKg.ThousandsSeparator = true;
			nudOreWeightKg.ValueChanged += nudOreContent_ValueChanged;
			// 
			// nudWaterWeightKg
			// 
			nudWaterWeightKg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			nudWaterWeightKg.Increment = new decimal(new int[] { 100, 0, 0, 0 });
			nudWaterWeightKg.Location = new Point(106, 65);
			nudWaterWeightKg.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			nudWaterWeightKg.Name = "nudWaterWeightKg";
			nudWaterWeightKg.Size = new Size(75, 23);
			nudWaterWeightKg.TabIndex = 6;
			nudWaterWeightKg.TextAlign = HorizontalAlignment.Right;
			nudWaterWeightKg.ThousandsSeparator = true;
			nudWaterWeightKg.ValueChanged += nudWaterContent_ValueChanged;
			// 
			// nudRelativeSpeed
			// 
			nudRelativeSpeed.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			nudRelativeSpeed.DecimalPlaces = 1;
			nudRelativeSpeed.Location = new Point(106, 123);
			nudRelativeSpeed.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
			nudRelativeSpeed.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
			nudRelativeSpeed.Name = "nudRelativeSpeed";
			nudRelativeSpeed.Size = new Size(75, 23);
			nudRelativeSpeed.TabIndex = 12;
			nudRelativeSpeed.TextAlign = HorizontalAlignment.Right;
			nudRelativeSpeed.ValueChanged += nudRelativeSpeed_ValueChanged;
			// 
			// txtTotalWeight
			// 
			txtTotalWeight.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			txtTotalWeight.Location = new Point(106, 94);
			txtTotalWeight.Name = "txtTotalWeight";
			txtTotalWeight.ReadOnly = true;
			txtTotalWeight.Size = new Size(75, 23);
			txtTotalWeight.TabIndex = 9;
			txtTotalWeight.TextAlign = HorizontalAlignment.Right;
			// 
			// txtPriority
			// 
			txtPriority.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			txtPriority.Location = new Point(106, 181);
			txtPriority.Name = "txtPriority";
			txtPriority.ReadOnly = true;
			txtPriority.Size = new Size(75, 23);
			txtPriority.TabIndex = 18;
			txtPriority.TextAlign = HorizontalAlignment.Right;
			// 
			// txtOreValue
			// 
			txtOreValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			txtOreValue.Location = new Point(106, 152);
			txtOreValue.Name = "txtOreValue";
			txtOreValue.ReadOnly = true;
			txtOreValue.Size = new Size(75, 23);
			txtOreValue.TabIndex = 15;
			txtOreValue.TextAlign = HorizontalAlignment.Right;
			// 
			// ChunkUI
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(label12);
			Controls.Add(txtOreValue);
			Controls.Add(label11);
			Controls.Add(label10);
			Controls.Add(label9);
			Controls.Add(txtPriority);
			Controls.Add(txtTotalWeight);
			Controls.Add(nudRelativeSpeed);
			Controls.Add(nudWaterWeightKg);
			Controls.Add(nudOreWeightKg);
			Controls.Add(cmbOreType);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "ChunkUI";
			Size = new Size(220, 212);
			((System.ComponentModel.ISupportInitialize)nudOreWeightKg).EndInit();
			((System.ComponentModel.ISupportInitialize)nudWaterWeightKg).EndInit();
			((System.ComponentModel.ISupportInitialize)nudRelativeSpeed).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cmbOreType;
		private NumericUpDown nudOreWeightKg;
		private NumericUpDown nudWaterWeightKg;
		private NumericUpDown nudRelativeSpeed;
		private TextBox txtTotalWeight;
		private TextBox txtPriority;
		private TextBox txtOreValue;
	}
}
