using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2TV
{
    class Account
    {

        #region định nghĩa dữ liệu
        private string id, fName, lName;
        private double balance;

        public Account()
        {
        }

        public Account(string id, string fName, string lName, double balance)
        {
            Balance = balance;
            Id = id;
            FName = fName;
            LName = lName;
        }
        #endregion

        public double Balance
        {
            get
            {
                if (balance >= 0)
                    return balance;
                else
                    throw new Exception();
            }
            set
            {
                if (balance >= 0)
                    balance = value;
                else
                    throw new Exception();
            }
        }

        public string Id { get => id; set => id = value; }
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }

        public void Show()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("First Name: " + FName);
            Console.WriteLine("Last Name: " + LName);
            Console.WriteLine("Balance: " + Balance);
            Console.WriteLine("---------------------------");
        }


        public void Input()
        {
            Console.Write("ID: ");
            Id = Console.ReadLine();
            Console.Write("First Name: ");
            FName = Console.ReadLine();
            Console.Write("Last Name: ");
            LName = Console.ReadLine();
            Console.Write("Balance: ");
            Balance = double.Parse(Console.ReadLine());
        }
    }

    class IDComparer : IComparer<Account>
    {
        public int Compare(Account x, Account y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }

    class FNameComparer : IComparer<Account>
    {
        public int Compare(Account x, Account y)
        {
            return x.FName.CompareTo(y.FName);
        }
    }

    class LNameComparer : IComparer<Account>
    {
        public int Compare(Account x, Account y)
        {
            return x.LName.CompareTo(y.LName);
        }
    }

    class BalanceComparer : IComparer<Account>
    {
        public int Compare(Account x, Account y)
        {
            return x.Balance.CompareTo(y.Balance);
        }
    }


    class AccountList
    {
        private List<Account> list = new List<Account>();

        internal List<Account> List { get => list; set => list = value; }

        public void AddAccount()
        {
            Account b = new Account();
            b.Input();
            List.Add(b);
            Console.WriteLine("Add success!");
        }

        public void Report()
        {
            foreach (Account b in List)
                b.Show();
        }

        public void SaveFile()
        {
            Console.Write("Input file name to save: ");
            string filename = Console.ReadLine();
            try
            {
                FileStream output = new FileStream(filename, FileMode.CreateNew, FileAccess.Write);
                StreamWriter writer = new StreamWriter(output);
                foreach (Account acc in List)
                {
                    writer.WriteLine("{0},{1},{2},{3}", acc.Id, acc.FName, acc.LName, acc.Balance);
                }
                writer.Close();
                output.Close();
                Console.WriteLine("Save file success!");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void LoadFile()
        {
            Console.Write("Input file name to load: ");
            string filename = Console.ReadLine();
            List.Clear();
            try
            {
                FileStream input = new FileStream(filename, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(input);
                string str;
                while ((str = reader.ReadLine()) != null)
                {
                    string[] ls = str.Split(',');
                    Account acc = new Account(ls[0], ls[1], ls[2], double.Parse(ls[3]));
                    List.Add(acc);
                }
                input.Close();
                reader.Close();
                Console.WriteLine("Load file success!");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Remove(string id)
        {
            List.Sort(new IDComparer());
            ArrayList arr = new ArrayList();
            foreach (Account acc in List)
            {
                arr.Add(acc.Id);
            }
            int i = arr.BinarySearch(id);
            if (i >= 0)
            {
                List.RemoveAt(i);
                Console.WriteLine("Delete success!");
            }
            else
            {
                Console.WriteLine("Not found!");
            }
        }
    }

    class Bai3va4
    {

        public static void Main()
        {
            AccountList list = new AccountList();
            Console.WriteLine("----------MENU----------");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Save");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Report");
            Console.WriteLine("5. Remove");
            Console.WriteLine("6. Sort by ID");
            Console.WriteLine("7. Sort by First Name");
            Console.WriteLine("8. Sort by Balance");
            Console.WriteLine("9. Exit");
            int i = 0;
            do
            {
                Console.Write("Your choice: ");
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        list.AddAccount();
                        break;
                    case 2:
                        list.SaveFile();
                        break;
                    case 3:
                        list.LoadFile();
                        break;
                    case 4:
                        list.Report();
                        break;
                    case 5:
                        Console.Write("Input ID to remove: ");
                        string s = Console.ReadLine();
                        list.Remove(s);
                        break;
                    case 6:
                        list.List.Sort(new IDComparer());
                        list.Report();
                        break;
                    case 7:
                        list.List.Sort(new FNameComparer());
                        list.Report();
                        break;
                    case 8:
                        list.List.Sort(new BalanceComparer());
                        list.Report();
                        break;
                    case 9:
                        break;
                    default:
                        Console.WriteLine("Please input in range 1-9!!!");
                        break;
                }
            }
            while (i != 9);
            Console.ReadKey();
        }
    }
}
