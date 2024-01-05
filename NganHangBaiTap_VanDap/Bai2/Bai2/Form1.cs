using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult xacnhan = MessageBox.Show("Bạn có muốn đóng chương trình này không? ", "Xác nhận đóng", (MessageBoxButtons.YesNo), MessageBoxIcon.Question);
            if (xacnhan == DialogResult.Yes) Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int soluong = int.Parse(txtsoluong.Text);
            if (soluong > 0)
            {
                int dongia = int.Parse(txtdongia.Text);
                int thanhtien = soluong * dongia;

                txtthanhtien.Text = thanhtien.ToString();
            }
            else
            {
                txtsoluong.Clear();
                MessageBox.Show("Vui lòng nhập giá trị lớn hơn 0", "Warming", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtsoluong.Clear();
            txtdongia.Clear();
            txtthanhtien.Clear();
            txttenhang.Clear();
            txttenhang.Focus();
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar<='Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z'))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số cho giá trị này", "Nhập số", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
