using assignment5._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5._1
{
    public class Subject
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public Exam? Exam { get; set; }

        public void CreateExam()
        {
            Console.WriteLine("Please Enter the Type of Exam you want to create (1 for practical and 2 for final)");
            int examNo = Convert.ToInt32(Console.ReadLine());
            Exam = examNo == 1 ? new PracticalExam() : new FinalExam();

            Console.WriteLine("Please Enter the Time of Exam in Minutes");
            int examTime;
            int.TryParse(Console.ReadLine(), out examTime);
            Exam.Minutes = examTime;

            Console.WriteLine("Please Enter the Number of Questions you want to create");
            int questionsNo;
            int.TryParse(Console.ReadLine(), out questionsNo);
            Exam.NumberOfQuestions = questionsNo;

            Exam.InitializeExam(questionsNo);

        }
    }
}