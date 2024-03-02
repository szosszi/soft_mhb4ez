namespace gyakorlas_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int sor = 0; sor < 11; sor++)
            {
                for (int oszlop = 0; oszlop < 11; oszlop++)
                {
                    Button gombi = new Button();
                    
                    gombi.Text = (sor*oszlop).ToString();
                    if (sor*oszlop % 2 == 0 )
                    {
                        gombi.BackColor = Color.Red;
                    }
                    gombi.Width = 40;
                    gombi.Height = 40;
                    gombi.Top = 40 * oszlop;
                    gombi.Left = 40 * sor;
                    Controls.Add(gombi);
                    
                }
            }
            
        }
    }
}
