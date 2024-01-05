﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChonMau_Click(object sender, EventArgs e)
        {
            ColorDialog clDLog = new ColorDialog();
            DialogResult rs = clDLog.ShowDialog();
            if (rs == DialogResult.OK)
            {
                if (radMauChu.Checked == true)
                {
                    lblHienThi.ForeColor = clDLog.Color;
                }
                if (radMauNen.Checked == true)
                {
                    lblHienThi.BackColor = clDLog.Color;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(" Bạn có chắc chắn muốn thoát ? ",
                " Thoát chương trình ", MessageBoxButtons.YesNo);
            if( result == DialogResult.Yes)
                Close();    
        }
    }
}

