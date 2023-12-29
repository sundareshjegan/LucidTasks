using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal struct Square
    {
        int side;
        internal Square(int s)
        {
            side = s;
        }
        internal void printArea()
        {
            Console.Write(side * side);
        }
    }
}
