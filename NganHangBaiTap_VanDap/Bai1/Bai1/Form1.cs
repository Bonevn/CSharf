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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string pheptoan = "";

        private void so1_Click(object sender, EventArgs e)
        {
            String number = textBox1.Text;
            number += "1";
            textBox1.Text = number;
        }

        private void so2_Click(object sender, EventArgs e)
        {
            String number = textBox1.Text;
            number += "2";
            textBox1.Text = number;
        }

        private void so9_Click(object sender, EventArgs e)
        {
            String number = textBox1.Text;
            number += "9";
            textBox1.Text = number;
        }

        private void so4_Click(object sender, EventArgs e)
        {
            String number = textBox1.Text;
            number += "4";
            textBox1.Text = number;
        }

        private void so5_Click(object sender, EventArgs e)
        {
            String number = textBox1.Text;
            number += "5";
            textBox1.Text = number;
        }

        private void so6_Click(object sender, EventArgs e)
        {
            String number = textBox1.Text;
            number += "6";
            textBox1.Text = number;
        }

        private void so7_Click(object sender, EventArgs e)
        {
            String number = textBox1.Text;
            number += "7";
            textBox1.Text = number;
        }

        private void so8_Click(object sender, EventArgs e)
        {
            String number = textBox1.Text;
            number += "8";
            textBox1.Text = number;
        }

        private void so3_Click(object sender, EventArgs e)
        {
            String number = textBox1.Text;
            number += "3";
            textBox1.Text = number;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            String number = textBox1.Text;
            number += "0";
            textBox1.Text = number;
        }
        private void daucong_Click(object sender, EventArgs e)
        {
            String number = textBox1.Text;
            number += "+";
            textBox1.Text = number;
            pheptoan = "+";
        }

        private void dautru_Click(object sender, EventArgs e)
        {
            String number = textBox1.Text;
            number += "-";
            textBox1.Text = number;
            pheptoan = "-";
        }

        private void daunhan_Click(object sender, EventArgs e)
        {
            String number = textBox1.Text;
            number += "*";
            textBox1.Text = number;
            pheptoan = "*";
        }

        private void dauchia_Click(object sender, EventArgs e)
        {
            String number = textBox1.Text;
            number += "/";
            textBox1.Text = number;
            pheptoan = "/";
        }
        private void button16_Click(object sender, EventArgs e)
        {
            String number = textBox1.Text;
            number += ".";
            textBox1.Text = number;
        }
        private void daubang_Click(object sender, EventArgs e)
        {
            string number = textBox1.Text;
            string[] socantinhs = number.Split(Convert.ToChar(pheptoan));
            double ketqua = Convert.ToDouble(socantinhs[0]);

            if (pheptoan == "+")
            {
                for (int i = 1; i < socantinhs.Length; i++)
                {
                    ketqua += Convert.ToDouble(socantinhs[1]);
                }
            }
            else if (pheptoan == "-")
            {
                for (int i = 1; i < socantinhs.Length; i++)
                {
                    ketqua -= Convert.ToDouble(socantinhs[1]);
                }
            }
            else if (pheptoan == "*")
            {
                for (int i = 1; i < socantinhs.Length; i++)
                {
                    ketqua *= Convert.ToDouble(socantinhs[1]);
                }
            }
            else if (pheptoan == "/")
            {
                for (int i = 1; i < socantinhs.Length; i++)
                {
                    ketqua /= Convert.ToDouble(socantinhs[1]);
                }
            }

            textBox1.Text = Convert.ToString(ketqua);
        }
        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}