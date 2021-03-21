using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Lab3TV
{
    public partial class UocBoi : Form
    {

        public UocBoi()
        {
            InitializeComponent();
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private string CheckResult(GroupBox gr)
        {
            RadioButton rd = null;
            foreach(RadioButton item in gr.Controls)
            {
                if (item.Checked)
                {
                    rd = item;
                    return rd.Text;
                }
            }
            return null;
        }

        private int UCLN(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return a + b;
            }
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            if (CheckResult(grChontim).Equals("UCLN"))
            {
                txtKetqua.Text = UCLN(a, b).ToString();
            }
            else
            {
                txtKetqua.Text = (a * b / UCLN(a, b)).ToString();
            }
        }

        private void btBoqua_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtKetqua.Text = "";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = System.Windows.Forms.MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                
            }
        }


    }
}
