using System;

namespace Exercise2
{
    class Program
    {
        public class Arithmetic
        { 
            public static int Additon(int a, int b)
            {
                return a + b;
            }
            public static int Subtraction(int a, int b)
            {
                return a - b;
            }
            public static int Multiplication(int a, int b)
            {
                return a * b;
            }
            public static int Division(int a, int b)
            {
                return a / b;
            }
        }
        enum Option
        { 
            Addition = 1,
            Subtraction,
            Multiplication,
            Division
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first operand");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second operand");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose the operator");
            string[] names = Enum.GetNames(typeof(Option));
            int[] values = (int[])Enum.GetValues(typeof(Option));
            for (int i = 0; i < names.Length; i++) 
            {
                Console.WriteLine($"Type {values[i]} to choose operation {names[i]}");
            }
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Console.WriteLine(Arithmetic.Additon(a, b));
                    break;
                case 2:
                    Console.WriteLine(Arithmetic.Subtraction(a, b));
                    break;
                case 3:
                    Console.WriteLine(Arithmetic.Multiplication(a, b));
                    break;
                case 4:
                    Console.WriteLine(Arithmetic.Division(a, b));
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

        }
    }
}
