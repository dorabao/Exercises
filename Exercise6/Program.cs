using System;

namespace Exercise6
{
    class Program
    {
        public static void PrintDiamond(char[,] diamond)
        {
            int row = diamond.GetLength(0);
            int col = diamond.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(diamond[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static char[,] BuildDiamond(int row)
        {
            row = 2 * row - 1;
            char[,] diamond = new char[row, row];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    diamond[i, j] = IsAsterisk(i, j, row, row) ? '*' : ' ';
                }
            }
            return diamond;
        }

        public static bool IsAsterisk(int i, int j, int row, int col)
        {
            int rowOfCenter = row / 2;
            int colOfCenter = col / 2;
            int distanceToCenter = Math.Abs(rowOfCenter - i) + Math.Abs(colOfCenter - j);
            return distanceToCenter <= row / 2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows");
            int row = Convert.ToInt32(Console.ReadLine());
            char[ , ] result = BuildDiamond(row);
            PrintDiamond(result);
        }
    }
}
