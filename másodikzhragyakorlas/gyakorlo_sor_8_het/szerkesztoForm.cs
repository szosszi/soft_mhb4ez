using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyakorlo_sor_8_het
{
    public partial class szerkesztoForm : Form
    {
        public Feladat ezegyujvalami;
        public szerkesztoForm()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            using (var writer = new StreamWriter("ujadat.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords("ujadat.csv");
            }
            this.Close();
        }

        private void szerkesztoForm_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = ezegyujvalami;
        }
    }
}
