using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3OnClass
{
    class Student : IComparable<Student>
    {
        private int id;
        private string name;
        private double diem;

        public Student(int id, string name, double diem)
        {
            this.Id = id;
            this.Name = name;
            this.Diem = diem;
        }

        public Student()
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
            Console.WriteLine("ID: {0}", id);
            Console.WriteLine("Tên: {0}", name);
            Console.WriteLine("Điểm: {0}", diem);
            Console.WriteLine();
        }

        public int CompareTo(Student s)
        {
            return this.id.CompareTo(s.id);
        }

    }
    class Bai4
    {
        public static void Main4()
        {
            List<Student> ls = new List<Student>();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Có bao nhiêu học sinh? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                ls.Add(new Student());
                ls[i].Input();
            }
            Console.WriteLine("--------Danh sách ban đầu--------");

            for (int i = 0; i < n; i++)
            {
                ls[i].Show();
            }
            ls.Sort();
            Console.WriteLine();
            Console.WriteLine("--------Sắp xếp theo id--------");
            for (int i = 0; i < n; i++)
            {
                ls[i].Show();
            }
            Console.ReadKey();
        }
    }
}
