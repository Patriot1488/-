using System;
using System.Text;

namespace LAB_2_2
{
    class Program
    {
        static void Main()
        {
            string tmp2;
            tmp2 = Console.ReadLine();
            var rand = new Random();
            StringBuilder tmp = new StringBuilder();
            tmp.Append(tmp2);
            for(int i = 0; i < tmp.Length; i++)
            {
                char T;
                int x = rand.Next();
                x = x % tmp.Length;
                T = tmp[x];
                tmp[x] = tmp[i];
                tmp[i] = T;
            }
            Console.WriteLine(tmp);
        }
    }
}
