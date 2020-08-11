using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book=new Book("C# fundamentals");
         
            book.AddGrade(90.38);
            book.AddGrade(23.88);
            book.AddGrade(56.90);
            
            var stats=book.GetStat();
            System.Console.WriteLine($"Book Name is {book.GetName()}");    
            System.Console.WriteLine($"The lowest grade is {stats.LowGrade:N2}");
            System.Console.WriteLine($"The highest grade is {stats.HighGrade:N2}");
            System.Console.WriteLine($"The average grade is {stats.AverageGrade:N2}");
        }
    }
}
