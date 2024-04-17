namespace _6_gyak
{
    public partial class Form1 : Form
    {
        List<question> AllQuestion;
        List<question> ActiveQuestions;
        int ActiveQ = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<question> QuestionRead()
            {
                List<question> questions = new List<question>();
                StreamReader sr = new StreamReader("hajok.csv", true);

                while (!sr.EndOfStream) { 

                    string line = sr.ReadLine() ?? string.Empty;
                    string[] data = line.Split("\t");
                    if (data.Length != 7)
                    {
                        continue;
                    }
                    question q = new question();
                    q.QuestionText = data[1];
                    q.Answer1 = data[2];
                    q.Answer2 = data[3];
                    q.Answer3 = data[4];
                    q.URL = data[5];

                    int.TryParse(data[6], out int goodanswer);
                    q.CorrectAnswer = goodanswer;

                    questions.Add(q);
                }
                sr.Close();
                return questions;
            }


            ActiveQuestions = new List<question>();
            AllQuestion = QuestionRead();
            for (int i = 0; i < 7; i++)
            {
                ActiveQuestions.Add(AllQuestion[0]);
                AllQuestion.RemoveAt(0);
            }
            dataGridView1.DataSource = ActiveQuestions;
        }
    }
}
