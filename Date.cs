using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roy_U2_Graded2
{
    public class Date
    {
       public int Month { get; set; }
       public int Day { get; set; }
       public int Year { get; set; }
    
       public Date(int month, int day, int year)
        {
            Month = month;
            Day = day;
            Year = year;
        }
        public void DisplayDate()
        {
            Console.WriteLine("{00}, {1}, {2}", Month, Day, Year);
        }
    }
}