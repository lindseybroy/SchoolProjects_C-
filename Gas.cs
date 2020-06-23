using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roy_U3_GradedGasMilage
{
    public class Gas
    {
        public static void Main(string[] args)
        {
            int miles;
            int gallons;
            int totalMiles = 0;
            int totalGallons = 0;

            double milesPerGallon;
            double totalMilesPerGallon;

            Console.WriteLine("Enter miles: ");
            miles = Convert.ToInt32(Console.ReadLine());

            while (miles != -1)
            {
                Console.WriteLine("Enter gallons: ");
                gallons = Convert.ToInt32(Console.ReadLine());

                totalMiles += miles;
                totalGallons += gallons;


                if (gallons != 0)
                {
                    milesPerGallon = (double)miles / gallons;
                    Console.WriteLine("MPG this tankful: {0:F}", milesPerGallon);
                }

                if (totalGallons != 0)
                {
                    totalMilesPerGallon = (double)totalMiles / totalGallons;
                    Console.WriteLine("Total MPG for trip is: {0:F}", totalMilesPerGallon);
                }

                Console.WriteLine("Enter miles (-1 to quit): ");
                miles = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}

