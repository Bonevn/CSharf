using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txt_n.Text);
            String nhiphan = "";
            while (n >0)
            {
                int sodu;
                sodu = n % 2;
                nhiphan += sodu;
                n /= 2;
            }

            ketqua.Text = nhiphan;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
