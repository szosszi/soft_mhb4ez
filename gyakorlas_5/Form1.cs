using System.CodeDom;
using System.DirectoryServices;

namespace gyakorlas_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int meret = 40;
            bool feher = true;
            for (int sor = 0; sor < 8; sor++)
            {
                if (feher) { feher = false; }
                else { feher = true; }

                for (int oszlop = 0; oszlop < 8; oszlop++) {
                    Button gombocska = new Button();
                    gombocska.Height = meret;
                    gombocska.Width = meret;
                    gombocska.Left = meret * sor;
                    gombocska.Top = meret * oszlop;
                    if (feher)
                    {
                        gombocska.BackColor = Color.White;
                        feher = false;
                    }
                    else {
                        gombocska.BackColor = Color.Black;
                        feher = true;
                    }
                    Controls.Add(gombocska);
                    
                }
            }
        }
    }
}
