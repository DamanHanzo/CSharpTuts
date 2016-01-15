using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeStatistics
    {
        public GradeStatistics()
        {
            HighesetGrade = 0;
            AverageGrade = 0;
            LowestGrade = float.MaxValue; //maxvalue gives us highest possible value that can be stored in a float
        }
        public float HighesetGrade;
        public float AverageGrade;
        public float LowestGrade;
    }
}
