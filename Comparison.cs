using System;


namespace Roy_U1_GuidedPractice2
{
   public class Comparison
    {
        //Main method begins execution of C# app
        public static void Main(string[] args)
        {
            int number1;  //declare first number to compare
            int number2;  //declare second number to compare

            //prompt user and read frist number
            Console.Write("Enter first integer: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            //prompt user and read second number
            Console.Write("Enter second integer: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 == number2)
                Console.WriteLine("{0} == {1}", number1, number2);
            if (number1 != number2)
                Console.WriteLine("{0} !={1}", number1, number2);
            if (number1 < number2)
                Console.WriteLine("{0} < {1}", number1, number2);
            if (number1 > number2)
                Console.WriteLine("{0} > {1}", number1, number2);
            if (number1 <= number2)
                Console.WriteLine("{0} <= {1}", number1, number2);
            if (number1 >= number2)
                Console.WriteLine("{0} >= {1}", number1, number2);
        } //end MAin
    }//End Class Comparison
}
