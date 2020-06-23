using System;


namespace Roy_U3_Guided4
{
    class Increment
    {
        static void Main(string[] args)
        {
            int c;

            c = 5;
            Console.WriteLine(c);
            Console.WriteLine(c++);
            Console.WriteLine(c);

            Console.WriteLine();

            c = 5;
            Console.WriteLine(c);
            Console.WriteLine(++c);
            Console.WriteLine(c);

            Console.WriteLine("Passed: {0}\nFailed: {1}", passes, failures);

            if (passes > 8)
                Console.WriteLine("Bonus to instructor!");
        }
    }

}
