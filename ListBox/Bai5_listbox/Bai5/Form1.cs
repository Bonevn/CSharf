using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = Convert.ToString(txtfirst.Text);
            string lastname = Convert.ToString(txtlast.Text);
            string info = "";
            listBox1.Items.Add(gender.Text + " " + firstname + " " + lastname);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
