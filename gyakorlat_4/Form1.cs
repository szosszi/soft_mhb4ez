namespace gyakorlat_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int Faktorialis(int n) {
                if (n == 0)  return 1; 
                return n * Faktorialis(n - 1);
            }
            for (int sor = 0; sor < 10; sor++) {
                for (int oszlop = 0; oszlop <= 10; oszlop++)
                {
                    Button button = new Button();
                    
                    button.Height = 40;
                    button.Width = 40;
                    button.Left = sor * 40;
                    button.Top = oszlop * 40;
                    int felirat = Faktorialis(sor) / (Faktorialis(oszlop) * (Faktorialis(sor - oszlop)));
                    button.Text = felirat.ToString();
                    Controls.Add(button);
                }
            }
        }
    }
}
