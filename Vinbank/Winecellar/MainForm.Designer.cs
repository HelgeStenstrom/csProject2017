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
            this.btnDrink = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveFileAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lblWineEventInfo = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
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
            this.lstvWines.Location = new System.Drawing.Point(14, 44);
            this.lstvWines.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lstvWines.MultiSelect = false;
            this.lstvWines.Name = "lstvWines";
            this.lstvWines.Size = new System.Drawing.Size(860, 390);
            this.lstvWines.TabIndex = 1;
            this.lstvWines.UseCompatibleStateImageBehavior = false;
            this.lstvWines.View = System.Windows.Forms.View.Details;
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
            // btnDrink
            // 
            this.btnDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrink.ForeColor = System.Drawing.Color.Red;
            this.btnDrink.Location = new System.Drawing.Point(654, 446);
            this.btnDrink.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(125, 38);
            this.btnDrink.TabIndex = 7;
            this.btnDrink.Text = "Drick vin!";
            this.btnDrink.UseVisualStyleBackColor = true;
            this.btnDrink.Click += new System.EventHandler(this.btnDrink_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(902, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenFile,
            this.mnuSaveFile,
            this.mnuSaveFileAs,
            this.mnuNewFile});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fileToolStripMenuItem.Text = "Vinfil";
            // 
            // mnuOpenFile
            // 
            this.mnuOpenFile.Name = "mnuOpenFile";
            this.mnuOpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpenFile.Size = new System.Drawing.Size(182, 22);
            this.mnuOpenFile.Text = "Öppna vinfil";
            this.mnuOpenFile.Click += new System.EventHandler(this.mnuOpenFile_Click);
            // 
            // mnuSaveFile
            // 
            this.mnuSaveFile.Name = "mnuSaveFile";
            this.mnuSaveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSaveFile.Size = new System.Drawing.Size(182, 22);
            this.mnuSaveFile.Text = "Spara vinfil";
            this.mnuSaveFile.Click += new System.EventHandler(this.mnuSaveFile_Click);
            // 
            // mnuSaveFileAs
            // 
            this.mnuSaveFileAs.Name = "mnuSaveFileAs";
            this.mnuSaveFileAs.Size = new System.Drawing.Size(182, 22);
            this.mnuSaveFileAs.Text = "Spara vinfil som";
            this.mnuSaveFileAs.Click += new System.EventHandler(this.mnuSaveFileAs_Click);
            // 
            // mnuNewFile
            // 
            this.mnuNewFile.Name = "mnuNewFile";
            this.mnuNewFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuNewFile.Size = new System.Drawing.Size(182, 22);
            this.mnuNewFile.Text = "Ny vinfil";
            this.mnuNewFile.Click += new System.EventHandler(this.mnuNewFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Binary file|*.bin|All files|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Binary file|*.bin";
            // 
            // lblWineEventInfo
            // 
            this.lblWineEventInfo.AutoSize = true;
            this.lblWineEventInfo.Location = new System.Drawing.Point(87, 24);
            this.lblWineEventInfo.Name = "lblWineEventInfo";
            this.lblWineEventInfo.Size = new System.Drawing.Size(142, 18);
            this.lblWineEventInfo.TabIndex = 9;
            this.lblWineEventInfo.Text = "Will be set by events";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 572);
            this.Controls.Add(this.lblWineEventInfo);
            this.Controls.Add(this.btnDrink);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstvWines);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Vinkällaren";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
        private System.Windows.Forms.ColumnHeader colVintage;
        private System.Windows.Forms.Button btnDrink;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenFile;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveFile;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveFileAs;
        private System.Windows.Forms.ToolStripMenuItem mnuNewFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label lblWineEventInfo;
    }
}

