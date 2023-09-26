using System;

namespace Sem06_Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool p = false, q = false;

            do
            {
                do
                {
                    Console.WriteLine($"q = {q}, p = {p}, F(q, p) = {!(q & p) & !(p | !q)}");
                    q = !q;
                } while (q != false);
                p = !p;
            } while (p != false);
        }
    }
}
