using System;


namespace Roy_U2_Graded1
{
    public class GradeBookTest
    {
        public static void Main(string [] args)
        {
            GradeBook gradeBook1 = new GradeBook("CS101 Introduction to C# Programming", "Sam Smith");
            Console.WriteLine("{0}", gradeBook1.CourseName);

            gradeBook1.DisplayMessage();  //display welcome message


            Console.WriteLine("Changing Instructor name of Judy Jones");
            gradeBook1.InstructorName = "Judy Jones";

            gradeBook1.DisplayMessage();  //display welcome message
            
        }
    }
}
