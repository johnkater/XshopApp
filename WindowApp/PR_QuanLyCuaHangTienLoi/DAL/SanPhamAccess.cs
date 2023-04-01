using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SanPhamAccess
    {

        // -----------------------------------------------------------> LoaiSanPham
        
        // Load data LoaiSanPham
        public static DataTable getDataLoaiSanPham()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("showLoaiSanPham", conn);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;

        }
        // Add LoaiSanPham
        public string AddLoaiSanPham(LoaiSanPhamDTO loaisanpham)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("addLoaiSanPham", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaLoaiSanpham", SqlDbType.Int).Value = loaisanpham.MaLoaiSanPham;
            command.Parameters.Add("@TenLoaiSanPham", SqlDbType.NVarChar).Value = loaisanpham.TenLoaiSanPham;

            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Update LoaiSanPham
        public string UpdateLoaiSanPham(LoaiSanPhamDTO loaisanpham)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("updateLoaiSanPham", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaLoaiSanpham", SqlDbType.Int).Value = loaisanpham.MaLoaiSanPham;
            command.Parameters.Add("@TenLoaiSanPham", SqlDbType.NVarChar).Value = loaisanpham.TenLoaiSanPham;

            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Delete LoaiSanPham
        public string DeleteLoaiSanPham(LoaiSanPhamDTO loaisanpham)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("deleteLoaiSanPham", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaLoaiSanpham", SqlDbType.Int).Value = loaisanpham.MaLoaiSanPham;
            
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }


        // -----------------------------------------------------------> SanPham
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
            SqlCommand command = new SqlCommand("searchSANPHAM", conn);
            command.CommandType = CommandType.StoredProcedure;
            // Add Parameter
            command.Parameters.Add("@TenSanPham", SqlDbType.NVarChar).Value = sanpham.TenSanPham;
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

        // Add SanPham
        public string AddSanPham(SanPhamDTO sanpham)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            // SqlCommand
            SqlCommand command = new SqlCommand("addSanPham", conn);
            command.CommandType = CommandType.StoredProcedure;
            // Add Parameters
            command.Parameters.Add("@MaSanpham", SqlDbType.VarChar).Value = sanpham.MaSanPham;
            command.Parameters.Add("@MaVach", SqlDbType.VarChar).Value = sanpham.MaVach;
            command.Parameters.Add("@TenSanPham", SqlDbType.NVarChar).Value = sanpham.TenSanPham;
            command.Parameters.Add("@DonGiaBan", SqlDbType.Int).Value = sanpham.DonGiaBan;
            command.Parameters.Add("@DonViTinh", SqlDbType.NVarChar).Value = sanpham.DonViTinh;
            command.Parameters.Add("@NgaySanXuat", SqlDbType.Date).Value = sanpham.NgaySanXuat.Date;
            command.Parameters.Add("@HanSuDung", SqlDbType.Date).Value = sanpham.HanSuDung.Date;
            command.Parameters.Add("@MaLoaiSanPham", SqlDbType.Int).Value = sanpham.MaLoaiSanPham;
            command.Parameters.Add("@MaKhuyenMai", SqlDbType.VarChar).Value = sanpham.MaKhuyenMai;
            command.Parameters.Add("@HinhAnh", SqlDbType.Text).Value = sanpham.HinhAnh;

            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Update SanPham
        public string UpdateSanPham(SanPhamDTO sanpham)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            // SqlCommand
            SqlCommand command = new SqlCommand("updateSanPham", conn);
            command.CommandType = CommandType.StoredProcedure;
            // Add Parameters
            command.Parameters.Add("@MaSanpham", SqlDbType.VarChar).Value = sanpham.MaSanPham;
            command.Parameters.Add("@MaVach", SqlDbType.VarChar).Value = sanpham.MaVach;
            command.Parameters.Add("@TenSanPham", SqlDbType.NVarChar).Value = sanpham.TenSanPham;
            command.Parameters.Add("@DonGiaBan", SqlDbType.Int).Value = sanpham.DonGiaBan;
            command.Parameters.Add("@DonViTinh", SqlDbType.NVarChar).Value = sanpham.DonViTinh;
            command.Parameters.Add("@NgaySanXuat", SqlDbType.Date).Value = sanpham.NgaySanXuat.Date;
            command.Parameters.Add("@HanSuDung", SqlDbType.Date).Value = sanpham.HanSuDung.Date;
            command.Parameters.Add("@MaLoaiSanPham", SqlDbType.Int).Value = sanpham.MaLoaiSanPham;
            command.Parameters.Add("@MaKhuyenMai", SqlDbType.VarChar).Value = sanpham.MaKhuyenMai;
            command.Parameters.Add("@HinhAnh", SqlDbType.Text).Value = sanpham.HinhAnh;

            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Delete SanPham
        public string DeleteSanPham(SanPhamDTO sanpham)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            // SqlCommand
            SqlCommand command = new SqlCommand("deleteSanPham", conn);
            command.CommandType = CommandType.StoredProcedure;
            // Add Parameters
            command.Parameters.Add("@MaSanpham", SqlDbType.VarChar).Value = sanpham.MaSanPham;
            
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
