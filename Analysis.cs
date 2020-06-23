using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roy_U3_Guided3
{
    class Analysis
    {
        static void Main(string[] args)
        {
            //initialize variables in declarations
            int passes = 0;
            int failures = 0;
            int studentCounter = 1;
            int result;

            //process 10 students using conter-controlled repetition
            while(studentCounter<=10)
            {
                Console.Write("Enter result(1= pass, 2 = fail): ");
                result = Convert.ToInt32(Console.ReadLine());

                if (result == 1)
                    passes = passes + 1;
                else
                    failures = failures + 1;


                studentCounter = studentCounter + 1;
            }//end while

            Console.WriteLine("Passed: {0}\nFailed{1}", passes, failures);

            if (passes > 8)
                Console.WriteLine("Bonus to instructor!");

        }//end Main
    }// end class Analysis
}
