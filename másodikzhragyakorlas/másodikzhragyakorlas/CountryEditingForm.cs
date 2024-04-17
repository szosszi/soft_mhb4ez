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

namespace másodikzhragyakorlas
{
    public partial class CountryEditingForm : Form
    {
        public countryData orszagadat;
        public CountryEditingForm()
        {
            InitializeComponent();
        }

        private void CountryEditingForm_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = orszagadat;
        }

        private void save_Click(object sender, EventArgs e)
        {
            using (var writer = new StreamWriter("writer.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords("writer.csv");
            }
            this.Close();
        }
    }
}
