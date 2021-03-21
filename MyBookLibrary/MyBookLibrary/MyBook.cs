using System;
using System.Collections;
using System.Collections.Generic;

namespace MyBookLibrary
{
    class Book
    {
        private string id, name, publisher;
        private double price;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public double Price { get => price; set => price = value; }

        public Book(string id, string name, string publisher, double price)
        {
            this.Id = id;
            this.Name = name;
            this.Publisher = publisher;
            this.Price = price;
        }

        public Book()
        {
        }

        public Book(string id)
        {
            Id = id;
        }

        public void Show()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Publisher: " + Publisher);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("---------------------------");
        }
        public void Input()
        {
            Console.Write("ID: ");
            Id = Console.ReadLine();
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Publisher: ");
            Publisher = Console.ReadLine();
            Console.Write("Price: ");
            Price = double.Parse(Console.ReadLine());
        }

        public void Update()
        {
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Publisher: ");
            Publisher = Console.ReadLine();
            Console.Write("Price: ");
            Price = double.Parse(Console.ReadLine());
        }

    }

    class IDComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }


    public class MyBook
    {
        List<Book> list = new List<Book>();

        public void Add()
        {
            Book b = new Book();
            b.Input();
            list.Add(b);
            Console.WriteLine("Add success!");
        }



        public void Delete(string id)
        {
            list.Sort(new IDComparer());
            ArrayList arr = new ArrayList();
            foreach (Book book in list)
            {
                arr.Add(book.Id);
            }
            int i = arr.BinarySearch(id);
            if (i >= 0)
            {
                list.RemoveAt(i);
                Console.WriteLine("Delete success!");
            }
            else
            {
                Console.WriteLine("Not found!");
            }


        }

        public void Update(string id)
        {
            list.Sort(new IDComparer());
            ArrayList arr = new ArrayList();
            foreach (Book book in list)
            {
                arr.Add(book.Id);
            }
            int i = arr.BinarySearch(id);
            if (i >= 0)
            {
                list.RemoveAt(i);
                Book b = new Book(id);
                b.Update();
                list.Insert(i, b);
                Console.WriteLine("Update success!");
            }
            else
            {
                Console.WriteLine("Not found!");
            }
        }

        public void Show()
        {
            list.Sort(new IDComparer());
            foreach(Book b in list)
            {
                b.Show();
            }
        }


    }
}
