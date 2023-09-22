using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nhap_a_TextChanged(object sender, EventArgs e)
        {

        }

        private void nhap_b_TextChanged(object sender, EventArgs e)
        {

        }

        private void nhap_c_TextChanged(object sender, EventArgs e)
        {

        }

        private void tim_Click(object sender, EventArgs e)
        {
            int a = int.Parse(nhap_a.Text);
            int b = int.Parse(nhap_b.Text);
            int c = int.Parse(nhap_c.Text);

            int max = a;

            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }

            int min = a;
            if (b < min)
            {
                min = b;
            }
            if (c < min)
            {
                min = c;
            }

            so_max.Text = max.ToString();
            so_min.Text = min.ToString();
        }

        private void so_max_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void so_min_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
