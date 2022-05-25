using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW2
{
    static public class copy
    {
        static public void cpy(object[] array)
        {
            object[] cp_array = new object[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                cp_array[i] = array[i];
            }   
            for (int i = 0; i < cp_array.Length; i++)
            {
                Console.WriteLine(cp_array[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
                    
                    
        }
    }
}
