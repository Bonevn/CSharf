using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_NET1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Add addForm = new Add();
            addForm.ShowDialog();
            
        }
        public void AddData (string maCB, string name, string ngaysinh, string gioitinh)
        {
            ListViewItem item = new ListViewItem(maCB);
            item.SubItems.Add(name);
            item.SubItems.Add(ngaysinh);
            item.SubItems.Add(gioitinh);
            listView1.Items.Add(item);

        }
    }
}
