using System;
using System.Text;


namespace LAB_2_string{
	public class solve{
		static public void Main(){
			int n;
			Console.Write("Введите количество элементов массива: ");
			n = Convert.ToInt32(Console.ReadLine());

			StringBuilder tmp = Console.ReadLine();
			int it = 0;
			StringBuilder[] a = new StringBuilder[n];
			int it2 = 0;
			int last = 0;
			while (it++ < tmp.Length){
				if (tmp[it] == 0){
					a[it2++] = tmp.Substring(last, it);
					last = it;
				}
			}
			for(int i = 0; i < tmp.Length / 2; i++)
            {

            }
		}
	}
}