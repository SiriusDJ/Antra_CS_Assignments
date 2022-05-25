using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW2
{
    public static class Rotation
    {
        public static void Method(int[] array, int r)
        {
            int n = array.Length;
            int k = r % n;
            int g = r / n;
            int sum = array.Sum();
            int[] res = new int[array.Length];
            for (int i = 0; i < n; i++)
            {
                int sumk = 0;
                for (int j = 1; j < k + 1; j++)
                {
                    if (i - j < 0)
                    {
                        sumk += array[n + i - j];
                    }
                    else
                    {
                        sumk += array[i - j];
                    }
                }
                res[i] = sum * g + sumk;
            }
            foreach(int i in res)
            {
                Console.WriteLine(i);
            }
            
        }
         
    }
}
