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

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(nhapn.Text);
            int tong = 0;
            string in_pheptinh = "";

            for (int i = 1; i <= n; i++)
            {
                tong += i;

                in_pheptinh += i;
                if (i < n)
                {
                    in_pheptinh += "+";
                }
            }
            pheptinh.Text = in_pheptinh;
            ketqua.Text = tong.ToString();

        }
    }
}
