using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(nhapn.Text);
            string SNT = "";

            for (int i = 2; i < n; i++)
            {
                if (i == 2)
                {
                    SNT += i + " ";
                    i++;
                    
                }

                if (i == 3)
                {
                    SNT += i + " ";
                    i++;
                }

                if (i == 5)
                {
                    SNT += i + " ";
                    i++;
                }

                if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 || i == 7)
                {
                    SNT += i + " ";
                }

            }

            this.SNT.Text = SNT;
        }
    }
}
