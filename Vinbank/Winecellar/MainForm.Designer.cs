namespace Winecellar
{
    partial class MainForm
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
            this.lstvWines = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVintage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTwo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblResultFromWineForm = new System.Windows.Forms.Label();
            this.lblBredd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstvWines
            // 
            this.lstvWines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colVintage,
            this.colTwo});
            this.lstvWines.FullRowSelect = true;
            this.lstvWines.GridLines = true;
            this.lstvWines.HideSelection = false;
            this.lstvWines.Location = new System.Drawing.Point(14, 15);
            this.lstvWines.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lstvWines.MultiSelect = false;
            this.lstvWines.Name = "lstvWines";
            this.lstvWines.Size = new System.Drawing.Size(775, 390);
            this.lstvWines.TabIndex = 1;
            this.lstvWines.UseCompatibleStateImageBehavior = false;
            this.lstvWines.View = System.Windows.Forms.View.Details;
            this.lstvWines.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.lstvWines_ColumnWidthChanged);
            this.lstvWines.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lstvWines_ColumnWidthChanging);
            this.lstvWines.SelectedIndexChanged += new System.EventHandler(this.lstvWines_SelectedIndexChanged);
            // 
            // colName
            // 
            this.colName.Text = "Namn";
            // 
            // colVintage
            // 
            this.colVintage.Text = "Årgång";
            this.colVintage.Width = 85;
            // 
            // colTwo
            // 
            this.colTwo.Text = "Något annat";
            this.colTwo.Width = 105;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(81, 446);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Lägg till vin";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(286, 446);
            this.btnChange.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(125, 38);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Ändra vin";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(464, 446);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(125, 38);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Ta bort vin";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblResultFromWineForm
            // 
            this.lblResultFromWineForm.AutoSize = true;
            this.lblResultFromWineForm.Location = new System.Drawing.Point(100, 529);
            this.lblResultFromWineForm.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblResultFromWineForm.Name = "lblResultFromWineForm";
            this.lblResultFromWineForm.Size = new System.Drawing.Size(201, 18);
            this.lblResultFromWineForm.TabIndex = 5;
            this.lblResultFromWineForm.Text = "Dialogresultat från WineForm";
            // 
            // lblBredd
            // 
            this.lblBredd.AutoSize = true;
            this.lblBredd.Location = new System.Drawing.Point(37, 415);
            this.lblBredd.Name = "lblBredd";
            this.lblBredd.Size = new System.Drawing.Size(193, 18);
            this.lblBredd.TabIndex = 6;
            this.lblBredd.Text = "bredd på kolum som ändras";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 572);
            this.Controls.Add(this.lblBredd);
            this.Controls.Add(this.lblResultFromWineForm);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstvWines);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Vinkällaren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lstvWines;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colTwo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblResultFromWineForm;
        private System.Windows.Forms.ColumnHeader colVintage;
        private System.Windows.Forms.Label lblBredd;
    }
}

