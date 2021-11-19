using System;
using System.Collections.Generic;

namespace Exercise4
{
    class Program
    {
        public static void FindArmstrongNumbers(int min, int max)
        {
            IList<int> armstrongNumbers = new List<int>();
            if (min < 0) min = 0;
            if (max < 0 || max < min)
            {
                Console.WriteLine("Invalid inputs");
            }
            for (int i = min; i <= max; i++)
            {
                if (IsArmstrong(i))
                {
                    armstrongNumbers.Add(i);
                    Console.WriteLine(i);
                }
            }
        }

        public static bool IsArmstrong(int number)
        {
            IList<int> digits = GetDigits(number);
            int sum = CalculateSum(digits);
            return number == sum;
        }

        public static IList<int> GetDigits(int number)
        {
            IList<int> digits = new List<int>();
            while (number != 0)
            {
                digits.Add(number % 10);
                number = number / 10;
            }
            return digits;
        }

        public static int CalculateSum(IList<int> digits)
        {
            double sum = 0;
            int n = digits.Count;
            foreach (int digit in digits)
            {
                sum += Math.Pow(digit, n);
            }
            return (int)sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());
            FindArmstrongNumbers(a, b);
        }
    }
}
