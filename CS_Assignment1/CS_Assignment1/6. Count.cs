using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW1
{
    static public class Count
    {
        static public void Cnt()
        {
            for(int i = 1; i < 5; i++)
            {
                int k = 0;
                while (true)
                {
                    Console.Write(k);
                    if (k == 24)
                    {
                        break;
                    }
                    Console.Write(",");
                    k += i;
                }
                Console.WriteLine();
            }
        }
    }
}
