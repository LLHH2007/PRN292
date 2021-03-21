using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W8OnClass
{
    public partial class show : Form
    {
        SqlConnection conn = null;
        string strconn = "database=QLSinhVien;Server=LONG;User id=sa; password=tv1502";
        public show()
        {
            InitializeComponent();
        }

        private void edit_Load(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from lop";
            command.Connection = conn;
            lsbDanhSachLop.ClearSelected();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string malop = reader.GetString(0);
                string tenlop = reader.GetString(1);
                int nam = reader.GetInt32(2);
                string line = malop + "-" + tenlop + "-" + nam.ToString();
                lsbDanhSachLop.Items.Add(line);
            }
            conn.Close();
        }

        private void lsbDanhSachLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvDSSV.Items.Clear();
            if (lsbDanhSachLop.SelectedIndex == -1) return;
            string line = lsbDanhSachLop.SelectedItem.ToString();
            string[] array = line.Split('-');
            string malop = array[0];

            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from sinhvien where malop =@malop";
            command.Connection = conn;
            SqlParameter sqlpara = new SqlParameter("@malop", SqlDbType.Char);
            sqlpara.Value = malop;
            command.Parameters.Add(sqlpara);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string masv = reader.GetString(0);
                string hoten = reader.GetString(1);
                string malopsv = reader.GetString(2);
                ListViewItem item = lsvDSSV.Items.Add(masv);
                item.SubItems.Add(hoten);
                item.SubItems.Add(malopsv);
                
            }
            conn.Close();
        }
    }
}
