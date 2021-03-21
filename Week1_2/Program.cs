using System;

namespace Week1_2
{
    class Program
    {
        static void Main(string[] args)
        {
			Random r = new Random();
			int n, a;
			char c;
			do
			{
				n = r.Next(1, 100);
				//Console.WriteLine(n);5
				for (int i = 0; i < 7; i++)
				{
					Console.Write("Nhap so ban doan: ");
					a = Convert.ToInt32(Console.ReadLine());
					if (a == n)
					{
						Console.WriteLine("Dung roi!!!!!");
						break;
					}
					else if (a < n)
					{
						Console.WriteLine("So can tim lon hon so ban doan");
					}
					else
						Console.WriteLine("So can tim nho hon so ban doan");
				}
				Console.Write("Nhap y de tiep tuc, phim khac de thoat: ");
				c = Convert.ToChar(Console.ReadLine());
			} while (c == 'y');
		}
    }
}
