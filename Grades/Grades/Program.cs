using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91f);
            book.AddGrade(89.5f);
            book.AddGrade(95f);
            book.AddGrade(23.3f);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("Average Grade:" + stats.AverageGrade);
            Console.WriteLine("Lowest Grade:" + stats.LowestGrade);
            Console.WriteLine("Highest Grade:" + stats.HighesetGrade);

            GradeBook book2 = new GradeBook(); //cretes a new object with reassignment
            book2.AddGrade(75);
        }
    }
}
