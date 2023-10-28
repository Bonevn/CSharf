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
            dgvDanhSachCanBo.DataSource = null; // Xóa dữ liệu cũ

            dgvDanhSachCanBo.DataSource = ListDanhSachCanBo.Instance.ListDanhsachcb1;

        }
    }
}
