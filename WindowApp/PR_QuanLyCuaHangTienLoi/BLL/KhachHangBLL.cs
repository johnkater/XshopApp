using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class KhachHangBLL
    {
        KhachHangAccess KHAccess = new KhachHangAccess();
        // Show KhachHang
        public static DataTable GetAllKhachHang()
        {
            return KhachHangAccess.getData();
        }

        // Search KhachHang
        public static DataTable searchKhachHang(KhachHangDTO khachhang)
        {
            return KhachHangAccess.SearchKhachHang(khachhang);
        }

        // Add KhachHang
        public string AddKhachHang(KhachHangDTO khachhang)
        {
            // Kiem tra nghiep vu
            if (khachhang.MaKhachHang == "")
            {
                return "require_MaKhachHang";
            }
            if (khachhang.HoTen == "")
            {
                return "require_HoTen";
            }
            // Them KhachHang
            string resultAdd = KHAccess.AddKhachHang(khachhang);
            return resultAdd;
        }

        // Update KhachHang
        public string UpdateKhachHang(KhachHangDTO khachhang)
        {
            // Kiem tra nghiep vu
            if (khachhang.MaKhachHang == "")
            {
                return "require_MaKhachHang";
            }
            // Cap nhat KhachHang
            string resultAdd = KHAccess.UpdateKhachHang(khachhang);
            return resultAdd;
        }

        // Delete KhachHang
        public string DeleteKhachHang(KhachHangDTO khachhang)
        {
            // Kiem tra nghiep vu
            if (khachhang.MaKhachHang == "")
            {
                return "require_MaKhachHang";
            }
            // Xoa KhachHang
            string resultAdd = KHAccess.DeleteKhachHang(khachhang);
            return resultAdd;
        }

    }
}
