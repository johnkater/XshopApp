using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BanHangAccess:DatabaseAccess
    {
        // -------------------------------------------------------------------------> PhieuXuatChiTiet
        // Load data SanPham
        public static DataTable getDataSanPham()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("showSanPham", conn);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;

        }


        // Search SanPham
        public static DataTable searchSanPham(SanPhamDTO sanpham)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            // Sqlcommand
            SqlCommand command = new SqlCommand("searchSANPHAMBANHANG", conn);
            command.CommandType = CommandType.StoredProcedure;
            // Add Parameter
            command.Parameters.Add("@TenSanPham", SqlDbType.NVarChar).Value = sanpham.TenSanPham;
            command.Parameters.Add("@MaVach", SqlDbType.VarChar).Value = sanpham.MaVach;
            command.Parameters.Add("@MaSanPham", SqlDbType.VarChar).Value = sanpham.MaSanPham;
            // Fill Datatable
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            // Close connection
            conn.Close();
            // Return Datatable
            return dt;
        }

        // Add SanPham to PhieuXuatChiTiet
        public string AddPhieuXuatChiTiet(PhieuXuatChiTietDTOcs phieuxuatchitiet)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("addPhieuXuatChiTiet", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPhieuXuatChiTiet", SqlDbType.VarChar).Value = phieuxuatchitiet.MaPhieuXuatChiTiet;
            command.Parameters.Add("@MaSanPham", SqlDbType.VarChar).Value = phieuxuatchitiet.MaSanPham;
            command.Parameters.Add("@SoLuong", SqlDbType.Int).Value = phieuxuatchitiet.SoLuong;
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Update SanPham to PhieuXuatChiTiet
        public string UpdatePhieuXuatChiTiet(PhieuXuatChiTietDTOcs phieuxuatchitiet)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("updatePhieuXuatChiTiet", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPhieuXuatChiTiet", SqlDbType.VarChar).Value = phieuxuatchitiet.MaPhieuXuatChiTiet;
            command.Parameters.Add("@MaSanPham", SqlDbType.VarChar).Value = phieuxuatchitiet.MaSanPham;
            command.Parameters.Add("@SoLuong", SqlDbType.Int).Value = phieuxuatchitiet.SoLuong;
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Delete SanPham to PhieuXuatChiTiet
        public string DeletePhieuXuatChiTiet(PhieuXuatChiTietDTOcs phieuxuatchitiet)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("deleteSanPhamInPhieuXuat", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPhieuXuatChiTiet", SqlDbType.VarChar).Value = phieuxuatchitiet.MaPhieuXuatChiTiet;
            command.Parameters.Add("@MaSanPham", SqlDbType.VarChar).Value = phieuxuatchitiet.MaSanPham;
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Delete All SanPham to PhieuXuatChiTiet
        public string DeleteAllPhieuXuatChiTiet(PhieuXuatChiTietDTOcs phieuxuatchitiet)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("deletePhieuXuatChiTiet", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPhieuXuatChiTiet", SqlDbType.VarChar).Value = phieuxuatchitiet.MaPhieuXuatChiTiet;
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }



        // ------------------------------------------------------------------> PhieuXuat
        // Load data BanHang
        public static DataTable getDataBanHang()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("QueryBanHang", conn);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;

        }

        // Search PhieuXuat nhieu tham so
        public static DataTable searchPhieuXuat(PhieuXuatDTO phieuxuat)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            // Sqlcommand
            SqlCommand command = new SqlCommand("searchHOADONBANHANG", conn);
            command.CommandType = CommandType.StoredProcedure;
            // Add Parameter
            command.Parameters.Add("@MaPhieuXuat", SqlDbType.VarChar).Value = phieuxuat.MaPhieuXuat;
            command.Parameters.Add("@MaNhanVien", SqlDbType.VarChar).Value = phieuxuat.MaNhanVien;
            command.Parameters.Add("@MaKhachHang", SqlDbType.VarChar).Value = phieuxuat.MaKhachHang;
            // Fill Datatable
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            // Close connection
            conn.Close();
            // Return Datatable
            return dt;
        }
        // Search PhieuXuat mot tham so
        public static DataTable SearchPhieuXuatBanHang(PhieuXuatChiTietDTOcs phieuxuatchitiet)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            // Sqlcommand
            SqlCommand command = new SqlCommand("searchPHIEUXUAT", conn);
            command.CommandType = CommandType.StoredProcedure;
            // Add Parameter
            command.Parameters.Add("@MaPhieuXuat", SqlDbType.VarChar).Value = phieuxuatchitiet.MaPhieuXuatChiTiet;
            
            // Fill Datatable
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            // Close connection
            conn.Close();
            // Return Datatable
            return dt;
        }

        // Add PhieuXuat
        public string AddPhieuXuat(PhieuXuatDTO phieuxuat)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("addPhieuXuat", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPhieuXuat", SqlDbType.VarChar).Value = phieuxuat.MaPhieuXuat;
            command.Parameters.Add("@MaNhanVien", SqlDbType.VarChar).Value = phieuxuat.MaNhanVien;
            command.Parameters.Add("@MaKhachHang", SqlDbType.VarChar).Value = phieuxuat.MaKhachHang;
            command.Parameters.Add("@NgayXuat", SqlDbType.DateTime).Value = phieuxuat.NgayXuat;
            command.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = phieuxuat.TrangThai;
            command.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = phieuxuat.GhiChu;
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }


        // Update PhieuXuat
        public string UpdatePhieuXuat(PhieuXuatDTO phieuxuat)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("updatePhieuXuat", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPhieuXuat", SqlDbType.VarChar).Value = phieuxuat.MaPhieuXuat;
            command.Parameters.Add("@MaNhanVien", SqlDbType.VarChar).Value = phieuxuat.MaNhanVien;
            command.Parameters.Add("@MaKhachHang", SqlDbType.VarChar).Value = phieuxuat.MaKhachHang;
            command.Parameters.Add("@NgayXuat", SqlDbType.DateTime).Value = phieuxuat.NgayXuat;
            command.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = phieuxuat.GhiChu;
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Update PhieuXuat --> Cap nhat trang thai thanh toan
        public string UpdateThanhToanPhieuXuat(PhieuXuatDTO phieuxuat)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("updateThanhToanPhieuXuat", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPhieuXuat", SqlDbType.VarChar).Value = phieuxuat.MaPhieuXuat;
            command.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = phieuxuat.TrangThai;
                   
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Delete PhieuXuat
        public string DeletePhieuXuat(PhieuXuatDTO phieuxuat)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("deletePhieuXuat", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPhieuXuat", SqlDbType.VarChar).Value = phieuxuat.MaPhieuXuat;
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

    }
}
