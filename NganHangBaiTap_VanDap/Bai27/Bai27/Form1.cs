using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {

                // Lấy thông tin từ người dùng
                string hoTen = txtHoten.Text;
                DateTime ngaySinh;
                if (!DateTime.TryParse(txtDate.Text, out ngaySinh))
                {
                    MessageBox.Show("Ngày tháng năm sinh không hợp lệ!", "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string phai = radNam.Checked ? "Nam" : "Nữ";

                // Tính tuổi
                int tuoi = DateTime.Now.Year - ngaySinh.Year;

                // Xác định nhân xưng
                string nhanXung = "";
                if (phai == "Nam")
                {
                    if (tuoi >= 1 && tuoi <= 10)
                        nhanXung = "Cháu";
                    else if (tuoi >= 11 && tuoi <= 17)
                        nhanXung = "Em";
                    else if (tuoi >= 18 && tuoi <= 34)
                        nhanXung = "Anh";
                    else if (tuoi >= 35 && tuoi <= 70)
                        nhanXung = "Ông";
                    else
                        nhanXung = "Cụ";
                }
                else // Nữ
                {
                    if (tuoi >= 1 && tuoi <= 10)
                        nhanXung = "Cháu";
                    else if (tuoi >= 11 && tuoi <= 23)
                        nhanXung = "Em";
                    else if (tuoi >= 24 && tuoi <= 30)
                        nhanXung = "Chị";
                    else if (tuoi >= 31 && tuoi <= 65)
                        nhanXung = "Bà";
                    else
                        nhanXung = "Cụ";
                }

                // Hiển thị thông báo
                MessageBox.Show($"{hoTen}, {nhanXung} {tuoi} tuổi, sinh vào ngày {ngaySinh.ToString("dddd")}", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    }
    
