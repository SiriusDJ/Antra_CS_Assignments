using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW3
{
    public static class Fibonacci
    {
        public static int GetFibonacci(int index)
        {
            if (index == 0)
            {
                return 1;
            }
            else if (index == 1)
            {
                return 1;
            }
            return GetFibonacci(index - 1) + GetFibonacci(index - 2);
        }
    }
}
