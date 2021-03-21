using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4OnClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input string: ");
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            Dictionary<string,int> d = new Dictionary<string,int>();
            for(int i = 0; i < ss.Length; i++)
            {
                if (d.ContainsKey(ss[i]))
                    d[ss[i]]++;
                else d.Add(ss[i], 1);
            }

            foreach(var item in d)
            {
                Console.WriteLine("Key: {0}, value: {1}", item.Key, item.Value);
            }
            Console.ReadKey();
        }
    }
}
