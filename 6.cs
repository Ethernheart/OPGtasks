using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, x=0;
            n = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<n+1;i++)
            {
                x = x + i;
               
            }
            Console.WriteLine(x);
        }
    }
}
