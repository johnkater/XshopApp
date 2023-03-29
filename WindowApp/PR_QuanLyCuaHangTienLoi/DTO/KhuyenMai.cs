using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhuyenMai
    {
        public string MaKhuyenMai { set; get; }
        public int MaLoaiKhuyenMai { set; get; }
        public int GiaGiam { set; get; }
        public DateTime NgayBatDau { set; get; }
        public DateTime NgayKetThuc { set; get; }

    }
}
