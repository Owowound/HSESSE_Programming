using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            double ans = 0;
            for (double i = 1; i <= k; i++)
            {
                ans = ans + 1 / i;
            }
            Console.WriteLine("{0:#.####}", ans);
        }
    }
}
