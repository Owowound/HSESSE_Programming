using System;

namespace Sem06_Task07
{
    class Program
    {
        static double F(int n, double x)
        {
            double ans = 0;

            for (int k = 1; k <= n; k++)
            {
                ans = ans + Math.Abs(x - k) * Math.Cos(Math.Cbrt(k) * x / 2d);
            }
            return ans;
        }
        static void Main(string[] args)
        {
            bool key = false;
            while (!key) 
            {
                int n;
                double x;
                string s1, s2;
                Console.WriteLine($"Введите x:");
                s1 = Console.ReadLine();
                Console.WriteLine($"Введите n:");
                s2 = Console.ReadLine();

                if (double.TryParse(s1, out double t) && int.TryParse(s2, out int y))
                {
                    x = double.Parse(s1);
                    n = int.Parse(s2);
                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                    goto m1;
                }
                if (n > 20 || n <= 0)
                {
                    Console.WriteLine("Некорректный ввод");
                    goto m1;
                }

                double f = F(n, x) * (Math.Log(x) - 2d / 9d);

                Console.WriteLine($"Ваш ответ равен {f:0.###}");

            m1:;
                Console.WriteLine($"Продолжим? \nВведите Esc, чтобы завершить");

                key = Console.ReadKey().Key == ConsoleKey.Escape;

                Console.WriteLine(key);
            } 
        }
    }
}
