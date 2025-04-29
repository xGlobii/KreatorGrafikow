namespace Kreator_Grafików
{
    partial class Form1
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
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			workersGrid = new DataGridView();
			hoursGropbox = new GroupBox();
			label1 = new Label();
			customEnd = new NumericUpDown();
			customStart = new NumericUpDown();
			radioAnother = new RadioButton();
			radioUR = new RadioButton();
			radioW = new RadioButton();
			radio1017 = new RadioButton();
			radio1419 = new RadioButton();
			radio914 = new RadioButton();
			radio919 = new RadioButton();
			colorGroupbox = new GroupBox();
			radioCash = new RadioButton();
			radioWeekend = new RadioButton();
			radioNormal = new RadioButton();
			actionGroupbox = new GroupBox();
			radioPerson = new RadioButton();
			radioColor = new RadioButton();
			radioHour = new RadioButton();
			personTextbox = new TextBox();
			BtnReset = new Button();
			btnPrint = new Button();
			BtnSaveJSON = new Button();
			btnLoad = new Button();
			btnSave = new Button();
			WorkersNumber = new NumericUpDown();
			label2 = new Label();
			printDocument1 = new System.Drawing.Printing.PrintDocument();
			((System.ComponentModel.ISupportInitialize)workersGrid).BeginInit();
			hoursGropbox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)customEnd).BeginInit();
			((System.ComponentModel.ISupportInitialize)customStart).BeginInit();
			colorGroupbox.SuspendLayout();
			actionGroupbox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)WorkersNumber).BeginInit();
			SuspendLayout();
			// 
			// workersGrid
			// 
			workersGrid.AllowUserToAddRows = false;
			workersGrid.AllowUserToDeleteRows = false;
			workersGrid.AllowUserToResizeColumns = false;
			workersGrid.AllowUserToResizeRows = false;
			workersGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			workersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			workersGrid.ColumnHeadersVisible = false;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			workersGrid.DefaultCellStyle = dataGridViewCellStyle2;
			workersGrid.Location = new Point(12, 83);
			workersGrid.MultiSelect = false;
			workersGrid.Name = "workersGrid";
			workersGrid.ReadOnly = true;
			workersGrid.RowHeadersVisible = false;
			workersGrid.RowHeadersWidth = 51;
			workersGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			workersGrid.Size = new Size(1716, 606);
			workersGrid.TabIndex = 0;
			// 
			// hoursGropbox
			// 
			hoursGropbox.Controls.Add(label1);
			hoursGropbox.Controls.Add(customEnd);
			hoursGropbox.Controls.Add(customStart);
			hoursGropbox.Controls.Add(radioAnother);
			hoursGropbox.Controls.Add(radioUR);
			hoursGropbox.Controls.Add(radioW);
			hoursGropbox.Controls.Add(radio1017);
			hoursGropbox.Controls.Add(radio1419);
			hoursGropbox.Controls.Add(radio914);
			hoursGropbox.Controls.Add(radio919);
			hoursGropbox.Location = new Point(159, 12);
			hoursGropbox.Name = "hoursGropbox";
			hoursGropbox.Size = new Size(600, 65);
			hoursGropbox.TabIndex = 1;
			hoursGropbox.TabStop = false;
			hoursGropbox.Text = "Godziny";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(514, 28);
			label1.Name = "label1";
			label1.Size = new Size(15, 20);
			label1.TabIndex = 9;
			label1.Text = "-";
			// 
			// customEnd
			// 
			customEnd.Location = new Point(535, 26);
			customEnd.Maximum = new decimal(new int[] { 19, 0, 0, 0 });
			customEnd.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
			customEnd.Name = "customEnd";
			customEnd.Size = new Size(50, 27);
			customEnd.TabIndex = 8;
			customEnd.Value = new decimal(new int[] { 14, 0, 0, 0 });
			// 
			// customStart
			// 
			customStart.Location = new Point(458, 26);
			customStart.Maximum = new decimal(new int[] { 18, 0, 0, 0 });
			customStart.Minimum = new decimal(new int[] { 9, 0, 0, 0 });
			customStart.Name = "customStart";
			customStart.Size = new Size(50, 27);
			customStart.TabIndex = 7;
			customStart.Value = new decimal(new int[] { 9, 0, 0, 0 });
			// 
			// radioAnother
			// 
			radioAnother.AutoSize = true;
			radioAnother.Location = new Point(391, 26);
			radioAnother.Name = "radioAnother";
			radioAnother.Size = new Size(61, 24);
			radioAnother.TabIndex = 6;
			radioAnother.TabStop = true;
			radioAnother.Text = "Inne:";
			radioAnother.UseVisualStyleBackColor = true;
			// 
			// radioUR
			// 
			radioUR.AutoSize = true;
			radioUR.Location = new Point(336, 26);
			radioUR.Name = "radioUR";
			radioUR.Size = new Size(49, 24);
			radioUR.TabIndex = 5;
			radioUR.TabStop = true;
			radioUR.Text = "UR";
			radioUR.UseVisualStyleBackColor = true;
			// 
			// radioW
			// 
			radioW.AutoSize = true;
			radioW.Location = new Point(286, 26);
			radioW.Name = "radioW";
			radioW.Size = new Size(44, 24);
			radioW.TabIndex = 4;
			radioW.TabStop = true;
			radioW.Text = "W";
			radioW.UseVisualStyleBackColor = true;
			// 
			// radio1017
			// 
			radio1017.AutoSize = true;
			radio1017.Location = new Point(212, 26);
			radio1017.Name = "radio1017";
			radio1017.Size = new Size(68, 24);
			radio1017.TabIndex = 3;
			radio1017.TabStop = true;
			radio1017.Text = "10-17";
			radio1017.UseVisualStyleBackColor = true;
			// 
			// radio1419
			// 
			radio1419.AutoSize = true;
			radio1419.Location = new Point(138, 26);
			radio1419.Name = "radio1419";
			radio1419.Size = new Size(68, 24);
			radio1419.TabIndex = 2;
			radio1419.TabStop = true;
			radio1419.Text = "14-19";
			radio1419.UseVisualStyleBackColor = true;
			// 
			// radio914
			// 
			radio914.AutoSize = true;
			radio914.Location = new Point(72, 26);
			radio914.Name = "radio914";
			radio914.Size = new Size(60, 24);
			radio914.TabIndex = 1;
			radio914.TabStop = true;
			radio914.Text = "9-14";
			radio914.UseVisualStyleBackColor = true;
			// 
			// radio919
			// 
			radio919.AutoSize = true;
			radio919.Location = new Point(6, 26);
			radio919.Name = "radio919";
			radio919.Size = new Size(60, 24);
			radio919.TabIndex = 0;
			radio919.TabStop = true;
			radio919.Text = "9-19";
			radio919.UseVisualStyleBackColor = true;
			// 
			// colorGroupbox
			// 
			colorGroupbox.Controls.Add(radioCash);
			colorGroupbox.Controls.Add(radioWeekend);
			colorGroupbox.Controls.Add(radioNormal);
			colorGroupbox.Location = new Point(765, 12);
			colorGroupbox.Name = "colorGroupbox";
			colorGroupbox.Size = new Size(250, 65);
			colorGroupbox.TabIndex = 2;
			colorGroupbox.TabStop = false;
			colorGroupbox.Text = "Kolory";
			// 
			// radioCash
			// 
			radioCash.AutoSize = true;
			radioCash.Location = new Point(171, 26);
			radioCash.Name = "radioCash";
			radioCash.Size = new Size(61, 24);
			radioCash.TabIndex = 2;
			radioCash.TabStop = true;
			radioCash.Text = "Kasa";
			radioCash.UseVisualStyleBackColor = true;
			// 
			// radioWeekend
			// 
			radioWeekend.AutoSize = true;
			radioWeekend.Location = new Point(74, 26);
			radioWeekend.Name = "radioWeekend";
			radioWeekend.Size = new Size(91, 24);
			radioWeekend.TabIndex = 1;
			radioWeekend.TabStop = true;
			radioWeekend.Text = "Weekend";
			radioWeekend.UseVisualStyleBackColor = true;
			// 
			// radioNormal
			// 
			radioNormal.AutoSize = true;
			radioNormal.Location = new Point(6, 26);
			radioNormal.Name = "radioNormal";
			radioNormal.Size = new Size(62, 24);
			radioNormal.TabIndex = 0;
			radioNormal.TabStop = true;
			radioNormal.Text = "Biały";
			radioNormal.UseVisualStyleBackColor = true;
			// 
			// actionGroupbox
			// 
			actionGroupbox.Controls.Add(radioPerson);
			actionGroupbox.Controls.Add(radioColor);
			actionGroupbox.Controls.Add(radioHour);
			actionGroupbox.Location = new Point(1021, 12);
			actionGroupbox.Name = "actionGroupbox";
			actionGroupbox.Size = new Size(251, 65);
			actionGroupbox.TabIndex = 3;
			actionGroupbox.TabStop = false;
			actionGroupbox.Text = "Działanie";
			// 
			// radioPerson
			// 
			radioPerson.AutoSize = true;
			radioPerson.Location = new Point(169, 26);
			radioPerson.Name = "radioPerson";
			radioPerson.Size = new Size(73, 24);
			radioPerson.TabIndex = 2;
			radioPerson.TabStop = true;
			radioPerson.Text = "Osoba";
			radioPerson.UseVisualStyleBackColor = true;
			// 
			// radioColor
			// 
			radioColor.AutoSize = true;
			radioColor.Location = new Point(97, 26);
			radioColor.Name = "radioColor";
			radioColor.Size = new Size(66, 24);
			radioColor.TabIndex = 1;
			radioColor.TabStop = true;
			radioColor.Text = "Kolor";
			radioColor.UseVisualStyleBackColor = true;
			// 
			// radioHour
			// 
			radioHour.AutoSize = true;
			radioHour.Location = new Point(6, 26);
			radioHour.Name = "radioHour";
			radioHour.Size = new Size(85, 24);
			radioHour.TabIndex = 0;
			radioHour.TabStop = true;
			radioHour.Text = "Godzina";
			radioHour.UseVisualStyleBackColor = true;
			// 
			// personTextbox
			// 
			personTextbox.Location = new Point(1278, 33);
			personTextbox.Name = "personTextbox";
			personTextbox.PlaceholderText = "Osoba";
			personTextbox.Size = new Size(125, 27);
			personTextbox.TabIndex = 4;
			// 
			// BtnReset
			// 
			BtnReset.Location = new Point(1412, 12);
			BtnReset.Name = "BtnReset";
			BtnReset.Size = new Size(94, 29);
			BtnReset.TabIndex = 5;
			BtnReset.Text = "Reset";
			BtnReset.UseVisualStyleBackColor = true;
			BtnReset.Click += BtnReset_Click;
			// 
			// btnPrint
			// 
			btnPrint.Location = new Point(1412, 48);
			btnPrint.Name = "btnPrint";
			btnPrint.Size = new Size(94, 29);
			btnPrint.TabIndex = 6;
			btnPrint.Text = "Drukuj";
			btnPrint.UseVisualStyleBackColor = true;
			btnPrint.Click += btnPrint_Click;
			// 
			// BtnSaveJSON
			// 
			BtnSaveJSON.Location = new Point(1612, 31);
			BtnSaveJSON.Name = "BtnSaveJSON";
			BtnSaveJSON.Size = new Size(121, 29);
			BtnSaveJSON.TabIndex = 7;
			BtnSaveJSON.Text = "Zapisz do JSON";
			BtnSaveJSON.UseVisualStyleBackColor = true;
			BtnSaveJSON.Click += BtnSaveJSON_Click;
			// 
			// btnLoad
			// 
			btnLoad.Location = new Point(1512, 47);
			btnLoad.Name = "btnLoad";
			btnLoad.Size = new Size(94, 29);
			btnLoad.TabIndex = 8;
			btnLoad.Text = "Wczytaj";
			btnLoad.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			btnSave.Location = new Point(1512, 12);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(94, 29);
			btnSave.TabIndex = 9;
			btnSave.Text = "Zapisz";
			btnSave.UseVisualStyleBackColor = true;
			// 
			// WorkersNumber
			// 
			WorkersNumber.Location = new Point(12, 40);
			WorkersNumber.Name = "WorkersNumber";
			WorkersNumber.Size = new Size(141, 27);
			WorkersNumber.TabIndex = 10;
			WorkersNumber.ValueChanged += workersNumber_ValueChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 16);
			label2.Name = "label2";
			label2.Size = new Size(131, 20);
			label2.TabIndex = 11;
			label2.Text = "Ilość pracowników";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1740, 701);
			Controls.Add(label2);
			Controls.Add(WorkersNumber);
			Controls.Add(btnSave);
			Controls.Add(btnLoad);
			Controls.Add(BtnSaveJSON);
			Controls.Add(btnPrint);
			Controls.Add(BtnReset);
			Controls.Add(personTextbox);
			Controls.Add(actionGroupbox);
			Controls.Add(colorGroupbox);
			Controls.Add(hoursGropbox);
			Controls.Add(workersGrid);
			Name = "Form1";
			Text = "Kreator Grafików";
			((System.ComponentModel.ISupportInitialize)workersGrid).EndInit();
			hoursGropbox.ResumeLayout(false);
			hoursGropbox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)customEnd).EndInit();
			((System.ComponentModel.ISupportInitialize)customStart).EndInit();
			colorGroupbox.ResumeLayout(false);
			colorGroupbox.PerformLayout();
			actionGroupbox.ResumeLayout(false);
			actionGroupbox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)WorkersNumber).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView workersGrid;
        private GroupBox hoursGropbox;
        private RadioButton radio919;
        private RadioButton radio1419;
        private RadioButton radio914;
        private RadioButton radioUR;
        private RadioButton radioW;
        private RadioButton radio1017;
        private Label label1;
        private NumericUpDown customEnd;
        private NumericUpDown customStart;
        private RadioButton radioAnother;
        private GroupBox colorGroupbox;
        private RadioButton radioCash;
        private RadioButton radioWeekend;
        private RadioButton radioNormal;
        private GroupBox actionGroupbox;
        private RadioButton radioPerson;
        private RadioButton radioColor;
        private RadioButton radioHour;
        private TextBox personTextbox;
        private Button BtnReset;
        private Button btnPrint;
        private Button BtnSaveJSON;
        private Button btnLoad;
        private Button btnSave;
        private NumericUpDown WorkersNumber;
        private Label label2;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
