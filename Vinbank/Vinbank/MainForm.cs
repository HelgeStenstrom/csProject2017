using System;
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
    public partial class MainForm : Form
    {
        private WineEntryForm entryForm;

        public MainForm()
        {
            InitializeComponent();
        }

        public WineCellar WineCellar
        {
            get => default(WineCellar);
            set
            {
            }
        }

        public WineEntryForm WineEntryForm
        {
            get => default(WineEntryForm);
            set
            {
            }
        }

        /// <summary>
        /// Respond to clicks in the form.
        /// </summary>
        public void VariousClickMethods()
        {
            throw new System.NotImplementedException();
        }
    }
}
