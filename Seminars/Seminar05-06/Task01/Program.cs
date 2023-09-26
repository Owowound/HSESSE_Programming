using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {//Task01
            long n = -1;
            while (n < 50)
            {
                n++;
                if (n == 20)
                    continue;
                if (n % 6 == 0)
                    Console.WriteLine($"{n} кратно 2 и 3");
                else
                    Console.WriteLine($"{n} не соответствует требованию");
            }
        }
    }
}
