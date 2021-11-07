using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, x;
            for(i=2;i<=6; i++)
            {
                for(j=2;j<=6;j++)
                {
                    Console.Write($"{i*j}\t");
                }
                Console.WriteLine();
            }

        }
    }
}
