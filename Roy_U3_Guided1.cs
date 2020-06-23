using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roy_U3_Guided1
{
    public class GradeBookTest
    {
        public static void Main(string[] args)
        {
            GradeBook myGradeBook = new Roy_U3_Guided1.GradeBook("CS101 Instroduction to C# programming");

            myGradeBook.DisplayMessage();
            myGradeBook.DetermineClassAverage();
        }
    }
}
