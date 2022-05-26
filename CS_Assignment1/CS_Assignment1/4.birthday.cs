using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW1
{
    static public class Birthday
    {

        static public void calculate(DateTime date)
        {
            TimeSpan ts = DateTime.Today.Subtract(date);
            Console.WriteLine(ts.Days);
            DateTime anniv = date.AddDays(10000);
            Console.WriteLine("The 10000 days anniversary is {0}",anniv);
        }

    }

}
