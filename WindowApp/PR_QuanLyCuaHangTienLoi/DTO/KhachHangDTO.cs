using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public string MaKhachHang { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string HinhAnh { get; set; }

        // Constructor (No Parameter)
        public KhachHangDTO()
        {
            this.MaKhachHang = string.Empty;
            this.HoTen = string.Empty;
            this.GioiTinh = string.Empty;
            this.NgaySinh = DateTime.Now;
            this.DiaChi = string.Empty;
            this.SoDienThoai = string.Empty;
            this.Email = string.Empty;
            this.HinhAnh = string.Empty;
        }

        // Constructor (Parameters)
        public KhachHangDTO(string maKhachHang, string hoTen, string gioiTinh, DateTime ngaySinh, string diaChi, string soDienThoai, string email, string hinhAnh)
        {
            MaKhachHang = maKhachHang;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            Email = email;
            HinhAnh = hinhAnh;
        }
    }
}
