﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vinbank
{
    public partial class WineEntryForm : Form
    {
        public WineEntryForm()
        {
            InitializeComponent();
        }

        public WineEntryForm(Wine wine)
        {
            throw new System.NotImplementedException();
        }

        public Wine Wine
        {
            get => default(Wine);
            set
            {
            }
        }
    }
}
