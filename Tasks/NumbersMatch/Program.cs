using System;

namespace NumbersMatch
{
    class Program
    {
        static int[] stringToIntArr(string s)
        {
            int length = s.Length;
            int[] numarr = new int[length];
            for(int i = 0; i < length; i++)
            {
                numarr[i] = Convert.ToInt32(s[i] + "");
            }
            return numarr;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the first number : ");
            string num1 = Console.ReadLine();
            int num1Len = num1.Length;

            Console.Write("Enter the second number : ");
            string num2 = Console.ReadLine();
            int num2Len = num2.Length;

            string small = num1Len <= num2Len ? num1 : num2;
            string large = num1Len > num2Len ? num1 : num2;

            int[] smallarr = stringToIntArr(small);
            int[] largearr = stringToIntArr(large);
            int modifications = 0;
            if (num1 == num2)
            {
                Console.WriteLine("Both are same...");
            }
            else
            {
                if (large.Contains(small))
                {
                    Console.WriteLine($"Number {small} is present in {large}");
                    modifications = 0;
                }
                else
                {
                    int start = 0, end = smallarr.Length - 1,difference = 0,index = 0;
                    int min = 999999999;
                    while (end < largearr.Length)
                    {
                        int sum = 0;
                        index = start;
                        for(int i = 0; i < smallarr.Length; i++)
                        {
                            difference = Math.Abs(largearr[index] - smallarr[i]);
                            index++;
                            //Console.Write(difference + " ");
                            sum += difference;
                        }
                        start++;
                        end++;
                        if(sum < min)
                        {
                            min = sum;
                        }
                        Console.Write(sum + " ");
                    }
                    modifications = min;
                }
                Console.WriteLine("\nTotal Modifications : "+modifications);
            }
            //Console.WriteLine(String.Join(",",num1));
            //Console.WriteLine(String.Join(",", num2));
            Console.ReadLine();
        }
    }
}
