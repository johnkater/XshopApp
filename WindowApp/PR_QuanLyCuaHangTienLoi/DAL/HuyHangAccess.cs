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
    public class HuyHangAccess:DatabaseAccess
    {
        
        // ---------------------------------------------------------> PhieuHuyChiTiet
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

        // Add PhieuHuychiTiet
        public string AddPhieuHuyChiTiet(PhieuHuyChiTietDTO phieuhuychitiet)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("addPhieuHuyChiTiet", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPhieuHuyChiTiet", SqlDbType.VarChar).Value = phieuhuychitiet.MaPhieuHuyChiTiet;
            command.Parameters.Add("@MaSanPham", SqlDbType.VarChar).Value = phieuhuychitiet.MaSanPham;
            command.Parameters.Add("@SoLuong", SqlDbType.Int).Value = phieuhuychitiet.SoLuong;
            
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Update PhieuHuyChitiet
        public string UpdatePhieuHuyChiTiet(PhieuHuyChiTietDTO phieuhuychitiet)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("updatePhieuHuyChiTiet", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPhieuHuyChiTiet", SqlDbType.VarChar).Value = phieuhuychitiet.MaPhieuHuyChiTiet;
            command.Parameters.Add("@MaSanPham", SqlDbType.VarChar).Value = phieuhuychitiet.MaSanPham;
            command.Parameters.Add("@SoLuong", SqlDbType.Int).Value = phieuhuychitiet.SoLuong;

            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Delete PhieuHuyChiTiet
        public string DeletePhieuHuyChiTiet(PhieuHuyChiTietDTO phieuhuychitiet)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("deleteByOnePhieuHuyChiTiet", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPhieuHuyChiTiet", SqlDbType.VarChar).Value = phieuhuychitiet.MaPhieuHuyChiTiet;
            command.Parameters.Add("@MaSanPham", SqlDbType.VarChar).Value = phieuhuychitiet.MaSanPham;           

            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Delete All PhieuHuyChiTiet
        public string DeleteAllPhieuHuyChiTiet(PhieuHuyChiTietDTO phieuhuychitiet)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("deletePhieuHuyChiTiet", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPhieuHuyChiTiet", SqlDbType.VarChar).Value = phieuhuychitiet.MaPhieuHuyChiTiet;
            
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }


        // ---------------------------------------------------------> PhieuHuy
        // Load data HuyHang
        public static DataTable getDataHuyHang()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("QueryHuyHang", conn);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;

        }

        // Search PhieuHuy mot tham so
        public static DataTable SearchPhieuHuyHang(PhieuHuyChiTietDTO phieuhuychitiet)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            // Sqlcommand
            SqlCommand command = new SqlCommand("searchPhieuHuy", conn);
            command.CommandType = CommandType.StoredProcedure;
            // Add Parameter
            command.Parameters.Add("@MaPhieuHuy", SqlDbType.VarChar).Value = phieuhuychitiet.MaPhieuHuyChiTiet;

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

        // Search PhieuHuy nhieu tham so
        public static DataTable SearchPhieuHuyHangNhieuThamSo(PhieuHuyDTO phieuhuy)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            // Sqlcommand
            SqlCommand command = new SqlCommand("searchPhieuHuyNhieuThamSo", conn);
            command.CommandType = CommandType.StoredProcedure;
            // Add Parameter
            command.Parameters.Add("@MaPhieuHuy", SqlDbType.VarChar).Value = phieuhuy.MaPhieuHuy;
            command.Parameters.Add("@MaNhanVien", SqlDbType.VarChar).Value = phieuhuy.MaNhanVien;
            command.Parameters.Add("@NgayHuy", SqlDbType.Date).Value = phieuhuy.NgayHuy.Date;
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

        // Add PhieuHuy
        public string AddPhieuHuy(PhieuHuyDTO phieuhuy)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("addPhieuHuy", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPhieuHuy", SqlDbType.VarChar).Value = phieuhuy.MaPhieuHuy;
            command.Parameters.Add("@MaNhanVien", SqlDbType.VarChar).Value = phieuhuy.MaNhanVien;
            command.Parameters.Add("@NgayHuy", SqlDbType.DateTime).Value = phieuhuy.NgayHuy;
            command.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = phieuhuy.TrangThai;
            command.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = phieuhuy.GhiChu;

            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Update PhieuHuy
        public string UpdatePhieuHuy(PhieuHuyDTO phieuhuy)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("updatePhieuHuy", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPhieuHuy", SqlDbType.VarChar).Value = phieuhuy.MaPhieuHuy;
            command.Parameters.Add("@MaNhanVien", SqlDbType.VarChar).Value = phieuhuy.MaNhanVien;
            command.Parameters.Add("@NgayHuy", SqlDbType.DateTime).Value = phieuhuy.NgayHuy;
            command.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = phieuhuy.GhiChu;

            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Update TrangThai PhieuHuy
        public string UpdateTrangThaiPhieuHuy(PhieuHuyDTO phieuhuy)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("updateTrangThaiPhieuHuy", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPhieuHuy", SqlDbType.VarChar).Value = phieuhuy.MaPhieuHuy;
            command.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = phieuhuy.TrangThai;
            

            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Delete PhieuHuy
        public string DeletePhieuHuy(PhieuHuyDTO phieuhuy)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("deletePhieuHuy", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPhieuHuy", SqlDbType.VarChar).Value = phieuhuy.MaPhieuHuy;
            
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
