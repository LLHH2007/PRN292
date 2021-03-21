using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICALEXAM
{
    public partial class QuanLyChoThueBangDia : Form
    {
        public QuanLyChoThueBangDia()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void băngĐĩaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatBangDia capNhatBangDia = new CapNhatBangDia();
            this.Hide();
            capNhatBangDia.ShowDialog();
            this.Show();
        }

        private void tênBăngĐĩaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimBangDia timBangDia = new TimBangDia();
            this.Hide();
            timBangDia.ShowDialog();
            this.Show();
        }

        private void QuanLyChoThueBangDia_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo);
            if (!(dr == DialogResult.Yes))
            {
                e.Cancel = true;
            }
        }
    }
}
