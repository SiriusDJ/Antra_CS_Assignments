using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW1
{
    static public class Greetings
    {
        static public void grt(DateTime time)
        { 
            if(time.Hour < 12 && time.Hour >= 3)
            {
                Console.WriteLine("Good Morning");
            }
            if(time.Hour < 19 && time.Minute >= 12)
            {
                Console.WriteLine("Good Afternoon");
            }    
            if(time.Hour < 21 && time.Hour >= 19)
            {
                Console.WriteLine("Good Evening");
            }
            if(time.Hour < 3 || time.Hour >= 21)
            {
                Console.WriteLine("Good Night");
            }
        }
    }
}
