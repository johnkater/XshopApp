using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        

        public string MaSanPham { set; get; }
        public string MaVach { set; get; }
        public string TenSanPham { set; get; }
        public int DonGiaBan { set; get; }
        public string DonViTinh { set; get; }
        public DateTime NgaySanXuat { set; get; }
        public DateTime HanSuDung { set; get; }
        public int MaLoaiSanPham { set; get; }
        public string MaKhuyenMai { set; get; }
        public string HinhAnh { set; get; }

        // Constructor (No Parameter)
        public SanPhamDTO()
        {
            this.MaSanPham = "";
            this.MaVach = "";
            this.TenSanPham = "";
            this.DonGiaBan = 0;
            this.DonViTinh = "";
            this.NgaySanXuat = DateTime.Now;
            this.HanSuDung = DateTime.Now;
            this.MaLoaiSanPham = 0;
            this.MaKhuyenMai = "";
            this.HinhAnh = "";
        }

        // Constructor (Parameters)
        public SanPhamDTO(string maSanPham, string maVach, string tenSanPham, int donGiaBan, string donViTinh, DateTime ngaySanXuat, DateTime hanSuDung, int maLoaiSanPham, string maKhuyenMai, string hinhAnh)
        {
            MaSanPham = maSanPham;
            MaVach = maVach;
            TenSanPham = tenSanPham;
            DonGiaBan = donGiaBan;
            DonViTinh = donViTinh;
            NgaySanXuat = ngaySanXuat;
            HanSuDung = hanSuDung;
            MaLoaiSanPham = maLoaiSanPham;
            MaKhuyenMai = maKhuyenMai;
            HinhAnh = hinhAnh;
        }
    }
}
