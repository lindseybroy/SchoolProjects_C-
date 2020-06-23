using System;


namespace Roy_U1_Graded1
{
   public class Calculations
    {
       public static void Main(string[] args)
        {
            int number1;  //first number to calculate
            int number2;  //second number to calculate
            int sum;  //answer to display
            int diff; //answer to display
            int quot; //answer to display
            int prod; //answer to display

            //prompt user and read first number
            Console.Write("Enter first integer: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            //prompt user and read second number
            Console.Write("Enter second integer: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            sum = number1 + number2;
              Console.WriteLine("The sum is: {0}", sum); //display sum

            quot = number1 / number2;
            Console.WriteLine("The quotient is: {0}", quot); //display quot

            prod = number1 * number2;
            Console.WriteLine("The product is: {0}", prod); //display prod

            diff = number1 - number2;
            Console.WriteLine("The difference is: {0}", diff); //display diff

        }//end Main
    } //End Calculations
}
