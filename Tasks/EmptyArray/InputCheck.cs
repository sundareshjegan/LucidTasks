using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyArray
{
    class InputCheck
    {
        public int[] arr = null;
        public int length = 0;
        public void checkInput()
        {
            Console.Write("Enter the size of array : ");
            bool parse = (int.TryParse(Console.ReadLine(), out length));
            if (!parse)
            {
                Console.WriteLine("Plese enter integer value only..!");
                checkInput();
            }
            else if (length <= 0)
            {
                Console.WriteLine("Array size should be minimum 1..!");
                checkInput();
            }
            else
            {
                arr = new int[length];
                for (int i = 0; i < length; i++)
                {
                    bool canParse = false;
                    int temp = 0;
                    Console.Write($"Enter arr[{i}] : ");
                    canParse = int.TryParse(Console.ReadLine(), out temp);
                    if (canParse)
                    {
                        arr[i] = temp;
                    }
                    else
                    {
                        Console.WriteLine("Plese enter integer value only..!");
                        i--;
                    }
                }
            }
        }
        public InputCheck()
        {
            checkInput();
        }
    }
}
