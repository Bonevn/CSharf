using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n = double.Parse(txt_n.Text);
            double S = 0;
            if (rbtn_cong.Checked & n > 0)
            {
                for (double i = 1; i <= n; i++)
                {
                    S += (2 * i - 1);
                }
            }

            if (rbtn_binhphuong.Checked & n > 0)
            {
                for (double i = 1; i <= n; i++)
                {
                    S += (i * i);
                }
            }

            if (rbtn_chia.Checked & n > 0)
            {
                for (double i = 1; i <= n; i++)
                {
                    S += (1/i);
                }
            }

            if (rbtn_chiagiathua.Checked & n > 0)
            {
                for (double i = 1; i <= n; i++)
                {
                    double giaithua = Convert.ToDouble(Tinhgiaithua(i));
                    S += (1 / giaithua);
                }
            }

            ketqua.Text = Convert.ToString(S);
        }

        public double Tinhgiaithua(double n)
        {
            double giaithua = 1;
            for (double i = 1; i <= n; i++)
            {
                giaithua *= i;
            }

            return giaithua;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
