using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ho = Convert.ToString(txt_ho.Text);
            string ten = Convert.ToString(txt_ten.Text);
            string sdt = Convert.ToString(txt_sdt.Text);

            ListViewItem item = new ListViewItem(ho);
            item.SubItems.Add(ten);
            item.SubItems.Add(sdt);
            item.ImageIndex = 0;
            listView1.Items.Add(item);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cb1 = comboBox1.SelectedItem.ToString();
            switch (cb1)
            {
                case "Details":
                    listView1.View = View.Details;
                    break;
                case "List":
                    listView1.View = View.List;
                    break;
                case "Title":
                    listView1.View = View.Tile;
                    break;
            }
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Details");
            comboBox1.Items.Add("List");
            comboBox1.Items.Add("Title");

            comboBox1.SelectedIndex = 0;
            listView1.View = View.Details;
            listView1.SmallImageList = imageList1;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
