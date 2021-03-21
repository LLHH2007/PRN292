using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtName.Text =
                listView1.SelectedItems[0].SubItems[0].Text;
                dtpBirth.Text =
                listView1.SelectedItems[0].SubItems[1].Text;
                txtNumber.Text =
                listView1.SelectedItems[0].SubItems[2].Text;
                txtAddress.Text =
                listView1.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Hãy chọn hàng cần xóa!!!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = txtName.Text;
                listView1.SelectedItems[0].SubItems[1].Text =
                dtpBirth.Value.ToShortDateString();
                listView1.SelectedItems[0].SubItems[2].Text =
                txtNumber.Text;
                listView1.SelectedItems[0].SubItems[3].Text =
                txtAddress.Text;
            }
            else
            {
                MessageBox.Show("Hãy chọn hàng cần sửa!!!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Điền họ tên!!!");
                return;
            }
            ListViewItem lvi = listView1.Items.Add(txtName.Text);
            lvi.SubItems.Add(dtpBirth.Value.ToShortDateString());
            lvi.SubItems.Add(txtNumber.Text);
            lvi.SubItems.Add(txtAddress.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
