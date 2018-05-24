﻿//MainForm.cs
//Helge Stenström ah7875
//2017-12-29
using System;
using System.Windows.Forms;

namespace Winecellar
{
    public partial class MainForm : Form
    {
        #region Fields
        /// <summary>
        /// The MainForm has a WineManager which controls the list of wines.
        /// </summary>
        private WineManager wineManagerObj = new WineManager();
        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGui();
            UpdateGui();
        }
        #endregion

        #region Methods

        /// <summary>
        /// Initialize the GUI. Currently, it's only the ListView for wines that needs any initialization.
        /// </summary>
        private void InitializeGui()
        {
            // Replace the columns drawn in the GUI editor with columns defined here.
            // It's easier to match these columns to the data in Wine.RowStrings method.
            // Column widths are in argument #2 in the Add argument list.
            lstvWines.Columns.Clear();
            lstvWines.Columns.Add("Namn", 350, HorizontalAlignment.Center);
            lstvWines.Columns.Add("Årgång", 65, HorizontalAlignment.Center);
            lstvWines.Columns.Add("Land", 170, HorizontalAlignment.Left);
            lstvWines.Columns.Add("Typ", 50, HorizontalAlignment.Center);
            lstvWines.Columns.Add("Datum", 150, HorizontalAlignment.Center);
        }

        /// <summary>
        /// Update the GUI using available information.
        /// Add wines to the list.
        /// Enable some buttons if a wine is selected.
        /// </summary>
        private void UpdateGui()
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

        #region Event handlers
        /// <summary>
        /// Button Lägg till vin
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            WineForm wineFormObj = new WineForm("Lägg till vin");
            // Only one wine may be selected, so we know which wine to act on.
            if (lstvWines.SelectedIndices.Count == 1)
            {
                int selectedIndex = lstvWines.SelectedIndices[0]; // The first and only wine that is selected.
                try
                {
                    wineFormObj.WineData = wineManagerObj.GetWine(selectedIndex);
                }
                catch (IndexOutOfRangeException)
                {
                    MessageProblem(false); // If the selectedIndex was out of range, show a warning message.
                }
            }
            var result = wineFormObj.ShowDialog();

            if (result == DialogResult.OK) // If the user wants to add the wine
            {
                Wine wine = wineFormObj.WineData;
                wineManagerObj.AddWine(wine);
            }
            UpdateGui();
        }

        /// <summary>
        /// button Ändra vin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (lstvWines.SelectedIndices.Count == 1) 
                // Always true, since we can't click the button if it's not true.
                // We test anyway, to be extra super safe.
            {
                int selectedIndex = lstvWines.SelectedIndices[0];

                WineForm wineFormObj = new WineForm("Ändra vin");
                try
                {
                    wineFormObj.WineData = wineManagerObj.GetWine(selectedIndex);
                    var result = wineFormObj.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        Wine wine = wineFormObj.WineData;
                        wineManagerObj.ChangeWine(wine, selectedIndex);
                    }
                }
                catch (IndexOutOfRangeException )
                {
                    MessageProblem(false); // If the selectedIndex was out of range, show a warning message.
                }
                UpdateGui();
            }
        }

        /// <summary>
        /// button Ta bort vin
        /// </summary>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstvWines.SelectedIndices.Count == 1)
            {
                int selectedIndex = lstvWines.SelectedIndices[0];
                string selectedName = wineManagerObj.GetWine(selectedIndex).WineName;
                if (ConfirmDialog($"Vill du ta bort {selectedName}?"))
                {
                     bool success = wineManagerObj.RemoveWine(selectedIndex);
                    MessageProblem(success); // If the selectedIndex was out of range, show a warning message.
                }

                UpdateGui();
            }
        }
        
        /// <summary>
        /// button Drick vin!
        /// </summary>
        private void btnDrink_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstvWines.SelectedIndices[0];

            Wine wineIn = wineManagerObj.GetWine(selectedIndex);
            ConsumedForm consumedFormObj = new ConsumedForm(wineIn.WineName);
            consumedFormObj.WineData = wineIn;
            var result = consumedFormObj.ShowDialog();

            if (result == DialogResult.OK)
            {
                Wine wineOut = consumedFormObj.WineData;
                wineManagerObj.ChangeWine(wineOut, selectedIndex);
            }
            UpdateGui();
        }

        /// <summary>
        /// When a wine is selected, enable some buttons.
        /// </summary>
        private void lstvWines_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButtonsIfOneWineSelected();
        }

        /// <summary>
        /// MainForm closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxButtons okButton = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show("Vill du spara alla ändringar innan avslut?",
                "Bekräfta!", okButton);

            if (result == DialogResult.Yes)
            {
                SaveWinesToFile();
                e.Cancel = false;
            }
                          
            else if (result == DialogResult.No)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
        #endregion Event handlers

        /// <summary>
        /// Enable Change, Remove and Drink buttons if one wine is selected.
        /// In Swedish: Ändra vin, Ta bort vin, Drick vin!
        /// </summary>
        private void EnableButtonsIfOneWineSelected()
        {
            bool onlyOneSelected = (lstvWines.SelectedIndices.Count == 1);
            btnChange.Enabled = onlyOneSelected;
            btnRemove.Enabled = onlyOneSelected;
            btnDrink.Enabled = onlyOneSelected;
        }

        /// <summary>
        /// Messagebox to confirm choice
        /// </summary>
        /// <param name="prompt"></param>
        private bool ConfirmDialog(string prompt)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(prompt,
                "Är du säker?",
                buttons);
            return (result == DialogResult.Yes);
        }

        /// <summary>
        /// Messagebox to inform about internal error
        /// </summary>
        /// <param name="success"></param>
        private void MessageProblem(bool success)
        {
            if (success == false)
                MessageBox.Show("Något gick fel, försök igen!");
        }

        private void SaveWinesToFile()
        {
            throw new NotImplementedException();
        }

        #endregion Methods


    }
}
