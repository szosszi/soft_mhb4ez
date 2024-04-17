namespace otodik_gyakorlat
{
    public partial class Form1 : Form
    {
        List<Kerdes> OsszesKerdes;
        List<Kerdes> AKtualisKerdesek;
        int MegjelenitettKerdesekSzama = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OsszesKerdes = KerdesekBetoltese();
            AKtualisKerdesek = new List<Kerdes>();

            for (int i = 0; i < 7; i++)
            {
                AKtualisKerdesek.Add(OsszesKerdes[0]);
                OsszesKerdes.RemoveAt(0);
            }
            dataGridView1.DataSource = AKtualisKerdesek;
            KerdesMegjelenites(AKtualisKerdesek[MegjelenitettKerdesekSzama]);
        }
        List<Kerdes> KerdesekBetoltese()
        {
            List<Kerdes> kerdesek = new List<Kerdes>();
            StreamReader sr = new StreamReader("hajo.txt", true);
            while (!sr.EndOfStream)
            {
                bool? viccesBool = null;
                string sor = sr.ReadLine(); // ?? "n/a"
                string[] tomb = sor.Split("\t");

                if (tomb.Length != 7) continue;

                Kerdes k = new Kerdes();
                k.KérdésSzöveg = tomb[1].ToUpper();
                k.Válasz1 = tomb[2].Trim('"');
                k.Válasz2 = tomb[3].Trim('"');
                k.Válasz3 = tomb[4].Trim('"');
                k.URL = tomb[5];

                int x = 0;
                int.TryParse(tomb[6], out x);
                k.HelyesVálasz = x;

                kerdesek.Add(k);
            }


            sr.Close();
            return kerdesek;
        }

        void KerdesMegjelenites(Kerdes kerdes)
        {
            textBox1.Text = kerdes.Válasz1;
            textBox2.Text = kerdes.Válasz2;
            textBox3.Text = kerdes.Válasz3;
            label1.Text = kerdes.KérdésSzöveg;

            if (string.IsNullOrEmpty(kerdes.URL))
            {
                pictureBox1.Visible = false;
            }
            else
            {

                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kerdes.URL);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MegjelenitettKerdesekSzama++;
            if (MegjelenitettKerdesekSzama == AKtualisKerdesek.Count)
            {
                MegjelenitettKerdesekSzama = 0;
            }
            KerdesMegjelenites(AKtualisKerdesek[MegjelenitettKerdesekSzama]);
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Salmon;
            Szinezes();

        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Salmon;
            Szinezes();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Salmon;
            Szinezes();
        }
        void Szinezes()
        {
            int helyesValasz = AKtualisKerdesek[MegjelenitettKerdesekSzama].HelyesVálasz;
            if(helyesValasz == 1) textBox1.BackColor = Color.LightGreen;
            if (helyesValasz == 2) textBox2.BackColor = Color.LightGreen;
            if (helyesValasz == 3) textBox3.BackColor = Color.LightGreen;
        }
    }
        
}