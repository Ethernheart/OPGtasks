using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            a = Convert.ToDouble(Console.ReadLine());
           

            if (a >= 500 && a < 1000)
            {
                a = a - (a / 100 * 3);
                
                
            }
            if(a>=1000)
            { 
                a = a - (a / 100 * 5);
            }
            Console.WriteLine(a);





        }
    }
}
