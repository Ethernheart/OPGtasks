using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)        
        {
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if((a>=1) && (a<=3))
            {
                Console.WriteLine($"a={a}");
                 
            }
            if ((b >= 1) && (b <= 3))
            {
                Console.WriteLine($"b={b}");

            }
            if ((c >= 1) && (c <= 3))
            {
                Console.WriteLine($"c={c}");

            }
            

        }
    }
}
