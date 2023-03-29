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
    public class NhaCungCapBLL
    {
        NhaCungCapAccess NCCAccess = new NhaCungCapAccess();
        
        // Get all NhaCungCap
        public static DataTable GetAllNhaCungCap() {
            return NhaCungCapAccess.getData();
        }

        // Search NhaCungCap -> Parameter =  'TenNhacungCap'
        public static DataTable SearchNhaCungCap(NhaCungCapDTO nhacungcap)
        {
            return NhaCungCapAccess.SearchNhaCungCap(nhacungcap);
        }

        // Add NhaCungCap
        public string AddNhaCungCap(NhaCungCapDTO nhacungcap)
        {
            // Kiem tra nghiep vu
            if(nhacungcap.MaNhaCungCap == "")
            {
                return "require_MaNhaCungCap";
            }
            if (nhacungcap.TenNhaCungCap == "")
            {
                return "require_TenNhaCungCap";
            }
            
            string resultAdd = NCCAccess.AddNhaCungCap(nhacungcap);
            return resultAdd;
        }

        // Update NhaCungCap
        public string UpdateNhaCungCap(NhaCungCapDTO nhacungcap)
        {
            // Kiem tra nghiep vu
            if (nhacungcap.MaNhaCungCap == "")
            {
                return "require_MaNhaCungCap";
            }

            string resultUpdate = NCCAccess.UpdateNhaCungCap(nhacungcap);
            return resultUpdate;
            
        }

        // Delete NhaCungCap
        public string DeleteNhaCungCap(NhaCungCapDTO nhacungcap)
        {
            // Kiem tra nghiep vu
            if (nhacungcap.MaNhaCungCap == "")
            {
                return "require_MaNhaCungCap";
            }

            string resultDelete = NCCAccess.DeleteNhaCungCap(nhacungcap);
            return resultDelete;

        }


    }
}
