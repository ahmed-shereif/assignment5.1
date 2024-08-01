using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5._1
{
    public class Answers
    {
        public int AnswerID { get; set; }
        public string? AnswerText { get; set; }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return $"AnswerID-{AnswerID} -AnswerText{AnswerText}";
        }
    }
}
