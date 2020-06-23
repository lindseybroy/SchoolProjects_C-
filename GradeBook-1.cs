using System;


namespace Roy_U2_Guided3
{
   public class GradeBook
    {
        private string courseName; //course name for this GradeBook
        
        //property to get and set the course name
        public string CourseName
        {
            get
            {
                return courseName;
            }
            set
            {
                courseName = value;
            }
        }//end property CourseName

        //display a welcome message to teh GradeBook user
        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to the grade book for\n{0}!", CourseName);
        }
        }
    }

