using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, m, j;
            m = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=m;i++)
            {
                for(j=1;j<=i;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
