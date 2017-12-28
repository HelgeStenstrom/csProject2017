//WineForm.cs
//Ann-Marie Bergström ai2436
//2017-12-29

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
        #region Fields
        private Wine wineObj; //declare wineObj as type Wine
        #endregion Fields

        #region Properties
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
        #endregion Properties

        #region Constructors
        /// <summary>
        /// default constructor with one parameter for form title
        /// </summary>
        public WineForm(string title)
        {
            InitializeComponent();
            InitializeGui(title);
            wineObj = new Wine(); // create wineObj
        }
        #endregion Constructors

        #region Methods
        /// <summary>
        /// Initialize user interface
        /// </summary>
        private void InitializeGui(string title)
        {
            this.Text = title;
            txtWineName.Clear();
            txtWineName.Focus();
            numYear.Value = Convert.ToDecimal(DateTime.Now.ToString(@"yyyy")); //set Årgång to current year
            cboCountry.DataSource = GetAllCountryStrings(); //populate Land combobox
            cboWineType.DataSource = GetAllWineTypeStrings(); //populate Typ combobox
            chbIsConsumed.Checked = false; //uncheck checkbox for Dryckesdatum
            lblDateConsumed.Enabled = false; //grey out Dryckesdatum text
            dtpDateConsumed.Enabled = false; //grey out datetimepicker Dryckesdatum
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
            lblDateConsumed.Enabled = wineObj.IsConsumed;
            dtpDateConsumed.Enabled = wineObj.IsConsumed;
            if (wineObj.IsConsumed)
                dtpDateConsumed.Value = wineObj.DateConsumed;
        }

        #region Event handlers

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
            lblDateConsumed.Enabled = chbIsConsumed.Checked;
            dtpDateConsumed.Enabled = chbIsConsumed.Checked;

            if (!chbIsConsumed.Checked)
            {
                dtpDateConsumed.Value = dtpDateConsumed.MinDate;
            }
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
                e.Cancel = !CancelFormQuestion();
            }
        }
        #endregion Event handlers

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
            wineObj.DateConsumed = dtpDateConsumed.Value.Date;
        }

        /// <summary>
        /// Ask if changes should be discarded and form closed
        /// </summary>
        private bool CancelFormQuestion()
        {
                MessageBoxButtons okButton = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Vill du slänga alla ändringar?",
                    "Bekräfta!", okButton);
                return (result == DialogResult.Yes);
        }

        #endregion Methods

    } //close class
}//close namespace
