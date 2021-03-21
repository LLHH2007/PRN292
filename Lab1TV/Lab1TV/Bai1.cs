using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1TV
{
    class Student
    {
        private int SID;
        private string TenSV;
        private string Khoa;
        private double DiemTB;
        public Student()
        {
        }
        public Student(Student stu)
        {
            SID = stu.SID;
            TenSV = stu.TenSV;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }
        public Student(int id, string ten, string kh, double dtb)
        {
            SID = id;
            TenSV = ten;
            Khoa = kh;
            DiemTB = dtb;
        }
        public int StudentID 
        {
            get { return SID; } 
            set { SID = value; }
        }
        public String Name
        {
            get { return TenSV; }
            set { TenSV = value; }
        }
        public String Faculty
        {
            get { return Khoa; }
            set { Khoa = value; }
        }
        public double Mark
        {
            get { return DiemTB; }
            set { DiemTB = value; }
        }

        public void Show()
        {
            Console.WriteLine("MSSV: {0}", this.SID);
            Console.WriteLine("Ten SV: {0}", this.TenSV);
            Console.WriteLine("Khoa: {0}", this.Khoa);
            Console.WriteLine("Diem TB: {0}", this.DiemTB);
            Console.WriteLine();
        }
    }
    class Bai1
    {
        public static void Main1()
        {
            Student[] DSSV;
            int n;
            Console.Write("Nhap so luong SV: ");
            n = int.Parse(Console.ReadLine());
            DSSV = new Student[n];
            Console.WriteLine("\n ====NHAP DS SINH VIEN====");
            for (int i = 0; i < n; i++)
            {
                DSSV[i] = new Student();
                Console.Write("Nhap MaSV {0}: ", i + 1);
                DSSV[i].StudentID = int.Parse(Console.ReadLine());
                Console.Write("Ho ten SV: ");
                DSSV[i].Name = Console.ReadLine();
                Console.Write("Nhap khoa: ");
                DSSV[i].Faculty = Console.ReadLine();
                Console.Write("Nhap Diem TB: ");
                DSSV[i].Mark = double.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            foreach (Student sv in DSSV)
                sv.Show();
            Console.ReadLine();

        }
    }
}