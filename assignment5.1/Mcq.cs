using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace assignment5._1
{
    public class Mcq : Question
    {
        public Mcq()
        {
        }

        public override Question CreateQuestion()
        {
            Question question = new Mcq();
            Console.WriteLine("Choose One Answer Question");
            Console.WriteLine("Please Enter the Header of Question:");
            question.Header = Console.ReadLine();

            bool RightMark;


            do
            {
                Console.WriteLine("Please Enter the Mark for the Question");
                int mark;
                RightMark = int.TryParse(Console.ReadLine(), out mark);
                question.Mark = mark;

            } while (RightMark == false);


            do
            {
                Console.WriteLine("Please Enter the Body of the Question:");
                question.Body = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(question.Body))
                {
                    Console.WriteLine(" Please enter a valid Question");
                }
            } while (string.IsNullOrWhiteSpace(question.Body));


            Console.WriteLine("The Choices of Question");
            for (int i = 0; i < 4; i++)
            {
                string? choice;
                do
                {
                    Console.WriteLine($"Please enter the choice number {i + 1}");
                    choice = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(choice))
                    {
                        Console.WriteLine("Choice cannot be empty. Please enter a valid choice.");
                    }
                    else
                    {
                        question.AnswersList.Add(new Answers
                        {
                            AnswerID = i + 1,
                            AnswerText = choice
                        });

                    }
                } while (string.IsNullOrWhiteSpace(choice));


            }

            bool HasRightAnswer;
            int rightAnswer;
            do
            {
                Console.WriteLine("Please Specify The Right Choice of Question:");

                HasRightAnswer = int.TryParse(Console.ReadLine(), out rightAnswer);
                question.RightAnswer = new Answers();
                question.RightAnswer.AnswerID = rightAnswer;
            } while (HasRightAnswer == false || rightAnswer > 4);
      
            return question;
        }
    }
}
