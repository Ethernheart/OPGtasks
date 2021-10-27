using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            float[] a = new float[n];
            float summ = 0;
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                summ = summ + a[i];
            }
            for (int i = 0; i < n; i++)
            {
                if(a[i]==0)
                {
                    a[i] = summ / n;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
