using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3OnClass
{
    class student2
    {
        private int id;
        private string name;
        private double diem;

        public student2(int id, string name, double diem)
        {
            this.Id = id;
            this.Name = name;
            this.Diem = diem;
        }

        public student2()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Diem { get => diem; set => diem = value; }

        public void Input()
        {
            Console.Write("Nhập ID: ");
            this.id = int.Parse(Console.ReadLine());
            Console.Write("Nhập tên: ");
            this.name = Console.ReadLine();
            Console.Write("Nhập điểm: ");
            this.diem = double.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public void Show()
        {
            Console.WriteLine("ID: {0}",id);
            Console.WriteLine("Tên: {0}",name);
            Console.WriteLine("Điểm: {0}", diem);
            Console.WriteLine();
        }
    }

    class SortID: IComparer<student2>
    {
        public int Compare(student2 x, student2 y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }

    class SortName : IComparer<student2>
    {
        public int Compare(student2 x, student2 y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    class SortDiem : IComparer<student2>
    {
        public int Compare(student2 x, student2 y)
        {
            return x.Diem.CompareTo(y.Diem);
        }
    }

    class Bai5
    {
        public static void Main()
        {
            List<student2> ls = new List<student2>();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Có bao nhiêu học sinh? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                ls.Add(new student2());
                ls[i].Input();
            }
            Console.WriteLine("--------Danh sách ban đầu--------");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                ls[i].Show();
            }

            ls.Sort(new SortID());
            Console.WriteLine();
            Console.WriteLine("--------Sắp xếp theo id--------");
            for (int i = 0; i < n; i++)
            {
                ls[i].Show();
            }

            ls.Sort(new SortName());
            Console.WriteLine("--------Sắp xếp theo tên--------");
            for (int i = 0; i < n; i++)
            {
                ls[i].Show();
            }

            ls.Sort(new SortDiem());
            Console.WriteLine("--------Sắp xếp theo điểm--------");
            for (int i = 0; i < n; i++)
            {
                ls[i].Show();
            }
            Console.ReadKey();
        }
    }
}
