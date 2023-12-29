using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentDetails
{
    class InputValidate
    {
        public static int Mark = 0;
        public static int IntValue = 0;
        public static string StringValue = "";

        public static void ValidateMark(string text)
        {
            Console.Write(text);
            bool parse = int.TryParse(Console.ReadLine(), out Mark);
            if (!parse)
            {
                Console.WriteLine("Mark Should be an integer..!Try again");
                ValidateMark(text);
            }
            else if (Mark < 0)
            {
                Console.WriteLine("Marks should not be negative..!Try again");
                ValidateMark(text);
            }
            else if(Mark > 100)
            {
                Console.WriteLine("Invalid Mark..! Try again");
                ValidateMark(text);
            }
        }
        public static void  ValidateInt(string text)
        {
            Console.Write(text);
            bool parse = int.TryParse(Console.ReadLine(), out IntValue);
            if (!parse)
            {
                Console.WriteLine("Please enter Integer value..!");
                ValidateInt(text);
            }
        }

        public static void ValidateString(string text)
        {
            Console.Write(text);
            string s = Console.ReadLine();
            if (string.IsNullOrEmpty(s))
            {
                Console.WriteLine("Input should not be empty..!");
                ValidateString(text);
            }
            else if (!Regex.Match(s, "^[a-zA-Z ]*$").Success)
            {
                Console.WriteLine("Numbers and Special Characters are not allowed..!");
                ValidateString(text);
            }
            else
            {
                StringValue = s;
            }
        }
    }
}
