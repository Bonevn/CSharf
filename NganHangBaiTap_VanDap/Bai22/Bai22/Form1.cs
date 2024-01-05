using System;
using System.Windows.Forms;

namespace Bai22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapNhatNV_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem LVitem in listNhanVien.SelectedItems)

            {
                LVitem.SubItems[0].Text = txtTenNV.Text;
                LVitem.SubItems[1].Text = txtChucVuNV.Text;
                LVitem.SubItems[2].Text = txtLuongCBNV.Text;
                LVitem.SubItems[3].Text = txtHeSoLuongNV.Text;
            }
        }

        private void listNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem LIV in listNhanVien.SelectedItems)
            {
                txtTenNV.Text = LIV.SubItems[0].Text;
                txtChucVuNV.Text = LIV.SubItems[1].Text;
                txtLuongCBNV.Text = LIV.SubItems[2].Text;
                txtHeSoLuongNV.Text = LIV.SubItems[3].Text;
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text != "" && txtChucVuNV.Text != "" && txtLuongCBNV.Text != "" && txtHeSoLuongNV.Text != "")
            {
                ListViewItem listViewItem = new ListViewItem(txtTenNV.Text);
                ListViewItem.ListViewSubItem LVSIChucVu = new ListViewItem.ListViewSubItem(listViewItem, txtChucVuNV.Text);
                ListViewItem.ListViewSubItem LVSILCB = new ListViewItem.ListViewSubItem(listViewItem, txtLuongCBNV.Text);
                ListViewItem.ListViewSubItem LVSIHSL = new ListViewItem.ListViewSubItem(listViewItem, txtHeSoLuongNV.Text);
                listViewItem.SubItems.Add(LVSIChucVu);
                listViewItem.SubItems.Add(LVSILCB);
                listViewItem.SubItems.Add(LVSIHSL);
                listNhanVien.Items.Add(listViewItem);
                txtTenNV.Text = "";
                txtChucVuNV.Text = "";
                txtLuongCBNV.Text = "";
                txtHeSoLuongNV.Text = "";
            }
            else
            {
                MessageBox.Show(" Nhập đủ thông tin ");
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (listNhanVien.SelectedItems.Count > 0)
            {
                listNhanVien.Items.RemoveAt(listNhanVien.FocusedItem.Index);
            }
            else
            {
                MessageBox.Show("Phải chọn nhân viên muốn xóa  ");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận với tùy chọn Yes/No
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thoát chương trình", MessageBoxButtons.YesNo);

            // Kiểm tra kết quả từ hộp thoại xác nhận
            if (result == DialogResult.Yes)
            {
                // Đóng ứng dụng nếu người dùng chọn Yes
                Close();
            }
            // Không cần thực hiện hành động nếu người dùng chọn No
        }

        private void btnThemGV_Click(object sender, EventArgs e)
        {
            if (txtTenGV.Text != "" && txtHocVi.Text != "" && txtTienDayMotTiet.Text != "" && txtSoTietDay.Text != "")
            {
                ListViewItem LVItenGV = new ListViewItem(txtTenGV.Text);
                ListViewItem.ListViewSubItem LVSIHocVi = new ListViewItem.ListViewSubItem(LVItenGV, txtHocVi.Text);
                ListViewItem.ListViewSubItem LVSIYDMT = new ListViewItem.ListViewSubItem(LVItenGV, txtTienDayMotTiet.Text);
                ListViewItem.ListViewSubItem LVSISTD = new ListViewItem.ListViewSubItem(LVItenGV, txtSoTietDay.Text);
                LVItenGV.SubItems.Add(LVSIHocVi);
                LVItenGV.SubItems.Add(LVSIYDMT);
                LVItenGV.SubItems.Add(LVSISTD);
                listViewGV.Items.Add(LVItenGV);
                txtTenGV.Text= "";
                txtHocVi.Text = "";
                txtTienDayMotTiet.Text = "";
                txtSoTietDay.Text = "";
            }
            else
            {
                MessageBox.Show(" Nhập đầy đủ thông tin ");
            }
        }

        private void btnCapNhatGV_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem CapNhat in listViewGV.SelectedItems)
            {
                txtTenGV.Text = CapNhat.SubItems[0].Text;
                txtHocVi.Text = CapNhat.SubItems[1].Text;
                txtTienDayMotTiet.Text = CapNhat.SubItems[2].Text;
                txtSoTietDay.Text = CapNhat.SubItems[3].Text;


            }
        }

        private void listViewGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lsi in listViewGV.SelectedItems)
            {
                lsi.SubItems[0].Text = txtTenGV.Text;
                lsi.SubItems[1].Text = txtHocVi.Text;
                lsi.SubItems[2].Text = txtTienDayMotTiet.Text;
                lsi.SubItems[3].Text = txtSoTietDay.Text;
            }
        }

        private void btnXoaGiaoVien_Click(object sender, EventArgs e)
        {
            if(listViewGV.SelectedItems.Count > 0)
            {
                listViewGV.Items.RemoveAt(listViewGV.FocusedItem.Index);
            }
            else
            {
                MessageBox.Show(" Vui lòng chọn giáo viên cần xóa !");
            }
        }
    }
}
