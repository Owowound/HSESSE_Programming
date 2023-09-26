using System;

namespace Seminar05
{
    class Program
    {
        static void Main(string[] args)
        {//Task02
            int ans1 = 0, ans2 = 0, ans3 = 0;
            string s;

            do
            {
                s = Console.ReadLine();
                if (int.TryParse(s, out int a))
                {
                    ans1++;
                    continue;
                }
                if (double.TryParse(s, out double b))
                {
                    ans2++;
                    continue;
                }
                ans3++;
            } while (s != "0" && s != "0");
            Console.WriteLine($"{ans1} {ans2} {ans3}");
            
        }
    }
}
