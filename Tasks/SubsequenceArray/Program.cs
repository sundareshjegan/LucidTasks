using System;
namespace SubsequenceArray
{
    class Program
    {
        static int target = 0;
        static bool divCalled = false;
        static void printArr(int[] arr)
        {
            Console.WriteLine("[" + String.Join(",", arr) + "]");
        }
        static int[] dividedArray(int[] arr)
        {
            divCalled = true;
            int[] new_arr = new int[arr.Length * 2];
            int index = 0;
            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    new_arr[index] = num / 2;
                    new_arr[index + 1] = num / 2;
                    index += 2;
                }
                else
                {
                    new_arr[index] = num;
                    index++;
                }
            }
            int[] arr1 = new int[index];
            for (int i = 0; i < index; i++)
            {
                arr1[i] = new_arr[i];
            }
            return arr1;
        }


        static bool check(int[] arr, int target)
        {
            int sum = 0;
            foreach(int ele in arr){sum += ele;}
            return sum == target;
        }


        static int[][] GenerateCombinations(int[] arr)
        {
            int n = arr.Length;
            int totalCombinations = (int)Math.Pow(2, n) - 1;
            int[][] result = new int[totalCombinations][];

            int combinationCount = 0;
            for (int mask = 1; mask <= totalCombinations; mask++)
            {
                int[] currentCombination = new int[n];
                int currentIndex = 0;
                int tempMask = mask;
                for (int i = 0; i < n; i++)
                {
                    if (tempMask % 2 == 1)
                    {
                        currentCombination[currentIndex++] = arr[i];
                    }
                    tempMask /= 2;
                }
                Array.Resize(ref currentCombination, currentIndex);
                result[combinationCount++] = currentCombination;
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the elements seperated by space : ");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int sum = 0, n = arr.Length;
            foreach (int ele in arr) { sum += ele; }
            Array.Sort(arr);
            Console.Write("Enter the target value : ");
            target = int.Parse(Console.ReadLine());

            if(sum < target)
            {
                Console.WriteLine(-1);
            }
            else if (Array.IndexOf(arr, target) != -1)
            {
                Console.WriteLine("Array contains the target0 at position : " + Array.IndexOf(arr, target));
            }
            else
            {
                int splitCount = 0;
                bool flag = true;
                while (flag)
                {
                    printArr(arr);
                    int[][] combinations = GenerateCombinations(arr);
                    foreach (int[] array in combinations)
                    {
                        if (check(array, target))
                        {
                            printArr(array);
                            flag = false;
                        }
                    }
                    if(flag)
                        splitCount++;
                        arr = dividedArray(arr);
                }
                Console.Write("Total Splits : ");
                Console.WriteLine(divCalled ? splitCount : 0);
            }
            Console.ReadLine();
        }
    }
}
