using System;


namespace Roy_U2_Graded1
{
   public class GradeBook
    {
        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to C# Programming!");
            Console.WriteLine("CourseNam: {0}, Instructor: {1}", CourseName, InstructorName);
        }
       public string CourseName { get; set; }
       public string InstructorName { get; set; }
      
       

        public GradeBook(string name)
        {
            CourseName = name;
        }
        public GradeBook(string course, string instructor)
        {
            CourseName = course;
            InstructorName = instructor;
          
        }
       
    }
}
