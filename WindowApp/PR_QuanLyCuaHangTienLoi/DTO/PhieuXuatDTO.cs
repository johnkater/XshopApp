using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuXuatDTO
    {
        

        public string MaPhieuXuat { get; set; }
        public string MaNhanVien { get; set; }
        public string MaKhachHang { get; set; }
        public DateTime NgayXuat { get; set; }
        public string TrangThai { get; set; }
        public string GhiChu { get; set; }

        // Constructor (no parameter)
        public PhieuXuatDTO()
        {
            this.MaPhieuXuat = "";
            this.MaNhanVien = "";
            this.MaKhachHang = "";
            this.NgayXuat = DateTime.Now;
            this.TrangThai = "";
            this.GhiChu = "";
           
        }

        // Constructor ( Parameters)
        public PhieuXuatDTO(string maPhieuXuat, string maNhanVien, string maKhachHang, DateTime ngayXuat, string trangThai, string ghiChu)
        {
            MaPhieuXuat = maPhieuXuat;
            MaNhanVien = maNhanVien;
            MaKhachHang = maKhachHang;
            NgayXuat = ngayXuat;
            TrangThai = trangThai;
            GhiChu = ghiChu;
        }
    }
}
