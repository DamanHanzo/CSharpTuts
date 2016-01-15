using System;
using System.Collections.Generic;
/*using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace Grades
{
    class GradeBook
    {
        public void AddGrade(float grade) //method
        {
            grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            float sum = 0f;
            foreach (float grade in grades)
            {
                stats.HighesetGrade = Math.Max(grade, stats.HighesetGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);                
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count; //.Count for numbers of things in the list
            return stats;
        }

        List<float> grades = new List<float>(); //field
    }
}
