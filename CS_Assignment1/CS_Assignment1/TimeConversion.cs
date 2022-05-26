using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace C_HW1;

static public class TimeConversion
{
    static public void Conversion() 
    {
        string a = Console.ReadLine();
        int century = int.Parse(a);
        int year = 100 * century;
        int day = 365 * year;
        int hour = 24 * day;
        int minute = 60 * hour;
        long m = minute;
        long second = 60 * m;
        long millisecond = 1000 * second;
        BigInteger microsecond = 1000 * millisecond;
        BigInteger nanosecond = 1000 * microsecond;

        Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", century, year, day, hour, minute, second, millisecond, microsecond, nanosecond);

}
}
    
