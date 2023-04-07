using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuXuatChiTietDTOcs
    {
        

        public string MaPhieuXuatChiTiet { get; set; }
        public string MaSanPham { get; set; }
        public int SoLuong { get; set; }

        // Constructor (No Parameter)
        public PhieuXuatChiTietDTOcs()
        {
            this.SoLuong = 0;
            this.MaSanPham = "";
            this.MaPhieuXuatChiTiet = "";
        }
        // Constructor (Parameters)
        public PhieuXuatChiTietDTOcs(string maPhieuXuatChiTiet, string maSanPham, int soLuong)
        {
            MaPhieuXuatChiTiet = maPhieuXuatChiTiet;
            MaSanPham = maSanPham;
            SoLuong = soLuong;
        }

    }
}
