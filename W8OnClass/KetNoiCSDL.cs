using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W8OnClass
{
    public partial class KetNoiCSDL : Form
    {
        SqlConnection conn = null;
        string strconn = "database=QLSinhVien;Server=LONG;User id=sa; password=tv1502";
        public KetNoiCSDL()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strconn);
                conn.Open();
                MessageBox.Show("Kết nối thành công");
                btnEdit.Enabled = true;
                btnFind.Enabled = true;
                btnShow.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Kết nối thất bại\n" + ex.Message);
            }
            
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
                MessageBox.Show("Đã đóng CSDL thành công");
                this.Close();
            }
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            find fm = new find();
            fm.Show();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            show fm = new show();
            fm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            edit fm = new edit();
            fm.Show();
        }
    }
}
