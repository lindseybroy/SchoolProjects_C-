using System;


namespace Roy_U2_GuidedPractice4
{
   public class GradeBook
    {
        public string CourseName { get; set; }

        public GradeBook(string name)
        {
            CourseName = name; //set CourseName to name
        }//end constructor

        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to the grade book for\n {0}!", CourseName);
        }//end method DisplayMessage
    }//end class GradeBook
}
