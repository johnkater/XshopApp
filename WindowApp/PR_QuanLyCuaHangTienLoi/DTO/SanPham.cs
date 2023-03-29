using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DTO
{
    public class SanPham
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

    }
}
