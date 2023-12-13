using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace Bai22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            string hoten = txthoten.Text;
            DateTime ngaysinh = DateTime.ParseExact(txtngaysinh.Text, "d/M/yyyy", CultureInfo.InvariantCulture);
            double dtb = Convert.ToDouble(txtdtb.Text);

            MessageBox.Show("Họ tên: "+ hoten + "\n" + "Ngày sinh: " + ngaysinh + "\n" + "ĐTB: "+dtb);
        }

        private void txtdtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                errorProvider2.SetError(txtdtb,"Vui lòng nhập số");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void txtngaysinh_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngaysinh;
            bool kiemtrangaysinh = DateTime.TryParseExact(txtngaysinh.Text, "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaysinh);
            if (!kiemtrangaysinh)
            {
                errorProvider1.SetError(txtngaysinh, "Ngày sinh dd/mm/yyyy");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Thoát hẳn app
            Application.Exit();
        }
    }
}
