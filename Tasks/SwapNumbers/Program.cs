using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbers
{
    class Program
    {
        static int IntValue = 0;
        static List<int> list = new List<int>();
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
        static void printArr(List<int> arr)
        {
            Console.WriteLine("[" + String.Join(",", list) + "]");
        }
        static void Main(string[] args)
        {
            ValidateInt("Enter the Value of N : ");
            int n = IntValue;
            string num = "";
            for (int i = 1; i <= n; i++)
            {
                num += i;
            }
            Console.WriteLine("The number : " + num);
            permutations(num, 0, num.Length - 1);
            printArr(list);
            KLabel:
            ValidateInt("Enter the K Value : ");
            int k = IntValue;
            if (k > 0 && k < list.Count-1)
            {
                Console.WriteLine(list[k-1]);
            }
            else
            {
                Console.WriteLine("K value is invalid..!");
                goto KLabel;
            }
            Console.ReadLine();
        }
        private static void permutations(string s, int left, int right)
        {
            if(left == right)
            {
                list.Add(int.Parse(s));
                //Console.WriteLine(s);
            }
            else
            {
                for(int i = left; i <= right; i++)
                {
                    s = swap(s, left, i);
                    permutations(s, left + 1, right);
                }
            }
        }
        private static string swap(string s, int i, int j)
        {
            char[] arr = s.ToCharArray();
            char temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            return new string(arr);
        }
    }
}
