using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW3
{
    public static class Q1
    {
        public static int[] Reverse(int[] array)
        {
            int i = 0;
            int j = array.Length - 1; 
            while (i < j)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
            return array;
        }
    }
}
