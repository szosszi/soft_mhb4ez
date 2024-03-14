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
    }
}