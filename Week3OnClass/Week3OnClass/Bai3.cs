using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3OnClass
{
    class Bai3
    {
        public static void Main3()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string s;
            string[] ss;
            Console.Write("Nhập dãy số thứ nhất: ");
            s = Console.ReadLine();
            ss = s.Split(' ');
            List<int> ls = new List<int>();
            for (int i = 0; i < ss.Length; i++)
            {
                ls.Add(int.Parse(ss[i]));
            }
            Console.Write("Nhập dãy số thứ hai: ");
            s = Console.ReadLine();
            ss = s.Split(' ');
            List<int> ls2 = new List<int>();
            for (int i = 0; i < ss.Length; i++)
            {
                ls2.Add(int.Parse(ss[i]));
            }
            Console.Write("Kết quả: ");
            int size1 = ls.Count, size2 = ls2.Count;
            if (size1 > size2)
            {
                for (int i = 0; i < size2; i++)
                {
                    Console.Write(ls[i] + " " + ls2[i] + " ");
                }
                for (int i = size2; i < size1; i++)
                {
                    Console.Write(ls[i] + " ");
                }
            }
            else
            {
                for (int i = 0; i < size1; i++)
                {
                    Console.Write(ls[i] + " " + ls2[i] + " ");
                }
                for (int i = size1; i < size2; i++)
                {
                    Console.Write(ls2[i] + " ");
                }
            }
            Console.ReadKey();



        }
    }
}
