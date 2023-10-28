using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_NET1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string password = txtpassword.Text;

            if (username == "admin" & password == "1")
            {
                txtpassword.Clear();
                Dashboard ds = new Dashboard();
                this.Hide();
                ds.Show();
            }
            else
            {
                labelerror.Visible = true;
            }

        }

    }
}
