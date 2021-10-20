using System;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = Convert.ToInt16(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("Ponedel'nik");
            }
            if (a == 2)
            {
                Console.WriteLine("Vtornik");
            }
            if (a == 3)
            {
                Console.WriteLine("Sreda");
            }
            if (a == 4)
            {
                Console.WriteLine("Chetverg");
            }
            if (a == 5)
            {
                Console.WriteLine("Piatniza");
            }
            if (a == 6)
            {
                Console.WriteLine("Subbota");
            }
            if (a == 7)
            {
                Console.WriteLine("Voskresen'e");
            }
        }
    }
}
