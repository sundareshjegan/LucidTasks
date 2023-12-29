using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    class Program : Student
    {
             
        static void Main(string[] args)
        {
            //Student stu = new Student();

            LeoSpoiler leo = new LeoSpoiler("sundar", 's');
            leo += Bharth;
            leo("Myskin",'L');

            Console.ReadLine();
            string s = "nsbjdf";
            
        }

        public static void Sundar(string cast, char MovieStartingLetter)
        {
            Console.WriteLine("spoiler pannita , poda loosu " + cast + " "+ MovieStartingLetter);
        }
        public static void Bharth(string cast, char MovieStartingLetter)
        {
            Console.WriteLine("spoiler mental , poda loosu " + cast + " " + MovieStartingLetter);
        }

    }

    public class Student
    {
            public delegate void LeoSpoiler(string cast, char MovieStartingLetter);

        
    }
      
}
