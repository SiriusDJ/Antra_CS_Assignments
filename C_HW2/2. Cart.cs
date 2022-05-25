using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW2
{
    static public class Cart
    {
        static List<string> list = new List<string>();

        static public void todo()
        {
            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
                string operation = Console.ReadLine();
                if (operation == "--")
                {
                    list.Clear();
                }
                else if (operation[0] == '-')
                {
                    list.Remove(operation.Substring(2, operation.Length - 2));
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(list[i]);
                    }
                }
                else if (operation[0] == '+')
                {
  
                    list.Add(operation.Substring(2, operation.Length - 2));
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(list[i]);
                    }
                }
                else
                {
                    Console.WriteLine("input error");
                    continue;
                }


            }
        }

    }
}
