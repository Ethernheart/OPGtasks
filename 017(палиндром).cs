using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            string s,st,sr;
            s = Console.ReadLine();
            st = s.Trim();
            sr = st.ToLower();

            for (int i = 0; i <(sr.Length)/2; i++)
            {
                if( sr[i]==sr[sr.Length-1-i])
                {
                    Console.WriteLine("является палиндромом");
                    break;
                }
                else
                {
                    Console.WriteLine("не является палиндромом");
                    break;
                }
                
                    
            }

        }
    }
}
