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
    public partial class WineForm : Form
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
                UpdateGui();
            }
        }

        /// <summary>
        /// default constructor with one parameter
        /// </summary>
        public WineForm(string title)
        {
            InitializeComponent();
            InitializeGui(title);
            wineObj = new Wine(); // create wineObj
        }

        /// <summary>
        /// Initialize user interface
        /// </summary>
        private void InitializeGui(string title)
        {
            this.Text = title;
            txtWineName.Clear();
            txtWineName.Focus();
            btnSave.Enabled = false; //grey out Save (Spara) button
        }

        /// <summary>
        ///  update user interface
        /// </summary>
        private void UpdateGui()
        {
            //TODO: nya fält
            txtWineName.Text = wineObj.WineName;
        }

        /// <summary>
        /// Enable Spara button when name is written
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtWineName_TextChanged(object sender, EventArgs e)
        {            
            btnSave.Enabled = !string.IsNullOrWhiteSpace(txtWineName.Text); 
        }

        /// <summary>
        /// Spara button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateWineFromForm();
        }

        /// <summary>
        /// Save input from form to wine object
        /// </summary>
        private void UpdateWineFromForm()
        {
            //TODO: nya fält
            wineObj.WineName = txtWineName.Text;
            wineObj.Vintage = (int)numYear.Value;
            wineObj.DateAdded = dateTimePicker1.Value.Date;
        }

        /// <summary>
        /// Avbryt button
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
        private void WineForm_FormClosing(object sender, FormClosingEventArgs e)
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

        /// <summary>
        /// Create DateTimePicker, set max/min date, display control.
        /// </summary>
        //public void CreateMyDateTimePicker()
        //{
        //    // Create a new DateTimePicker control and initialize it.
        //    DateTimePicker dateTimePicker1 = new DateTimePicker();

        //    // Set the MinDate and MaxDate.
        //    dateTimePicker1.MinDate = new DateTime(1900, 01, 01);
        //    dateTimePicker1.MaxDate = new DateTime(2100, 12, 31);

        //    // Set the CustomFormat string.
        //    dateTimePicker1.CustomFormat = "yyyy MM dd";
        //    dateTimePicker1.Format = DateTimePickerFormat.Custom;

        //    // Show the CheckBox and display the control as an up-down control.
        //    dateTimePicker1.ShowCheckBox = true;
        //    dateTimePicker1.ShowUpDown = true;
        //}
    } //close class
}//close namespace
