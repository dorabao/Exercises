using System;

namespace Exercise5
{
    class Program
    {
        public static void PrintTriangle(int row)
        {
            if (row <= 0)
            {
                Console.WriteLine("Invalid Input");
            }
            bool toggle = true;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (toggle == true)
                    {
                        Console.Write(1);
                        toggle = false;
                    }
                    else {
                        Console.Write(0);
                        toggle = true;
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the Number of Rows:");
            int row = Convert.ToInt32(Console.ReadLine());
            PrintTriangle(row);
        }
    }
}
