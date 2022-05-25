using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW2
{
    public static class MostF
    {
        public static void method(int[] seq)
        {
            int max = 0;
            int num = seq[0];
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach(int i in seq)
            {
                if (map.ContainsKey(i))
                {
                    map[i] += 1;
                }
                else
                {
                    map[i] = 1;
                }
                if (map[i] > max)
                {
                    max = map[i];
                    num = i;
                }
            }
            Console.WriteLine($"The number {num} is the most frequent. The occrence is {max}.");
        }
    }
}
