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
    public partial class MainForm : Form
    {
        private WineManager wineManagerObj = new WineManager();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dialog = new WineForm();
            var result = dialog.ShowDialog();

            lblResultFromWineForm.Text = result.ToString();
        }
    }
}
