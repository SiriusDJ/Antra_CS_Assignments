using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW2
{
    static public class Prime
    {
        static public int[] FindPrime(int startNum, int endNum)
        {
            List<int> list = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {   
                if (isPrime(i))
                {
                    list.Add(i);
                }
               
             }
            return list.ToArray();

        }

        private static bool isPrime(int i)
        {
            if (i <= 1)
            {
                return false;
            }
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    return false;
                }
            }
            return true;
            
        }
    }

}
