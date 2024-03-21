namespace kigyok_kigyoznak
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;
        int irany_x = 1;
        int irany_y = 0;
        int lepesszam = 0;
        int hossz = 4;
        int meret = 20;
        List<KigyoElem> kigyo = new List<KigyoElem>();

        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tickel(object sender, EventArgs e)
        {
            lepesszam++;
            
            //Fejnövesztés
            fej_x += irany_x * KigyoElem.meret;
            fej_y += irany_y * KigyoElem.meret;

            foreach (object item in Controls)
            {
                if (item is KigyoElem)
                {
                    KigyoElem k = (KigyoElem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }

            KigyoElem ke = new KigyoElem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            kigyo.Add(ke);
            Controls.Add(ke);

            //Farokvágás
            if (kigyo.Count > hossz)
            {
                KigyoElem levagando = kigyo[0];
                kigyo.RemoveAt(0);
                Controls.Remove(levagando);
            }

            if (lepesszam == 5) { 
                int kepernyo_szeles = ClientRectangle.Width;
                int kepernyo_magas = ClientRectangle.Height;
                PictureBox alma = new PictureBox();
                alma.Height = meret;
                alma.Width = meret;
                alma.BackColor = Color.Red;
                alma.Top = rnd.Next(0, kepernyo_magas/10 - meret) *10;
                alma.Left = rnd.Next(0, kepernyo_szeles / 10 - meret) * 10;
                Controls.Add(alma);
            }


        }

        private void keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irany_y = -1;
                irany_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irany_y = 1;
                irany_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irany_y = 0;
                irany_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irany_y = 0;
                irany_x = 1;
            }
        }
    }
}