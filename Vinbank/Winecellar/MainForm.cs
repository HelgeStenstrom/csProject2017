using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winecellar
{
    public partial class MainForm : Form
    {
        private WineManager wineManagerObj = new WineManager();

        public MainForm()
        {
            InitializeComponent();
            UpdateTable();
            EnableButtonsIfOneWineSelected();
        }

        private void UpdateTable()
        {
            lstvWines.Items.Clear();
            foreach (var wineForRow in wineManagerObj.WinesAsRows)
            {
                // Create a row of the data
                ListViewItem tableRow = new ListViewItem(wineForRow);
                // and add it to the ListView
                lstvWines.Items.Add(tableRow);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            WineForm dialog = new WineForm("Lägg till vin");
            var result = dialog.ShowDialog();

            lblResultFromWineForm.Text = result.ToString();
            if (result == DialogResult.OK)
            {
                // TODO: Skriv färdigt nästa rader
                Wine wine = dialog.WineData;
                wineManagerObj.Add(wine);
            }
            UpdateTable();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstvWines.SelectedIndices.Count == 1) 
                // Not needed, actually, since we can't click the button if it's not true.
            {
                // TODO: redigera rätt vin
                int selected = lstvWines.SelectedIndices[0];
                Wine toEdit = wineManagerObj.Get(selected);

                WineForm dialog = new WineForm("Lägg till vin");
                dialog.WineData = toEdit;
                var result = dialog.ShowDialog();

                lblResultFromWineForm.Text = result.ToString();
                if (result == DialogResult.OK)
                {
                    // TODO: man kan inte avbryta
                    // TODO: Skriv färdigt nästa rader
                    Wine wine = dialog.WineData;
                    // wineManagerObj.Add(wine);
                }
                UpdateTable();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstvWines.SelectedIndices.Count == 1)
            {
                int selected = lstvWines.SelectedIndices[0];
                string selectedName = wineManagerObj.Get(selected).WineName;
                if (ConfirmDialog($"Vill du ta bort {selectedName}?"))
                    wineManagerObj.Remove(selected);
                UpdateTable();
            }
        }

        private bool ConfirmDialog(string propmpt)
        {
            MessageBoxButtons okButton = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(propmpt,
                "Är du säker?",
                okButton);
            return (result == DialogResult.OK);
        }

        private void lstvWines_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButtonsIfOneWineSelected();
        }

        private void EnableButtonsIfOneWineSelected()
        {
            bool onlyOneSelected = (lstvWines.SelectedIndices.Count == 1);
            btnEdit.Enabled = onlyOneSelected;
            btnRemove.Enabled = onlyOneSelected;
        }
    }
}
