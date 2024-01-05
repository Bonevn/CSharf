using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMoTapTin_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string tentaptin = openFileDialog1.FileName;
                StreamReader rd = new StreamReader(tentaptin);
                txtNoiDung.Text = rd.ReadToEnd();
                rd.Close();
            }
        }

        private void btnLuuTapTin_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string noidung = txtNoiDung.Text;
                string tentaptin = saveFileDialog1.FileName;
                StreamWriter wt = new StreamWriter(tentaptin);
                wt.Write(noidung);
                wt.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(" Bạn có muốn thoát chương trình ?", " Thông báo! ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)

            {
                Close();    
            }
        }
    }
}
