using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.Write("Enter a char to replace : ");
            char ch = Char.Parse(Console.ReadLine());

            s = s.Replace(ch, '-');
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
