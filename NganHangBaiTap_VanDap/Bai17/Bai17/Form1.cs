using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai17
{
    public partial class Form1 : Form
    {
        private int a = 0;
        private int b = 0;
        private float x = 0;
        Random rd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int so_a = rd.Next(-10, 10);
            int so_b = rd.Next(-10, 10);
            textBox1.Text = so_a.ToString();
            textBox2.Text = so_b.ToString();
            x = -so_b / (float)so_a;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(x.ToString());
            float kq = float.Parse(textBox1.Text);
            if (Math.Abs(kq - x) < 0.01)
            {
                MessageBox.Show("Bạn đã trả lời đúng");
                Close();
            }
            else
            {
                MessageBox.Show("Bạn đã trả lời sai");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 30000)
            {
                timer1.Enabled = false;
                MessageBox.Show("Hết thời gian làm bài");
            }
            progressBar1.PerformStep();
        }
    }
}
