using System;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, n;
            n = int.Parse(Console.ReadLine());
            string s = n.ToString(), ans = "";
            k = int.Parse(Console.ReadLine());
            
            if (k > s.Length)
            {
                Console.WriteLine("Такое число не пойдет");
                return;
            }

            for (int i = 0; i < k; i++)
            {
                ans = ans + s[i];
            }

            Console.WriteLine(ans);
        }
    }
}
