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
    
    public partial class find : Form
    {
        SqlConnection conn = null;
        string strconn = "database=QLSinhVien;Server=LONG;User id=sa; password=tv1502";
        public find()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select count(*) from sinhvien";
            command.Connection = conn;
            int kq = (int)command.ExecuteScalar();
            lbCount.Text = kq.ToString();
            conn.Close();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtNam.Text = "";
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from Lop where malop='" + txtNhapMaLop.Text + "'";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtMaLop.Text = reader.GetString(0);
                txtTenLop.Text = reader.GetString(1);
                txtNam.Text = reader.GetInt32(2).ToString();
            }
            conn.Close();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            lsvDSSV.Items.Clear();
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from SinhVien where malop = @malop";
            SqlParameter sqlPara = new SqlParameter("@malop", SqlDbType.Char);
            sqlPara.Value = txtNhapMaLop.Text;
            command.Parameters.Add(sqlPara);
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string masv = reader.GetString(0);
                string hoten = reader.GetString(1);
                string malop = reader.GetString(2);
                ListViewItem item = new ListViewItem(masv);

                item.SubItems.Add(hoten);
                item.SubItems.Add(malop);
                lsvDSSV.Items.Add(item);

            }
            conn.Close();
        }
    }
}
