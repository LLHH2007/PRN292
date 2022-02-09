/* Assignment 1                                                                 */
/* Course:                Fall 2020 - SE.1401                                                */
/* Family Name:           Student                                               */
/* Given Name:            Huynh Long                                                  */
/* Student Number:        DE140069                                           */
/* Due Date:              Sep 24, 2020                                     */
/*                                                                              */
/* I declare that the attached assignment is my own work in accordance with     */
/* FPT UniversityPolicy.  No part of this assignment has been copied manually */
/* or electronically from any other source (including web sites) or distributed */
/* to other students*/




using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    abstract class Shape
    {
        public int z { get; set; }
        public int y { get; set; }

        public Shape()
        {
        }

        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }



        public virtual void Move()
        {
        }

        public abstract void Input();

        public abstract void Show();


    }

    class lines : Shape
    {
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
            Console.WriteLine("Input information for a line");
            Console.WriteLine("First point: ");
            Console.Write("x = ");
            x = Convert.ToInt32(Console.ReadLine());
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
            Console.WriteLine("Length = " + (double)Math.Sqrt(Math.Pow(x - x2, 2) + Math.Pow(y - y2, 2)));
        }

        public override void Move()
        {
            Console.WriteLine("Moving");
            Console.Write("Move x = ");
            int mx = Convert.ToInt32(Console.ReadLine());
            Console.Write("Move y = ");
            int my = Convert.ToInt32(Console.ReadLine());
            x += mx;
            y += my;
            x2 += mx;
            y2 += my;
            Console.WriteLine("After moving");
            Console.WriteLine("First point: x = {0}, y= {1}", x, y);
            Console.WriteLine("Second point: x = {0}, y= {1}", x2, y2);
        }

        public override string ToString()
        {
            return "A line with first point (" + x + "," + y + "), second point (" + x2 + "," + y2 + ")";
        }

    }


    class circles : Shape
    {
        public int r { get; set; }

        public circles()
        {

        }

        public circles(int x, int y, int r) : base(x, y)
        {
            this.r = r;
        }

        public override void Input()
        {
            Console.WriteLine("Input information for a circle");
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

        public override string ToString()
        {
            return "A circle with center point (" + x + "," + y + "), radius r = " + r;
        }

        public override void Move()
        {
            Console.WriteLine("Moving");
            Console.Write("Move x = ");
            int mx = Convert.ToInt32(Console.ReadLine());
            Console.Write("Move y = ");
            int my = Convert.ToInt32(Console.ReadLine());
            x += mx;
            y += my;
            Console.WriteLine("After moving");
            Console.WriteLine("Center point: x = {0}, y= {1}", x, y);
        }

    }


    class rectangles : Shape
    {
        public int x2 { get; set; }
        public int y2 { get; set; }
        public int x3 { get; set; }
        public int y3 { get; set; }

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
            Console.WriteLine("Input information for a rectangle");
            Console.WriteLine("First point: ");
            Console.Write("x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second point:");
            Console.Write("x = ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x = ");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Third point:");
            Console.Write("x = ");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x = ");
            y3 = Convert.ToInt32(Console.ReadLine());
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

        public override string ToString()
        {
            return "A rectangle with first point (" + x + "," + y + "), second point (" + x2 + "," + y2 + "), third point (" + x3 + "," + y3 + ")";
        }

        public override void Move()
        {
            Console.WriteLine("Moving");
            Console.Write("Move x = ");
            int mx = Convert.ToInt32(Console.ReadLine());
            Console.Write("Move y = ");
            int my = Convert.ToInt32(Console.ReadLine());
            x += mx;
            y += my;
            x2 += mx;
            y2 += my;
            x3 += mx;
            y3 += my;
            Console.WriteLine("After moving");
            Console.WriteLine("First point: x = {0}, y= {1}", x, y);
            Console.WriteLine("Second point: x = {0}, y= {1}", x2, y2);
            Console.WriteLine("Third point: x = {0}, y= {1}", x3, y3);
        }
    }

    class PolygonWith3Lines : Shape
    {
        public int x2 { get; set; }
        public int y2 { get; set; }
        public int x3 { get; set; }
        public int y3 { get; set; }
        public int x4 { get; set; }
        public int y4 { get; set; }

        public PolygonWith3Lines()
        {

        }

        public PolygonWith3Lines(int x, int y, int x2, int y2, int x3, int y3, int x4, int y4) : base(x, y)
        {
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;
        }

        public override void Input()
        {
            Console.WriteLine("Input information for a rectangle");
            Console.WriteLine("First point: ");
            Console.Write("x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second point:");
            Console.Write("x = ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x = ");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Third point:");
            Console.Write("x = ");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x = ");
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fourth point:");
            Console.Write("x = ");
            x4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x = ");
            y4 = Convert.ToInt32(Console.ReadLine());
        }


        public override void Show()
        {
            Console.WriteLine("A polyline with 3 lines");
            Console.WriteLine("First point: x = {0}, y= {1}", x, y);
            Console.WriteLine("Second point: x = {0}, y= {1}", x2, y2);
            Console.WriteLine("Third point: x = {0}, y= {1}", x3, y3);
            Console.WriteLine("Fourth point: x = {0}, y= {1}", x4, y4);
        }

        public override string ToString()
        {
            return "A polyline with 3 lines with first point (" + x + "," + y + "), second point (" + x2 + "," + y2 + "),third point (" + x3 + "," + y3 + "), fourth point (" + x3 + "," + y3 + ")";
        }

        public override void Move()
        {
            Console.WriteLine("Moving");
            Console.Write("Move x = ");
            int mx = Convert.ToInt32(Console.ReadLine());
            Console.Write("Move y = ");
            int my = Convert.ToInt32(Console.ReadLine());
            x += mx;
            y += my;
            x2 += mx;
            y2 += my;
            x3 += mx;
            y3 += my;
            x4 += mx;
            y4 += my;
            Console.WriteLine("After moving");
            Console.WriteLine("First point: x = {0}, y= {1}", x, y);
            Console.WriteLine("Second point: x = {0}, y= {1}", x2, y2);
            Console.WriteLine("Third point: x = {0}, y= {1}", x3, y3);
            Console.WriteLine("Fourth point: x = {0}, y= {1}", x4, y4);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            /*lines l = new lines();
            l.Input();
            l.Show();
            l.ToString();
            l.Move();
            Console.WriteLine(l.ToString());
            circles c = new circles();
            c.Input();
            c.Show();
            c.ToString();
            c.Move();*/
            rectangles r = new rectangles();
            r.Input();
            r.Show();
            r.ToString();
            r.Move();
            /*PolygonWith3Lines p = new PolygonWith3Lines();
            p.Input();
            p.Show();
            p.Move();
            p.ToString();*/
            Console.ReadKey();
        }
    }
}
