using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tuso1 = int.Parse(txt_tuso1.Text);
            int tuso2 = int.Parse(txt_tuso2.Text);
            int mauso1 = int.Parse(txt_mauso1.Text);
            int mauso2 = int.Parse(txt_mauso2.Text);

            Phanso phanso1 = new Phanso(tuso1, mauso1);
            Phanso phanso2 = new Phanso(tuso2, mauso2);

            Phanso ketQua = phanso1 + phanso2;

            txt_kqtuso.Text = ketQua.Tuso.ToString();
            txt_kqmauso.Text = ketQua.Mauso.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class Phanso
    {
        public int Tuso { get; set; }
        public int Mauso { get; set; }

        public Phanso(int tu, int mau)
        {
            int Tuso = tu;
            int Mauso = mau;
        }

        public static Phanso operator +(Phanso ps1, Phanso ps2)
        {
            int Tusomoi = ps1.Tuso * ps2.Mauso + ps2.Tuso * ps1.Mauso;
            int Mausomoi = ps1.Mauso * ps2.Mauso;

            int USCLN = Phanso.USCLN(Tusomoi, Mausomoi);
            return new Phanso(Tusomoi, Mausomoi);
        }

        public static int USCLN(int a, int b)
        {
            while (b!=0)
            {
                int sodu = a%b;
                a = b;
                b = sodu;
            }

            return a;
        }
        public void RutGon()
        {
            int ucln = USCLN(Tuso, Mauso);
            Tuso /= ucln;
            Mauso /= ucln;
        }
    }
}
