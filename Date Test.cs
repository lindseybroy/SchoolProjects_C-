using System;


namespace Roy_U2_Graded2
{
   public class DateTest
    {
       public static void Main(string[] args)
        {
            Date date1 = new Date(7,4,2014);

            Console.Write("The initial date is: ");
            date1.DisplayDate();

            //change date values
            date1.Month=11;
            date1.Day = 1;
            date1.Year = 2003;

            Console.Write("\nDate with new value is: " );
            date1.DisplayDate();

            Console.WriteLine();  //output a new line
        }//end Main
    }//end class Date Test
}
