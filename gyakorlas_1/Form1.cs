namespace gyakorlas_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal hitelOssz = decimal.Parse(hitelossz.Text);
            decimal haviKamat = decimal.Parse(havikam.Text);
            decimal haviTorl = decimal.Parse(havitorl.Text);

            decimal hatralek = hitelOssz;
            decimal befizetett = 0;

            int honap = 1;
            List<EzLeszEgySor> tablazat = new List<EzLeszEgySor>();
            while (true)
            {
                EzLeszEgySor eppenirom = new EzLeszEgySor();
                hatralek += haviKamat * (hatralek/100m);
               

                if (hatralek <= haviTorl)
                {
                    eppenirom.Hatralekoszlop = 0;
                    eppenirom.Honaposzlop = honap+1;
                    eppenirom.EnnyitfizettemOsszesen = befizetett + hatralek;
                    tablazat.Add(eppenirom);
                    break;
                }
                hatralek -= haviTorl;
                befizetett += haviTorl;
                honap++;
                eppenirom.Hatralekoszlop = hatralek;
                eppenirom.Honaposzlop = honap;
                eppenirom.EnnyitfizettemOsszesen = befizetett;
                tablazat.Add(eppenirom);
                

            }
            megejeleníto.DataSource = tablazat;
        }
    }
}
