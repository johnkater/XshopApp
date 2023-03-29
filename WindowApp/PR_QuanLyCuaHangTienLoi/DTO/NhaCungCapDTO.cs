using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCapDTO
    {
        public string MaNhaCungCap { get; set; }
        public string TenNhaCungCap { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string HinhAnh { get; set; }
        
        // Constructor (No Parameter)
        public NhaCungCapDTO() {
            this.MaNhaCungCap = "";
            this.TenNhaCungCap = "";
            this.DiaChi = "";
            this.SoDienThoai = "";
            this.Email = "";
            this.HinhAnh = "";
        }
        // Constructor (Parameter)
        public NhaCungCapDTO(string maNhaCungCap, string tenNhaCungCap, string diaChi, string soDienThoai, string email, string hinhAnh)
        {
            MaNhaCungCap = maNhaCungCap;
            TenNhaCungCap = tenNhaCungCap;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            Email = email;
            HinhAnh = hinhAnh;
        }
    }
}
