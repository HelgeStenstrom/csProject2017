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
            UpdateGUI();
        }

        private void UpdateGUI()
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

        /// <summary>
        /// Button Lägg till vin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            WineForm wineFormObj = new WineForm("Lägg till vin");
            if (lstvWines.SelectedIndices.Count == 1)
            {
                int selectedIndex = lstvWines.SelectedIndices[0];
                wineFormObj.WineData = wineManagerObj.GetWine(selectedIndex);
            }
            var result = wineFormObj.ShowDialog();

            // Temporär label för att visa vad vi får för returnerat värde från WineForm
            lblResultFromWineForm.Text = result.ToString();

            if (result == DialogResult.OK)
            {
                Wine wine = wineFormObj.WineData;
                wineManagerObj.AddWine(wine);
            }
            UpdateGUI();
        }

        /// <summary>
        /// button Ändra vin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (lstvWines.SelectedIndices.Count == 1) 
                // TODO: Not needed, actually, since we can't click the button if it's not true.
            {
                int selectedIndex = lstvWines.SelectedIndices[0];

                WineForm wineFormObj = new WineForm("Ändra vin");
                wineFormObj.WineData = wineManagerObj.GetWine(selectedIndex);
                var result = wineFormObj.ShowDialog();

                lblResultFromWineForm.Text = result.ToString();

                if (result == DialogResult.OK)
                {
                    Wine wine = wineFormObj.WineData;
                    wineManagerObj.ChangeWine(wine, selectedIndex);
                }
                UpdateGUI();
            }
        }

        /// <summary>
        /// button Ta bort vin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstvWines.SelectedIndices.Count == 1)
            {
                int selectedIndex = lstvWines.SelectedIndices[0];
                string selectedName = wineManagerObj.GetWine(selectedIndex).WineName;
                if (ConfirmDialog($"Vill du ta bort {selectedName}?"))
                    wineManagerObj.RemoveWine(selectedIndex);
                UpdateGUI();
            }
        }

        /// <summary>
        /// Messagebox to confirm choice
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private bool ConfirmDialog(string prompt)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(prompt,
                "Är du säker?",
                buttons);
            return (result == DialogResult.Yes);
        }

        /// <summary>
        /// When a wine is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstvWines_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButtonsIfOneWineSelected();
        }

        /// <summary>
        /// Enable Change and Remove buttons
        /// </summary>
        private void EnableButtonsIfOneWineSelected()
        {
            bool onlyOneSelected = (lstvWines.SelectedIndices.Count == 1);
            btnChange.Enabled = onlyOneSelected;
            btnRemove.Enabled = onlyOneSelected;
        }
    }
}
