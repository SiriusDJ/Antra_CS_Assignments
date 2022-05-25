using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW2
{
    public static class ParseUrl
    {
        public static void Parse(string url)
        {
            
            StringBuilder protocol = new StringBuilder();
            StringBuilder server = new StringBuilder();
            StringBuilder resource = new StringBuilder();
            int j = 0;
            for(int i = 0; i < url.Length; i++)
            {
                if (url[i] == ':' && (url[i + 1] == '/'&& url[i + 2] == '/'))
                {   
                    protocol.Append(url.Substring(0, i));
                    j = i + 3;
               
                }
                if (url[i] == '.' && url.Substring(i,4) == ".com")
                {
                    server.Append(url.Substring(j,i + 4 - j));
                    j = i + 5;
                    if (j < url.Length)
                    {
                        resource.Append(url.Substring(j, url.Length - j));
                    }
                   
                }
            }
            Console.WriteLine($"[protocol] = {protocol}");
            Console.WriteLine($"[server] = {server}");
            Console.WriteLine($"[resource] = {resource}");
        }
    }
}
