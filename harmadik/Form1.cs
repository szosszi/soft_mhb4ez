namespace harmadik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button b = new Button();
            Controls.Add(b);
            b.Height = 10;
            b.Width = 10;
            b.Left = ClientRectangle.Width / 2 - b.Width / 2;
            b.Top = ClientRectangle.Height / 2 -b.Height / 2;


            Random random = new Random();

            int meret = 40;
            for (int oszlop = 0; oszlop < 20; oszlop++) {

                for (int sor = 0; sor < 20; sor++)
                {
                    szamoloGomb p = new szamoloGomb();
                    p.BackColor = Color.White;
                    
                    Controls.Add(p);
                    p.Height = meret;
                    p.Width = meret;
                    p.Left = meret * oszlop;
                    p.Top = meret * sor;
                    p.BackColor = Color.FromArgb(random.Next(0, 255), 0, 0);

                }

            }
        }
    }
}