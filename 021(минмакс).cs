using System;
namespace ConsoleApp17
{
    class Program
    {
        static void Minmax(ref int min, int[] a, int max)
        {
            min = a[0];
            max = a[0];
            for (int j = 0; j < a.Length; j++)
            {
                if (min > a[j])
                    min = a[j];
            }
            for (int j = 0; j < a.Length; j++)
            {
                if (max < a[j])
                    max = a[j];
            }

            Console.WriteLine(min);
            Console.WriteLine(max);
        }

        static void Main(string[] args)
        {
            var a = Array.ConvertAll((Console.ReadLine().Split(' ')), s => int.Parse(s));
            int min = a[0];
            int max = a[0];
            Minmax(ref min, a, max);
        }
    }
}

