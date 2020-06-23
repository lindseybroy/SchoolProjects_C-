using System;


namespace Roy_U3_Guided2
{
    public class GradeBook
    {
        //auto-implemented property CourseName
        public string CourseName { get; set; }
        //constructor initializes the CourseName property
        public GradeBook(string name)
        {
            CourseName = name;  //set CourseName to name
        }//end constructor

        //display a welcome message to the GradeBook user
        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to the grade book for \n{0}!\n", CourseName);
        }//end method DisplayMessage

        //determine the average of the arbitrary number of grades
        public void DetermineClassAverage()
        {
            int total;  //sum of grades
            int gradeCounter;  //number of grades entered
            int grade;  //grade value
            double average;  //number with decimal point for average
        //initialization phase
        total=0; 
        gradeCounter =0; 
    
        //processing phase
        //prompt for and read a grade from the user
        Console.Write("Enter grade or -1 to quit: ");
        grade=Convert.ToInt32(Console.ReadLine());

        //loop until sentinel value is read from the user
        while(grade != -1)
        {
            total = total+grade;  //add grade to total
            gradeCounter = gradeCounter + 1;  //increment counter

            Console.Write("Enter grade or -1 to quit; "); 
            grade=Convert.ToInt32(Console.ReadLine());
        }

            if (gradeCounter != 0)
            {
                average = (double)total / gradeCounter;

                Console.WriteLine("\nTotal of the {0} grades entered is {1}", gradeCounter, total);
                Console.WriteLine("Class average is {0:F}", average);
            }

            else
                Console.WriteLine("No grades were entered");
           }
    }//end method DetrmineClassAverage

}

    

