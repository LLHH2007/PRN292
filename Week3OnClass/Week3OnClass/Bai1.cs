using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3OnClass
{
    class Bai1
    {
        static void Main1()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập dãy số: ");
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            List<int> ls = new List<int>();
            List<int> ls2 = new List<int>();
            for (int i = 0; i< ss.Length; i++)
            {
                ls.Add(int.Parse(ss[i]));
            }
            int count;

            do
            {
                count = 0;
                int i = 0;
                for (i = 0; i < ls.Count - 1; i++)
                {
                    if (ls[i] == ls[i + 1])
                    {
                        ls2.Add(ls[i] + ls[i + 1]);
                        i++;
                        count++;
                    }
                    else
                        ls2.Add(ls[i]);
                }
                if (i == ls.Count-1)
                    ls2.Add(ls[i]);
                ls.Clear();
                for (i = 0; i < ls2.Count; i++)
                {
                    ls.Add(ls2[i]);
                }
                ls2.Clear();
            } while (count > 0);

            Console.Write("Kết quả: ");
            for (int i = 0; i < ls.Count; i++)
            {
                Console.Write(ls[i] + "  ");
            }


            Console.ReadKey();

        }
    }
}
