using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW1
{
    static public class pp
    {
        static public void method()
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i ++)
            {
                for (int k = 1; k < n - i + 1; k++)
                {
                    Console.Write(" ");
                }
                
                for(int j = n - i + 1; j <= n + i - 1; j ++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
