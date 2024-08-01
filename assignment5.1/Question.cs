using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5._1
{
    public class Question
    {
        public Question()
        {
            UseAnswer = new Answers();
            AnswersList = new List<Answers>();

        }
        public string? Header { get; set; }

        public string? Body { get; set; }

        public int Mark { get; set; }

        public List<Answers>? AnswersList { get; set; }

        public Answers? RightAnswer { get; set; }
        public Answers? UseAnswer { get; set; }

        public List<Question>? Questions { get; set; }

        public virtual Question CreateQuestion() { return new Question(); }

        public override string? ToString()
        {
            return $"Header-{Header}" +
                $"Body-{Body}" +
                $"AnswerList-{AnswersList.ToString()}" +
                $"RightAnswer-{RightAnswer}" +
                $"UseAnswer-{UseAnswer}";
        }
    }
}

