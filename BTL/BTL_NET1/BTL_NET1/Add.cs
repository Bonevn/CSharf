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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maCanBo = txtmacb.Text;
            string tenCanBo = txtname.Text;
            string ngaySinh = Convert.ToString(dtpngaysinh.Text);
            string gioiTinh = cbgioitinh.Text;
            
            Dashboard dashboard = new Dashboard();
            dashboard.AddData(maCanBo, tenCanBo, ngaySinh, gioiTinh);

            this.Close();
        }
    }
}
