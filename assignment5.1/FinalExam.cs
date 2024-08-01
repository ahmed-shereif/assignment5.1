using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace assignment5._1
{
    public class FinalExam : Exam
    {
        public FinalExam()
        {
            Questions = new List<Question>();
        }

        public int TotalMark { get; private set; }

        public override void InitializeExam(int questionsNum)
        {
            for (int i = 0; i < questionsNum; i++)
            {
                Mcq mcqQuestion = new Mcq();
                mcqQuestion = (Mcq)mcqQuestion.CreateQuestion();
                Questions.Add(mcqQuestion);
            }
        }

        public override void showExam()
        {
            Console.WriteLine("==================");
            Console.WriteLine("|   FINAL EXAM   |");
            Console.WriteLine("==================");

            foreach (Question question in Questions)
            {
                Console.WriteLine(question.Header);
                Console.WriteLine(question.Body);
                int currentAns;
                bool isInt;
                Console.WriteLine("=================================");
                foreach (Answers answers in question.AnswersList)
                {
                    Console.WriteLine($"{answers.AnswerID} - {answers.AnswerText}");
                }
                do
                {
                    Console.WriteLine("please enter an answer between 1 and 4 ");
                    isInt = int.TryParse(Console.ReadLine(), out currentAns);
                    question.UseAnswer.AnswerID = currentAns;

                } while (isInt == false || currentAns > 4 || currentAns < 1);


                if (question.RightAnswer.AnswerID == question.UseAnswer.AnswerID)
                {
                    TotalMark += question.Mark;
                }
                else
                {
                }

            }
            Console.WriteLine($"your score is {TotalMark}");


        }



    }

}
