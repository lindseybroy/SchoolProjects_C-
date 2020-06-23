using System;


namespace Roy_U2_Guided3
{
   public class GradeBookTest
    {
        //Main method begins program execution
        public static void Main(string [] args)
        {
            //create a GradeBook object and assign it to myGradeBook
            GradeBook myGradeBook = new GradeBook();

            //display initial value of CourseName
            Console.WriteLine("Initial course name is: '{0}'\n", myGradeBook.CourseName);

            //prompt for and read course name
            Console.WriteLine("Please enter the course name: ");
            myGradeBook.CourseName = Console.ReadLine();
            Console.WriteLine();

            //display welcome message after specifying course name
            myGradeBook.DisplayMessage();
        }
    }
}
