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
    public class HuyHangBLL
    {
        HuyHangAccess HHAccess = new HuyHangAccess();
        // ---------------------------------------------------------> PhieuHuyChiTiet
       
        // Load data SanPham
        public static DataTable GetAllSanPham()
        {
            return HuyHangAccess.getDataSanPham();
        }

        // Search SanPham
        public static DataTable searchSanPham(SanPhamDTO sanpham)
        {
            return HuyHangAccess.searchSanPham(sanpham);
        }

        // Add PhieuHuyChiTiet
        public string AddPhieuHuyChiTiet(PhieuHuyChiTietDTO phieuhuychitiet)
        {
            // Kiem tra nghiep vu
            if (phieuhuychitiet.MaPhieuHuyChiTiet == "")
            {
                return "require_MaPhieuHuyChiTiet";
            }
            if (phieuhuychitiet.MaSanPham == "")
            {
                return "require_MaSanPham";
            }
            if (phieuhuychitiet.SoLuong == 0)
            {
                return "require_SoLuong";
            }
            
            // Them SanPham to PhieuNhapChiTiet
            string resultAdd = HHAccess.AddPhieuHuyChiTiet(phieuhuychitiet);
            return resultAdd;
        }

        // Update PhieuHuyChiTiet
        public string UpdatePhieuHuyChiTiet(PhieuHuyChiTietDTO phieuhuychitiet)
        {
            // Kiem tra nghiep vu
            if (phieuhuychitiet.MaPhieuHuyChiTiet == "")
            {
                return "require_MaPhieuHuyChiTiet";
            }
            if (phieuhuychitiet.MaSanPham == "")
            {
                return "require_MaSanPham";
            }
            if (phieuhuychitiet.SoLuong == 0)
            {
                return "require_SoLuong";
            }

            // Cap nhat SanPham to PhieuNhapChiTiet
            string resultUpdate = HHAccess.UpdatePhieuHuyChiTiet(phieuhuychitiet);
            return resultUpdate;
        }

        // Delete PhieuHuyChiTiet
        public string DeletePhieuHuyChiTiet(PhieuHuyChiTietDTO phieuhuychitiet)
        {
            // Kiem tra nghiep vu
            if (phieuhuychitiet.MaPhieuHuyChiTiet == "")
            {
                return "require_MaPhieuHuyChiTiet";
            }
            if (phieuhuychitiet.MaSanPham == "")
            {
                return "require_MaSanPham";
            }
            

            // Xoa SanPham to PhieuNhapChiTiet
            string resultDelete = HHAccess.DeletePhieuHuyChiTiet(phieuhuychitiet);
            return resultDelete;
        }

        // Delete All PhieuHuyChiTiet
        public string DeleteAllPhieuHuyChiTiet(PhieuHuyChiTietDTO phieuhuychitiet)
        {
            // Kiem tra nghiep vu
            if (phieuhuychitiet.MaPhieuHuyChiTiet == "")
            {
                return "require_MaPhieuHuyChiTiet";
            }


            // Xoa All SanPham to PhieuNhapChiTiet
            string resultDelete = HHAccess.DeleteAllPhieuHuyChiTiet(phieuhuychitiet);
            return resultDelete;
        }


        // ---------------------------------------------------------> PhieuHuy
        // Load data HuyHang
        public static DataTable GetAllHuyHang()
        {
            return HuyHangAccess.getDataHuyHang();
        }

        // Search PhieuHuy mot tham so
        public static DataTable searchPhieuHuyHang(PhieuHuyChiTietDTO phieuhuychitiet)
        {
            return HuyHangAccess.SearchPhieuHuyHang(phieuhuychitiet);
        }

        // Search PhieuHuy nhieu tham so
        public static DataTable searchPhieuHuyHangNhieuThamSo(PhieuHuyDTO phieuhuy)
        {
            return HuyHangAccess.SearchPhieuHuyHangNhieuThamSo(phieuhuy);
        }

        // Add PhieuHuy
        public string AddPhieuHuy(PhieuHuyDTO phieuhuy)
        {
            // Kiem tra nghiep vu
            if (phieuhuy.MaPhieuHuy == "")
            {
                return "require_MaPhieuHuy";
            }
            if (phieuhuy.MaNhanVien == "")
            {
                return "require_MaNhanVien";
            }
            

            // Them PhieuHuy
            string resultAdd = HHAccess.AddPhieuHuy(phieuhuy);
            return resultAdd;
        }

        // Update PhieuHuy
        public string UpdatePhieuHuy(PhieuHuyDTO phieuhuy)
        {
            // Kiem tra nghiep vu
            if (phieuhuy.MaPhieuHuy == "")
            {
                return "require_MaPhieuHuy";
            }
            if (phieuhuy.MaNhanVien == "")
            {
                return "require_MaNhanVien";
            }


            // Cap nhat PhieuHuy
            string resultUpdate = HHAccess.UpdatePhieuHuy(phieuhuy);
            return resultUpdate;
        }

        // Update TrangThai PhieuHuy
        public string UpdateTrangThaiPhieuHuy(PhieuHuyDTO phieuhuy)
        {
            // Kiem tra nghiep vu
            if (phieuhuy.MaPhieuHuy == "")
            {
                return "require_MaPhieuHuy";
            }
            
            // Cap nhat PhieuHuy
            string resultUpdate = HHAccess.UpdateTrangThaiPhieuHuy(phieuhuy);
            return resultUpdate;
        }

        // Delete PhieuHuy
        public string DeletePhieuHuy(PhieuHuyDTO phieuhuy)
        {
            // Kiem tra nghiep vu
            if (phieuhuy.MaPhieuHuy == "")
            {
                return "require_MaPhieuHuy";
            }          

            // Xoa PhieuHuy
            string resultDelete = HHAccess.DeletePhieuHuy(phieuhuy);
            return resultDelete;
        }

    }
}
