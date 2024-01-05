using System;
using System.Windows.Forms;

namespace Bai28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtHoDem.Focus();
        }

        private void btnXemTT_Click(object sender, EventArgs e)
        {
            // Khai báo các biến 
            String strMessage, strHoten, strTile, strNgoaiNgu = "";
            strHoten = txtHoDem.Text + " " + txtTen.Text;

            // Xác định xưng hô dựa vào lựa chọn giới tính
            if (radNam.Checked == true)
                strTile = " Mr. ";
            else
                strTile = " Mrs. ";

            // Tạo chuỗi chào hỏi
            strMessage = " Xin chào: " + strTile + " " + strHoten;

            // Kiểm tra các ô chọn ngoại ngữ và cập nhật thông tin ngoại ngữ
            if (chkTiengAnh.Checked == true)
            {
                strNgoaiNgu = " Tiếng Anh ";
            }
            if (chkTiengTrung.Checked == true)
            {
                strNgoaiNgu = (strNgoaiNgu.Length == 0) ? " Tiếng Trung " : (strNgoaiNgu + " và Tiếng Trung");
            }

            // Thêm thông tin ngoại ngữ vào chuỗi chào hỏi
            strMessage = strMessage + "\nNgoại ngữ của bạn là : " + strNgoaiNgu;

            // Thêm thông tin quê quán vào chuỗi chào hỏi sử dụng vòng lặp
            foreach (string item in lstQueQuan.SelectedItems)
            {
                strMessage = strMessage + "\nQuê quán:" + item;
            }

            // Hiển thị hộp thoại thông báo với thông tin đã xây dựng
            MessageBox.Show(strMessage);
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu đã nhập và thiết lập lại trạng thái ban đầu
            txtHoDem.Clear();
            txtTen.Clear();
            radNam.Checked = false;
            radNu.Checked = false;
            chkTiengAnh.Checked = false;
            chkTiengTrung.Checked = false;
            lstQueQuan.SelectedItem = null;
            txtHoDem.Focus();
        }
    }
}
