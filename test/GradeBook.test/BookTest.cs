using System;
using Xunit;
namespace GradeBook.test
{
    public class BookTest
    {
        [Fact]
        public void TestGetStat()
        {
            var obj=new Book("shubham");

            obj.AddGrade(90.38);
            obj.AddGrade(23.88);
            obj.AddGrade(56.90);

            var result=obj.GetStat();

            Assert.Equal(23.88,result.LowGrade,1);
            Assert.Equal(90.38,result.HighGrade,1);
            Assert.Equal(57.0533d,result.AverageGrade,1);            
        }

        [Fact]
        public void TestGetName()
        {
            var obj=new Book("Shubham");
            string expected="Shubham";
            string result=obj.GetName();
            Assert.Equal(expected,result);
        } 
    }
}
