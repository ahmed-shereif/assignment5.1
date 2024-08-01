using assignment5._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5._1
{
    public class TrueOrFalse : Question
    {
        public override Question CreateQuestion()
        {
            Question question = new TrueOrFalse();
            Console.WriteLine("True | False Question");
            Console.WriteLine("Please Enter the Body of Question:");
            question.Body = Console.ReadLine();
            Console.WriteLine("Please Enter the Mark for the Question");
            int mark;
            int.TryParse(Console.ReadLine(), out mark);
            question.Mark = mark;
            Console.WriteLine("Please enter the right answer of the question (1 for True and 2 for False)");
            int rightAnswer;
            bool hasValue = int.TryParse(Console.ReadLine(), out rightAnswer);
            question.RightAnswer = new Answers();
            question.RightAnswer.AnswerID = rightAnswer;
            return question;
        }
    }
}
