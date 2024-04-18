using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyakorlo_sor_8_het
{
    public partial class EditingForm : Form
    {
        public Feladat ezegyujsrac = new Feladat();
        public EditingForm()
        {
            InitializeComponent();
        }

        private void EditingForm_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = ezegyujsrac;
        }
    }
}
