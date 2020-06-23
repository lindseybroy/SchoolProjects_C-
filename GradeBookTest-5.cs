using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roy_U3_Guided7
{
   public class GradeBookTest
    {
        public static void Main(string[] args)
        {
            GradeBook myGradeBook = new GradeBook("CS101 Introduction to C# Programming");

            myGradeBook.DisplayMessage();
            myGradeBook.InputGrades();
            myGradeBook.DisplayGradeReport();
        }
    }
}
