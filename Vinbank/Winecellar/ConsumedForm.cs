using System;
using System.Windows.Forms;

namespace Winecellar
{
    public partial class ConsumedForm : Form
    {
        private Wine wineObj; //declare wineObj as type Wine

        /// <summary>
        /// Wine object as property, using copy constructors
        /// </summary> 
        public Wine WineData
    {
            get => new Wine(wineObj);
            set
            {
                wineObj = new Wine(value);
            }
    }

        /// <summary>
        /// Constructor with a form title.
        /// Open the form for marking a wine as consumed, and optionally setting the date.
        /// </summary>
        /// <param name="title"></param>
        public ConsumedForm(string title)
        {
            InitializeComponent();
            this.Text = title;
        }

        /// <summary>
        /// Called when the button "Spara" is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            wineObj.DateConsumed = dtpDateConsumed.Value.Date;
            wineObj.IsConsumed = true;
        }

        /// <summary>
        /// Called when the button "Avbryt" is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void ConsumedForm_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (DialogResult == DialogResult.OK)
        //        e.Cancel = false;
        //    else
        //    {
        //        // TODO: fundera på när konfirmering ska användas.
        //        e.Cancel = !CancelFormQuestion();
        //    }
        //}

        /// <summary>
        /// Ask if changes should be discarded and form closed
        /// </summary>
        /// <returns></returns>
        //private bool CancelFormQuestion()
        //{
        //    MessageBoxButtons okButton = MessageBoxButtons.YesNo;
        //    DialogResult result = MessageBox.Show("Vill du slänga alla ändringar?",
        //        "Bekräfta!", okButton);
        //    return (result == DialogResult.Yes);
        //}

    } // close class
}