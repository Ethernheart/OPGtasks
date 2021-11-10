using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, maxi = 0, mini=0;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            maxi = a[0];
            mini = a[0];
            for (int i = 0; i < n; i++)
            {
                if (a[i] > maxi)
                {
                    maxi = a[i];
                }
                if (a[i] < mini) 
                {
                    mini = a[i];
                }
               
            }
            Console.WriteLine("\n\n");
            for (int i = 0; i < n; i++) 
            {
                
                if (a[i] == mini)
                {
                    a[i] = maxi;
                }
                else
                {
                    if(a[i]==maxi)
                    {
                        a[i] = mini;
                    }
                }

            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }

        }
    }
}

