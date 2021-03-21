using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5TV
{
    public partial class Form1 : Form
    {
        private DataTable table = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            table.Columns.Add("Food Name", typeof(string));
            table.Columns.Add("Quantity",typeof(int));
            DataColumn[] PrimaryKey = new DataColumn[1];
            PrimaryKey[0] = table.Columns["Food Name"];
            table.PrimaryKey = PrimaryKey;
            dataGridView1.DataSource = table;
        }

        private void btnPMBo_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            foreach (DataRow dr in table.Rows)
            {
                if (dr["Food Name"].Equals(b.Text))
                {
                    dr["Quantity"] = int.Parse(dr["Quantity"].ToString()) + 1;
                    return;                 }
            }
            DataRow r = table.NewRow();
            r["Food Name"] = b.Text;
            r["Quantity"] = 1;
            table.Rows.Add(r);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (cbx.SelectedItem == null)
            {
                MessageBox.Show("Chọn bàn!!!");
            }
            else if (table.Rows.Count==0)
            {
                MessageBox.Show("Chọn món!!!");
            }
            else
            {
                MessageBox.Show("Đã order bàn " + cbx.SelectedItem.ToString() + "  xong!");
                table.Rows.Clear();
            }
        }
    }
}
