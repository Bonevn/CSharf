using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(nhapa.Text);
            listBox1.Items.Add(a);

        }

        private void quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tong_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (int item in listBox1.Items)
            {
                sum += item;
            }

            MessageBox.Show("Tổng danh sách là: " + sum);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = listBox1.Items.Count;

            listBox1.Items.RemoveAt(0);
            listBox1.Items.RemoveAt(n-2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<int> list_rm = new List<int>();

            foreach (int item in listBox1.SelectedItems)
            {
                list_rm.Add(item);
            }

            foreach (int item in list_rm)
            {
                listBox1.Items.Remove(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> tang2dv = new List<int>();
            foreach (int item in listBox1.SelectedItems)
            {
                tang2dv.Add(item);
            }

            foreach (int item in tang2dv)
            {
                item += 2;
            }
        }
    }
}
