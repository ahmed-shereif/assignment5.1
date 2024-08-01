

using System.Security;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;

namespace assignment5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            subject.CreateExam();
            Console.Clear();

            Console.WriteLine("Start Exam? (y | n): ");
            if (char.Parse(Console.ReadLine()) == 'y')
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                subject.Exam.showExam();
                Console.WriteLine($"Elapsed Time: {stopwatch.Elapsed}");
            }

        }
    }




}