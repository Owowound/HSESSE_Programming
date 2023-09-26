using System;

namespace Task09
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            if (x <= 0 && y >= 0)
            {
                if (Math.Sqrt(x * x + y * y) <= 2)
                {
                    Console.WriteLine("В секторе");
                    return;
                }
                else
                {
                    Console.WriteLine("Не в секторе");
                    return;
                }
            }
            else{
                if (x <= y && x >= 0 && y >= 0)
                {
                    if (Math.Sqrt(x * x + y * y) <= 2)
                    {
                        Console.WriteLine("В секторе");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Не в секторе");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Не в секторе");
                    return;
                }
            }
        }
    }
}
