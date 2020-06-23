using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roy_U3_GradedCalculatingSales
{
   public class Sales
    {
        static void Main(string[] args)
        {
            decimal product1 = 0M;
            decimal product2 = 0M;
            decimal product3 = 0M;

            int productId = 1;

            while(productId !=0)
            {
                Console.Write("Enter product number (1-3) (0 to stop): ");
                productId = Convert.ToInt32(Console.ReadLine());

                if (productId >= 1 && productId <= 3)
                {
                    Console.Write("Enter quantity sold: ");
                    int quantity = Convert.ToInt32(Console.ReadLine());

                    switch ( productId)
                    {
                         case 1:
                            product1 = quantity * 2.98M;
                            break;

                        case 2:
                            product2 = quantity * 4.50M;
                            break;

                        case 3:
                            product3 = quantity * 9.98M;
                            break;
                             
                    }
                }

                else if (productId != 0)
                    Console.WriteLine("Product number must be between 1 and 3 or 0 to stop");
            }

            Console.WriteLine("\nProduct 1: {0:C}", product1);
            Console.WriteLine("\nProduct 2: {0:C}", product2);
            Console.WriteLine("Product 3: {0:C}", product3);
        }
    }
}
