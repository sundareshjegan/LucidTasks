using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    public class Student
    {
        public delegate void divideHandler(int i);
        public divideHandler Stuobj = null;

        public void Function()
        {
            for(int i = 1; i < 50; i++)
            {
                if (i % 5 == 0)
                {
                    Stuobj.Invoke(i);
                }
            }
        }
    }
}
