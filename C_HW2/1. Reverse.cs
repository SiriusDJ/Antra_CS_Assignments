using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW2
{
    public static class Rev
    {
        public static void method()
        {
            string str = Console.ReadLine();
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            foreach (char c in chars)
            {
                Console.Write(c);
            }
        }
    }
}
