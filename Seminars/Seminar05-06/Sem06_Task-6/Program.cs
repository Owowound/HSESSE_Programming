using System;

namespace Sem06_Task_6
{
    class Program
    {
        static int F(int x)
        {
            int ans = 1;
            for (int i = 1; i <= x; i++)
                ans = ans * i;
            return ans;
        }

        static void Main(string[] args)
        {
            int n, ans = 0;
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                ans = ans + F(i);
            }
            Console.WriteLine(ans);
        }
    }
}
