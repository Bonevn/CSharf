using System;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string txtsanpham1 = Convert.ToString(this.txtsanpham1.Text);
            listBox1.Items.Add(txtsanpham1);
            Thietlaplaivitricombo();
            this.txtsanpham1.Clear();

        }

        private void btnThemVT_Click(object sender, EventArgs e)
        {
            string txtsanpham2 = Convert.ToString(this.txtsanpham2.Text);
            if (txtsanpham2 != "")
            {
                listBox1.Items.Insert(comboBox1.SelectedIndex, txtsanpham2);
            }
            else
            {
                MessageBox.Show("Vui vòng nhập sản phẩm");
            }
            this.txtsanpham2.Clear();
            Thietlaplaivitricombo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thietlaplaivitricombo();
        }

        private void Thietlaplaivitricombo()
        {
            comboBox1.Items.Clear();
            int chiso = listBox1.Items.Count;
            for (int i = 0; i < chiso; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            while (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string timkiem = Convert.ToString(textBox3.Text);
            if (timkiem != "")
            {
                if (listBox1.Items.Contains(timkiem))
                {
                    MessageBox.Show("Có sản phẩm trong danh sách");
                }
                else
                {
                    MessageBox.Show("Không có sản phẩm trong danh sách");
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsanpham2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsanpham1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
