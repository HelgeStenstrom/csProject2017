namespace Winecellar
{
    partial class WineForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txtWineName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpDateAdded = new System.Windows.Forms.DateTimePicker();
            this.lblYear = new System.Windows.Forms.Label();
            this.dtpDateConsumed = new System.Windows.Forms.DateTimePicker();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblWineType = new System.Windows.Forms.Label();
            this.cboWineType = new System.Windows.Forms.ComboBox();
            this.lblDateAdded = new System.Windows.Forms.Label();
            this.lblDateConsumed = new System.Windows.Forms.Label();
            this.chbIsConsumed = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(55, 62);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Namn";
            // 
            // txtWineName
            // 
            this.txtWineName.Location = new System.Drawing.Point(134, 59);
            this.txtWineName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWineName.Name = "txtWineName";
            this.txtWineName.Size = new System.Drawing.Size(734, 24);
            this.txtWineName.TabIndex = 1;
            this.txtWineName.TextChanged += new System.EventHandler(this.txtWineName_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(182, 284);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 37);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Spara";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(355, 284);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 37);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Avbryt";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpDateAdded
            // 
            this.dtpDateAdded.Checked = false;
            this.dtpDateAdded.CustomFormat = "";
            this.dtpDateAdded.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateAdded.Location = new System.Drawing.Point(182, 186);
            this.dtpDateAdded.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDateAdded.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpDateAdded.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDateAdded.Name = "dtpDateAdded";
            this.dtpDateAdded.Size = new System.Drawing.Size(139, 24);
            this.dtpDateAdded.TabIndex = 4;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(55, 115);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(54, 18);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "Årgång";
            // 
            // dtpDateConsumed
            // 
            this.dtpDateConsumed.Checked = false;
            this.dtpDateConsumed.CustomFormat = "";
            this.dtpDateConsumed.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateConsumed.Location = new System.Drawing.Point(729, 192);
            this.dtpDateConsumed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDateConsumed.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpDateConsumed.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDateConsumed.Name = "dtpDateConsumed";
            this.dtpDateConsumed.Size = new System.Drawing.Size(139, 24);
            this.dtpDateConsumed.TabIndex = 6;
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(134, 110);
            this.numYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(68, 24);
            this.numYear.TabIndex = 8;
            this.numYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // cboCountry
            // 
            this.cboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(325, 109);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(266, 25);
            this.cboCountry.TabIndex = 9;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(255, 120);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(40, 18);
            this.lblCountry.TabIndex = 10;
            this.lblCountry.Text = "Land";
            // 
            // lblWineType
            // 
            this.lblWineType.AutoSize = true;
            this.lblWineType.Location = new System.Drawing.Point(691, 112);
            this.lblWineType.Name = "lblWineType";
            this.lblWineType.Size = new System.Drawing.Size(32, 18);
            this.lblWineType.TabIndex = 11;
            this.lblWineType.Text = "Typ";
            // 
            // cboWineType
            // 
            this.cboWineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWineType.FormattingEnabled = true;
            this.cboWineType.Location = new System.Drawing.Point(729, 109);
            this.cboWineType.Name = "cboWineType";
            this.cboWineType.Size = new System.Drawing.Size(139, 25);
            this.cboWineType.TabIndex = 12;
            // 
            // lblDateAdded
            // 
            this.lblDateAdded.AutoSize = true;
            this.lblDateAdded.Location = new System.Drawing.Point(55, 192);
            this.lblDateAdded.Name = "lblDateAdded";
            this.lblDateAdded.Size = new System.Drawing.Size(93, 18);
            this.lblDateAdded.TabIndex = 13;
            this.lblDateAdded.Text = "Datum tillagd";
            // 
            // lblDateConsumed
            // 
            this.lblDateConsumed.AutoSize = true;
            this.lblDateConsumed.Location = new System.Drawing.Point(600, 192);
            this.lblDateConsumed.Name = "lblDateConsumed";
            this.lblDateConsumed.Size = new System.Drawing.Size(104, 18);
            this.lblDateConsumed.TabIndex = 14;
            this.lblDateConsumed.Text = "Dryckesdatum";
            // 
            // chbIsConsumed
            // 
            this.chbIsConsumed.AutoSize = true;
            this.chbIsConsumed.Location = new System.Drawing.Point(576, 197);
            this.chbIsConsumed.Name = "chbIsConsumed";
            this.chbIsConsumed.Size = new System.Drawing.Size(15, 14);
            this.chbIsConsumed.TabIndex = 15;
            this.chbIsConsumed.UseVisualStyleBackColor = true;
            this.chbIsConsumed.CheckedChanged += new System.EventHandler(this.chbIsConsumed_CheckedChanged);
            // 
            // WineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 350);
            this.Controls.Add(this.chbIsConsumed);
            this.Controls.Add(this.lblDateConsumed);
            this.Controls.Add(this.lblDateAdded);
            this.Controls.Add(this.cboWineType);
            this.Controls.Add(this.lblWineType);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.cboCountry);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.dtpDateConsumed);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.dtpDateAdded);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtWineName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WineForm";
            this.Text = "WineForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WineForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtWineName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpDateAdded;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.DateTimePicker dtpDateConsumed;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblWineType;
        private System.Windows.Forms.ComboBox cboWineType;
        private System.Windows.Forms.Label lblDateAdded;
        private System.Windows.Forms.Label lblDateConsumed;
        private System.Windows.Forms.CheckBox chbIsConsumed;
    }
}