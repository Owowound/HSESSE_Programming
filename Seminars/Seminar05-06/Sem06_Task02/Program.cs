using System;

namespace Sem06_Task02
{
    class Program
    {
        static char L(bool x)
        {
            if (x == true)
                return '1';
            else
                return '0';
        }
        static void Main(string[] args)
        {
            bool A = false, B = false, C = false;
            Console.WriteLine("A B C F");
            do
            {
                do
                {
                    do
                    {
                        bool F = !(A | B & C) | A;
                        Console.WriteLine($"{L(A)} {L(B)} {L(C)} {L(F)}");
                        C = !C;
                    } while (C != false);
                    B = !B;
                } while (B != false);
                A = !A;
            } while (A != false);
        }
    }
}
