using System;


namespace Roy_U1_Practice1
{
    class Addition
    {
        //Main method begins execution of C# app
        static void Main(string[] args)
        {
            int number1; //declare first number to add
            int number2; //declare second number to add
            int sum;  //declare sum of number1 and number2

            Console.Write("Enter frist integer: "); //prompt user
            //read frist number from user
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer: "); //prompt user

            //read second number from user
            number2 = Convert.ToInt32(Console.ReadLine());

            sum = number1 + number2;  //add numbers

            Console.WriteLine("Sume is {0}", sum); //display sum
        }  //end Main
    }//end Class Addition
}
