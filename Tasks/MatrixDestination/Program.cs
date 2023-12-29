using System;
namespace MatrixDestination
{
    class Program
    {
        public static int IntValue;
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
        static void printMatrix(int[,] mat)
        {
            int rows = mat.GetLength(0);
            int cols = mat.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            ValidateInt("Enter the number of rows : ");
            int rows = IntValue;
            ValidateInt("Enter the number of columns : ");
            int cols = IntValue;
            int[,] arr = new int[rows, cols];

            int i = 0, j = 0;
            for (i = 0; i < rows; i++)
            {
                for(j = 0; j < cols; j++)
                {
                    ValidateInt($"Enter arr[{i}][{j}] : ");
                    arr[i, j] = IntValue;
                }
            }
            i = 0;j = 0;
            printMatrix(arr);

            ValidateInt("Enter the Destination row index : ");
            int desRow = IntValue;
            ValidateInt("Enter the Destination column index : ");
            int desCol = IntValue;

            int rowSum = 0, colSum = 0, diagSum = 0, index = 0; ;
            while (index <= Math.Min(desCol, desRow))
            {
                diagSum += arr[index, index];
                i = index;
                j = index;
                index++;
            }
            if (desRow > desCol)
            {
                while (i < desRow)
                {
                    i++;
                    diagSum += arr[i, j];
                }
            }
            else
            {
                while (j < desCol)
                {
                    j++;
                    diagSum += arr[i, j];
                }
            }
            i = 0; j = 0;
            while(i<desRow || j < desCol)
            {
                if(j != desCol)
                {
                    rowSum += arr[i, j];
                    j++;
                }
                else
                {
                    rowSum += arr[i, j];
                    i++;
                }
                if (i == desRow && j == desCol)
                {
                    rowSum += arr[i, j];
                    break;
                }
            }
            i = 0;j = 0;
            while (i < desRow || j < desCol)
            {
                if (i != desRow)
                {
                    colSum += arr[i, j];
                    i++;
                }
                else
                {
                    colSum += arr[i, j];
                    j++;
                }
                if (i == desRow && j == desCol)
                {
                    colSum += arr[i, j];
                    break;
                }
            }

            Console.WriteLine($"Row Sum : {rowSum}\nCol Sum : {colSum}\nDiagonal Sum : {diagSum}");
            Console.WriteLine("Minimum Steps : "+((desRow > desCol) ? desRow : desCol));
            Console.ReadLine();
        }
    }
}
