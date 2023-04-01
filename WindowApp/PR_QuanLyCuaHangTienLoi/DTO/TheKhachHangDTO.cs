using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TheKhachHangDTO
    {
        

        public string MaTheKhachHang { set; get; }
        public string MaKhachhang { set; get; }
        public DateTime NgayLap { set; get; }
        public int TichDiem { set; get; }
        public int MaLoaiTheKhachHang { set; get; }

        // Constructor (No Parameter)
        public TheKhachHangDTO() 
        { 
            this.MaKhachhang = string.Empty;
            this.MaTheKhachHang = string.Empty;
            this.TichDiem = 0;
            this.NgayLap = DateTime.Now;
            this.MaLoaiTheKhachHang = 0;
        }

        // Constructor (Parameters)
        public TheKhachHangDTO(string maTheKhachHang, string maKhachhang, DateTime ngayLap, int tichDiem, int maLoaiTheKhachHang)
        {
            MaTheKhachHang = maTheKhachHang;
            MaKhachhang = maKhachhang;
            NgayLap = ngayLap;
            TichDiem = tichDiem;
            MaLoaiTheKhachHang = maLoaiTheKhachHang;
        }
    }
}
