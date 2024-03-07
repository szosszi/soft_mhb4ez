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
            #region Rakj ki a k�perny�re 10x10 gombb�l egy szorz�t�bl�t!
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

            #region Rakj�tok ki a Fibonacci-sor els� t�z elem�t gombokb�l az �rlapra.
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

            //Helyezz el az �rlapon egy DataGridView vez�rl�t, ebbe ker�lnek majd az �rt�kek!
            DataGridView myGrid = new DataGridView();
            myGrid.Top = meret + 30;
            myGrid.Width = ClientSize.Width;
            myGrid.Height = ClientSize.Height/2*3;
            Controls.Add(myGrid);
            //Addj egy Elem nev� oszt�lyt a prokethez.
            //Az oszt�lynak legyen egy int t�pus� Sorsz�m nev�, �s egy long t�pus� �rt�k nev� tulajdons�ga!
            //Hozz l�tre egy elemek nev� list�t, mely Elem t�pus� elemekb�l �ll! Ezt m�g a ciklus el�tt �rdemes.

            List<Elem> elemek = new List<Elem>();

            //Minden ciklusl�p�sben hozz l�tre egy �j elemet, �ll�tsd be a tulajdons�gait, �s add hozz� az elemek list�hoz.

            for (int i = 0; i < 10; i++)
            {
                Elem ujelem = new Elem();
                ujelem.Ertek = Fibonacci(i);
                ujelem.Sorszam = i+1;
                elemek.Add(ujelem); 
            }
            //A DataGridView DataSource tulajdons�g�n kereszt�l jelen�tsd meg a lista tartal�t az �rlapon!
            myGrid.DataSource = elemek;
            */
            #endregion

            #region Pascal h�romsz�g
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


            #region Csin�ljatok sakkt�bl�t. Azaz csak minden m�sodik n�gyzetet jelen�ts�tek meg.
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

            #region els� feladat
            //Hozz l�tre K�DB�L gomb n�ven egy p�ld�nyt a Button oszt�lyb�l, �s add hozz� az �rlap vez�rl�inek list�j�hoz!
            /*
            Button gomb = new Button();
            
            // �ll�ts be m�retet a gombnak!
            int meret = 40;
            gomb.Height = meret;
            gomb.Width = meret;

            //�ll�tsd be a gomb Left �s Top tulajdons�g�t �gy, hogy pont k�z�pre ker�lj�n az ablakban!
            gomb.Left = ClientSize.Width/2- meret/2;
            gomb.Top = ClientSize.Height/2 -meret/2;
            Controls.Add(gomb);
            //Rakj ki 10 gombot egym�s mell� az �rlapra for ciklusb�l!
            //Eg�sz�tsd ki az el�z� feladatot �gy, hogy 10x10 gomb legyen kint!
            //Csin�lj szorz�t�bl�t; jelen�tsd meg a gombokon a sz�mokat.

            
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
                //Sz�rmaztass Villog�Gomb n�ven oszt�lyt a Button oszt�lyb�l!(A k�dot �rhatod a Form1 oszt�ly al�, de adhatsz �j oszt�lyt a projekthez.)

                //Hozz l�tre konstruktort a Villog�Gomb oszt�lyban!(ctor - tab - tab)

                //A konstruktorban rendelj esem�nykiszolg�l�t a MouseEnter �s a MouseLeave esem�nyekhez!(+= -tab - tab)

                //Az esem�nykiszolg�l�kban �ll�tsd be a gomb sz�n�t.

                //Cser�ld le a szorz�t�bla gombjait Villog�Gomb - ra!
            */
            #endregion

            #region V�letlens�gek
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
