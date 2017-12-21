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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // TODO: hitta på bättre formulärrubrik.
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
            {
                // TODO: redigera rätt vin
                UpdateTable();
                throw new NotImplementedException();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstvWines.SelectedIndices.Count == 1)
            {
                // TODO: ta bort rätt vin
                UpdateTable();
                throw new NotImplementedException();
            }
        }
    }
}
