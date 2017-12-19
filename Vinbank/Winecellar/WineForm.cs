﻿using System;
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

       // private bool closeForm; // flag to handle closing of form


        /// <summary>
        /// default constructor
        /// </summary>
        public WineForm()
        {
            InitializeComponent();
            InitializeGui();
            wineObj = new Wine(); // create wineObj
            //UpdateGui();
        }

        /// <summary>
        /// Initialize user interface
        /// </summary>
        private void InitializeGui()
        {
            txtWineName.Clear();
            txtWineName.Focus();
            btnSave.Enabled = false; //grey out Save (Spara) button
            //closeForm = true;
            UpdateGui();
        }

        /// <summary>
        ///  update user interface
        /// </summary>
        private void UpdateGui()
        {
            txtWineName.Text = wineObj.WineName;
        }

            /// <summary>
            /// Check text and ungrey Save (Spara) button 
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void txtWineName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtWineName.Text))
                btnSave.Enabled = true; 
        }

        /// <summary>
        /// Button Spara click - save input to wine object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            wineObj.WineName = txtWineName.Text;
        }


        /// <summary>
        /// Button Avbryt click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
        }

        private void WineForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = CancelFormQuestion();
        }

        /// <summary>
        /// Ask if changes should be discarded and form closed
        /// </summary>
        /// <returns></returns>
        private bool CancelFormQuestion()
        {
                MessageBoxButtons okButton = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show("Vill du slänga alla ändringar?",
                    "Bekräfta!", okButton);
                return (result == DialogResult.OK);
        }

    } //close class
}//close namespace
