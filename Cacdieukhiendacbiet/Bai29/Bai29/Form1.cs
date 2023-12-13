using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(txt_ten.Text);
            string ngaysinh = Convert.ToString(dtp_ngaysinh.Text);
            string sdt = Convert.ToString(txt_sdt.Text);

            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(ngaysinh);
            item.SubItems.Add(sdt);
            listView1.Items.Add(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
