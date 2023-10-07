using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(textBox1, "Tên đăng nhập không dấu, không khoảng trắng");
            toolTip1.SetToolTip(textBox2, "Nhập ít nhất 6 ký tự, nhiều nhất 10 ký tự");
            helpProvider1.SetShowHelp(textBox1, true);
            helpProvider1.HelpNamespace = "https://translate.google.com/";
        }
    }
}
