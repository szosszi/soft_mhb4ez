using CsvHelper;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace gyakorlo_sor_8_het
{
    public partial class Form1 : Form
    {
        BindingList<Feladat> feladatok = new();

        public Form1()
        {
            InitializeComponent();
            feladatBindingSource.DataSource = feladatok;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void read_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("hajokak.csv");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var r = csv.GetRecords<Feladat>();
                foreach (var item in r)
                {
                    feladatok.Add(item);
                }
                sr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (feladatBindingSource.Current == null) { return; }
            if (MessageBox.Show("Biztosvagybenne???", "Merész!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                feladatBindingSource.RemoveCurrent();
            }
        }

        private void new_line_Click(object sender, EventArgs e)
        {
            EditingForm ujadatok = new EditingForm();

            if (ujadatok.ShowDialog() == DialogResult.OK)
            {
                feladatBindingSource.Add(ujadatok.ezegyujsrac);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    CsvWriter csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(feladatok);
                    sw.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            szerkesztoForm szf = new szerkesztoForm();
            szf.ezegyujvalami = feladatBindingSource.Current as Feladat;
            szf.Show();
        }

        private void erdekessegek_Click(object sender, EventArgs e)
        {
            int egyes = 0;
            int kettes = 0;
            int harmas = 0;
            foreach (var item in feladatok) { 
                if (item.HelyesValasz == 1) { egyes++; }
                if (item.HelyesValasz == 2) { kettes++; }
                if (item.HelyesValasz == 3) { harmas++; }
            }
            MessageBox.Show($"Ahol az egyes volt a helyes válasz: {egyes}\nAhol a kettes volt a helyes válasz: {kettes}\nAhol a hármas volt a helyes válasz: {harmas}\n");

            double legkorabbi = double.PositiveInfinity;
            int bevetel = 0;
            string nev = string.Empty;
            foreach (var item in feladatok)
            {
                if (item.Ev < legkorabbi)
                {
                    legkorabbi = item.Ev;
                    bevetel = item.Bevetel;
                    nev = item.Cim;
                }
            }
            MessageBox.Show($"A {nev} címû film, lett legkorábban kiadva ({legkorabbi}-ban), a bevétele: {bevetel}");
        }



    }
}
