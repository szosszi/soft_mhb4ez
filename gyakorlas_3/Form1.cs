using System.CodeDom;

namespace gyakorlas_3
{
    public partial class Form1 : Form
    {
        DataGridView ujgrid;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int Fibonacci(int n)
            {
                if (n == 0)
                {
                    return 0;
                }
                if (n == 1)
                {
                    return 1;
                }
                return (Fibonacci(n - 1) + Fibonacci(n - 2));
            }
            for (int i = 0; i < 10; i++)
            {
                int meret = 40;
                Button gombika = new Button();
                gombika.Text = (Fibonacci(i)).ToString();
                gombika.Top = i * meret;
                gombika.Height = meret;
                gombika.Width = meret;
                Controls.Add(gombika);
            }
            /*gridbetenni*/
            ujgrid = new DataGridView();
            ujgrid.Height = 400;
            ujgrid.Width = 400;
            ujgrid.Left = 60;
            Controls.Add(ujgrid);
            List<tablazat> gridbe = new List<tablazat>();
            for (int i = 0; i < 11; i++)
            {
                tablazat hozzaadom = new tablazat();
                int aktSzam = Fibonacci(i);
                hozzaadom.FibonacciSzamok = aktSzam;
                hozzaadom.Sorszam = i;
                gridbe.Add(hozzaadom);
            }
            ujgrid.DataSource = gridbe;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (ujgrid != null)
            {
                ujgrid.Height = Form1.ActiveForm.Height-100;
                ujgrid.Width = Form1.ActiveForm.Width-100;
            }

        }
    }
}
