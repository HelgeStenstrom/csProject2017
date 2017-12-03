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
    public partial class WineEntryForm : Form
    {
        /// <summary>
        /// The wine that corresponds to the GUI fields.
        /// </summary>
        private Wine workingWine;

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

        public void VariousClickMethods()
        {
            throw new System.NotImplementedException();
        }
    }
}
