using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhuyenMaiDTO
    {

        public string MaKhuyenMai { set; get; }
        public int MaLoaiKhuyenMai { set; get; }
        public int GiaGiam { set; get; }
        public DateTime NgayBatDau { set; get; }
        public DateTime NgayKetThuc { set; get; }

        // 
        public KhuyenMaiDTO()
        {
            this.MaKhuyenMai = string.Empty;
            this.MaLoaiKhuyenMai = 0;
            this.GiaGiam = 0;
            this.NgayKetThuc = DateTime.Now;
            this.NgayKetThuc = DateTime.Now;
        }
        //
        public KhuyenMaiDTO(string maKhuyenMai, int maLoaiKhuyenMai, int giaGiam, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            MaKhuyenMai = maKhuyenMai;
            MaLoaiKhuyenMai = maLoaiKhuyenMai;
            GiaGiam = giaGiam;
            NgayBatDau = ngayBatDau;
            NgayKetThuc = ngayKetThuc;
        }
    }
}
