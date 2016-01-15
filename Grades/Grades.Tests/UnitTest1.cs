using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void CalculateHighestGradeCorrectly()
        {
            GradeBook book = new GradeBook();
            
            book.AddGrade(90f);
            book.AddGrade(80f);
            
            GradeStatistics stats = book.ComputeStatistics();

            Assert.AreEqual(90f, stats.HighesetGrade);
        }
        [TestMethod]
        public void PassByValue()
        {
            GradeBook book = new GradeBook();
            book.Name = "Not set";
            SetName(book);

            Assert.AreEqual("Not Set", book.Name);
        }

        void SetName(GradeBook book)
        {
            book.Name = "Name  set";
        }
    }
}
