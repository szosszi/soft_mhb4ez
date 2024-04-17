using CsvHelper;
using System.ComponentModel;
using System.Diagnostics.PerformanceData;
using System.Globalization;

namespace másodikzhragyakorlas
{
    public partial class Form1 : Form
    {
        BindingList<countryData> countriesList = new();
        public Form1()
        {
            InitializeComponent();
            countryDataBindingSource.DataSource = countriesList;
            dataGridView1.DataSource = countryDataBindingSource;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var reader = new StreamReader("country.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var x = csv.GetRecords<countryData>();
                foreach (var item in x)
                {
                    countriesList.Add(item);
                }
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                countryDataBindingSource.RemoveCurrent();
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            CountryEditingForm form = new CountryEditingForm();
            form.orszagadat = countryDataBindingSource.Current as countryData;
            form.Show();
        }
    }
}
