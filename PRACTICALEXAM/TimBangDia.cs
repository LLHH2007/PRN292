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
    public partial class TimBangDia : Form
    {
        SqlConnection conn = null;
        string strconn = "database=QL_BANGDIA;Server=LONG;User id=sa; password=tv1502";
        public TimBangDia()
        {
            InitializeComponent();
        }
        private void TimDia(string TenDia)
        {
            lsvDia.Items.Clear();
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand("Select * from DIA where TENDIA like N'%"+TenDia+"%'", conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string Ma = reader.GetString(0);
                string Ten = reader.GetString(1);
                string Loai = reader.GetString(2);
                ListViewItem item = lsvDia.Items.Add(Ma);
                item.SubItems.Add(Ten);
                item.SubItems.Add(Loai);
            }
            if (!(lsvDia.Items.Count > 0))
            {
                MessageBox.Show("Không có tên đĩa cần tìm!!!");
            }
            conn.Close();
            return;

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tendia = txtTendia.Text;
            if (tendia.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập tên đĩa!!!");
                return;
            }
            TimDia(tendia);
        }
    }
}

    
