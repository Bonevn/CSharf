using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float Tu1, Tu2, Mau1, Mau2, Tu, Mau, usc;

        private void btTieptuc_click_Click(object sender, EventArgs e)
        {
            KhungTu1.Clear();
            KhungMau1.Clear();
            KhungTu2.Clear();
            KhungMau2.Clear();
            KhungKetQuaTu.Clear();
            KhungKetQuaMau.Clear();
        }

        private void btThoat_click_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btChia_click_Click(object sender, EventArgs e)
        {
            this.groupboxKetQua.Text = "Kết quả Chia";
            Tu = Tu1 * Mau2;
            Mau = Mau1 * Tu2;
            usc = USCLN(Tu, Mau);
            KhungKetQuaTu.Text = Convert.ToString(Tu / usc);
            KhungKetQuaMau.Text = Convert.ToString(Mau / usc);
        }

        private void btNhan_click_Click(object sender, EventArgs e)
        {
            this.groupboxKetQua.Text = "Kết quả Nhân";
            Tu = Tu1 * Tu2;
            Mau = Mau1 * Mau2;
            usc = USCLN(Tu, Mau);
            KhungKetQuaTu.Text = Convert.ToString(Tu / usc);
            KhungKetQuaMau.Text = Convert.ToString(Mau / usc);
        }

        private void btTru_click_Click(object sender, EventArgs e)
        {
            this.groupboxKetQua.Text = "Kết quả Trừ";
            Tu = (Tu1 * Mau2) - (Tu2 * Mau1);
            Mau = Mau1 * Mau2;
            usc = USCLN(Tu, Mau);
            KhungKetQuaTu.Text = Convert.ToString(Tu / usc);
            KhungKetQuaMau.Text = Convert.ToString(Mau / usc);
        }

        private void btCong_click_Click(object sender, EventArgs e)
        {
            this.groupboxKetQua.Text = "Kết quả Cộng";
            Tu = (Tu1 * Mau2) + (Tu2 * Mau1);
            Mau = Mau1 * Mau2;
            usc = USCLN(Tu, Mau);
            KhungKetQuaTu.Text = Convert.ToString(Tu / usc);
            KhungKetQuaMau.Text = Convert.ToString(Mau / usc);
        }

        private void groupboxPhepTinh_enter(object sender, EventArgs e)
        {
            Tu1 = float.Parse(KhungTu1.Text);
            Tu2 = float.Parse(KhungTu2.Text);
            Mau1 = float.Parse(KhungMau1.Text);
            Mau2 = float.Parse(KhungMau2.Text);
        }
        public static float USCLN(float a, float b)
        {
            if (a == 0 || b == 0)
                return a + b;
            while (a != b)
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            return a;
        }

    }
}
