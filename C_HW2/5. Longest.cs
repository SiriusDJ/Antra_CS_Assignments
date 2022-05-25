using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW2
{
    public static class longest
    {
        public static void findlong(int[] array)
        {
            int i = 0;
            int j = 0;
            int cnt = 0;
            int max = 0;
            int a = 0;
            int b = 0;
            while (j < array.Length)
            {
                cnt = 0;
                while ( j < array.Length && array[j] == array[i])
                {
                    j++;
                    cnt++;
                }
                if (cnt > max)
                {
                    max = cnt;
                    a = i;
                    b = j;
                }
                i = j;
            }
            for (int h = a; a < b; a ++ )
            {
                Console.WriteLine(array[h]);
            }

        }
    }
}
