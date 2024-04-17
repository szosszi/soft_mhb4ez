using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace masodikzhajajaj
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> countrylist = new();
        public Form1()
        {
            InitializeComponent();
            countryDataBindingSource.DataSource = countrylist;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var reader = new StreamReader("country.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var x = csv.GetRecords<CountryData>();
                foreach (var item in x)
                {
                    countrylist.Add(item);
                }
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            countryDataBindingSource.RemoveCurrent();
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                countryDataBindingSource.RemoveCurrent();

            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            CountryEditingForm cef = new CountryEditingForm();
            cef.ezbizonyaz = countryDataBindingSource.Current as CountryData;
            cef.Show();
            
        }
    }
}