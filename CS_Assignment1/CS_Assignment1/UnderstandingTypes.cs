using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW1
{
    static public class UnderstandingTypes
    {
        static public void bytesusage() 
        {
            Console.WriteLine("sizeof(sbyte):{0}", sizeof(sbyte));
            Console.WriteLine("sizeof(short):{0}", sizeof(byte));
            Console.WriteLine("sizeof(ushort):{0}", sizeof(ushort));
            Console.WriteLine("sizeof(int):{0}", sizeof(int));
            Console.WriteLine("sizeof(uint):{0}", sizeof(uint));
            Console.WriteLine("sizeof(long):{0}", sizeof(long));
            Console.WriteLine("sizeof(ulong):{0}", sizeof(ulong));
            Console.WriteLine("sizeof(float):{0}", sizeof(float));
            Console.WriteLine("sizeof(double):{0}", sizeof(double));
            Console.WriteLine("sizeof(decimal):{0}", sizeof(decimal));
        }
    }
}
