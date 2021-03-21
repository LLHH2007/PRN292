using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1TV
{

    class Student2
    {
        private int id;
        private string ten;
        private string khoa;
        private double diemTB;
        public Student2()
        {
        }

        public void SetId(int id)
        {
            this.id = id;
        }
        public void SetTen(String ten)
        {
            this.ten = ten;
        }
        public void SetKhoa(String khoa)
        {
            this.khoa = khoa;
        }
        public void SetDiemTB(double diemTB)
        {
            this.diemTB = diemTB;
        }

        public int GetId()
        {
            return this.id;
        }

        public String GetTen()
        {
            return this.ten;
        }

        public String GetKhoa()
        {
            return this.khoa;
        }

        public double GetDiemTB()
        {
            return this.diemTB;
        }

        public Student2(int id, string ten, string khoa, double diemTB)
        {
            this.id = id;
            this.ten = ten;
            this.khoa = khoa;
            this.diemTB = diemTB;
        }

        public void Show()
        {
            Console.WriteLine("MSSV: {0}", this.id);
            Console.WriteLine("Ten SV: {0}", this.ten);
            Console.WriteLine("Khoa: {0}", this.khoa);
            Console.WriteLine("Diem TB: {0}", this.diemTB);
            Console.WriteLine();
        }

        public void Input()
        {
            Console.Write("Nhap MSSV: ");
            this.id = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten SV: ");
            this.ten = Console.ReadLine();
            Console.Write("Nhap khoa: ");
            this.khoa = Console.ReadLine();
            Console.Write("Nhap diem TB: ");
            this.diemTB = double.Parse(Console.ReadLine());
            Console.WriteLine();
        }
    }

    class Students
    {
        private int n1;

        public int GetN()
        {
            return n1;
        }

        public void SetN(int value)
        {
            n1 = value;
        }

        private Student2[] ss1;

        public Student2[] GetSs()
        {
            return ss1;
        }

        public void SetSs(Student2[] value)
        {
            ss1 = value;
        }

        public Students(int n)
        {
            this.SetN(n);
            SetSs(new Student2[n]);
        }

        public void NhapDS()
        {
            Console.WriteLine("======Nhap danh sach sinh vien=======");
            for (int i = 0; i < GetN(); i++)
            {
                Console.WriteLine("Nhap thong tin cho sinh vien thu {0}", i + 1);
                ss1[i] = new Student2();
                ss1[i].Input();
            }
        }

        public void XuatDS()
        {
            Console.WriteLine("======Danh sach sinh vien=======");
            for (int i = 0; i < GetN(); i++)
            {
                ss1[i].Show();
            }
        }


    }
    class Bai2
    {
        public static void Main2()
        {
            Console.Write("So luong sinh vien: ");
            Students ss = new Students(int.Parse(Console.ReadLine()));
            ss.NhapDS();
            ss.XuatDS();
            Console.ReadKey();
        }
    }
}
