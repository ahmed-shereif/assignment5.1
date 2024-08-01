using assignment5._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace assignment5._1
{
    public class Exam
    {
        public List<Question>? Questions { get; set; }
        public int Minutes { get; set; }
        public int NumberOfQuestions { get; set; }

        public virtual void InitializeExam(int questionsNum)
        {
        }

        public virtual void showExam()
        {

          
        }

    }
}
