using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO.NET_Bai1
{
    
    public partial class frmtaomoitk : Form
    {
        private string chuoiketnoi = "Data Source=BONEVN;Initial Catalog=master;Integrated Security=True";
        SqlConnection cn;
        string sql;
        SqlCommand cmdSelect;
        SqlCommand cmdInsert;
        SqlCommand cmdXoa;
        int i = 0;
        public frmtaomoitk()
        {
            InitializeComponent();
            cn = new SqlConnection(chuoiketnoi);
        }

        private void buttaomoi_Click(object sender, EventArgs e)
        {
            
            if (!Kiemtra_manv()) 
            {
                sql = @"INSERT INTO nhanvien (manv, hoten, diachi, tendangnhap, matkhau, quyenhan) VALUES (@manv, @hoten, @diachi, @tendangnhap, @matkhau, @quyenhan) ";
                cmdInsert = new SqlCommand(sql, cn);
                cmdInsert.Parameters.AddWithValue("@manv", txtmanv.Text);
                cmdInsert.Parameters.AddWithValue("@hoten", txthoten.Text);
                cmdInsert.Parameters.AddWithValue("@diachi", txtdiachi.Text);
                cmdInsert.Parameters.AddWithValue("@tendangnhap", txttendangnhap.Text);
                cmdInsert.Parameters.AddWithValue("@matkhau", ""); // mật khẩu ban đầu là rỗng
                cmdInsert.Parameters.AddWithValue("@quyenhan", cbquyenhan.Text);

                cn.Open();
                cmdInsert.ExecuteNonQuery();
                MessageBox.Show("Đã tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Mã nhân viên đã tồn tại vui lòng sử dụng mã khác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cn.Close();
            LoadListView();
        }

        private bool Kiemtra_manv()
        {
            string manv = txtmanv.Text;
            sql = @"SELECT manv FROM nhanvien where manv = @manv";
            cmdSelect = new SqlCommand(sql, cn);
            cmdSelect.Parameters.AddWithValue("@manv", manv);
            cn.Open();
            SqlDataReader docdulieu = cmdSelect.ExecuteReader();

            if (docdulieu.Read())
            {
                string manv_sql = docdulieu["manv"].ToString();
                return true;
            }
            cn.Close();
            return false;
        }

        private void LoadListView()
        {
            listView1.Items.Clear();
            sql = @"SELECT * FROM nhanvien";
            cmdSelect = new SqlCommand(sql, cn);
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            SqlDataReader docdulieu = cmdSelect.ExecuteReader();

            while (docdulieu.Read())
            {
                ListViewItem item = new ListViewItem(docdulieu["manv"].ToString());
                item.SubItems.Add(docdulieu["hoten"].ToString());
                item.SubItems.Add(docdulieu["diachi"].ToString());
                item.SubItems.Add(docdulieu["tendangnhap"].ToString());
                item.SubItems.Add(docdulieu["quyenhan"].ToString());

                listView1.Items.Add(item);
            }
            cn.Close();
        }

        private void frmtaomoitk_Load(object sender, EventArgs e)
        {
            LoadListView();
        }

        private void buttimkiem_Click(object sender, EventArgs e)
        {
            string manv = txtmanv.Text;
            if (manv.Length > 0)
            {
                sql = @"SELECT * FROM nhanvien WHERE manv = @manv";
                cmdSelect = new SqlCommand (sql, cn);
                cmdSelect.Parameters.AddWithValue("@manv", manv);
                cn.Open();
                SqlDataReader docdulieu = cmdSelect.ExecuteReader();

                if (docdulieu.Read())
                {
                    txtmanv.Text = docdulieu["manv"].ToString();
                    txthoten.Text = docdulieu["hoten"].ToString();
                    txtdiachi.Text = docdulieu["diachi"].ToString();
                    txttendangnhap.Text = docdulieu["tendangnhap"].ToString();
                    cbquyenhan.Text = docdulieu["quyenhan"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã nhân viên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cn.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên để tìm kiếm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void butxoabo_Click(object sender, EventArgs e)
        {
            string manv = txtmanv.Text;
            sql = @"DELETE FROM nhanvien WHERE manv = @manv";
            cmdXoa = new SqlCommand(sql, cn);
            cmdXoa.Parameters.AddWithValue("@manv", manv);
            cn.Open();
            if (cmdXoa.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Đã xoá nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListView();
            }
            else
            {
               MessageBox.Show("Nhân viên không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cn.Close();
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LoadItem (int i)
        {
            txtmanv.Text = listView1.Items[i].Text;
            txthoten.Text = listView1.Items[i].SubItems[1].Text;
            txtdiachi.Text = listView1.Items[i].SubItems[2].Text;
            txttendangnhap.Text = listView1.Items[i].SubItems[3].Text;
            cbquyenhan.Text = listView1.Items[i].SubItems[4].Text;
        }

        private void butdau_Click(object sender, EventArgs e)
        {
            i = 0;
            LoadItem(i);
        }

        private void butlui_Click(object sender, EventArgs e)
        {
            i++;
            LoadItem(i);
        }

        private void buttien_Click(object sender, EventArgs e)
        {
            i--;
            LoadItem(i);
        }

        private void butcuoi_Click(object sender, EventArgs e)
        {
            i = listView1.Items.Count - 1;
            LoadItem(i);
        }
    }
}