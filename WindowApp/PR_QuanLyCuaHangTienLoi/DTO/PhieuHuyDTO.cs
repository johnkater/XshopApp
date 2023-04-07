using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuHuyDTO
    {
      
        public string MaPhieuHuy { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime NgayHuy { get; set; }
        public string TrangThai { get; set; }
        public string GhiChu { get; set; }
        // Constructor (Parameters)
        public PhieuHuyDTO(string maPhieuHuy, string maNhanVien, DateTime ngayHuy, string trangThai, string ghiChu)
        {
            MaPhieuHuy = maPhieuHuy;
            MaNhanVien = maNhanVien;
            NgayHuy = ngayHuy;
            TrangThai = trangThai;
            GhiChu = ghiChu;
        }
        // Constructor (No Parameter)
        public PhieuHuyDTO()
        {
            this.MaPhieuHuy = "";
            this.MaNhanVien = "";
            this.GhiChu = "";
            this.NgayHuy = DateTime.Now;
            this.TrangThai = "Chưa duyệt";
        }

    }
}
