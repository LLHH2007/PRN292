using Lab1TV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1TV
{
    abstract class VienKhoaHoc
    {
        private String ten, bangCap;
        int namSinh;

        public string Ten { get => ten; set => ten = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public string BangCap { get => bangCap; set => bangCap = value; }

        protected VienKhoaHoc(string ten, int namSinh, string bangCap)
        {
            Ten = ten;
            NamSinh = namSinh;
            BangCap = bangCap;
        }

        protected VienKhoaHoc()
        {

        }

        public abstract void Input();

        public abstract void Show();
        public abstract double Luong();
    }
    class QuanLy : VienKhoaHoc
    {
        private string chucVu;
        private int soNgayCong;
        private double bacLuong;

        public string ChucVu { get => chucVu; set => chucVu = value; }
        public int SoNgayCong { get => soNgayCong; set => soNgayCong = value; }
        public double BacLuong { get => bacLuong; set => bacLuong = value; }

        public QuanLy(string ten, int namSinh, string bangCap, String chucVu, int soNgayCong, double bacLuong) : base(ten, namSinh,bangCap)
        {
            ChucVu = chucVu;
            SoNgayCong = soNgayCong;
            BacLuong = bacLuong;
        }

        public QuanLy() 
        { 

        }


        public override void Input()
        {
            Console.Write("Nhap Ho va Ten: ");
            this.Ten = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            this.NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap bang cap: ");
            this.BangCap = Console.ReadLine();
            Console.Write("Nhap chuc vu: ");
            this.chucVu = Console.ReadLine();
            Console.Write("Nhap so ngay cong: ");
            this.soNgayCong = int.Parse(Console.ReadLine());
            Console.Write("Nhap bac luong: ");
            this.bacLuong = double.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public override void Show()
        {
            Console.WriteLine("Ho va ten: {0}", Ten);
            Console.WriteLine("Nam sinh: {0}", NamSinh);
            Console.WriteLine("Bang cap: {0}", BangCap);
            Console.WriteLine("Chuc vu: {0}", ChucVu);
            Console.WriteLine("So ngay cong: {0}", SoNgayCong);
            Console.WriteLine("Bac luong: {0}", BacLuong);
            Console.WriteLine("Tong luong: {0}", Luong());
            Console.WriteLine();
        }

        public override double Luong()
        {
            return this.bacLuong * this.soNgayCong;
        }


    }

    class NhaKhoaHoc : QuanLy
    {
        int soBaiBao;

        public int SoBaiBao { get => soBaiBao; set => soBaiBao = value; }

        public NhaKhoaHoc(string ten, int namSinh, string bangCap, String chucVu, int soNgayCong, double bacLuong,int soBaiBao):base(ten,namSinh,bangCap,chucVu,soNgayCong,bacLuong)
        {
            SoBaiBao = soBaiBao;
        }

        public NhaKhoaHoc()
        {

        }

        public override void Input()
        {
            Console.Write("Nhap Ho va Ten: ");
            this.Ten = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            this.NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap bang cap: ");
            this.BangCap = Console.ReadLine();
            Console.Write("Nhap chuc vu: ");
            this.ChucVu = Console.ReadLine();
            Console.Write("Nhap so ngay cong: ");
            this.SoNgayCong = int.Parse(Console.ReadLine());
            Console.Write("Nhap bac luong: ");
            this.BacLuong = double.Parse(Console.ReadLine());
            Console.Write("Nhap so bai bao da cong bo: ");
            this.SoBaiBao = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public override void Show()
        {
            Console.WriteLine("Ho va ten: {0}", Ten);
            Console.WriteLine("Nam sinh: {0}", NamSinh);
            Console.WriteLine("Bang cap: {0}", BangCap);
            Console.WriteLine("Chuc vu: {0}", ChucVu);
            Console.WriteLine("So ngay cong: {0}", SoNgayCong);
            Console.WriteLine("Bac luong: {0}", BacLuong);
            Console.WriteLine("Tong luong: {0}", Luong());
            Console.WriteLine("So bai bao da cong bo: {0}", SoBaiBao);
            Console.WriteLine();
        }


    }

    class NVPhongThiNghiem : VienKhoaHoc
    {
        private double luong;

        public NVPhongThiNghiem(string ten, int namSinh, string bangCap, double luong) : base(ten, namSinh, bangCap)
        { 
            this.luong = luong;
        }

        public NVPhongThiNghiem()
        {

        }

        public override void Input()
        {
            Console.Write("Nhap Ho va Ten: ");
            this.Ten = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            this.NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap bang cap: ");
            this.BangCap = Console.ReadLine();
            Console.Write("Nhap luong thang: ");
            this.luong = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public override void Show()
        {
            Console.WriteLine("Ho va ten: {0}", Ten);
            Console.WriteLine("Nam sinh: {0}", NamSinh);
            Console.WriteLine("Bang cap: {0}", BangCap);
            Console.WriteLine("Luong: {0}", luong);
            Console.WriteLine();
        }

        public override double Luong()
        {
            return this.luong;
        }
    }

    class Bai4
    {
        public static void Main()
        {
            Console.Write("Vien khoa hoc co bao nhieu nguoi? ");
            int n = int.Parse(Console.ReadLine());   
            VienKhoaHoc[] v = new VienKhoaHoc[n];
            double luongNhaKH=0, luongQL=0, luongNV=0;
            string s;
            for(int i = 0; i < n; i++)
            {
                Console.Write("Ban muon nhap thong tin cho (NKH,QL,NV): ");
                s = Console.ReadLine().ToUpper();
                switch (s)
                {
                    case "NKH":
                        v[i] = new NhaKhoaHoc();
                        v[i].Input();
                        luongNhaKH += v[i].Luong();
                        break;
                    case "QL":
                        v[i] = new QuanLy();
                        v[i].Input();
                        luongQL += v[i].Luong();
                        break;
                    default:
                        v[i] = new NVPhongThiNghiem();
                        v[i].Input();
                        luongNV += v[i].Luong();
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Danh sach nhan vien cua phong thi nghiem");
            for (int i = 0; i < n; i++)
            {
                v[i].Show();
                Console.WriteLine();
            }
                
            Console.WriteLine("Tong luong cac nha khoa hoc: {0}", luongNhaKH);
            Console.WriteLine("Tong luong cac nha quan ly: {0}", luongQL);
            Console.WriteLine("Tong luong cac nhan vien phong thi nghiem: {0}", luongNV);
            Console.ReadKey();
        }
    }
}
