using System;

namespace zad1
{
    class Program
    {
        private static int col;

        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                var line = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                for (int col = 0; col < cols; col++) matrix[rows, cols] = line[col];
                

                
            }
            int maxSum = 0, maxRow = -1, maxCol = -1;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int tempSum = matrix[row, col] + matrix[row + 1, col] +
                                  matrix[row, col + 1] + matrix[row + 1, col + 1];
                        if(tempSum > maxSum)
                    { 
                        maxSum = tempSum;
                        maxRow = row;
                        maxCol = col;
                        Console.WriteLine("Sum {0} at [{1},{2}]", maxSum, maxRow, maxCol);


                    }

                } 
            }
            for (int row = maxRow; row < maxRow; row++)
            {
                for (int col = maxCol; col < maxCol + 2; col++);
                Console.Write(matrix[row, col] +" ");
                Console.WriteLine();
                

                
            }
        }
    }
}
