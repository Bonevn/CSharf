using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hoten = txtname.Text;
            string lop = txtlop.Text;
            string cacmonhoc = "";

            List<string> monhoc = new List<string>();
            if (checkBox1.Checked) monhoc.Add(checkBox1.Text);
            if (checkBox2.Checked) monhoc.Add(checkBox2.Text);
            if (checkBox3.Checked) monhoc.Add(checkBox3.Text);
            if (checkBox4.Checked) monhoc.Add(checkBox4.Text);

            for (int i = 0; i < monhoc.Count; i++) 
            {
                if (i == (monhoc.Count - 1))
                {
                    cacmonhoc += monhoc[i];
                }
                else cacmonhoc += monhoc[i] + ", ";
            }
            MessageBox.Show("Họ tên: " + hoten + "\n" + "Lớp: " + lop + "\n" + "Các môn học: " + cacmonhoc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
