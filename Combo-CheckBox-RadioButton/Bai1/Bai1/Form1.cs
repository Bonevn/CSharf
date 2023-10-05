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

        private void button1_Click(object sender, EventArgs e)
        {
            double a = int.Parse(txtsoa.Text);
            double b = int.Parse(txtsob.Text);
            double kq = 0;
            if (comboBox1.Text == "+") kq = a + b;
            if (comboBox1.Text == "-") kq = a - b;
            if (comboBox1.Text == "*") kq = a * b;
            if (comboBox1.Text == "/") kq = a / b;

            ketqua.Text = Convert.ToString(kq);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
