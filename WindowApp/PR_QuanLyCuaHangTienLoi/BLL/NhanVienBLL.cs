using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienAccess NVAccess = new NhanVienAccess();
        public static DataTable GetAllNhanVien()
        {
            return NhanVienAccess.getData();
        }

        // Add NhanVien
        public string AddNhanVien(NhanVienDTO nhanvien)
        {
            // Kiem tra nghiep vu
            if (nhanvien.MaNhanVien == "")
            {
                return "require_MaNhanVien";
            }
            if (nhanvien.HoTen == "")
            {
                return "require_HoTen";
            }

            string resultAdd = NVAccess.AddNhanVien(nhanvien);
            return resultAdd;
        }
        // Update NhanVien
        public string UpdateNhanVien(NhanVienDTO nhanvien)
        {
            // Kiem tra nghiep vu
            if (nhanvien.MaNhanVien == "")
            {
                return "require_MaNhanVien";
            }

            string resultUpdate = NVAccess.UpdateNhanVien(nhanvien);
            return resultUpdate;
        }
        // Delete NhanVien
        public string DeleteNhanVien(NhanVienDTO nhanvien)
        {
            // Kiem tra nghiep vu
            if (nhanvien.MaNhanVien == "")
            {
                return "require_MaNhanVien";
            }

            string resultDelete = NVAccess.DeleteNhanVien(nhanvien);
            return resultDelete;
 
        }

        // Search NhanVien
        public static DataTable searchNhanVien(NhanVienDTO nhanvien)
        {
            return NhanVienAccess.searchNhanVien(nhanvien);
        }
    }
}
