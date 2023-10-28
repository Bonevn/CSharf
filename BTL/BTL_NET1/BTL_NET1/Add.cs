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
            DateTime ngaySinh = dtpngaysinh.Value;
            string gioiTinh = cbgioitinh.Text;
            
            DanhSachCanBo canBo = new DanhSachCanBo(maCanBo, tenCanBo, ngaySinh, gioiTinh);
            ListDanhSachCanBo.Instance.ListDanhsachcb1.Add(canBo);

            this.Close();
        }
    }
}
