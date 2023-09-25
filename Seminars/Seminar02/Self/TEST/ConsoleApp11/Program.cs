using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, ans = 0, s = 0;
            x = double.Parse(Console.ReadLine());

            while (s <= x)
            {
                ans = ans + s * s * 0.001;
                //Console.WriteLine($"{ans}  {s * s} ");
                s = s + (0.001);
            }
            Console.WriteLine(ans);
        }
    }
}
