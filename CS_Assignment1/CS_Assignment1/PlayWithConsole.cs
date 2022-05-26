using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW1
{
    static public class PlayWithConsole
    {
        static public void CreateHackerName()
        {
            Console.WriteLine("Please input your favorite color.");
            string color = Console.ReadLine();
            Console.WriteLine("Please input your astrology");
            string astrology = Console.ReadLine();
            Console.WriteLine("Please input your address number");
            string addnum = Console.ReadLine();
            Console.WriteLine($"Your hacker name is {color+astrology+addnum}");
        }
        
    }

}
