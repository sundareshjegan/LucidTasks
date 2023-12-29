using System;
namespace Matix
{
    class Program
    {
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
            Console.Write("Enter the number of rows : ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of Columns : ");
            int cols = Convert.ToInt32(Console.ReadLine());

            if(rows >1 && cols > 1)
            {
                int[,] matrix = new int[rows,cols];
                Console.WriteLine("Enter matrix Elements : ");
                for(int i = 0; i < rows; i++)
                {
                    for(int j = 0; j < cols; j++)
                    {
                        Console.Write($"Enter matrix[{i}][{j}] : ");
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.Write("Enter submatrix row size: ");
                int subMatrixRowSize = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter submatrix row size: ");
                int subMatrixColSize = Convert.ToInt32(Console.ReadLine());
                int subMatCount = 0;

                Console.WriteLine("Actual Matrix : ");
                printMatrix(matrix);

                int maxSum = -999999999;
                int minSum = 999999999;
                int[,] maxSubMatrix = new int[subMatrixRowSize, subMatrixColSize];
                int[,] minSubMatrix = new int[subMatrixRowSize, subMatrixColSize];

                for (int i = 0; i <= rows - subMatrixRowSize; i++)
                {
                    for (int j = 0; j <= cols - subMatrixColSize; j++)
                    {
                        int currentSum = 0;
                        int[,] currentSubMatrix = new int[subMatrixRowSize, subMatrixColSize];

                        for (int x = 0; x < subMatrixRowSize; x++)
                        {
                            for (int y = 0; y < subMatrixColSize; y++)
                            {
                                currentSubMatrix[x, y] = matrix[i + x, j + y];
                                currentSum += matrix[i + x, j + y];
                            }
                        }
                        Console.WriteLine($"Submatrix {++subMatCount} with sum of {currentSum}:");
                        printMatrix(currentSubMatrix);

                        if(currentSum > maxSum)
                        {
                            maxSum = currentSum;
                            maxSubMatrix = currentSubMatrix;
                        }
                        if(currentSum < minSum)
                        {
                            minSum = currentSum;
                            minSubMatrix = currentSubMatrix;
                        }
                    }
                }
                Console.WriteLine("--------------------------");
                Console.WriteLine("Maximum submatrix is ");
                printMatrix(maxSubMatrix);
                Console.WriteLine("Maximum Sum = "+maxSum);

                Console.WriteLine("--------------------------");
                Console.WriteLine("Minimum submatrix is ");
                printMatrix(minSubMatrix);
                Console.WriteLine("Minimum Sum = " + minSum);
            }
            else
            {
                Console.WriteLine("Invalid row or columns");
            }
            Console.ReadLine();
        }
    }
}