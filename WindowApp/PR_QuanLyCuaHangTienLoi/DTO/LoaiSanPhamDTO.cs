using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiSanPhamDTO
    {
       

        public int MaLoaiSanPham { get; set; }
        public string TenLoaiSanPham { set; get; }

        // Constructor (No Parameter)
        public LoaiSanPhamDTO()
        {
            this.MaLoaiSanPham = 0;
            this.TenLoaiSanPham = "";
        }
        // Constructor (Parameters)
        public LoaiSanPhamDTO(int maLoaiSanPham, string tenLoaiSanPham)
        {
            MaLoaiSanPham = maLoaiSanPham;
            TenLoaiSanPham = tenLoaiSanPham;
        }
}
}
