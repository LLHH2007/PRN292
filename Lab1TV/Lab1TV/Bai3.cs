using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1TV
{
    abstract class People
    {
        private string ten;

        protected People()
        {

        }
        protected People(string ten)
        {
            this.ten = ten;
        }

        public string Ten { get => ten; set => ten = value; }

        public abstract void Show();
    }

    class Student3 : People
    {
        private int id;
        private string khoa;
        private double diemTB;

        public int Id { get => id; set => id = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public double DiemTB { get => diemTB; set => diemTB = value; }

        public Student3(int id, string ten, string khoa, double diemTB) :base(ten)
        {
            this.id = id;
            this.khoa = khoa;
            this.diemTB = diemTB;
        }

        public Student3()
        {

        }

        override
        public void Show()
        {
            Console.WriteLine("MSSV: {0}", this.id);
            Console.WriteLine("Ten SV: {0}", this.Ten);
            Console.WriteLine("Khoa: {0}", this.khoa);
            Console.WriteLine("Diem TB: {0}", this.diemTB);
            Console.WriteLine();
        }

        public Student3 Input()
        {
            Console.Write("Nhap MSSV: ");
            this.id = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten SV: ");
            this.Ten = Console.ReadLine();
            Console.Write("Nhap khoa: ");
            this.khoa = Console.ReadLine();
            Console.Write("Nhap diem TB: ");
            this.diemTB = double.Parse(Console.ReadLine());
            Console.WriteLine();
            return this;
        }
    }
    class Bai3
    {
        public static void Main3()
        {
            List<Student3> ls = new List<Student3>();
            ArrayList arr = new ArrayList();
            Console.Write("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap danh sach sinh vien");
            for(int i = 0; i< n; i++)
            {
                Console.WriteLine("Sinh vien {0}",i+1);
                Student3 s = new Student3().Input();
                ls.Add(s);
                arr.Add(s);
                Console.WriteLine();
            }

            Console.WriteLine("Thong tin toan bo sinh vien (dung List)");
            foreach (Student3 s in ls)
            {
                s.Show();
            }
            Console.WriteLine("Thong tin toan bo sinh vien (dung ArrayList)");

            foreach(Student3 s in arr)
            {
                s.Show();
            }
            Console.ReadKey();
        }
    }
}
