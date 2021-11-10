using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, summ=0, k=0;
            float sred=0;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
             a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                sred += a[i];
            }
            sred = sred / n;
            for (int i = 0; i < n; i++)
            {
                if(a[i]>sred)
                {
                    summ = summ + a[i];
                    k++;
                }
            }
            Console.WriteLine($"summa= {summ}\tkol-vo={k}");
        }
    }
}
