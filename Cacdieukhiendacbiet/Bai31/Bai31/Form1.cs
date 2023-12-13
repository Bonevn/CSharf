using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bai31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] drives = Directory.GetLogicalDrives(); // Lấy ổ đĩa và lưu vào list drives
            for (int i = 0; i < drives.Length; i++)
            {
                TreeNode node = new TreeNode(drives[i]);
                treeView1.Nodes.Add(node);
                node.Nodes.Add(new TreeNode("*")); // nút con giả
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            Form1.ActiveForm.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            if (e.Node.Nodes.Count != 0)
            {
                treeView1.Nodes.RemoveAt(0);
            }
            String[] dirs = new String[0];
            try
            {
                dirs = Directory.GetDirectories(e.Node.FullPath); // Lấy danh sách thư mục
                Array.Sort(dirs); // Sắp xếp
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi: "+ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            for (int i = 0; i < dirs.Length; i++)
            {
                String dirName = dirs[i];
                TreeNode node = new TreeNode(Path.GetFileName(dirName));
                treeView1.Nodes.Add(node);
                String[] subdirs = new String[0];
                try
                {
                    subdirs = Directory.GetDirectories(dirs[i]); // kiểm tra xem thư mục vừa thêm có thư mục con hay không, nếu có thì thêm nút giả vào
                    if (subdirs.Length > 0)
                    {
                        node.Nodes.Add("temp");
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi thêm nút giả", ex.Message);
                }

            }
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            Form1.ActiveForm.Text = e.Node.FullPath;
        }
    }
}
