using System;
using System.Text;

namespace LAB_2_2
{
    class Program
    {
        static void Main()
        {

            string tmp;
            tmp = Console.ReadLine();
            int poz = 0, id = 0;
            StringBuilder[] a = new StringBuilder[1488];
            for(int i = 0; i < 1488; i++)
            {
                a[i] = new StringBuilder();
            }

            tmp += ' ';
            for(int i = 0; i < tmp.Length; i++)
            {
                if(tmp[i] == ' ')
                {
                    string tmp2;
                    tmp2 = tmp.Substring(poz, i - poz);

                    a[id].Append(tmp2);
                    id++;
                    
                    poz = i + 1;
                }
            }

            for (int i = 0; i < id / 2; i++)
            {
                StringBuilder T = new StringBuilder();
                T.Append(a[i]);
                a[i].Clear();
                a[i].Append(a[id - 1 - i]);
                a[id - 1 - i].Clear();
                a[id - 1 - i].Append(T);
            }

            for (int i = 0; i < id; i++)
            {
                Console.Write(a[i]);
                Console.Write(' ');

            }
        }
    }
}
