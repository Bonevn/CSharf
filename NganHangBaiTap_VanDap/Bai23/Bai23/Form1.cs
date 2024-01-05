using System;
using System.Windows.Forms;

namespace Bai23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myWebsite.Navigate("www.google.com");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if ( txtLink.Text != "")
            {
                ListViewItem lvi = new ListViewItem(txtLink.Text);
                listLinkWebsite.Items.Add(lvi);
                txtLink.Text = "";
            }
            else
            {
                MessageBox.Show(" Vui lòng nhập trang web");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            listLinkWebsite.FocusedItem.Text = txtLink.Text;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = listLinkWebsite.FocusedItem.Index;
            listLinkWebsite.Items.RemoveAt(i);
            txtLink.Text = "";
            myWebsite.Navigate("www.google.com");

        }

        private void listLinkWebsite_MouseClick(object sender, MouseEventArgs e)
        {
            txtLink.Text = listLinkWebsite.FocusedItem.Text;
            if (e.Button == MouseButtons.Left)
                myWebsite.Navigate(listLinkWebsite.FocusedItem.Text);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thoát chương trình", MessageBoxButtons.YesNo);

            // Kiểm tra kết quả từ hộp thoại xác nhận
            if (result == DialogResult.Yes)
            {
                // Đóng ứng dụng nếu người dùng chọn Yes
                Close();
            }
            // Không cần thực hiện hành động nếu người dùng chọn No        }
        }
    }
}
