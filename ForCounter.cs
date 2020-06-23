using System;


namespace Roy_U3_Guided5
{
   public class ForCounter
    {
        static void Main(string[] args)
        {
            for (int counter = 1; counter <= 10; ++counter)
                Console.Write("{0}", counter);

            Console.WriteLine(); //output a newline
        }
    }
}
