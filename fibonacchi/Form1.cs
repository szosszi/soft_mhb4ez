namespace fibonacchi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Sor> sorok = new List<Sor>();
            for (int i = 0; i < 10; i++)
            {
                Sor ujsor = new Sor();
                ujsor.Ertek = Fibonacchi(i);
                ujsor.Sorszam = i;

                sorok.Add(ujsor);
            }
            dataGridView1.DataSource = sorok;
        }
        int Fibonacchi(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacchi(n - 1) + Fibonacchi(n - 2);
        }
    }
}
