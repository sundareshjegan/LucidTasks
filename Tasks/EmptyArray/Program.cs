using System;
namespace EmptyArray
{
    class Program
    {
        static void printArr(int[] arr)
        {
            Console.WriteLine("[" + String.Join(",", arr) + "]");
        }
        static int[] removeFirst(int[] arr)
        {
            int length = arr.Length;
            int[] newArr = new int[length - 1];
            for(int i = 1; i < length; i++)
            {
                newArr[i - 1] = arr[i];
            }
            return newArr;
        }
        static int[] rotate(int[] arr)
        {
            int x = arr[0];
            for (int i = 0; i < (arr.Length - 1); i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[(arr.Length - 1)] = x;
            return arr;
        }
        static void Main(string[] args)
        {   
            InputCheck check = new InputCheck();
            int[] arr = check.arr;
            int swapCount = 0, removeCount = 0;
            while (arr.Length > 1)
            {
                int i = 0;
                bool minFound = false;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        minFound = true;
                        arr = rotate(arr);
                        swapCount++;
                        Console.Write(swapCount+" Time swapped --> ");
                        printArr(arr);
                    }
                }
                if (!minFound)
                {
                    arr = removeFirst(arr);
                    removeCount++;
                    Console.Write(removeCount+" Time Removed --> ");
                    printArr(arr);
                }
            }
            Console.Write(++removeCount + " Time Removed --> []");
            Console.WriteLine($"\n\nTotal Swap Count = {swapCount}\nTotal Remove Count = {removeCount}");
            Console.ReadLine();
        }
    }
}