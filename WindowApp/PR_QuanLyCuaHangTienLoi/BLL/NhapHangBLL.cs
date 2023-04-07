using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class NhapHangBLL
    {
        NhapHangAccess NHAccess = new NhapHangAccess();
        // ------------------------------------------------------> PhieuNhapChiTiet
        // Load data SanPham
        public static DataTable GetAllSanPham()
        {
            return NhapHangAccess.getDataSanPham();
        }

        // Search SanPham
        public static DataTable searchSanPham(SanPhamDTO sanpham)
        {
            return NhapHangAccess.searchSanPham(sanpham);
        }

        // Add SanPham to PhieuNhapChiTiet
        public string AddPhieuNhapChiTiet(PhieuNhapChiTietDTO phieunhapchitiet)
        {
            // Kiem tra nghiep vu
            if (phieunhapchitiet.MaPhieuNhapChiTiet == "")
            {
                return "require_MaPhieuNhapChiTiet";
            }
            if (phieunhapchitiet.MaSanPham == "")
            {
                return "require_MaSanPham";
            }
            if (phieunhapchitiet.SoLuong == 0)
            {
                return "require_SoLuong";
            }
            if (phieunhapchitiet.DonGiaNhap == 0)
            {
                return "require_DonGiaNhap";
            }
            // Them SanPham to PhieuNhapChiTiet
            string resultAdd = NHAccess.AddPhieuNhapChiTiet(phieunhapchitiet);
            return resultAdd;
        }

        // Update SanPham to PhieuNhapChiTiet
        public string UpdatePhieuNhapChiTiet(PhieuNhapChiTietDTO phieunhapchitiet)
        {
            // Kiem tra nghiep vu
            if (phieunhapchitiet.MaPhieuNhapChiTiet == "")
            {
                return "require_MaPhieuNhapChiTiet";
            }
            if (phieunhapchitiet.MaSanPham == "")
            {
                return "require_MaSanPham";
            }
            if (phieunhapchitiet.SoLuong == 0)
            {
                return "require_SoLuong";
            }
            if (phieunhapchitiet.DonGiaNhap == 0)
            {
                return "require_DonGiaNhap";
            }
            // Them SanPham to PhieuNhapChiTiet
            string resultUpdate = NHAccess.UpdatePhieuNhapChiTiet(phieunhapchitiet);
            return resultUpdate;
        }

        // Delete SanPham to PhieuNhapChiTiet
        public string DeletePhieuNhapChiTiet(PhieuNhapChiTietDTO phieunhapchitiet)
        {
            // Kiem tra nghiep vu
            if (phieunhapchitiet.MaPhieuNhapChiTiet == "")
            {
                return "require_MaPhieuNhapChiTiet";
            }
            if (phieunhapchitiet.MaSanPham == "")
            {
                return "require_MaSanPham";
            }
            
            // Them SanPham to PhieuNhapChiTiet
            string resultDelete = NHAccess.DeletePhieuNhapChiTiet(phieunhapchitiet);
            return resultDelete;
        }

        // Delete All SanPham to PhieuNhapChiTiet
        public string DeleteAllPhieuNhapChiTiet(PhieuNhapChiTietDTO phieunhapchitiet)
        {
            // Kiem tra nghiep vu
            if (phieunhapchitiet.MaPhieuNhapChiTiet == "")
            {
                return "require_MaPhieuNhapChiTiet";
            }
            

            // Them SanPham to PhieuNhapChiTiet
            string resultDelete = NHAccess.DeleteAllPhieuNhapChiTiet(phieunhapchitiet);
            return resultDelete;
        }


        // ------------------------------------------------------> PhieuNhap
        // Load data NhapHang
        public static DataTable GetAllNhapHang()
        {
            return NhapHangAccess.getDataNhapHang();
        }

        // Search PhieuNhap mot tham so
        public static DataTable searchPhieuNhapHang(PhieuNhapChiTietDTO phieunhapchitiet)
        {
            return NhapHangAccess.SearchPhieuNhapHang(phieunhapchitiet);
        }

        // Search PhieuNhap nhieu tham so
        public static DataTable searchPhieuNhapNhieuThamSo(PhieuNhapDTO phieunhap)
        {
            return NhapHangAccess.SearchPhieuNhapHangNhieuThamSo(phieunhap);
        }

        // Add PhieuNhap
        public string AddPhieuNhap(PhieuNhapDTO phieunhap)
        {
            // Kiem tra nghiep vu
            if (phieunhap.MaPhieuNhap == "")
            {
                return "require_MaPhieuNhap";
            }
            if (phieunhap.MaNhanVien == "")
            {
                return "require_MaNhanVien";
            }
            if (phieunhap.MaNhaCungCap == "")
            {
                return "require_MaNhaCungCap";
            }
           
            // Them PhieuNhap
            string resultAdd = NHAccess.AddPhieuNhap(phieunhap);
            return resultAdd;
        }

        // Update PhieuNhap
        public string UpdatePhieuNhap(PhieuNhapDTO phieunhap)
        {
            // Kiem tra nghiep vu
            if (phieunhap.MaPhieuNhap == "")
            {
                return "require_MaPhieuNhap";
            }
            if (phieunhap.MaNhanVien == "")
            {
                return "require_MaNhanVien";
            }
            if (phieunhap.MaNhaCungCap == "")
            {
                return "require_MaNhaCungCap";
            }

            // Cap nhat PhieuNhap
            string resultUpdate = NHAccess.UpdatePhieuNhap(phieunhap);
            return resultUpdate;
        }

        // Update TrangThai PhieuNhap
        public string UpdateTrangThaiPhieuNhap(PhieuNhapDTO phieunhap)
        {
            // Kiem tra nghiep vu
            if (phieunhap.MaPhieuNhap == "")
            {
                return "require_MaPhieuNhap";
            }
            

            // Cap nhat PhieuNhap
            string resultUpdate = NHAccess.UpdateTrangThaiPhieuNhap(phieunhap);
            return resultUpdate;
        }


        // Delete PhieuNhap
        public string DeletePhieuNhap(PhieuNhapDTO phieunhap)
        {
            // Kiem tra nghiep vu
            if (phieunhap.MaPhieuNhap == "")
            {
                return "require_MaPhieuNhap";
            }
            

            // Xoa PhieuNhap
            string resultDelete = NHAccess.DeletePhieuNhap(phieunhap);
            return resultDelete;
        }
    }
}
