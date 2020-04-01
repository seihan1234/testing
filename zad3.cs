using System;

namespace seihan_zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows,cols]; 
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
            }

            for (int col = 0; col < cols; col++)
            {
                int min = 1000;
                for (int row = 0; row < rows; row++)
                {
                    if (matrix[row, col] < min) min = matrix[row, col];
                }
                Console.Write("{0}", min);
            }
        }
    }
}
