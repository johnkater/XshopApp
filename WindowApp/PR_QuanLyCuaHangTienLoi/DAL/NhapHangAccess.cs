using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NhapHangAccess:DatabaseAccess
    {
        // ------------------------------------------------------> PhieuNhapChiTiet
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

        // Add SanPham to PhieuNhapChiTiet
        public string AddPhieuNhapChiTiet(PhieuNhapChiTietDTO phieunhapchitiet)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("addPhieuNhapChiTiet", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPhieuNhapChiTiet", SqlDbType.VarChar).Value = phieunhapchitiet.MaPhieuNhapChiTiet;
            command.Parameters.Add("@MaSanPham", SqlDbType.VarChar).Value = phieunhapchitiet.MaSanPham;
            command.Parameters.Add("@SoLuong", SqlDbType.Int).Value = phieunhapchitiet.SoLuong;
            command.Parameters.Add("@DonGiaNhap", SqlDbType.Int).Value = phieunhapchitiet.DonGiaNhap;
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Update SanPham to PhieuNhapChiTiet
        public string UpdatePhieuNhapChiTiet(PhieuNhapChiTietDTO phieunhapchitiet)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("updatePhieuNhapChiTiet", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPhieuNhapChiTiet", SqlDbType.VarChar).Value = phieunhapchitiet.MaPhieuNhapChiTiet;
            command.Parameters.Add("@MaSanPham", SqlDbType.VarChar).Value = phieunhapchitiet.MaSanPham;
            command.Parameters.Add("@SoLuong", SqlDbType.Int).Value = phieunhapchitiet.SoLuong;
            command.Parameters.Add("@DonGiaNhap", SqlDbType.Int).Value = phieunhapchitiet.DonGiaNhap;
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Delete SanPham to PhieuNhapChiTiet
        public string DeletePhieuNhapChiTiet(PhieuNhapChiTietDTO phieunhapchitiet)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("deleteByOnePhieuNhapChiTiet", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPhieuNhapChiTiet", SqlDbType.VarChar).Value = phieunhapchitiet.MaPhieuNhapChiTiet;
            command.Parameters.Add("@MaSanPham", SqlDbType.VarChar).Value = phieunhapchitiet.MaSanPham;
        
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Delete All SanPham to PhieuNhapChiTiet
        public string DeleteAllPhieuNhapChiTiet(PhieuNhapChiTietDTO phieunhapchitiet)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("deletePhieuNhapChiTiet", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPhieuNhapChiTiet", SqlDbType.VarChar).Value = phieunhapchitiet.MaPhieuNhapChiTiet;
            
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }



        // ------------------------------------------------------> PhieuNhap
        // Load data NhapHang
        public static DataTable getDataNhapHang()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("QueryNhapHang", conn);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;

        }

        // Search PhieuNhap mot tham so
        public static DataTable SearchPhieuNhapHang(PhieuNhapChiTietDTO phieunhapchitiet)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            // Sqlcommand
            SqlCommand command = new SqlCommand("searchPhieuNhap", conn);
            command.CommandType = CommandType.StoredProcedure;
            // Add Parameter
            command.Parameters.Add("@MaPhieuNhap", SqlDbType.VarChar).Value = phieunhapchitiet.MaPhieuNhapChiTiet;

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

        // Search PhieuNhap nhieu tham so
        public static DataTable SearchPhieuNhapHangNhieuThamSo(PhieuNhapDTO phieunhap)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            // Sqlcommand
            SqlCommand command = new SqlCommand("searchPhieuNhapNhieuThamSo", conn);
            command.CommandType = CommandType.StoredProcedure;
            // Add Parameter
            command.Parameters.Add("@MaPhieuNhap", SqlDbType.VarChar).Value = phieunhap.MaPhieuNhap;
            command.Parameters.Add("@MaNhanVien", SqlDbType.VarChar).Value = phieunhap.MaNhanVien;
            command.Parameters.Add("@MaNhaCungCap", SqlDbType.VarChar).Value = phieunhap.MaNhaCungCap;

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

        // Add PhieuNhap
        public string AddPhieuNhap(PhieuNhapDTO phieunhap)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("addPhieuNhap", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPhieuNhap", SqlDbType.VarChar).Value = phieunhap.MaPhieuNhap;
            command.Parameters.Add("@MaNhanVien", SqlDbType.VarChar).Value = phieunhap.MaNhanVien;
            command.Parameters.Add("@MaNhaCungCap", SqlDbType.VarChar).Value = phieunhap.MaNhaCungCap;
            command.Parameters.Add("@NgayNhap", SqlDbType.DateTime).Value = phieunhap.NgayNhap;
            command.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = phieunhap.TrangThai;
            command.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = phieunhap.GhiChu;
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Update PhieuNhap
        public string UpdatePhieuNhap(PhieuNhapDTO phieunhap)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("updatePhieuNhap", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPhieuNhap", SqlDbType.VarChar).Value = phieunhap.MaPhieuNhap;
            command.Parameters.Add("@MaNhanVien", SqlDbType.VarChar).Value = phieunhap.MaNhanVien;
            command.Parameters.Add("@MaNhaCungCap", SqlDbType.VarChar).Value = phieunhap.MaNhaCungCap;
            command.Parameters.Add("@NgayNhap", SqlDbType.DateTime).Value = phieunhap.NgayNhap;
            command.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = phieunhap.GhiChu;
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Update Thanh Toan PhieuNhap
        public string UpdateTrangThaiPhieuNhap(PhieuNhapDTO phieunhap)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("updateTrangThaiPhieuNhap", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPhieuNhap", SqlDbType.VarChar).Value = phieunhap.MaPhieuNhap;
            
            command.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = phieunhap.TrangThai;
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Delete PhieuNhap
        public string DeletePhieuNhap(PhieuNhapDTO phieunhap)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("deletePhieuNhap", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPhieuNhap", SqlDbType.VarChar).Value = phieunhap.MaPhieuNhap;
          
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
