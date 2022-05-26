using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW1
{
    static public class GuessNumber
    {
        static public int correctNumber = new Random().Next(3) + 1;

        static public void checkNumber()
        {

            while (true) 
            {
                Console.WriteLine("Please take a guess");
                int a = int.Parse(Console.ReadLine());

                if (a < 1 || a > 3)
                {
                    Console.WriteLine("Out of range. Range is 1-3");
                }
                else if (a == correctNumber)
                {
                    Console.WriteLine("Correct");
                    break;
                }
                else if (a < correctNumber)
                {
                    Console.WriteLine("Too small");
                }
                else
                {
                    Console.WriteLine("Too big");
                }
            }
        }

    }
}
