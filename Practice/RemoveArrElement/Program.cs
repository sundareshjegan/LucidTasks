using System;
namespace RemoveArrElement
{
    class Program
    {
        static void printArr(int[] arr)
        {
            foreach(int i in arr)
            {
                if (i != Int32.MaxValue)
                {
                    Console.Write(i + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            InputValidate.ValidateInt("Enter the size of the array : ");
            int n = InputValidate.IntValue;
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                InputValidate.ValidateInt($"Enter arr[{i}] : ");
                arr[i] = InputValidate.IntValue;
            }
            InputValidate.ValidateInt("Enter min/max (1/2):");
            int option = InputValidate.IntValue;
            switch (option)
            {
                case 1:
                    
                    for (int i = 0; i < n - 1; i++)
                    {
                        if (arr[i] <= arr[i + 1])
                        {
                            arr[i] = Int32.MaxValue;
                        }
                    }
                    if(arr[n-2] == Int32.MaxValue)
                    {
                        arr[n - 1] = Int32.MaxValue;
                    }
                    break;
                case 2:
                    for (int i = 0; i < n - 1; i++)
                    {
                        if (arr[i] >= arr[i + 1])
                        {
                            arr[i] = Int32.MaxValue;
                        }
                    }
                    if (arr[n - 2] == Int32.MaxValue)
                    {
                        arr[n - 1] = Int32.MaxValue;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option..!");
                    break;
            }
            printArr(arr);
            Console.ReadLine();
        }
    }
}
