namespace Winecellar
{
    partial class ConsumedForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDrink = new System.Windows.Forms.Label();
            this.dtpDateConsumed = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 78);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 32);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Spara";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(150, 78);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Avbryt";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblDrink
            // 
            this.lblDrink.AutoSize = true;
            this.lblDrink.Location = new System.Drawing.Point(13, 30);
            this.lblDrink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDrink.Name = "lblDrink";
            this.lblDrink.Size = new System.Drawing.Size(129, 24);
            this.lblDrink.TabIndex = 2;
            this.lblDrink.Text = "Dryckesdatum";
            // 
            // dtpDateConsumed
            // 
            this.dtpDateConsumed.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateConsumed.Location = new System.Drawing.Point(150, 26);
            this.dtpDateConsumed.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateConsumed.Name = "dtpDateConsumed";
            this.dtpDateConsumed.Size = new System.Drawing.Size(143, 28);
            this.dtpDateConsumed.TabIndex = 3;
            // 
            // ConsumedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 140);
            this.Controls.Add(this.dtpDateConsumed);
            this.Controls.Add(this.lblDrink);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsumedForm";
            this.Text = "ConsumedForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDrink;
        private System.Windows.Forms.DateTimePicker dtpDateConsumed;
    }
}