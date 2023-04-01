using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiKhuyenMaiDTO
    {
        
        public int MaLoaiKhuyenMai { set; get; }
        public string TenLoaiKhuyenMai { set; get; }

        //
        public LoaiKhuyenMaiDTO()
        {
            this.MaLoaiKhuyenMai = 0;
            this.TenLoaiKhuyenMai = "";
        }

        //
        public LoaiKhuyenMaiDTO(int maLoaiKhuyenMai, string tenLoaiKhuyenMai)
        {
            MaLoaiKhuyenMai = maLoaiKhuyenMai;
            TenLoaiKhuyenMai = tenLoaiKhuyenMai;
        }


    }
}
