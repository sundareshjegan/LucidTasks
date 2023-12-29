using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        /*static void Main(string[] args)
        {
            Calc c = new Calc();
            c.s = print;
            //c.s += printData;

            Thread t1 = new Thread(new ThreadStart(c.function1));
            Thread t2 = new Thread(new ThreadStart(c.function2));
            t1.Start();
            t2.Start();
            //c.s -= print;

            void print(int i)
            {
                Console.WriteLine(i);
            }
            void printData(int i)
            {
                Console.WriteLine(i+" data");
            }
            Console.ReadLine();
        }*/
    }
    public class Calc
    {
        public delegate void Sample(int n);
        public Sample s = null;
        public void function1()
        {
            int i = 0;
            while (i < 10)
            {
                i++;
                Thread.Sleep(1000);
                s.Invoke(i);
            }
        }
        public void function2()
        {
            int i = 100;
            while (i < 110)
            {
                i++;
                Thread.Sleep(1000);
                s.Invoke(i);
            }
        }
       
            

    }

}
}
