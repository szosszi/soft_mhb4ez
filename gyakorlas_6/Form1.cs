using System.CodeDom;

namespace gyakorlas_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Gomb középre téve
            /*int meret = 40;
            Button picigomb = new Button();
            picigomb.Width = meret;
            picigomb.Height = meret;
            picigomb.Left = ClientRectangle.Width / 2 - meret/2;
            picigomb.Top = ClientRectangle.Height / 2 - meret/2;
            Controls.Add(picigomb);*/
            #endregion

            #region 10 gomb kirakása
            /*int meret = 40;
            for (int i = 0; i < 10; i++)
            { 
                Button gomboc = new Button();
                gomboc.Height = meret;
                gomboc.Width = meret;
                gomboc.Left = meret * i+20*i;
                Controls.Add(gomboc);

            }
            */


            #endregion

            #region szorzotabla készítése + villogo +szinezo gomb
            /*
            int meret = 100;
            for (int sor = 1; sor < 11; sor++)
            {
                for (int oszlop = 1; oszlop < 11; oszlop++)
                {
                    SzinezodoGomb gomboc = new SzinezodoGomb();
                    gomboc.Height = meret;
                    gomboc.Width = meret;
                    gomboc.Left = meret * oszlop + 10 * oszlop;
                    gomboc.Top = meret *sor + 10 * sor;
                    gomboc.Text = (sor * oszlop).ToString();
                    gomboc.BackColor = Color.White;
                    Controls.Add(gomboc);

                }
            }
            */
            #endregion

            #region szamolo gomb
            /*
            int meret = 40;
            for (int sor = 1; sor < 11; sor++)
            {
                for (int oszlop = 1; oszlop < 11; oszlop++)
                {
                    SzamoloGomb gomboc = new SzamoloGomb();
                    
                    gomboc.Left = meret * oszlop + 10 * oszlop;
                    gomboc.Top = meret * sor + 10 * sor;
                    
                    gomboc.BackColor = Color.White;
                    Controls.Add(gomboc);

                }
            }
            */
            #endregion

            #region Véletlenszerûségek
            /*
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                Button kisgomb = new Button();
                int meret = random.Next(20, 50);
                kisgomb.Height = meret;
                kisgomb.Width= meret;
                kisgomb.Top = random.Next(0,ClientRectangle.Height-meret);
                kisgomb.Left = random.Next(0, ClientRectangle.Width - meret);
                int r = random.Next(0,255);
                int g = random.Next(0, 255);
                int b = random.Next(0, 255);
                kisgomb.BackColor = Color.FromArgb(r, g, b);
                Controls.Add(kisgomb);
            }
            */
            #endregion

            #region Rakd ki egy 10x10-es gombokból álló mátrix gombjait fõátlóba!
            /*
            int meret = 40;

            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++) 
                {
                    
                    if (oszlop < sor)
                    {
                        Button gombigombi = new Button();
                        gombigombi.Height = meret;
                        gombigombi.Width = meret;
                        gombigombi.Top = meret * sor;
                        gombigombi.Left = meret*oszlop;
                        Controls.Add(gombigombi);

                    }
                    
                }
            }*/
            #endregion


            #region  Fenyõfa <3

            int meret = 40;
            
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < sor+1; oszlop++)
                {
                    int ennyiNegyzetVanASorban = sor + 1;
                    int osszesKockaSzelesseg = ennyiNegyzetVanASorban * meret;
                    int ablak = ClientRectangle.Width;

                    Button kisgombi = new Button();
                    kisgombi.Height = meret;
                    kisgombi.Width = meret;
                    kisgombi.Top = meret * sor;
                    kisgombi.BackColor = Color.Green;
                    kisgombi.Left = meret * oszlop + (ClientRectangle.Width/2) - (osszesKockaSzelesseg / 2);
                    Controls.Add(kisgombi);
                    

                }
            }
            for (int i = 0; i < 2; i++)
            {
                Button torzs = new Button();
                torzs.Height = meret;
                torzs.Width = meret;
                torzs.BackColor = Color.Brown;
                torzs.Top = meret * 10;
                torzs.Left = ClientRectangle.Width / 2 - meret*i;
                Controls.Add(torzs);
            }
            
            #endregion
        }
    }
}
