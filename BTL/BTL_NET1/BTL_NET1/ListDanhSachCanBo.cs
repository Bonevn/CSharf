using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_NET1
{
    public class DanhSachCanBo
    {
        private string macb;
        private string name;
        private DateTime ngaysinh;
        private string gioitinh;

        public string MaCB { get => macb; set => macb = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }

        public DanhSachCanBo(string MaCB, string name, DateTime ngaysinh, string gioitinh)
        {
            this.MaCB = MaCB;
            this.name = name;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
        }
        public DanhSachCanBo() { }
    }
    public class ListDanhSachCanBo
    {
        private static ListDanhSachCanBo instance;

        private List<DanhSachCanBo> ListDanhsachcb;

        public List<DanhSachCanBo> ListDanhsachcb1 { get => ListDanhsachcb; set => ListDanhsachcb = value; }
        public static ListDanhSachCanBo Instance
        {
            get 
            {
                if (instance == null) instance = new ListDanhSachCanBo(); return instance;
            }
            set => instance = value; 
        }

        private ListDanhSachCanBo()
        {
            ListDanhsachcb = new List<DanhSachCanBo>
            {
            };
        }
    }
}
