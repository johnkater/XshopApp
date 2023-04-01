using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SanPhamBLL
    {
        SanPhamAccess SPAccess = new SanPhamAccess();
        // -----------------------------------------------------------> LoaiSanPham
        // Load data LoaiSanPham
        public static DataTable GetAllLoaiSanPham()
        {
            return SanPhamAccess.getDataLoaiSanPham();
        }

        // Add LoaiSanPham
        public string AddLoaiSanPham(LoaiSanPhamDTO loaisanpham)
        {
            // Kiem tra nghiep vu
            if (loaisanpham.MaLoaiSanPham == 0)
            {
                return "require_MaLoaiSanPham";
            }
            if (loaisanpham.TenLoaiSanPham == "")
            {
                return "require_TenLoaiSanPham";
            }
            // Them LoaiKhuyenMai
            string resultAdd = SPAccess.AddLoaiSanPham(loaisanpham);
            return resultAdd;
        }

        // Update LoaiSanPham
        public string UpdateLoaiSanPham(LoaiSanPhamDTO loaisanpham)
        {
            // Kiem tra nghiep vu
            if (loaisanpham.MaLoaiSanPham == 0)
            {
                return "require_MaLoaiSanPham";
            }
            if (loaisanpham.TenLoaiSanPham == "")
            {
                return "require_TenLoaiSanPham";
            }
            // Them LoaiKhuyenMai
            string resultUpdate = SPAccess.UpdateLoaiSanPham(loaisanpham);
            return resultUpdate;
        }


        // Delete LoaiSanPham
        public string DeleteLoaiSanPham(LoaiSanPhamDTO loaisanpham)
        {
            // Kiem tra nghiep vu
            if (loaisanpham.MaLoaiSanPham == 0)
            {
                return "require_MaLoaiSanPham";
            }
            // Xoa LoaiKhuyenMai
            string resultDelete = SPAccess.DeleteLoaiSanPham(loaisanpham);
            return resultDelete;
        }


        // -----------------------------------------------------------> SanPham
        // Load data SanPham
        public static DataTable GetAllSanPham()
        {
            return SanPhamAccess.getDataSanPham();
        }

        // Search SanPham
        public static DataTable searchSanPham(SanPhamDTO sanpham)
        {
            return SanPhamAccess.searchSanPham(sanpham);
        }

        // Add SanPham
        public string AddSanPham(SanPhamDTO sanpham)
        {
            // Kiem tra nghiep vu
            if (sanpham.MaSanPham == "")
            {
                return "require_MaSanPham";
            }
            if (sanpham.TenSanPham == "")
            {
                return "require_TenSanPham";
            }
            if (sanpham.MaVach == "")
            {
                return "require_MaVach";
            }
            if (sanpham.MaLoaiSanPham == 0)
            {
                return "require_MaLoaiSanPham";
            }
            if (sanpham.MaKhuyenMai == "")
            {
                return "require_MaKhuyenMai";
            }
            // Them LoaiKhuyenMai
            string resultAdd = SPAccess.AddSanPham(sanpham);
            return resultAdd;
        }
        // Update SanPham
        public string UpdateSanPham(SanPhamDTO sanpham)
        {
            // Kiem tra nghiep vu
            if (sanpham.MaSanPham == "")
            {
                return "require_MaSanPham";
            }
            if (sanpham.TenSanPham == "")
            {
                return "require_TenSanPham";
            }
            if (sanpham.MaLoaiSanPham == 0)
            {
                return "require_MaLoaiSanPham";
            }
            if (sanpham.MaKhuyenMai == "")
            {
                return "require_MaKhuyenMai";
            }
            // Them LoaiKhuyenMai
            string resultAdd = SPAccess.UpdateSanPham(sanpham);
            return resultAdd;
        }


        // Delete SanPham
        public string DeleteSanPham(SanPhamDTO sanpham)
        {
            // Kiem tra nghiep vu
            if (sanpham.MaSanPham == "")
            {
                return "require_MaSanPham";
            }
            
            // Them LoaiKhuyenMai
            string resultAdd = SPAccess.DeleteSanPham(sanpham);
            return resultAdd;
        }
    }
}
