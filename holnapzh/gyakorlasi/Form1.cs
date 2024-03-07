using System.CodeDom;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace gyakorlasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Rakj ki a képernyõre 10x10 gombból egy szorzótáblát!
            /*
            int meret = 40;
            for (int sorok = 0; sorok < 11; sorok++)
            {
                for (int oszlopok = 0; oszlopok < 11; oszlopok++)
                {
                    Button gombi = new Button();
                    gombi.Width = meret;
                    gombi.Height = meret;
                    gombi.Top = meret * sorok;
                    gombi.Left = meret * oszlopok;
                    gombi.Text = ((oszlopok+1 )* (sorok+1)).ToString();
                    Controls.Add(gombi);
                }
                

            }*/
            #endregion

            #region Rakjátok ki a Fibonacci-sor elsõ tíz elemét gombokból az ûrlapra.
            /*
            int Fibonacci (int n) { 
            if (n==0) return 0;
            if (n==1) return 1;
            return Fibonacci(n-1)+Fibonacci(n-2);
            }
            int meret = 40;
            for (int i = 0; i < 10; i++)
            {
                Button b = new Button();
                b.Height = meret;
                b.Width = meret;
                b.Text = Fibonacci(i).ToString();
                b.Left = i*meret;
                b.Top = 10;
                Controls.Add(b);
  
            }

            //Helyezz el az ûrlapon egy DataGridView vezérlõt, ebbe kerülnek majd az értékek!
            DataGridView myGrid = new DataGridView();
            myGrid.Top = meret + 30;
            myGrid.Width = ClientSize.Width;
            myGrid.Height = ClientSize.Height/2*3;
            Controls.Add(myGrid);
            //Addj egy Elem nevû osztályt a prokethez.
            //Az osztálynak legyen egy int típusú Sorszám nevû, és egy long típusú Érték nevû tulajdonsága!
            //Hozz létre egy elemek nevû listát, mely Elem típusú elemekbõl áll! Ezt még a ciklus elõtt érdemes.

            List<Elem> elemek = new List<Elem>();

            //Minden cikluslépésben hozz létre egy új elemet, állítsd be a tulajdonságait, és add hozzá az elemek listához.

            for (int i = 0; i < 10; i++)
            {
                Elem ujelem = new Elem();
                ujelem.Ertek = Fibonacci(i);
                ujelem.Sorszam = i+1;
                elemek.Add(ujelem); 
            }
            //A DataGridView DataSource tulajdonságán keresztül jelenítsd meg a lista tartalát az ûrlapon!
            myGrid.DataSource = elemek;
            */
            #endregion

            #region Pascal háromszög
            /*
            int Faktorialis (int n) { 
                if (n == 0) { return 1; }
                return n * Faktorialis(n - 1);
            }

            int meret = 40;
            for (int sor = 0; sor < 10; sor++)
            {

                for (int oszlop = 0; oszlop < sor+1; oszlop++)
                {
                    int latomezo = ClientSize.Width;
                    int buttonHossz = (sor + 1) * meret;
                    Button v = new Button();
                    v.Width = meret;
                    v.Height = meret;
                    v.Top = meret*sor;
                    v.Left = latomezo/2 - buttonHossz/2 + oszlop*meret;
                    int p = Faktorialis(sor) / (Faktorialis(oszlop) * (Faktorialis(sor - oszlop)));
                    v.Text = p.ToString();

                    Controls.Add(v);
                }
            }
            */
            #endregion


            #region Csináljatok sakktáblát. Azaz csak minden második négyzetet jelenítsétek meg.
            /*

            int meret = 40;
            int szamlalo = 0;
            for (int sor = 0; sor < 10; sor++)
            {
                szamlalo++;
                for(int oszlop = 0; oszlop < 10; oszlop++)
                {
                    if (szamlalo % 2 == 0)
                    {
                        Button z = new Button();
                        z.Width = meret;
                        z.Height = meret;
                        z.Top = meret * sor;
                        z.Left = meret * oszlop;
                        Controls.Add(z);
                    }
                    szamlalo++;
                }
            }*/
            #endregion

            #region elsõ feladat
            //Hozz létre KÓDBÓL gomb néven egy példányt a Button osztályból, és add hozzá az ûrlap vezérlõinek listájához!
            /*
            Button gomb = new Button();
            
            // Állíts be méretet a gombnak!
            int meret = 40;
            gomb.Height = meret;
            gomb.Width = meret;

            //Állítsd be a gomb Left és Top tulajdonságát úgy, hogy pont középre kerüljön az ablakban!
            gomb.Left = ClientSize.Width/2- meret/2;
            gomb.Top = ClientSize.Height/2 -meret/2;
            Controls.Add(gomb);
            //Rakj ki 10 gombot egymás mellé az ûrlapra for ciklusból!
            //Egészítsd ki az elõzõ feladatot úgy, hogy 10x10 gomb legyen kint!
            //Csinálj szorzótáblát; jelenítsd meg a gombokon a számokat.

            
            int meret = 40;
            for (int sorok = 0; sorok < 11; sorok++)
            {
                for (int oszlopok = 0; oszlopok < 11; oszlopok++)
                {
                    VillogoGomb gombik = new VillogoGomb();
                    gombik.Width = meret;
                    gombik.Height = meret;
                    gombik.Top = meret * sorok;
                    gombik.Left = meret * oszlopok;
                    gombik.Text = ((oszlopok + 1) * (sorok + 1)).ToString();
                    Controls.Add(gombik);
                }


            }
                //Származtass VillogóGomb néven osztályt a Button osztályból!(A kódot írhatod a Form1 osztály alá, de adhatsz új osztályt a projekthez.)

                //Hozz létre konstruktort a VillogóGomb osztályban!(ctor - tab - tab)

                //A konstruktorban rendelj eseménykiszolgálót a MouseEnter és a MouseLeave eseményekhez!(+= -tab - tab)

                //Az eseménykiszolgálókban állítsd be a gomb színét.

                //Cseréld le a szorzótábla gombjait VillogóGomb - ra!
            */
            #endregion

            #region Véletlenségek
            Random random = new Random();
            for (int i = 0; i < 300; i++)
            {
                int m = random.Next(51);
                int t = random.Next(ClientSize.Height-m);
                int l = random.Next(ClientSize.Width-m);
                Button button = new Button();
                button.Height = m;
                button.Width = m;
                button.Top = t;
                button.Left = l;
                int r = random.Next(256);
                int g = random.Next(256);
                int b = random.Next(256);
                button.BackColor = Color.FromArgb(r, g, b);
                Controls.Add(button);
            }

            #endregion
        }
    }
}
