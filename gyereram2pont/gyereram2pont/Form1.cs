namespace gyereram2pont
{
    public partial class Form1 : Form
    {
        private bool[,] palya;
        private bool[,] ujpalya;

        int sor = 20;
        int oszlop = 40;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            palya = new bool[sor, oszlop];
            ujpalya = new bool[sor, oszlop];
            dataGridView1.ColumnCount = oszlop;
            dataGridView1.RowCount = sor;
            dataGridView1.RowTemplate.Height = dataGridView1.Height / (sor+2);
            for (int i = 0; i < oszlop; i++)
            {
                dataGridView1.Columns[i].Width = dataGridView1.Width / (oszlop+2);
            }
        }
    }
}
