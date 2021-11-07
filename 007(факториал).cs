using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, x=1, i=1;
            p = Convert.ToInt32(Console.ReadLine());
            do
            {

                x = x * i;
                i++;

            }
            while (i <= p);
            Console.WriteLine(x);
        }
    }
}
