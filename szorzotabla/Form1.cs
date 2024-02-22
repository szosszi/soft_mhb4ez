namespace szorzotabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int sor = 1; sor < 10; sor++)
            {
                for (int oszlop = 1; oszlop < 10; oszlop++)
                {
                    Button button = new();
                    button.Text = (sor*oszlop).ToString();
                    button.Top = sor * 40;
                    button.Left = oszlop * 40;
                    button.Height = 40;
                    button.Width = 40;
                    Controls.Add(button);
                }
            }
        }
    }
}
