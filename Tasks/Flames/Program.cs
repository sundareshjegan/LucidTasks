using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flames
{
    class Program
    {
        static void sad()
        {
            Console.WriteLine("     .-'''''''-.");
            Console.WriteLine("   .'           '.");
            Console.WriteLine("  /   O      O   \\");
            Console.WriteLine(" :    '      `    :");
            Console.WriteLine(" |               | ");
            Console.WriteLine(" :    .------.    :");
            Console.WriteLine("  \\  '        '  /");
            Console.WriteLine("   '.          .'");
            Console.WriteLine("     '-......-'");
        }
        static void smile()
        {
            Console.WriteLine("     .-'''''''-.");
            Console.WriteLine("   .'           '.");
            Console.WriteLine("  /   O      O    \\");
            Console.WriteLine(" :                :");
            Console.WriteLine(" |                | ");
            Console.WriteLine(" : ',          ,' :");
            Console.WriteLine("  \\  '-......-'  /");
            Console.WriteLine("   '.          .'");
            Console.WriteLine("     '-......-'");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\tFLAMES\n\t\t\t\t------");
            Console.Write("Enter the player1 name : ");
            string name1 = Console.ReadLine().ToLower();
            Console.Write("Enter the player2 name : ");
            string name2 = Console.ReadLine().ToLower();

            int length = name1.Length + name2.Length;
            foreach(char ch in name1)
            {
                if (name2.Contains(ch))
                {
                    length -= 2;
                }
            }
            string relationship = "FLAMES";
            
            while(relationship.Length > 1)
            {
                int i = length % relationship.Length;
                if(i == 0)
                {
                    relationship = relationship.Substring(0, relationship.Length - 1);
                }
                else
                {
                    relationship = relationship.Substring(i) + relationship.Substring(0, i-1);
                }
            }
            Console.Write("The Relationship will end in : ");
            switch (relationship[0])
            {
                case 'F':
                    Console.WriteLine("Friends");
                    break;
                case 'L':
                    Console.WriteLine("Love");
                    break;
                case 'A':
                    Console.WriteLine("Affection");
                    break;
                case 'M':
                    Console.WriteLine("Marriage (^_-)");
                    smile();
                    break;
                case 'E':
                    Console.WriteLine("Enemy");
                    break;
                case 'S':
                    Console.WriteLine("Sister(-_-)\n");
                    sad();
                    break;
            }
            Console.Read();
        }
    }
}
