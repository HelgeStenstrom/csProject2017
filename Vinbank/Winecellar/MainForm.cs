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
            EnableButtonsIfOneWineSelected();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            WineForm wineFormObj = new WineForm("Lägg till vin");
            if (lstvWines.SelectedIndices.Count == 1)
            {
                int selectedIndex = lstvWines.SelectedIndices[0];
                wineFormObj.WineData = wineManagerObj.Get(selectedIndex);
            }
            var result = wineFormObj.ShowDialog();

            // Temporär label för att visa vad vi får för returnerat värde från WineForm
            lblResultFromWineForm.Text = result.ToString();

            if (result == DialogResult.OK)
            {
                Wine wine = wineFormObj.WineData;
                wineManagerObj.Add(wine);
            }
            UpdateTable();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstvWines.SelectedIndices.Count == 1) 
                // Not needed, actually, since we can't click the button if it's not true.
            {
                int selectedIndex = lstvWines.SelectedIndices[0];

                WineForm wineFormObj = new WineForm("Ändra vin");
                wineFormObj.WineData = wineManagerObj.Get(selectedIndex);
                var result = wineFormObj.ShowDialog();

                lblResultFromWineForm.Text = result.ToString();

                if (result == DialogResult.OK)
                {
                    Wine wine = wineFormObj.WineData;
                    wineManagerObj.ChangeWine(wine, selectedIndex);
                }
                UpdateTable();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstvWines.SelectedIndices.Count == 1)
            {
                int selectedIndex = lstvWines.SelectedIndices[0];
                string selectedName = wineManagerObj.Get(selectedIndex).WineName;
                if (ConfirmDialog($"Vill du ta bort {selectedName}?"))
                    wineManagerObj.Remove(selectedIndex);
                UpdateTable();
            }
        }

        private bool ConfirmDialog(string prompt)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(prompt,
                "Är du säker?",
                buttons);
            return (result == DialogResult.Yes);
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
