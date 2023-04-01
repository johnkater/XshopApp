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
        // ------------------------------------------------> KhachHang
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

        // --------------------------------------------------------------> TheKhachHang
        // Show TheKhachHang
        public static DataTable GetAllTheKhachHang()
        {
            return KhachHangAccess.getDataTheKhachHang();
        }

        // Search TheKhachHang
        public static DataTable searchTheKhachHang(KhachHangDTO khachhang)
        {
            return KhachHangAccess.SearchTheKhachHang(khachhang);
        }

        // Add TheKhachHang
        public string AddTheKhachHang(TheKhachHangDTO thekhachhang)
        {
            // Kiem tra nghiep vu
            if (thekhachhang.MaTheKhachHang == "")
            {
                return "require_MaTheKhachHang";
            }
            if (thekhachhang.MaKhachhang == "")
            {
                return "require_MaKhachHang";
            }
            if (thekhachhang.MaLoaiTheKhachHang == 0)
            {
                return "require_MaLoaiTheKhachHang";
            }
            // Them KhachHang
            string resultAdd = KHAccess.AddTheKhachHang(thekhachhang);
            return resultAdd;
        }

        // Update TheKhachHang
        public string UpdateTheKhachHang(TheKhachHangDTO thekhachhang)
        {
            // Kiem tra nghiep vu
            if (thekhachhang.MaTheKhachHang == "")
            {
                return "require_MaTheKhachHang";
            }
            if (thekhachhang.MaKhachhang == "")
            {
                return "require_MaKhachHang";
            }
            if (thekhachhang.MaLoaiTheKhachHang == 0)
            {
                return "require_MaLoaiTheKhachHang";
            }
            // Them KhachHang
            string resultUpdate = KHAccess.UpdateTheKhachHang(thekhachhang);
            return resultUpdate;
        }

        // Delete TheKhachHang
        public string DeleteTheKhachHang(TheKhachHangDTO thekhachhang)
        {
            // Kiem tra nghiep vu
            if (thekhachhang.MaTheKhachHang == "")
            {
                return "require_MaTheKhachHang";
            }
            
            // Them KhachHang
            string resultDelete = KHAccess.DeleteTheKhachHang(thekhachhang);
            return resultDelete;
        }



        // --------------------------------------------------------------> LoaiTheKhachHang
        // Show LoaiTheKhachHang
        public static DataTable GetAllLoaiTheKhachHang()
        {
            return KhachHangAccess.getDataLoaiTheKhachHang();
        }

        // Add LoaiTheKhachHang
        public string AddLoaiTheKhachHang(LoaiTheKhachHangDTO loaithekhachhang)
        {
            // Kiem tra nghiep vu
            if (loaithekhachhang.MaLoaiTheKhachHang == 0)
            {
                return "require_MaLoaiTheKhachHang";
            }
            if (loaithekhachhang.TenLoaiTheKhachHang == "")
            {
                return "require_TenLoaiTheKhachHang";
            }
            // Them KhachHang
            string resultAdd = KHAccess.AddLoaiTheKhachHang(loaithekhachhang);
            return resultAdd;
        }
        // Update LoaiTheKhachHang
        public string UpdateLoaiTheKhachHang(LoaiTheKhachHangDTO loaithekhachhang)
        {
            // Kiem tra nghiep vu
            if (loaithekhachhang.MaLoaiTheKhachHang == 0)
            {
                return "require_MaLoaiTheKhachHang";
            }
            
            // Them KhachHang
            string resultUpdate = KHAccess.UpdateLoaiTheKhachHang(loaithekhachhang);
            return resultUpdate;
        }
        // Delete LoaiTheKhachHang
        public string DeleteLoaiTheKhachHang(LoaiTheKhachHangDTO loaithekhachhang)
        {
            // Kiem tra nghiep vu
            if (loaithekhachhang.MaLoaiTheKhachHang == 0)
            {
                return "require_MaLoaiTheKhachHang";
            }

            // Them KhachHang
            string resultUpdate = KHAccess.DeleteLoaiTheKhachHang(loaithekhachhang);
            return resultUpdate;
        }

    }
}
