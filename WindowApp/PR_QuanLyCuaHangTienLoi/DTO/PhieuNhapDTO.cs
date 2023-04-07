using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhapDTO
    {
        // 
        public string MaPhieuNhap { get; set; }
        public string MaNhanVien { get; set; }
        public string MaNhaCungCap { get; set; }
        public DateTime NgayNhap { get; set; }
        public string TrangThai { get; set; }
        public string GhiChu { get; set; }

        // Constructor ( No Parameter )
        public PhieuNhapDTO()
        {
            this.MaPhieuNhap = "";
            this.MaNhanVien = "";
            this.MaNhaCungCap = "";
            this.NgayNhap = DateTime.Now;
            this.GhiChu = "";
            this.TrangThai = "";
            
        }
        // ( Constructor Parameters )
        public PhieuNhapDTO(string maPhieuNhap, string maNhanVien, string maNhaCungCap, DateTime ngayNhap, string trangThai, string ghichu)
        {
            MaPhieuNhap = maPhieuNhap;
            MaNhanVien = maNhanVien;
            MaNhaCungCap = maNhaCungCap;
            NgayNhap = ngayNhap;
            TrangThai = trangThai;
            GhiChu = ghichu;
        }
    }
}
