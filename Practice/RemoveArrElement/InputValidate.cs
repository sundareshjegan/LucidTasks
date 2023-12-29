using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveArrElement
{
    public class InputValidate
    {
        public static int IntValue = 0;
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
    }
}
