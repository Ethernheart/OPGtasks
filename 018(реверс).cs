using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            s = Console.ReadLine();
            Console.WriteLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
        }
    }
}
