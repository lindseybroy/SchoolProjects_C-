using System;


namespace Roy_U3_Guided6
{
    public class Interest
    {
        static void Main(string[] args)
        {
            decimal amount;
            decimal principal = 1000;
            double rate = 0.05;

            Console.WriteLine("Year{0, 20}", "Amount on deposit");

            for(int year=1; year<=10; ++year)
            {
                amount = principal
                    ((decimal)Math.Pow(1.0 + rate, year));

                Console.WriteLine("{0,4}{1,20:C}", year, amount);
            }
        }
    }
}
