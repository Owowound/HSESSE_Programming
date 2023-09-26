using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {//Task04
            double a = 0;
            int x = 1, y = 2, z = 3;
            while (x <= 1000_000_000)
            {
                a = a + 1.0/(x++ + y++ + z++);
                Console.WriteLine($"{a} {x}");
            }
        }
    }
}
