using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Bai1
{
    internal class Class1
    {
        // String kết nối tới cơ sở dữ liệu
        string connectionString = "Server=localhost; Database=bonevn.Bai1; Integrated Security=True;";

        // Hàm để mở kết nối
        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Hàm để thực hiện thêm dữ liệu
        private void AddData(string maNV, string hoTen, string diaChi)
        {
            string query = "INSERT INTO nhanvien (manv, hoten, diachi) VALUES (@manv, @hoten, @diachi)";
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@manv", maNV);
                    cmd.Parameters.AddWithValue("@hoten", hoTen);
                    cmd.Parameters.AddWithValue("@diachi", diaChi);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
