using System;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine(), ans = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                ans = ans + s[i];
            }
            Console.WriteLine(int.Parse(ans));
        }
    }
}
