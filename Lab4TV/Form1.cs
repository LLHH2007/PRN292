using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4TV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("BẠN MUỐN ĐÓNG FORM?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                using (StreamWriter sw = new StreamWriter("information.txt"))
                {
                    foreach (string s in lbx.Items)
                    {
                        sw.WriteLine(s);
                    }
                }
                this.Close();
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Chưa nhập tên khách hàng!");
            }
            else
            {
                GetPay();
            }

        }

        private void GetPay()
        {
            double Total = 0;
            if (chkClean.Checked)
            {
                Total += 100000;
            }
            if (chkWhitening.Checked)
            {
                Total += 1200000;
            }
            if (chkXRay.Checked)
            {
                Total += 200000;
            }
            Total += (double)numFilling.Value*80000;
            txtTotal.Text = "$"+Total.ToString();
            lbx.Items.Add(txtName.Text + "\t\t" + txtTotal.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("information.txt"))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        lbx.Items.Add(line);
                    }
                }
            }
            catch (Exception)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("BẠN MUỐN ĐÓNG FORM?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                using (StreamWriter sw = new StreamWriter("information.txt"))
                {
                    foreach (string s in lbx.Items)
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
    }
}
