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

namespace W8OnClassEx2
{
    public partial class Form1 : Form
    {
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        string strconn = "database=QLSinhVien;Server=LONG;User id=sa; password=tv1502";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int kq = 0;
            DataRow row = ds.Tables[0].NewRow();
            row[0] = txtMaSinhVien.Text;
            row["Hoten"] = txtHoTen.Text;
            row[2] = txtMaLop.Text;
            ds.Tables[0].Rows.Add(row);

            try
            {
                kq = adapter.Update(ds, "SinhVien");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm một sinh viên thất bại \n" + ex.Message);
            }
            if (kq > 0) MessageBox.Show("Thêm sinh viên thành công");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("select * from sinhvien", strconn);
            ds = new DataSet();
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(ds, "SinhVien");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Tables[0];
        }
        int vitri = -1;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (vitri == -1)
            {
                MessageBox.Show("Bạn chưa chọn dòng nào");
                return;
            }
            DataRow row = ds.Tables["Sinhvien"].Rows[vitri];
            row.BeginEdit();
            row["MaSV"] = txtMaSinhVien.Text;
            row["Hoten"] = txtHoTen.Text;
            row[2] = txtMaLop.Text;
            row.EndEdit();
            int kq = adapter.Update(ds.Tables["SinhVien"]);
            if (kq > 0)
            {
                MessageBox.Show("Cập nhật thành công");

            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (vitri == -1) return;
            DataRow row = ds.Tables["SinhVien"].Rows[vitri];
            row.Delete();
            int kq = adapter.Update(ds.Tables["Sinhvien"]);
            if (kq > 0)
            {
                MessageBox.Show("Xóa thành công");
            }
            else
                MessageBox.Show("Xóa thất bại");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            if (vitri == -1)
            {
                MessageBox.Show("Không có dòng nào được chọn");
                return;
            }
            DataRow row = ds.Tables["SinhVien"].Rows[vitri];
            txtMaSinhVien.Text = row[0].ToString();
            txtHoTen.Text = row["Hoten"].ToString();
            txtMaLop.Text = row[2].ToString();
        }
    }
}
