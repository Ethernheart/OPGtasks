using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, xmax;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            xmax = a;
            if (b > a)
            {
                xmax = b;
            }
            if (c > b) 
            {
                xmax = c;
            }
           
            Console.WriteLine(xmax);
        }
    }
}
