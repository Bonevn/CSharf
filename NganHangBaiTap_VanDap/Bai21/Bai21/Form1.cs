using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < myImageList.Images.Count; i++)
            {
                PictureBox pic = new PictureBox();

                // Đặt hình ảnh của PictureBox là hình ảnh tương ứng từ ImageList
                pic.Image = myImageList.Images[i];

                pic.Size = new Size(50, 50);

                // Gắn sự kiện Click cho PictureBox mới tạo
                pic.Click += new EventHandler(Form1_Click);

                // Thêm PictureBox vào FlowLayoutPanel
                myFlowLayoutPanel.Controls.Add(pic);
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy PictureBox được click từ đối tượng gửi sự kiện (sender)
                PictureBox pic = (PictureBox)sender;

                // Đặt hình ảnh của PictureBox đã được click vào PictureBox lớn (myPictureBox)
                myPictureBox.Image = pic.Image;
            }
            catch (Exception ex)
            {
            }
        }
    }
}
