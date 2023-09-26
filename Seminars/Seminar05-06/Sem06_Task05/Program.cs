using System;

namespace Sem06_Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double ans1 = 0, ans2 = 1, a = double.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)/// Сумма
            {
                ans1 = ans1 + (1 / Math.Pow(a, i));
            }

            for (int i = 1; i <= n; i++)/// Произведение
            {
                ans2 = ans2 * (a - i);
            }

            Console.WriteLine($"{ans1} {ans2}");
        }
    }
}
