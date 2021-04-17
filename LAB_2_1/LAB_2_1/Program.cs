using System;

namespace LAB_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string tmp;
            tmp = Console.ReadLine();
            Int64 a = 0, b = 0;
            for(int i = 0; i < tmp.Length; i++)
            {
                if(tmp[i] == ' ')
                {
                    a = Convert.ToInt64(tmp.Substring(0,i));
                    b = Convert.ToInt64(tmp.Substring(i));
                }
            }

            int ans = 0;
            for(Int64 i = a; i <= b; i++)
            {
                Int64 T = i;
                while (T % 2 == 0) {
                    T /= 2;
                    ans++;
                }
            }

            Console.WriteLine(ans);

        }
    }
}
