namespace eletjatek_proba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool[,] p�lya;
        private bool[,] �jP�lya;
        int n = 20;
        int m = 20;
        private void Form1_Load(object sender, EventArgs e)
        {
            p�lya = new bool[n, m];
            �jP�lya = new bool[n, m];
            dataGridViewP�lya.ColumnCount = m;
            dataGridViewP�lya.RowCount = n;
            dataGridViewP�lya.RowHeadersWidth = 60;
            dataGridViewP�lya.RowTemplate.Height = (ClientRectangle.Height - dataGridViewP�lya.RowHeadersWidth * 8) / n;
            dataGridViewP�lya.Dock = DockStyle.Fill;
            for (int i = 0; i < m; i++)
            {
                dataGridViewP�lya.Columns[i].Width = (dataGridViewP�lya.Width - dataGridViewP�lya.RowHeadersWidth * 2) / m;

            }
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    p�lya[i, j] = rand.Next(2) == 1;
                    dataGridViewP�lya.Rows[i].Cells[j].Value = p�lya[i, j] ? "1" : "0";
                    if (dataGridViewP�lya.Rows[i].Cells[j].Value == "1")
                    {
                        dataGridViewP�lya.Rows[i].Cells[j].Style.BackColor = Color.Black;
                        dataGridViewP�lya.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                    }
                    if (dataGridViewP�lya.Rows[i].Cells[j].Value == "0")
                    {
                        dataGridViewP�lya.Rows[i].Cells[j].Style.BackColor = Color.White;
                        dataGridViewP�lya.Rows[i].Cells[j].Style.ForeColor = Color.White;
                    }
                }
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int eloszomszedszam = Eloszomszedok(i, j);
                    if (p�lya[i, j])
                    {
                        �jP�lya[i, j] = eloszomszedszam == 2 || eloszomszedszam == 3;
                    }
                    else
                    {
                        �jP�lya[i, j] = eloszomszedszam == 3;
                    }
                }
            }
            

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    p�lya[i, j] = �jP�lya[i, j];
                    dataGridViewP�lya.Rows[i].Cells[j].Value = p�lya[i, j] ? "1" : "0";

                }
            }
        }
        private int Eloszomszedok(int x, int y)
        {
            int count = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0) continue;
                    count += mezoErteke(x + i, y + j, p�lya);
                }
            }
            return count;
        }
        private int mezoErteke(int sor, int oszlop, bool[,] p)
        {
            if (sor > p.GetUpperBound(0)) return 0;
            if (oszlop > p.GetUpperBound(1)) return 0;
            if (sor < 0 || oszlop < 0) return 0;
            return (p[sor, oszlop] ? 1 : 0);
        }
    }
}
