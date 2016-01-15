using System;
using System.Collections.Generic;
/*using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace Grades
{
    public class GradeBook
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

        public GradeBook(string name = "There is no name")
        {
            _name = name; //initializing the memeber variable name
            grades = new List<float>(); 
        }

        private string _name;
        
        public string Name
        {
            get
            {
                return _name.ToUpper();
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }
        
        List<float> grades = new List<float>(); //field
    }
}
