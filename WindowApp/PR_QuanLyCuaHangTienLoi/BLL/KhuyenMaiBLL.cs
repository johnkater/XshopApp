using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class KhuyenMaiBLL
    {
        KhuyenMaiAccess KMAccess = new KhuyenMaiAccess();
        // ---------------------------------------------------------> LoaiKhuyenMai
        // Load data LoaiKhuyenMai
        public static DataTable GetAllLoaiKhuyenMai()
        {
            return KhuyenMaiAccess.getDataLoaiKhuyenMai();
        }

        // Add LoaiKhuyenMai
        public string AddLoaiKhuyenMai(LoaiKhuyenMaiDTO loaikhuyenmai)
        {
            // Kiem tra nghiep vu
            if (loaikhuyenmai.MaLoaiKhuyenMai == 0)
            {
                return "require_MaLoaiKhuyenMai";
            }
            if (loaikhuyenmai.TenLoaiKhuyenMai == "")
            {
                return "require_TenLoaiKhuyenMai";
            }
            // Them LoaiKhuyenMai
            string resultAdd = KMAccess.AddLoaiKhuyenMai(loaikhuyenmai);
            return resultAdd;
        }
        // Update LoaiKhuyenMai
        public string UpdateLoaiKhuyenMai(LoaiKhuyenMaiDTO loaikhuyenmai)
        {
            // Kiem tra nghiep vu
            if (loaikhuyenmai.MaLoaiKhuyenMai == 0)
            {
                return "require_MaLoaiKhuyenMai";
            }
            if (loaikhuyenmai.TenLoaiKhuyenMai == "")
            {
                return "require_TenLoaiKhuyenMai";
            }
            // Cap nhat LoaiKhuyenMai
            string resultUpdate = KMAccess.UpdateLoaiKhuyenMai(loaikhuyenmai);
            return resultUpdate;
        }

        // Delete LoaiKhuyenMai
        public string DeleteLoaiKhuyenMai(LoaiKhuyenMaiDTO loaikhuyenmai)
        {
            // Kiem tra nghiep vu
            if (loaikhuyenmai.MaLoaiKhuyenMai == 0)
            {
                return "require_MaLoaiKhuyenMai";
            }
            
            // Xoa LoaiKhuyenMai
            string resultDelete = KMAccess.DeleteLoaiKhuyenMai(loaikhuyenmai);
            return resultDelete;
        }

        // ---------------------------------------------------------> KhuyenMai 
        // Load data KhuyenMai
        public static DataTable GetAllKhuyenMai()
        {
            return KhuyenMaiAccess.getDataKhuyenMai();
        }

        // Search KhuyenMai
        public static DataTable searchKhuyenMai(KhuyenMaiDTO khuyenmai)
        {
            return KhuyenMaiAccess.searchKhuyenMai(khuyenmai);
        }

        // Add KhuyenMai
        public string AddKhuyenMai(KhuyenMaiDTO khuyenmai)
        {
            // Kiem tra nghiep vu
            if (khuyenmai.MaKhuyenMai == "")
            {
                return "require_MaKhuyenMai";
            }
            if (khuyenmai.MaLoaiKhuyenMai == 0)
            {
                return "require_MaLoaiKhuyenMai";
            }
            // Them LoaiKhuyenMai
            string resultAdd = KMAccess.AddKhuyenMai(khuyenmai);
            return resultAdd;
        }

        // Update KhuyenMai
        public string UpdateKhuyenMai(KhuyenMaiDTO khuyenmai)
        {
            // Kiem tra nghiep vu
            if (khuyenmai.MaKhuyenMai == "")
            {
                return "require_MaKhuyenMai";
            }
            if (khuyenmai.MaLoaiKhuyenMai == 0)
            {
                return "require_MaLoaiKhuyenMai";
            }
            // Cap nhat LoaiKhuyenMai
            string resultAdd = KMAccess.UpdateKhuyenMai(khuyenmai);
            return resultAdd;
        }

        // Delete KhuyenMai
        public string DeleteKhuyenMai(KhuyenMaiDTO khuyenmai)
        {
            // Kiem tra nghiep vu
            if (khuyenmai.MaKhuyenMai == "")
            {
                return "require_MaKhuyenMai";
            }
            
            // Cap nhat LoaiKhuyenMai
            string resultAdd = KMAccess.DeleteKhuyenMai(khuyenmai);
            return resultAdd;
        }
    }
}
