using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace testBug
{
    abstract class Shape
    {
        public int x { get; set; }
        public int y { get; set; }
        public Shape()
        {
        }

        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //public int x { get; set; }
        //{
        //  get { return x; }
        //set { x = value; }
        //}

        /*
        public int y
        {
            get { return y; }
            set { y = value; }
        }

        */

        public void Move(int m, int n)
        {
            x += m;
            y += n;
        }

        public abstract void Input();

        public abstract void Show();


    }

    class lines : Shape
    {
        /*
        public int x2
        {
            get { return x2; }
            set { x2 = value; }
        }

        public int y2
        {
            get { return y2; }
            set { y2 = value; }
        }
        */
        public int x2 { get; set; }
        public int y2 { get; set; }

        public lines()
        {

        }

        public lines(int x, int y, int x2, int y2) : base(x, y)
        {
            this.x2 = x2;
            this.y2 = y2;
        }

        public override void Input()
        {
            Console.WriteLine("First point: ");
            Console.Write("x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x);
            Console.Write("y = ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second point:");
            Console.Write("x = ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x = ");
            y2 = Convert.ToInt32(Console.ReadLine());
        }


        public override void Show()
        {
            Console.WriteLine("A line");
            Console.WriteLine("First point: x = {0}, y= {1}", x, y);
            Console.WriteLine("Second point: x = {0}, y= {1}", x2, y2);
            //Console.WriteLine("{0} {1} {2} {3}", x, y, x2, y2);
            Console.WriteLine("Length = {0}", (double)Math.Sqrt(Math.Pow(x - x2, 2) + Math.Pow(y - y2, 2)));
        }


    }


    class circles : Shape
    {
        public int r
        {
            get { return r; }
            set { if (r > 0) r = value; }
        }

        public circles()
        {

        }

        public circles(int x, int y, int r) : base(x, y)
        {
            this.r = r;
        }

        public override void Input()
        {
            Console.WriteLine("Center point: ");
            Console.Write("x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Radius r = ");
            r = Convert.ToInt32(Console.ReadLine());
        }


        public override void Show()
        {
            Console.WriteLine("A circle");
            Console.WriteLine("Center point: x = {0}, y= {1}", x, y);
            Console.WriteLine("Radius: r = {0}", r);
            Console.WriteLine("Perimeter = " + (double)(2 * r * 3.14));
            Console.WriteLine("Area = " + (double)(Math.Pow(r, 2) * 3.14));
        }


    }


    class rectangles : Shape
    {
        public int x2
        {
            get { return x2; }
            set { x2 = value; }
        }

        public int y2
        {
            get { return y2; }
            set { y2 = value; }
        }

        public int x3
        {
            get { return x3; }
            set { x3 = value; }
        }

        public int y3
        {
            get { return y3; }
            set { y3 = value; }
        }

        public rectangles()
        {

        }

        public rectangles(int x, int y, int x2, int y2, int x3, int y3) : base(x, y)
        {
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }

        public override void Input()
        {
            Console.WriteLine("First point: ");
            Console.Write("x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second point:");
            Console.Write("x = ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x = ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Third point:");
            Console.Write("x = ");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x = ");
            x3 = Convert.ToInt32(Console.ReadLine());
        }


        public override void Show()
        {
            Console.WriteLine("A line");
            Console.WriteLine("First point: x = {0}, y= {1}", x, y);
            Console.WriteLine("Second point: x = {0}, y= {1}", x2, y2);
            Console.WriteLine("Third point: x = {0}, y= {1}", x3, y3);
            double a, b, c, p;
            a = Math.Sqrt(Math.Pow(x - x2, 2) + Math.Pow(y - y2, 2));
            b = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            c = Math.Sqrt(Math.Pow(x - x3, 2) + Math.Pow(y - y3, 2));
            p = (a + b + c) / 2;
            Console.WriteLine("Perimeter = " + (double)(a + b + c));
            Console.WriteLine("Area = " + (double)(Math.Sqrt(p * (p - a) * (p - b) * (p - c))));
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            lines l = new lines();
            l.Input();
            l.Show();
            Console.WriteLine(l.ToString());
            //Console.ReadKey();
        }
    }
}
