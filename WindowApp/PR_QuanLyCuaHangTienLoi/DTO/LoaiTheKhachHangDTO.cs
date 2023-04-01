using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiTheKhachHangDTO
    {
        

        public int MaLoaiTheKhachHang { set; get; }
        public string TenLoaiTheKhachHang { set; get; }

        // Constructor (No Parameters)
        public LoaiTheKhachHangDTO()
        {
            this.MaLoaiTheKhachHang = 0;
            this.TenLoaiTheKhachHang = "";
        }
        // Constructor (Parameters)
        public LoaiTheKhachHangDTO(int maLoaiTheKhachHang, string tenLoaiTheKhachHang)
        {
            MaLoaiTheKhachHang = maLoaiTheKhachHang;
            TenLoaiTheKhachHang = tenLoaiTheKhachHang;
        }


    }
}
