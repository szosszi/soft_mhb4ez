using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace mintazh_eloadason_megoldva
{
    public partial class Form1 : Form
    {
        BindingList<Futok> csomofuto = new BindingList<Futok>();

        public Form1()
        {
            InitializeComponent();
            //dataGridView1.DataSource = csomofuto; //!!!!!!!!!!!!! ezt majd ki kell törölni
            futokBindingSource.DataSource = csomofuto;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("adatok.csv");
                //ha usingot használunk nem kell sr.Close()
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var t = csv.GetRecords<Futok>();
                foreach (var item in t)
                {
                    csomofuto.Add(item);
                }

                sr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void mentes_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter streamwriter = new StreamWriter(sfd.FileName);
                    CsvWriter csv = new CsvWriter(streamwriter, CultureInfo.InvariantCulture);
                    //var csv = new CsvWriter(streamwriter, CultureInfo.InvariantCulture);
                    csv.WriteRecords(csomofuto);


                    streamwriter.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (futokBindingSource.Current == null)
            {
                return;
                // ha nincs kiválasztva semmi, akk nem csinál semmit
            }

            if (MessageBox.Show("Fenti felirat", "Lenti felirat", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                futokBindingSource.RemoveCurrent();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            UjFuto ujform = new UjFuto();

            if (ujform.ShowDialog() == DialogResult.OK)
            {
                futokBindingSource.Add(ujform.ezegyujgyerek);
            }
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            /*double osszeg = 0;
            int darab = 0;
            foreach (var item in csomofuto)
            {
                if (item.Nemzetiseg == "USA") {
                    osszeg += item.EredmenyPerc;
                    darab++;
                }
                

            }
            double atlag = osszeg/darab;
            MessageBox.Show(atlag.ToString());*/

            // leggyorsabb

            double minimum = double.PositiveInfinity;
            string leggyorsabb = string.Empty;
            foreach (var item in csomofuto)
            {
                if (item.EredmenyPerc < minimum)
                {
                    minimum = item.EredmenyPerc;
                    leggyorsabb = item.Nev;

                }
            }
            MessageBox.Show(minimum.ToString());
            MessageBox.Show(leggyorsabb);
            MessageBox.Show($"A legjobb idõ: {minimum}");
        }
    }
}
