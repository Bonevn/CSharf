using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThemGoc_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add(textBox1.Text);
            textBox1.Text = ""; // trả về textbox trống
        }

        private void btnThemcon_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Nodes.Add(textBox1.Text);
            textBox1.Text = ""; // trả về textbox trống
            treeView1.ExpandAll();
        }

        private void btnxoatatca_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void btnxoadangchon_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
