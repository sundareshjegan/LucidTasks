using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    class Manager
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Beep(1234, 1000);
            }
            Staff staff = new Staff();
            staff.Obj = Printsetta;
            void Printsetta(int i)
            {
                Console.WriteLine("student : " + i);
            }
        }
    }
}
