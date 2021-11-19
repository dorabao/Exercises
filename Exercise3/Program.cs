using System;

namespace Exercise3
{
    class Program
    {
        public static string ReverseStr(string s)
        {
            if (s == null) return "";
            char[] array = s.ToCharArray();
            for (int i = 0, j = array.Length - 1; i < j; i++, j--)
            {
                char temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
            return new string(array);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input your words");
            string input = Console.ReadLine();
            Console.WriteLine(ReverseStr(input.ToLower()));
            Console.ReadKey();
        }
    }
}
