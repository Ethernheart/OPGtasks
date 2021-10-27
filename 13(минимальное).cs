using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int mini, imin;
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            imin = 0;
            mini = a[0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                   
                    if (mini > a[j])
                    {
                        mini = a[j];
                        imin = j;
                    }
                }
            }
            Console.WriteLine($"\nmin={mini}\tImin={imin}");
            
        }
    }
}
