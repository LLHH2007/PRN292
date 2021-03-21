using System;
using System.Collections;
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

namespace Lab3
{
    public partial class Form1 : Form
    {
        List<String> ls = new List<String>();
        string s;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("information.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        ls.Add(line);
                    }
                }
                Hienthisinhvien();
            }
            catch (Exception)
            {
                Console.WriteLine("The file could not be read:");
            }
        }

        private void Hienthisinhvien()
        {
            lsvDSSV.Items.Clear();
            foreach(string s in ls)
            {
                string[] ss = s.Split(',');
                ListViewItem item = lsvDSSV.Items.Add(ss[0]);
                item.SubItems.Add(ss[1]);
                item.SubItems.Add(ss[2]);
                item.SubItems.Add(ss[3]);
                item.SubItems.Add(ss[4]);
                item.SubItems.Add(ss[5]);
                item.SubItems.Add(ss[6]);
            }
            

        }

        private void lsvDSSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDSSV.SelectedItems.Count > 0)
            {
                txtName.Text = lsvDSSV.SelectedItems[0].SubItems[0].Text;
                txtAge.Text = lsvDSSV.SelectedItems[0].SubItems[1].Text;
                txtAddress.Text = lsvDSSV.SelectedItems[0].SubItems[2].Text;
                txtYear.Text = lsvDSSV.SelectedItems[0].SubItems[3].Text;
                txtPhoneNumber.Text = lsvDSSV.SelectedItems[0].SubItems[4].Text;
                txtEmail.Text = lsvDSSV.SelectedItems[0].SubItems[5].Text;
                dtpDate.Text = lsvDSSV.SelectedItems[0].SubItems[6].Text;
                s = txtName.Text;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("BẠN MUỐN ĐÓNG FORM?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                using (StreamWriter sw = new StreamWriter("information.txt"))
                {
                    foreach (string s in ls)
                    {
                        sw.WriteLine(s);
                    }
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please input Name!!!");
                return;
            }else if (int.Parse(txtAge.Text) < 0)
            {
                MessageBox.Show("Age must be greater than 0!!!");
                return;
            }else if(int.Parse(txtYear.Text)>2|| int.Parse(txtYear.Text) < 0)
            {
                MessageBox.Show("Year of experience must be from 0 to 2 year!!!");
                return;
            }
            ls.Add(txtName.Text + "," + txtAge.Text + "," + txtAddress.Text + "," + txtYear.Text + "," + txtPhoneNumber.Text + ","
                + txtEmail.Text + "," + dtpDate.Value.ToShortDateString());
            Hienthisinhvien();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lsvDSSV.SelectedItems.Count > 0)
            {
                foreach(string str in ls)
                {
                    if (str.Split(',')[0].Equals(s))
                    {
                        ls.Remove(str);
                        break;
                    }
                }
                Hienthisinhvien();
            }
            else
            {
                MessageBox.Show("Hãy chọn hàng cần xóa!!!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lsvDSSV.SelectedItems.Count > 0)
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("Please input Name!!!");
                    return;
                }
                else if (int.Parse(txtAge.Text) < 0)
                {
                    MessageBox.Show("Age must be greater than 0!!!");
                    return;
                }
                else if (int.Parse(txtYear.Text) > 2 || int.Parse(txtYear.Text) < 0)
                {
                    MessageBox.Show("Year of experience must be from 0 to 2 year!!!");
                    return;
                }
                foreach (string str in ls)
                {
                    if (str.Split(',')[0].Equals(s))
                    {
                        int i = ls.IndexOf(str);
                        ls.Insert(i, txtName.Text + "," + txtAge.Text + "," + txtAddress.Text + "," + txtYear.Text + "," + txtPhoneNumber.Text + ","
                        + txtEmail.Text + "," + dtpDate.Value.ToShortDateString());
                        ls.Remove(str);
                        break;
                    }
                    
                }
                Hienthisinhvien();                
            }
            else
            {
                MessageBox.Show("Hãy chọn hàng cần sửa!!!");
            }
        }
    }

}
