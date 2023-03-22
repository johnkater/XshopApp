using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class TaiKhoanBLL
    {
        //
        TaiKhoanAccess tkAccess = new TaiKhoanAccess();

        public string CheckLogin(TaiKhoan taiKhoan)
        {
            // Kiem tra nghiep vu
            if(taiKhoan.TenTaiKhoan == "")
            {
                return "require_taikhoan";
            }
            if (taiKhoan.MatKhau == "")
            {
                return "require_matkhau";
            }

            string info = tkAccess.CheckLogin(taiKhoan);
            return info;
        }

    }
}
