using System;
using System.Collections.Generic;
namespace GradeBook
{
   public class Book
    {
        public Book(string name)
        {
            this.name=name;
        }
        public string GetName()
        {
            return this.name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        public Statistics GetStat()
        {
            Statistics result=new Statistics();

            result.HighGrade=double.MinValue;
            result.LowGrade=double.MaxValue;

            foreach (var grade in grades)
            {               
                result.HighGrade=Math.Max(grade,result.HighGrade);
                result.LowGrade=Math.Min(grade,result.LowGrade);
                result.AverageGrade+=grade;
            }

            result.AverageGrade=result.AverageGrade/grades.Count;

            return result;
        }

        string name;
        List<double> grades=new List<double>();


    }
}