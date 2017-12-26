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
            numYear.Value = Convert.ToDecimal(DateTime.Now.ToString(@"yyyy"));
            cboCountry.DataSource = GetAllCountryStrings(); //populate Land combobox
            cboWineType.DataSource = GetAllWineTypeStrings(); //populate Typ combobox
            chbIsConsumed.Checked = false;
            lblDateConsumed.Enabled = false;
            dtpDateConsumed.Enabled = false;
            btnSave.Enabled = false; // disable Spara button
        }

        /// <summary>
        /// Create country strings without underscore chars
        /// </summary>
        /// <returns>returns countries list without underscore chars </returns>
        private static List<string> GetAllCountryStrings()
        {
            List<string> countries = new List<string>();
            foreach (string country in Enum.GetNames(typeof(Countries)))
            {
                countries.Add(country.Replace("_", " "));
            }
            return countries;
        }

        /// <summary>
        /// Create wine type strings
        /// </summary>
        /// <returns>return wine type list </returns>
        private static List<string> GetAllWineTypeStrings()
        {
            List<string> wineTypes = new List<string>();
            foreach (string winetype in Enum.GetNames(typeof(WineType)))
            {
                wineTypes.Add(winetype);
            }
            return wineTypes;
        }

        /// <summary>
        ///  update user interface
        /// </summary>
        private void UpdateGui()
        {
            txtWineName.Text = wineObj.WineName;
            numYear.Value = wineObj.Vintage;
            cboCountry.SelectedIndex = (int)wineObj.Country;
            cboWineType.SelectedIndex = (int)wineObj.WineType;
            dtpDateAdded.Value = wineObj.DateAdded;
            chbIsConsumed.Checked = wineObj.IsConsumed;
            if (chbIsConsumed.Enabled)
            {
                lblDateConsumed.Enabled = true;
                dtpDateConsumed.Enabled = true;
                dtpDateConsumed.Value = wineObj.DateConsumed;
            }
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
        /// Checkbox for Dryckesdatum changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chbIsConsumed_CheckedChanged(object sender, EventArgs e)
        {
            lblDateConsumed.Enabled = true;
            dtpDateConsumed.Enabled = true;
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
            wineObj.WineName = txtWineName.Text;
            wineObj.Vintage = (int)numYear.Value;
            wineObj.Country = (Countries)cboCountry.SelectedIndex;
            wineObj.WineType = (WineType)cboWineType.SelectedIndex;
            wineObj.DateAdded = dtpDateAdded.Value.Date;
            wineObj.IsConsumed = chbIsConsumed.Checked;
            if (chbIsConsumed.Checked)
                wineObj.DateConsumed = dtpDateConsumed.Value.Date;
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
