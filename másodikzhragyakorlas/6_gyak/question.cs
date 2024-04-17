using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_gyak
{
    internal class question
    {
        public string QuestionText { get; set; } = string.Empty;
        public string Answer1 { get; set; } = string.Empty;
        public string Answer2 { get; set; } = string.Empty;
        public string Answer3 { get; set; } = string.Empty;
        public string URL { get; set; } = string.Empty;
        public int CorrectAnswer { get; set; }
        public int CorrecctAnswerNumber { get; set; }
    }
}
