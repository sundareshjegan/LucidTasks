using staticPractive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticPractice
{
    class Abc
    {
        int a;
        static int b;

        public void Print()
        {
            Abc a1 = new Abc();
            Console.WriteLine(a1.a+ " "+b);
            
        }

    }
    public static class Program
    {
        public static string Name;
        public static int a;
        public static void Main(string[] args)
        {
            string s= Program1.Name;
            List<Info> infos = new List<Info>();
            infos.Add(new student());
            infos.Add(new Staff());
            
            student s1 = infos[0] as student;
            
            if (infos[0] is student s2) ;
        }
        
        public static void Print()
        {
            a = 90;
        }
    }
    class Program1 
    {
        
        public static string Name
        {
            get;set;
        }
    }
}
