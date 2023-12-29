using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveComments
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string ans = "";
            if (s.Contains("//"))
            {
                for(int i=0;i<s.Length;i++)
                {
                    if(s[i] == '/')
                    {
                        break;
                    }
                    else
                    {
                        ans += s[i];
                    }
                }
            }
            else if(s.Contains("/*"))
            {
                
            }
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
