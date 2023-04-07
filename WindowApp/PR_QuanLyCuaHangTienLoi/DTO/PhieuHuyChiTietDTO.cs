using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuHuyChiTietDTO
    {
       
        public string MaPhieuHuyChiTiet { get; set; }
        public string MaSanPham { get; set; }
        public int SoLuong { get; set; }

        // Constructor (Parameters)
        public PhieuHuyChiTietDTO(string maPhieuHuyChiTiet, string maSanPham, int soLuong)
        {
            MaPhieuHuyChiTiet = maPhieuHuyChiTiet;
            MaSanPham = maSanPham;
            SoLuong = soLuong;
        }
        // Constructor (No Parameter)
        public PhieuHuyChiTietDTO()
        {
            this.MaPhieuHuyChiTiet = "";
            this.MaSanPham = "";
            this.SoLuong = 0;
        }

    }
}
