using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBookLibrary;

namespace TestMyBookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int choose;
            MyBook Book = new MyBook();
            Console.WriteLine("----------Menu----------");
            Console.WriteLine("1. Add new Book");
            Console.WriteLine("2. Update a Book");
            Console.WriteLine("3. Delete a Book");
            Console.WriteLine("4.List all Book");
            Console.WriteLine("5. Quit");
            Console.WriteLine("------------------------");

            do
            {
                Console.Write("Please enter your choice: ");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Book.Add();
                        break;
                    case 2:
                        Console.Write("Input ID to update: ");
                        string idUpdate = Console.ReadLine();
                        Book.Update(idUpdate);
                        break;
                    case 3:
                        Console.Write("Input ID to delete: ");
                        string idDelete = Console.ReadLine();
                        Console.Write("Do you really want to delete (Yes/No)?  ");
                        if (Console.ReadLine().ToUpper().Equals("YES"))
                        {
                            Book.Delete(idDelete);
                        }
                        break;
                    case 4:
                        Book.Show();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Please enter number in range 1-5");
                        break;
                }
            } while (choose != 5);
        }
        
    }
}
