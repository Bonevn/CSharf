using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtn_do.Checked) richTextBox1.ForeColor = Color.Red;
            if (rbtn_xanh.Checked) richTextBox1.ForeColor = Color.Aqua;
            if (rbtn_den.Checked) richTextBox1.ForeColor = Color.Black;

            FontFamily f = new FontFamily("Times New Roman");
            richTextBox1.Font = new Font(f, 15);

            if (indam.Checked & nghieng.Checked == false & gachduoi.Checked == false) {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold);
            }
            else if (indam.Checked == false & nghieng.Checked & gachduoi.Checked == false)
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Italic);
            }
            else if (indam.Checked == false & nghieng.Checked ==false & gachduoi.Checked)
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Underline);
            }
            else if (indam.Checked & nghieng.Checked & gachduoi.Checked == false)
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold ^ FontStyle.Italic);
            }
            else if (indam.Checked & nghieng.Checked == false & gachduoi.Checked)
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold ^ FontStyle.Underline);
            }
            else if (indam.Checked == false & nghieng.Checked & gachduoi.Checked)
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Italic ^ FontStyle.Underline);
            }
            else if (indam.Checked & nghieng.Checked & gachduoi.Checked)
            {
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold ^ FontStyle.Italic ^ FontStyle.Underline);
            }
            richTextBox1.Text = "Trường đại học Mỏ - Địa chất - Khoa Công nghệ Thông tin";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
