using System;


namespace Roy_U2_Guided2
{
    public class GradeBookTest2
    {
        //Main method begins program execution
        public static void Main(string [] args)
        {
            //create a GradeBook object and assign it to myGradebook
            GradeBook2 myGradeBook = new GradeBook2();

            //prompt for an input course name
            Console.WriteLine("Please enter the course name: ");
            string nameOfCourse = Console.ReadLine(); //read a line a text
            Console.WriteLine(); //output a blank line

            //call myGradeBook's DisplayMessge method
            //and pass nameOfCourse as an argument
            myGradeBook.DisplayMessage(nameOfCourse);

        }//end Main
    }//end class GradeBookTest2
}
