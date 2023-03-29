using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public string MaNhanVien { set; get; }
        public string HoTen { set; get; }
        public string GioiTinh { set; get; }
        public DateTime NgaySinh { set; get; }
        public string DiaChi { set; get; }
        public string QueQuan { set; get; }
        public string SoDienThoai { set; get; }
        public string Email { set; get; }
        public string HinhAnh { set; get; }

        public NhanVienDTO()
        {
            this.MaNhanVien = "";
            this.HoTen = "";
            this.GioiTinh = "";
            this.NgaySinh = DateTime.Now;
            this.DiaChi = "";
            this.QueQuan = "";
            this.SoDienThoai = "";
            this.Email = "";
            this.HinhAnh = "";

        }
        // Constructor
        public NhanVienDTO(string maNhanVien, string hoTen, string gioiTinh, DateTime ngaySinh, string diaChi, string queQuan, string soDienThoai, string email, string hinhAnh)
        {
            MaNhanVien = maNhanVien;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            QueQuan = queQuan;
            SoDienThoai = soDienThoai;
            Email = email;
            HinhAnh = hinhAnh;
        }
    }
}
