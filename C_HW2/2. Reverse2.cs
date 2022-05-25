using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace C_HW2;

public static class Reverse
{
    public static string method(string str)
    {
        List<string> list = new List<string>();
        HashSet<char> set = new HashSet<char>() { '.', ',', ':', ';', '=', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };

        int i = 0;
        int j = 0;
        while (j < str.Length)
        {
            while (j < str.Length && !set.Contains(str[j]))
            {
                j++;
            }
            list.Add(str.Substring(i, j - i));
            i = j;

            while (j < str.Length && set.Contains(str[j]))  
            {
                j++;
            }
            list.Add(str.Substring(i, j - i));
            i = j;
        }

        StringBuilder res = new StringBuilder();
        int p = 1;
        int q = list.Count - 2;
        while (p < list.Count)
        {
            res.Append(list[q]);
            res.Append(list[p]);
            p += 2;
            q -= 2;
        }
        return res.ToString();

    }
}
