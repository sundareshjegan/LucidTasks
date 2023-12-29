using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixDestination
{
    class Program
    {
        public static int IntValue;
        public static void ValidateInt(string text)
        {
            Console.Write(text);
            bool parse = int.TryParse(Console.ReadLine(), out IntValue);
            if (!parse)
            {
                Console.WriteLine("Please enter Integer value..!");
                ValidateInt(text);
            }
        }
        static void Main(string[] args)
        {
            ValidateInt("Enter the number of rows : ");
            int rows = IntValue;
            ValidateInt("Enter the number of columns : ");
            int cols = IntValue;

            int[,] arr = new int[rows, cols];
            

        }
    }
}
