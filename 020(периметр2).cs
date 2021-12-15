using System;

namespace ConsoleApp17
{
    class Program
    {   static int Perimeter(int a, int b, int c)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Perimeter(a, b, c));

        }
    }
}
