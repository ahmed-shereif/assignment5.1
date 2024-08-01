using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace assignment5._1
{
    public class PracticalExam : Exam
    {
        public int TotalMark { get; set; }
        public PracticalExam()
        {
            Questions = new List<Question>();
            TotalMark = 0;
        }
        public override void InitializeExam(int questionsNum)
        {

            for (int i = 0; i < questionsNum; i++)
            {
                Console.WriteLine($"Please choose The Type Of Question Number{i + 1} (1 for True or False || 2 for MCQ)");
                int questionType;
                int.TryParse(Console.ReadLine(), out questionType);
                if (questionType == 1)
                {
                    TrueOrFalse trueOrFalseQuestion = new TrueOrFalse();
                    trueOrFalseQuestion = (TrueOrFalse)trueOrFalseQuestion.CreateQuestion();
                    Questions.Add(trueOrFalseQuestion);
          
                    Console.WriteLine(Questions);
                }
                else if (questionType == 2)
                {
                    Mcq mcqQuestion = new Mcq();
                    mcqQuestion =(Mcq) mcqQuestion.CreateQuestion();
                    Questions.Add(mcqQuestion);
                }

            }
        }
        public override void showExam()
        {
            Console.WriteLine("==================");
            Console.WriteLine("| Practical EXAM |");
            Console.WriteLine("==================");
            foreach (Question question in Questions)
            {
                Console.WriteLine(question.Header);
                Console.WriteLine(question.Body);
                if (question is TrueOrFalse)
                {
                    int currentAns;
                    bool isInt;

                    do
                    {
                        Console.WriteLine("1- True         2-False");
                        isInt = int.TryParse(Console.ReadLine(), out currentAns);
                        question.UseAnswer.AnswerID = currentAns;

                    } while (isInt == false || currentAns > 2 || currentAns < 1);

                    Console.WriteLine("=================================");


                }
                else
                {
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
        
                }

                if (question.RightAnswer.AnswerID == question.UseAnswer.AnswerID)
                {
                    Console.WriteLine("Your Answer Is Right");
                    TotalMark += question.Mark;
                }
                else
                {
                    Console.WriteLine("wrogn answer");
                }

                Console.WriteLine($"your score is {TotalMark}");
            }
        }

    }
}
