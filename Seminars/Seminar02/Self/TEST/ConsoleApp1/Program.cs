using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        { ///Sem05_task02
            string a;
            int t1;
            double t2;
            int a1 = 0, a2 = 0, a3 = 0;

            do
            {
                a = Console.ReadLine();
                
                if (double.TryParse(a, out t2))
                {
                    //Console.WriteLine(a);
                    if (int.TryParse(a, out t1))
                    {
                        //Console.WriteLine(a);
                        a1++;
                    }
                    else
                    {
                        //Console.WriteLine(a);
                        a2++;
                    }
                }
                else
                {
                    a3++;
                }
            } while (a != "0" && a != "-0");

            Console.WriteLine($"{a1} {a2} {a3}");


        }
    }
}
