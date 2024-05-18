namespace huhaezmargazos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();   
            UserControl1 userc = new UserControl1();
            panel1.Controls.Add(userc);
            userc.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl2 userc = new UserControl2();
            panel1.Controls.Add(userc);
            userc.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl3 userc = new UserControl3();
            panel1.Controls.Add(userc);
            userc.Dock = DockStyle.Fill;
        }
    }
}
