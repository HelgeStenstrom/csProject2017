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
    public partial class ConsumedForm : Form
    {
        private Wine wineObj; //declare wineObj as type Wine

        /// <summary>
        /// Property related to wine object
        /// </summary> 
        public Wine WineData
    {
            get => new Wine(wineObj);
            set
            {
                wineObj = new Wine(value);
            }
    }

        public ConsumedForm(string title)
        {
            InitializeComponent();
            this.Text = title;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            wineObj.DateConsumed = dtpDateConsumed.Value.Date;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConsumedForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
                e.Cancel = false;
            else
            {
                // TODO: fundera på när konfirmering ska användas.
                e.Cancel = !CancelFormQuestion();
            }
        }

        /// <summary>
        /// Ask if changes should be discarded and form closed
        /// </summary>
        /// <returns></returns>
        private bool CancelFormQuestion()
        {
            MessageBoxButtons okButton = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Vill du slänga alla ändringar?",
                "Bekräfta!", okButton);
            return (result == DialogResult.Yes);
        }

    } // close class
}