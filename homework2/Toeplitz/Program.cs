using System;

namespace Toeplitz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } };
            Console.WriteLine(IsToeplitz(matrix));
        }

        static bool IsToeplitz(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row > 0 && col > 0 && matrix[row,col] != matrix[row - 1,col - 1])
                        return false;
                }
            }
            return true;
        }
    }
}
