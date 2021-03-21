using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3OnClass
{
    class Bai2
    {
        public static void Main2()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập dãy số: ");
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            List<int> ls = new List<int>();
            Console.Write("Kết quả: ");
            int i;
            for (i = 0; i < ss.Length; i++)
            {
                ls.Add(int.Parse(ss[i]));
            }
            int size = ls.Count();
            if (size % 2 == 0)
            {
                for (i = 0; i < size / 2; i++)
                    Console.Write(ls[i] + ls[size - 1 - i]+" ");
            }
            else
            {
                for (i = 0; i < size / 2; i++)
                    Console.Write(ls[i] + ls[size - 1 - i]+" ");
                Console.Write(ls[i]);
            }
            Console.ReadKey();

        }
    }
}
