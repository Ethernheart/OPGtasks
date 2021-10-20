using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, x=0, n, count=0;
            n = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                if(i%2==0)
                {
                    count++;
                    x = x + i;
                }
                
            }
            Console.WriteLine($"x={x} count={count}");
        }
    }
}
