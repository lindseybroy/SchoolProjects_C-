using System;


namespace Roy_U3_Guided2
{
    class GradeBookTest
    {
        public static void Main(string [] args)
        {
            //create GradeBook object myGradebook and 
            //pass course name to constructor
            GradeBook myGradeBook = new GradeBook("CS101 Introduction to C# Programming");

            myGradeBook.DisplayMessage();  //display welcome message
            myGradeBook.DetermineClassAverage();  //find average of grades
        }//end Main
    }//end class GradeBookTest   
            
}
