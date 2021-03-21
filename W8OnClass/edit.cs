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
    public partial class edit : Form
    {
        int result = -1;
        SqlConnection conn = null;
        string strconn = "database=QLSinhVien;Server=LONG;User id=sa; password=tv1502";
        public edit()
        {
            InitializeComponent();
        }

        private void edit_Load(object sender, EventArgs e)
        {
            Hienthisinhvien();
        }

        private void Hienthisinhvien()
        {
            lsvDSSV.Items.Clear();
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand("Select * from sinhvien", conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string masv = reader.GetString(0);
                string hoten = reader.GetString(1);
                string malop = reader.GetString(2);
                ListViewItem item = lsvDSSV.Items.Add(masv);
                item.SubItems.Add(hoten);
                item.SubItems.Add(malop);
            }
            conn.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = conn;
            command.CommandText = "update sinhvien set hoten=@hoten, malop=@malop where masv=@masv";
            SqlParameter parameter1 = new SqlParameter("@masv", txtMaSinhVien.Text);
            command.Parameters.Add(parameter1);
            SqlParameter parameter2 = new SqlParameter("@hoten", txtHoTen.Text);
            command.Parameters.Add(parameter2);
            SqlParameter parameter3 = new SqlParameter("@malop", txtMaLop.Text);
            command.Parameters.Add(parameter3);
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nCập nhật một sinh viên thất bại");
            }
            if (result > 0)
            {
                Hienthisinhvien();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = conn;
            command.CommandText = "insert into sinhvien(masv,hoten,malop)" + "values (@masv,@hoten,@malop)";
            SqlParameter parameter1 = new SqlParameter("@masv", txtMaSinhVien.Text);
            command.Parameters.Add(parameter1);
            SqlParameter parameter2 = new SqlParameter("@hoten", txtHoTen.Text);
            command.Parameters.Add(parameter2);
            SqlParameter parameter3 = new SqlParameter("@malop", txtMaLop.Text);
            command.Parameters.Add(parameter3);
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nThêm một sinh viên thất bại");
            }
            if (result > 0)
            {
                Hienthisinhvien();
            }
        }

        private void lsvDSSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDSSV.SelectedItems.Count > 0)
            {
                txtMaSinhVien.Text = lsvDSSV.SelectedItems[0].SubItems[0].Text;
                txtHoTen.Text = lsvDSSV.SelectedItems[0].SubItems[1].Text;
                txtMaLop.Text = lsvDSSV.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = conn;
            command.CommandText = "delete from sinhvien where masv=@masv";
            SqlParameter parameter1 = new SqlParameter("@masv", txtMaSinhVien.Text);
            command.Parameters.Add(parameter1);
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nXóa một sinh viên thất bại");
            }
            if (result > 0)
            {
                Hienthisinhvien();
                txtMaSinhVien.Text = "";
                txtHoTen.Text = "";
                txtMaLop.Text = "";
            }
        }
    }
}
