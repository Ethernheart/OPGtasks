using System;
namespace ConsoleApp17
{
    class Program
    {
        static void Min(ref int min, int[] a)
        {
            min = a[0];
            for (int j = 0; j < a.Length; j++)
            {
                if (min > a[j])
                    min = a[j];
            }

            Console.WriteLine(min);
        }

        static void Main(string[] args)
        {
            var a = Array.ConvertAll((Console.ReadLine().Split(' ')), s => int.Parse(s));
            int min = a[0];
            Min(ref min, a);
        }
    }
}

