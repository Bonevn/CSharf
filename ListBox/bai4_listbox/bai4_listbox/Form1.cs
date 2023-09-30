using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4_listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string info = txtinfo.Text.ToString();
            listBox1.Items.Add(info);
            txtTong.Text = Convert.ToString(listBox1.Items.Count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
            txtTong.Text = Convert.ToString(listBox1.Items.Count);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(0);
            txtTong.Text = Convert.ToString(listBox1.Items.Count);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            txtTong.Text = Convert.ToString(listBox1.Items.Count);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
            txtTong.Text = Convert.ToString(listBox1.Items.Count);
        }

        private void txtTong_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
