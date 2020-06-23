using System;


namespace Roy_U1_Graded2
{
   public class Compare
    {
       public static void Main(string[] args)
        {
            int number1;  //declare first number to compare
            int number2;  //declare second number to compare

            //prompt user and read first number
            Console.Write("Enter first integer: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            //prompt user and read second number
            Console.Write("Enter second integer:  ");
            number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 < number2)
                Console.WriteLine("The largest number is: {0}", number2);
            else if(number1 > number2)
                  Console.WriteLine("The largest number is: {0}", number1);
        }
    }
}
