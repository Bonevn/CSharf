using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            while (listBox2.SelectedIndex >= 0)
            {
                listBox2.Items.Remove(listBox2.SelectedItems[0]);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (string item in listBox1.Items)
            {
                listBox2.Items.Add(item);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string thucdon = "";
            foreach (string item in listBox2.Items)
            {
                thucdon = thucdon + item + "\n";
            }
            MessageBox.Show(thucdon);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
