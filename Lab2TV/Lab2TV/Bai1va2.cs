using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab2TV
{
    interface IBook
    {
        string this[int index]
        {
            get;
            set;
        }

        string Title
        {
            get;
            set;
        }

        string Author
        {
            get;
            set;
        }

        string Publisher
        {
            get;
            set;
        }

        string ISBN
        {
            get;
            set;
        }

        int Year
        {
            get;
            set;
        }

        void Show();

    }

    class Book : IBook,IComparable<Book>
    {

        #region định nghĩa dữ liệu
        private string isbn, title, author, publisher;
        private int year;
        private ArrayList chapter = new ArrayList();
        #endregion

        #region Thực thi giao diện IBook
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < chapter.Count)
                    return (String)chapter[index];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < chapter.Count)
                    chapter[index] = value;
                else if (index == chapter.Count)
                    chapter.Add(value);
                else
                    throw new IndexOutOfRangeException();
            }
        }

        

        public int Year
        {
            get
            {
                if (year > 0)
                    return year;
                else
                    throw new Exception();
            }
            set
            {
                if (year > 0)
                    year = value;
                else
                    throw new Exception();
            }
        }

        public string ISBN { get => isbn; set => isbn = value; }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }

        public void Show()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Publisher: " + Publisher);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Chapter: ");
            for (int i = 0; i < chapter.Count; i++)
                Console.WriteLine("\t{0}: {1}", i + 1, chapter[i]);
            Console.WriteLine("---------------------------");
        }
        #endregion

        public void Input()
        {
            Console.Write("Title: ");
            Title = Console.ReadLine();
            Console.Write("Author: ");
            Author = Console.ReadLine();
            Console.Write("Publisher: ");
            Publisher = Console.ReadLine();
            Console.Write("Year: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("ISBN: ");
            ISBN = Console.ReadLine();
            Console.WriteLine("Input chapter (finished with empty string) ");
            string str;
            do
            {
                str = Console.ReadLine();
                if (str.Length > 0)
                {
                    chapter.Add(str);
                }
            } while (str.Length > 0);
        }

        public int CompareTo(Book other)
        {
            return this.title.CompareTo(other.title);
        }

    }

    class TitleComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Title.CompareTo(y.Title);
        }
    }

    class AuthorComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Author.CompareTo(y.Author);
        }
    }

    class PublisherComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Publisher.CompareTo(y.Publisher);
        }
    }

    class YearComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Year.CompareTo(y.Year);
        }
    }

    class ISBNComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.ISBN.CompareTo(y.ISBN);
        }
    }



    class BookList
    {
        private List<Book> list = new List<Book>();

        public void AddBook()
        {
            Book b = new Book();
            b.Input();
            list.Add(b);
        }

        public void ShowList()
        {
            foreach (Book b in list)
                b.Show();
        }

        public void InputList()
        {
            int n;
            Console.Write("Amount of books: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                AddBook();
                n--;
            }
        }

        public void ShowSort()
        {
            Console.WriteLine("Original list");
            ShowList();
            Console.WriteLine("Sort by Title (use IComparable)");
            list.Sort();
            ShowList();
            Console.WriteLine("Sort use IComparer");
            Console.WriteLine("Sort by Title");
            list.Sort(new TitleComparer());
            ShowList();
            Console.WriteLine("Sort by Author");
            list.Sort(new AuthorComparer());
            ShowList();
            Console.WriteLine("Sort by Publisher");
            list.Sort(new PublisherComparer());
            ShowList();
            Console.WriteLine("Sort by ISBN");
            list.Sort(new ISBNComparer());
            ShowList();
            Console.WriteLine("Sort by year");
            list.Sort(new YearComparer());
            ShowList();
        }
    }
    class Bai1va2
    {
        static void Main1(string[] args)
        {
            BookList bl = new BookList();
            bl.InputList();
            bl.ShowSort();
            Console.ReadKey();
        }
    }
}
