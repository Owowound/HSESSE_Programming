using System;

namespace Sem06_Task03
{
    class Program
    {
       static void Main()
        {
            for (int i = 1000; i <= 9999; i++)
            {
                string s = i.ToString();
                if (s[0] == s[1] || s[0] == s[2] || s[0] == s[3] || s[1] == s[2] || s[1] == s[3] || s[2] == s[3])
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
