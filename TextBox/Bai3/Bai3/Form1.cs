using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int uscln = TimUSCLN(a, b);
            int bscnn = a * b / uscln;
            uscln_kq.Text = uscln.ToString();
            bscnn_kq.Text = bscnn.ToString();
        }
        static int TimUSCLN(int a, int b)
        {
            while (b != 0 && a != 0)
            {
                if (a < b)
                {
                    int sodu = a;
                    a = b % a;
                    b = sodu;
                }
                else
                {
                    int sodu = b;
                    b = a % b;
                    a = sodu;
                }
            }

            if (a < b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }

        private void uscln_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
