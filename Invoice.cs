using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roy_Invoice_Midterm
{
   public class Invoice
    {
        public string PartNumber { get; set; } = "part number";
        private string PartDescription { get; set; } = "part description";

        class myInvoice
        {

            int quantity = 0;
            public int PartQuantity
            {
                get { return quantity; }
                set { quantity = value; }
            }
            double price = 0.0;

            public double PartPrice
            {
                get { return price; }
                set { price = value; }
            }
            double amount = 0.0;

            public double InvoiceAmount
            {
                get { return amount; }
                set { amount = value; }
            }

            public void GetInvoiceAmount()
            {

                quantity = Convert.ToInt32(Console.ReadLine());

                if (quantity != -1)
                {
                    //calculate invoice amount
                    amount = quantity * price;
                }
                else
                    Console.WriteLine("No quantity was entered");

            }

            public void DisplayMessage()
            {
                Console.WriteLine("\nThe number of items is: {0}", quantity);
                Console.WriteLine("\nThe Invoice Amount is: {0}", InvoiceAmount);
            }
        }
    }
}
