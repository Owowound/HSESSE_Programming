using System;

namespace Sem06_Task07
{
    class Program
    {
        static double F(int n, double x)
        {
            double ans = 0;

            for (int k = 0; k <= n; k++)
            {
                ans = ans + Math.Abs(x - k) * (Math.Cos(Math.Cbrt(k) * x / 2));
            }
            return ans;
        }
        static void Main(string[] args)
        {
            string ss = "Y";
            while (ss != "N") 
            {
                int n;
                double ans = 0, x;
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

                double f = F(n, x) * (double)((double)Math.Log10(x) - 2 / 9);

                Console.WriteLine($"Ваш ответ равен {f}");

            m1:;
                Console.WriteLine($"Продолжим?(Y/N)");
                ss = Console.ReadLine();
            } 
        }
    }
}
