using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class ListAll : Form
    {
        SqlConnection conn = null;
        string strconn;
        public ListAll()
        {
            InitializeComponent();
        }

        private void ListAll_Load(object sender, EventArgs e)
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("config.txt"))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    if ((line = sr.ReadLine()) != null)
                    {
                        strconn=line;
                    }
                }
               
            }
            catch (Exception)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
            }
        }

        private void cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = cbx.SelectedItem.ToString() ;
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            switch (s)
            {
                case "Categories":
                    command.CommandText = "Select CategoryID,CategoryName,Description from categories";
                    command.Connection = conn;
                    SqlDataReader reader = command.ExecuteReader();
                    lsv.Clear();
                    lsv.Columns.Add("CategoryID", 60);
                    lsv.Columns.Add("CategoryName", 60);
                    lsv.Columns.Add("Description", 60);

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string Name = reader.GetString(1);
                        string desciption = reader.GetString(2);
                        ListViewItem item = lsv.Items.Add(id.ToString());
                        item.SubItems.Add(Name);
                        item.SubItems.Add(desciption);
                    }
                    break;
                case "Suppliers":
                    command.CommandText = "Select SupplierID,CompanyName,ContactName,Address,City from suppliers";
                    command.Connection = conn;
                    SqlDataReader reader2 = command.ExecuteReader();
                    lsv.Clear();
                    lsv.Columns.Add("SupplierID", 60);
                    lsv.Columns.Add("CompanyName", 60);
                    lsv.Columns.Add("ContactName", 60);
                    lsv.Columns.Add("Address", 60);
                    lsv.Columns.Add("City", 60);

                    while (reader2.Read())
                    {
                        int id = reader2.GetInt32(0);
                        string companyName = reader2.GetString(1);
                        string contactName = reader2.GetString(2);
                        string address = reader2.GetString(3);
                        string city = reader2.GetString(4);
                        ListViewItem item = lsv.Items.Add(id.ToString());
                        item.SubItems.Add(companyName);
                        item.SubItems.Add(contactName);
                        item.SubItems.Add(address);
                        item.SubItems.Add(city);
                    }
                    break;
                default:
                    command.CommandText = "Select ProductID,ProductName,supplierID,CategoryID,QuantityPerUnit,unitprice from products";
                    command.Connection = conn;
                    SqlDataReader reader3 = command.ExecuteReader();
                    lsv.Clear();
                    lsv.Columns.Add("ProductID", 60);
                    lsv.Columns.Add("ProductName", 60);
                    lsv.Columns.Add("SupplierID", 60);
                    lsv.Columns.Add("CategoryID", 60);
                    lsv.Columns.Add("QuantityPerUnit", 60);
                    lsv.Columns.Add("unitprice", 60);

                    while (reader3.Read())
                    {
                        int id = reader3.GetInt32(0);
                        string Name = reader3.GetString(1);
                        int sid = reader3.GetInt32(2);
                        int cid = reader3.GetInt32(3);
                        string quantityPerUnit = reader3.GetString(4);
                        decimal unitPrice = reader3.GetDecimal(5);
                        ListViewItem item = lsv.Items.Add(id.ToString());
                        item.SubItems.Add(Name);
                        item.SubItems.Add(sid.ToString());
                        item.SubItems.Add(cid.ToString());
                        item.SubItems.Add(quantityPerUnit);
                        item.SubItems.Add(unitPrice.ToString());


                    }
                    break;
            }
            conn.Close();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "" || cbxInput.SelectedItem == null)
            {
                MessageBox.Show("Please input Name and Type!!!");
                return;
            }
            string s = cbxInput.SelectedItem.ToString();
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            switch (s)
            {
                case "CompanyName":
                    command.CommandText = "Select SupplierID,CompanyName,ContactName,Address,City from suppliers where companyname like '%" + txtInput.Text + "%'";
                    command.Connection = conn;
                    SqlDataReader reader2 = command.ExecuteReader();
                    lsv.Clear();
                    lsv.Columns.Add("SupplierID", 60);
                    lsv.Columns.Add("CompanyName", 60);
                    lsv.Columns.Add("ContactName", 60);
                    lsv.Columns.Add("Address", 60);
                    lsv.Columns.Add("City", 60);

                    while (reader2.Read())
                    {
                        int id = reader2.GetInt32(0);
                        string companyName = reader2.GetString(1);
                        string contactName = reader2.GetString(2);
                        string address = reader2.GetString(3);
                        string city = reader2.GetString(4);
                        ListViewItem item = lsv.Items.Add(id.ToString());
                        item.SubItems.Add(companyName);
                        item.SubItems.Add(contactName);
                        item.SubItems.Add(address);
                        item.SubItems.Add(city);
                    }
                    break;
                default:
                    command.CommandText = "Select ProductID,ProductName,supplierID,CategoryID,QuantityPerUnit,unitprice from products where productName like '%" + txtInput.Text + "%'";
                    command.Connection = conn;
                    SqlDataReader reader3 = command.ExecuteReader();
                    lsv.Clear();
                    lsv.Columns.Add("ProductID", 60);
                    lsv.Columns.Add("ProductName", 60);
                    lsv.Columns.Add("SupplierID", 60);
                    lsv.Columns.Add("CategoryID", 60);
                    lsv.Columns.Add("QuantityPerUnit", 60);
                    lsv.Columns.Add("unitprice", 60);

                    while (reader3.Read())
                    {
                        int id = reader3.GetInt32(0);
                        string Name = reader3.GetString(1);
                        int sid = reader3.GetInt32(2);
                        int cid = reader3.GetInt32(3);
                        string quantityPerUnit = reader3.GetString(4);
                        decimal unitPrice = reader3.GetDecimal(5);
                        ListViewItem item = lsv.Items.Add(id.ToString());
                        item.SubItems.Add(Name);
                        item.SubItems.Add(sid.ToString());
                        item.SubItems.Add(cid.ToString());
                        item.SubItems.Add(quantityPerUnit);
                        item.SubItems.Add(unitPrice.ToString());


                    }
                    break;
            }
            conn.Close();

        }
    }
}
