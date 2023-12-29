using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperation
{
    internal static class Program
    {
        public static string reverse(string s,int length)
        {
            string reversed = "";
            for(int i = length-1; i>=0; i--)
            {
                reversed += s[i];
            }
            return reversed;
        }
        public static string removeDuplicates(string s,int length)
        {
            String noDuplicate = "";
            for (int i = 0; i < length; i++)
            {
                if (!noDuplicate.Contains(s[i]))
                {
                    noDuplicate += s[i];
                }
            }
            return noDuplicate;
        }
        public static int count(string s, char c)
        {
            int length = s.Length;
            int count = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] == c)
                {
                    count++;
                }
            }
            return count;
        }

        public static void countCharacters(String s,int length)
        {
            string s1 = removeDuplicates(s,length);
            int len = s1.Length;
            for(int i = 0; i < len; i++)
            {
                Console.WriteLine("Character : "+s1[i] + " - " + count(s, s1[i]));
            }
        }

        static void Main(string[] args)
        {
            int choice = 0;
            Console.WriteLine("String Operations");
            Console.Write("Enter a sentence : ");
            string str = Console.ReadLine();
            int length = str.Length;
            string[] arr = str.Split(' ');
            int arrlength = arr.Length;
            do
            { 
                Console.Write("\nOPTIONS\n-------\n1. Entire Reverse\n2. Reverse Each letter in words\n3. Reverse words\n4. Count characters\n5. Exit\nEnter your option : ");
                choice = Convert.ToInt32(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                        Console.WriteLine(reverse(s:str,length:length));
                        break;
                    case 2:
                        for (int i = 0; i < arrlength; i++)
                        { 
                            Console.Write(reverse(arr[i],arr[i].Length)+" ");
                        }
                        break;
                    
                    case 3:
                        for(int i = arrlength - 1; i >= 0; i--)
                        {
                            Console.Write(arr[i] + " ");
                        }
                        break;
                    case 5:
                        countCharacters(str, length);
                        break;
                    case 6:
                        Console.WriteLine("Bye...(^_^)");
                        Console.Read();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice..!");
                        break;
                }
            } while (choice != 4);
        }
    }
}