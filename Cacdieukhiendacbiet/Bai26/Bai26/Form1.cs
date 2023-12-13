using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenlop = Convert.ToString(txt_tenlop.Text);
            string soluong = Convert.ToString(txt_soluong.Text);

            ListViewItem item = new ListViewItem(tenlop);
            item.SubItems.Add(soluong);
            listView1.Items.Add(item);
        }
    }
}
