using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhapChiTietDTO
    {
        
        public string MaPhieuNhapChiTiet { get; set; }
        public string MaSanPham { get; set; }
        public int SoLuong { get; set; }
        public int DonGiaNhap { get; set; }

        // Constructor (No Parameter)
        public PhieuNhapChiTietDTO()
        {
            this.MaPhieuNhapChiTiet = "";
            this.MaSanPham = "";
            this.SoLuong = 0;
            this.DonGiaNhap = 0;
        }

        // ( Constructor Parameters)
        public PhieuNhapChiTietDTO(string maPhieuNhapChiTiet, string maSanPham, int soLuong, int donGiaNhap)
        {
            MaPhieuNhapChiTiet = maPhieuNhapChiTiet;
            MaSanPham = maSanPham;
            SoLuong = soLuong;
            DonGiaNhap = donGiaNhap;
        }

    }
}
