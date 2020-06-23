using System;


namespace Roy_U2_GuidedPractice4
{
   public class GradeBookTest
    {
        public static void Main(string[] args)
        {

            GradeBook gradeBook1 = new GradeBook("CS101 Introduction to C# Programming");
            GradeBook gradeBook2 = new GradeBook("CS102 Data Structures in C#");

            Console.WriteLine("gradeBook1 course name is: {0}", gradeBook1.CourseName);
            Console.WriteLine("gradeBook2 course name is: {0}", gradeBook2.CourseName);
        }
    }
}
