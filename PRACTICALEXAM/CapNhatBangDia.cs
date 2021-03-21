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

namespace PRACTICALEXAM
{
    public partial class CapNhatBangDia : Form
    {
        SqlConnection conn = null;
        string strconn = "database=QL_BANGDIA;Server=LONG;User id=sa; password=tv1502";
        public CapNhatBangDia()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            string MaDia = txtMaDia.Text;
            string TenDia = txtTenDia.Text;
            string TheLoai = txtTheLoai.Text;
            if (MaDia.Equals("") || (TenDia.Equals("") && TheLoai.Equals("")))
            {
                MessageBox.Show("Hãy nhập đủ tất cả các trường!");
                return;
            }
            if (!TimBangDia(MaDia).Equals(""))
            {
                if (TenDia.Equals(""))
                {
                    if (conn == null) conn = new SqlConnection(strconn);
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.Connection = conn;
                    command.CommandText = "update Dia set THELOAI=@theloai where MADIA=@madia";
                    SqlParameter parameter1 = new SqlParameter("@madia", MaDia);
                    command.Parameters.Add(parameter1);
                    SqlParameter parameter3 = new SqlParameter("@theloai", TheLoai);
                    command.Parameters.Add(parameter3);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Sửa thành công!");
                        txtMaDia.Text = "";
                        txtTenDia.Text = "";
                        txtTheLoai.Text = "";
                        return;
                    }
                }
                else if(TheLoai.Equals(""))
                {
                    if (conn == null) conn = new SqlConnection(strconn);
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.Connection = conn;
                    command.CommandText = "update Dia set TENDIA=@tendia where MADIA=@madia";
                    SqlParameter parameter1 = new SqlParameter("@madia", MaDia);
                    command.Parameters.Add(parameter1);
                    SqlParameter parameter2 = new SqlParameter("@tendia", TenDia);
                    command.Parameters.Add(parameter2);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Sửa thành công!");
                        txtMaDia.Text = "";
                        txtTenDia.Text = "";
                        txtTheLoai.Text = "";
                        return;
                    }
                }
                else
                {
                    if (conn == null) conn = new SqlConnection(strconn);
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.Connection = conn;
                    command.CommandText = "update Dia set TENDIA=@tendia, THELOAI=@theloai where MADIA=@madia";
                    SqlParameter parameter1 = new SqlParameter("@madia", MaDia);
                    command.Parameters.Add(parameter1);
                    SqlParameter parameter2 = new SqlParameter("@tendia", TenDia);
                    command.Parameters.Add(parameter2);
                    SqlParameter parameter3 = new SqlParameter("@theloai", TheLoai);
                    command.Parameters.Add(parameter3);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Sửa thành công!");
                        txtMaDia.Text = "";
                        txtTenDia.Text = "";
                        txtTheLoai.Text = "";
                        return;
                    }
                }
                MessageBox.Show("Không tồn tại Mã đĩa!!!");
                return;
            }
                MessageBox.Show("Không tồn tại Mã đĩa!!!");
                return;
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            string MaDia = txtMaDia.Text;
            string TenDia = txtTenDia.Text;
            string TheLoai = txtTheLoai.Text;
            if(MaDia.Equals("")|| TenDia.Equals("") || TheLoai.Equals(""))
            {
                MessageBox.Show("Hãy nhập đủ tất cả các trường!");
                return;
            }
            if (TimBangDia(MaDia).Equals(""))
            {
                if (conn == null) conn = new SqlConnection(strconn);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = conn;
                command.CommandText = "insert into DIA " + "values (@madia,@tendia,@theloai)";
                SqlParameter parameter1 = new SqlParameter("@madia", MaDia);
                command.Parameters.Add(parameter1);
                SqlParameter parameter2 = new SqlParameter("@tendia", TenDia);
                command.Parameters.Add(parameter2);
                SqlParameter parameter3 = new SqlParameter("@theloai", TheLoai);
                command.Parameters.Add(parameter3);
                if (command.ExecuteNonQuery()>0)
                {
                    MessageBox.Show("Thêm một đĩa mới thành công!");
                    txtMaDia.Text = "";
                    txtTenDia.Text = "";
                    txtTheLoai.Text = "";
                }
                conn.Close();
                return;
            }
            MessageBox.Show("Đã tồn tại Mã đĩa!!!");
            return;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            string MaDia = txtMaDia.Text;
            if (MaDia.Equals(""))
            {
                MessageBox.Show("Hãy nhập Mã đĩa!!!");
                return;
            }
            if (!TimBangDia(MaDia).Equals(""))
            {
                if (conn == null) conn = new SqlConnection(strconn);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = conn;
                command.CommandText = "delete from DIA where madia=@madia";
                SqlParameter parameter1 = new SqlParameter("@madia", MaDia);
                command.Parameters.Add(parameter1);
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    txtMaDia.Text = "";
                    txtTenDia.Text = "";
                    txtTheLoai.Text = "";
                    return;
                }
            }
            MessageBox.Show("Không tồn tại mã đĩa!");
            
        }

        private string TimBangDia(string MaDia)
        {
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand("Select * from DIA where MADIA = '"+MaDia+"'", conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string Ma = reader.GetString(0);
                string TenDia = reader.GetString(1);
                string TheLoai = reader.GetString(2);
                conn.Close();
                Console.WriteLine(Ma);
                return Ma;
            }
            conn.Close();
            return "";
  
        }
    }
}
