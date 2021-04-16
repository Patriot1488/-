using System;
//using System.Collections;

namespace LAB_1
{
    class Program
    {
        static public void Main()
        {
            Int64 a = 0, b = 0;
            string tmp = Console.ReadLine();
            for(int i = 0; i < tmp.Length; i ++)
            {
                if(tmp[i] == ' ')
                {
                    a = Convert.ToInt64(tmp.Substring(0,i + 1));
                    b = Convert.ToInt64(tmp.Substring(i + 1));
                }
            }
            int ans = 0;
            for(Int64 i = a; i <= b; i++)
            {
                Int64 c = i;
                while (c % 2 == 0) {
                    c /= 2;
                    ans++;
                }
            }
            Console.WriteLine(ans);

            
        }
    }
}

/*
3
7
4 2 0 1 3 3 7
5
2 2 8 6 9
1
0

1
7
4 2 0 1 3 3 7


*/
