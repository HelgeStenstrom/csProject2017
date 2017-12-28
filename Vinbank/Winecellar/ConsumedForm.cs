//ConsumedForm.cs
//Ann-Marie Bergström ai2436
//2017-12-29
using System;
using System.Windows.Forms;

namespace Winecellar
{
    public partial class ConsumedForm : Form
    {
        #region Fields
        private Wine wineObj; //declare wineObj as type Wine
        #endregion Fields

        #region Properties
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
        #endregion Properties

        #region Constructors
        /// <summary>
        /// Constructor with a parameter for form title.
        /// </summary>
        /// <param name="title"></param>
        public ConsumedForm(string title)
        {
            InitializeComponent();
            this.Text = title;
        }
        #endregion Constructors

        #region Event handlers
        /// <summary>
        /// Button "Spara"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            wineObj.DateConsumed = dtpDateConsumed.Value.Date;
            wineObj.IsConsumed = true;
        }

        /// <summary>
        /// Button "Avbryt"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
        #endregion Event handlers

    } // close class
}