using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW2
{
    public static class Extract
    {
        public static string method(string str)
        {
            StringBuilder sb = new StringBuilder();
            HashSet<char> set = new HashSet<char>() { '.', ',', ':', ';', '=', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };

            int i = 0;
            int j = 0;
            while (j < str.Length)
            {
                while (j < str.Length && !set.Contains(str[j]))
                {
                    j++;
                }
                if (Checkstr(str.Substring(i, j - i)))
                {
                    sb.Append(str.Substring(i, j - i));
                    sb.Append(", ");
                }
                i = j;
                while (j < str.Length && set.Contains(str[j]))
                {
                    j++;
                }
                i = j;
            }
            return sb.ToString(0,sb.Length - 2);
             

        }

        public static Boolean Checkstr(string str)
        {
            int i = 0;
            int j = str.Length - 1;
            while (i < j)
            {
                if(str[i] != str[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
}
