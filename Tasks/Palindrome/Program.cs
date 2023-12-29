using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using StringOperation;

namespace Palindrome
{
    class Program
    {
        static string intToBin(int n)
        {
            string binary = "";
            while (n > 0)
            {
                binary = (n & 1) + binary;
                n >>= 1;
            }
            return binary;
        }
        public static string reverse(string s, int length)
        {
            string reversed = "";
            for (int i = length - 1; i >= 0; i--)
            {
                reversed += s[i];
            }
            return reversed;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int actual = n;
            int reversed = 0;

            bool isintPalindrome, isbinaryPalindrome=false;
            while (n > 0)
            {
                reversed = reversed * 10 + n % 10;
                n /= 10;
            }
            isintPalindrome = actual == reversed ? true : false;
            string bin = intToBin(actual);
            //isbinaryPalindrome = bin == StringOperation.reverse(bin,bin.Length) ? true : false;
            Console.WriteLine($"The number {actual} in binary is {bin}");

            isbinaryPalindrome = bin == reverse(bin, bin.Length) ? true : false;

            string status = isbinaryPalindrome && isintPalindrome ? "Both String and Integer" : isintPalindrome ? "Only Integer" : isbinaryPalindrome ? "Only Binary" : "Not a";
            Console.Write($"The number {actual} is {status} Palindrome");
            Console.ReadLine();
        }
    }
}
