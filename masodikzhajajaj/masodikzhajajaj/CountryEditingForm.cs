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

namespace masodikzhajajaj
{
    public partial class CountryEditingForm : Form
    {
        public CountryData ezbizonyaz;

        public CountryEditingForm()
        {
            InitializeComponent();
        }

        private void CountryEditingForm_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = ezbizonyaz;
        }

        private void save_Click(object sender, EventArgs e)
        {
            using (var writer = new StreamWriter("countries.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                // Write records to the CSV file
                csv.WriteRecords("countries.csv");
            };
            this.Close();
        }
    }
}
