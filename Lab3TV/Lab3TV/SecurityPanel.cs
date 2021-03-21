using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Lab3TV
{
    public partial class SecurityPanel : Form
    {
        public SecurityPanel()
        {
            InitializeComponent();
        }

        private void SecurityPanel_Load(object sender, EventArgs e)
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
                        lbxAccessLog.Items.Add(line);
                    }
                }
            }
            catch (Exception)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
            }

        }

        private void bt9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtSecurityCode.Text = txtSecurityCode.Text + b.Text;
            this.Focus();
            ((Button)sender).Enabled = false;

            ((Button)sender).Enabled = true;
        }

        private void btC_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text = "";
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            switch (txtSecurityCode.Text)
            {
                case "1645":
                case "1689":
                    MessageBox.Show("Access granted!!!");
                    lbxAccessLog.Items.Add(now + "    Technicians");
                    break;
                case "8345":
                    MessageBox.Show("Access granted!!!");
                    lbxAccessLog.Items.Add(now + "    Custodians");
                    break;
                case "9998":
                case "1006":
                case "1007":
                case "1008":
                    MessageBox.Show("Access granted!!!");
                    lbxAccessLog.Items.Add(now + "    Scientist");
                    break;
                default:
                    MessageBox.Show("Access denied!!!");
                    lbxAccessLog.Items.Add(now + "    Restricted Access!");
                    break;

            }
            txtSecurityCode.Text = "";

        }

        private void SecurityPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("BẠN MUỐN ĐÓNG FORM?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                using (StreamWriter sw = new StreamWriter("information.txt"))
                {
                    foreach (string s in lbxAccessLog.Items)
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

        private void SecurityPanel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void SecurityPanel_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                case Keys.D1:
                    bt1.PerformClick();
                    break;
                case Keys.NumPad2:
                case Keys.D2:
                    bt2.PerformClick();
                    break;
                case Keys.NumPad3:
                case Keys.D3:
                    bt3.PerformClick();
                    break;
                case Keys.NumPad4:
                case Keys.D4:
                    bt4.PerformClick();
                    break;
                case Keys.NumPad5:
                case Keys.D5:
                    bt5.PerformClick();
                    break;
                case Keys.NumPad6:
                case Keys.D6:
                    bt6.PerformClick();
                    break;
                case Keys.NumPad7:
                case Keys.D7:
                    bt7.PerformClick();
                    break;
                case Keys.NumPad8:
                case Keys.D8:
                    bt8.PerformClick();
                    break;
                case Keys.NumPad9:
                case Keys.D9:
                    bt9.PerformClick();
                    break;
                case Keys.NumPad0:
                case Keys.D0:
                    bt0.PerformClick();
                    break;
                case Keys.C:
                    btC.PerformClick();
                    break;
                case Keys.Enter:
                    btLogin.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}
