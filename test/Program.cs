using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        delegate void Display();
        static void Main()
        {
            Display d1 = new Display(DisplayHello);
            d1();
        }
        static void DisplayHello()
        {
            Console.WriteLine("Hello");
            Console.ReadKey();
        }
    }
}
