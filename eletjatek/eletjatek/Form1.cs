using System.Windows.Forms;

namespace eletjatek
{
    public partial class Form1 : Form
    {
        private bool[,] pálya;
        private bool[,] újPálya;
        int n = 20; // Példa sorok száma
        int m = 40; // Példa oszlopok száma

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            pálya = new bool[n, m];
            újPálya = new bool[n, m];
            //grid letrehozása
            dataGridViewPálya.ColumnCount = m;
            dataGridViewPálya.RowCount = n;
            dataGridViewPálya.RowHeadersWidth = 60;
            dataGridViewPálya.RowTemplate.Height = dataGridViewPálya.Height / n;
            dataGridViewPálya.Dock = DockStyle.Fill;


            for (int i = 0; i < m; i++)
            {
                dataGridViewPálya.Columns[i].Width = (dataGridViewPálya.Width - dataGridViewPálya.RowHeadersWidth * 2) / m;

            }
            //pálya generálás

            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    pálya[i, j] = rand.Next(2) == 1;
                    dataGridViewPálya.Rows[i].Cells[j].Value = pálya[i, j] ? "1" : "0";
                    if (dataGridViewPálya.Rows[i].Cells[j].Value == "1")
                    {
                        dataGridViewPálya.Rows[i].Cells[j].Style.BackColor = Color.Black;
                        dataGridViewPálya.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                    }
                    if (dataGridViewPálya.Rows[i].Cells[j].Value == "0")
                    {
                        dataGridViewPálya.Rows[i].Cells[j].Style.BackColor = Color.White;
                        dataGridViewPálya.Rows[i].Cells[j].Style.ForeColor = Color.White;
                    }
                }
            }
            timer1.Tick += new EventHandler(Ujrarendezes);
        }
        
        

        private void Ujrarendezes(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int eloszomszedszam = Eloszomszedok(i, j);
                    if (pálya[i, j])
                    {
                        újPálya[i, j] = eloszomszedszam == 2 || eloszomszedszam == 3;
                    }
                    else
                    {
                        újPálya[i, j] = eloszomszedszam == 3;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    pálya[i, j] = újPálya[i, j];
                    dataGridViewPálya.Rows[i].Cells[j].Value = pálya[i, j] ? "1" : "0";
                    if (dataGridViewPálya.Rows[i].Cells[j].Value == "1")
                    {
                        dataGridViewPálya.Rows[i].Cells[j].Style.BackColor = Color.Black;
                        dataGridViewPálya.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                    }
                    if (dataGridViewPálya.Rows[i].Cells[j].Value == "0")
                    {
                        dataGridViewPálya.Rows[i].Cells[j].Style.BackColor = Color.White;
                        dataGridViewPálya.Rows[i].Cells[j].Style.ForeColor = Color.White;
                    }
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
                    count += mezoErteke(x + i, y + j, pálya);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int liveNeighbors = Eloszomszedok(i, j);
                    if (pálya[i, j])
                    {
                        újPálya[i, j] = liveNeighbors == 2 || liveNeighbors == 3;
                    }
                    else
                    {
                        újPálya[i, j] = liveNeighbors == 3;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    pálya[i, j] = újPálya[i, j];
                    dataGridViewPálya.Rows[i].Cells[j].Value = pálya[i, j] ? "1" : "0";
                    
                }
            }
        }
    }
}
    