using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxi;
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            maxi = a[0];
            for (int i = 0; i < n; i++)
            {
                maxi = a[i];
                for (int j = 0; j < i; j++)
                {
                    if(a[i]<a[j])
                    {
                        maxi = a[j];
                    }
                }
            }
            Console.WriteLine($"\tmaxi={maxi}");
            for (int i = n-1; i >=0; i--)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
