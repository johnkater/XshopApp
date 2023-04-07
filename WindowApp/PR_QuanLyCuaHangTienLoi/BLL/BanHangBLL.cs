using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BanHangBLL
    {
        BanHangAccess BHAccess = new BanHangAccess();

        // ---------------------------------------------------------------> PhieuXuatChiTiet
        // Load data SanPham
        public static DataTable GetAllSanPham()
        {
            return BanHangAccess.getDataSanPham();
        }

        // Search SanPham
        public static DataTable searchSanPham(SanPhamDTO sanpham)
        {
            return BanHangAccess.searchSanPham(sanpham);
        }

        // Add SanPham to PhieuXuatChiTiet
        public string AddPhieuXuatChiTiet(PhieuXuatChiTietDTOcs phieuxuatchitiet)
        {
            // Kiem tra nghiep vu
            if (phieuxuatchitiet.MaPhieuXuatChiTiet == "")
            {
                return "require_MaPhieuXuatChiTiet";
            }
            if (phieuxuatchitiet.MaSanPham == "")
            {
                return "require_MaSanPham";
            }
            if (phieuxuatchitiet.SoLuong == 0)
            {
                return "require_SoLuong";
            }
            // Them LoaiKhuyenMai
            string resultAdd = BHAccess.AddPhieuXuatChiTiet(phieuxuatchitiet);
            return resultAdd;
        }

        // Update SanPham to PhieuXuatChiTiet
        public string UpdatePhieuXuatChiTiet(PhieuXuatChiTietDTOcs phieuxuatchitiet)
        {
            // Kiem tra nghiep vu
            if (phieuxuatchitiet.MaPhieuXuatChiTiet == "")
            {
                return "require_MaPhieuXuatChiTiet";
            }
            if (phieuxuatchitiet.MaSanPham == "")
            {
                return "require_MaSanPham";
            }
            if (phieuxuatchitiet.SoLuong == 0)
            {
                return "require_SoLuong";
            }
            // Them LoaiKhuyenMai
            string resultUpdate = BHAccess.UpdatePhieuXuatChiTiet(phieuxuatchitiet);
            return resultUpdate;
        }

        // Delete SanPham to PhieuXuatChiTiet
        public string DeletePhieuXuatChiTiet(PhieuXuatChiTietDTOcs phieuxuatchitiet)
        {
            // Kiem tra nghiep vu
            if (phieuxuatchitiet.MaPhieuXuatChiTiet == "")
            {
                return "require_MaPhieuXuatChiTiet";
            }
            if (phieuxuatchitiet.MaSanPham == "")
            {
                return "require_MaSanPham";
            }
            
            // Them LoaiKhuyenMai
            string resultDelete = BHAccess.DeletePhieuXuatChiTiet(phieuxuatchitiet);
            return resultDelete;
        }

        // Delete All SanPham to PhieuXuatChiTiet
        public string DeleteAllPhieuXuatChiTiet(PhieuXuatChiTietDTOcs phieuxuatchitiet)
        {
            // Kiem tra nghiep vu
            if (phieuxuatchitiet.MaPhieuXuatChiTiet == "")
            {
                return "require_MaPhieuXuatChiTiet";
            }           

            // Them LoaiKhuyenMai
            string resultDelete = BHAccess.DeleteAllPhieuXuatChiTiet(phieuxuatchitiet);
            return resultDelete;
        }

        // ------------------------------------------------------------> PhieuXuat
        // Load data BanHang
        public static DataTable GetAllBanHang()
        {
            return BanHangAccess.getDataBanHang();
        }

        // Search PhieuXuat nhieu tham so
        public static DataTable searchPhieuXuat(PhieuXuatDTO phieuxuat)
        {
            return BanHangAccess.searchPhieuXuat(phieuxuat);
        }

        // Search PhieuXuat mot tham so
        public static DataTable searchPhieuXuatBanHang(PhieuXuatChiTietDTOcs phieuxuatchitiet)
        {
            return BanHangAccess.SearchPhieuXuatBanHang(phieuxuatchitiet);
        }

        // Add PhieuXuat
        public string AddPhieuXuat(PhieuXuatDTO phieuxuat)
        {
            // Kiem tra nghiep vu
            if (phieuxuat.MaPhieuXuat == "")
            {
                return "require_MaPhieuXuat";
            }
            if (phieuxuat.MaNhanVien == "")
            {
                return "require_MaNhanVien";
            }
            if (phieuxuat.MaKhachHang == "")
            {
                return "require_MaKhachHang";
            }
            
            // Them PhieuXuat
            string resultAdd = BHAccess.AddPhieuXuat(phieuxuat);
            return resultAdd;
        }

        // Update PhieuXuat
        public string UpdatePhieuXuat(PhieuXuatDTO phieuxuat)
        {
            // Kiem tra nghiep vu
            if (phieuxuat.MaPhieuXuat == "")
            {
                return "require_MaPhieuXuat";
            }
            if (phieuxuat.MaNhanVien == "")
            {
                return "require_MaNhanVien";
            }
            if (phieuxuat.MaKhachHang == "")
            {
                return "require_MaKhachHang";
            }

            // Cap nhat PhieuXuat
            string resultUpdate = BHAccess.UpdatePhieuXuat(phieuxuat);
            return resultUpdate;
        }

        // Update PhieuXuat --> thanh toan PhieuXuat
        public string UpdateThanhToanPhieuXuat(PhieuXuatDTO phieuxuat)
        {
            // Kiem tra nghiep vu
            if (phieuxuat.MaPhieuXuat == "")
            {
                return "require_MaPhieuXuat";
            }
            if (phieuxuat.TrangThai == "")
            {
                return "require_TrangThai";
            }
            
            

            // Cap nhat PhieuXuat --> TrangThai
            string resultUpdate = BHAccess.UpdateThanhToanPhieuXuat(phieuxuat);
            return resultUpdate;
        }

        // Delete PhieuXuat
        public string DeletePhieuXuat(PhieuXuatDTO phieuxuat)
        {
            // Kiem tra nghiep vu
            if (phieuxuat.MaPhieuXuat == "")
            {
                return "require_MaPhieuXuat";
            }

            // Delete PhieuXuat
            string resultDelete = BHAccess.DeletePhieuXuat(phieuxuat);
            return resultDelete;
        }

    }
}
