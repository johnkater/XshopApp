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
    public class KhuyenMaiAccess:DatabaseAccess
    {

        // ---------------------------------------------------------> LoaiKhuyenMai
        // Load data LoaiKhuyenMai
        public static DataTable getDataLoaiKhuyenMai()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("showLoaiKhuyenMai", conn);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;

        }
        // Add LoaiKhuyenMai
        public string AddLoaiKhuyenMai(LoaiKhuyenMaiDTO loaikhuyenmai)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("addLoaiKhuyenMai", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaLoaiKhuyenMai", SqlDbType.VarChar).Value = loaikhuyenmai.MaLoaiKhuyenMai;
            command.Parameters.Add("@TenLoaiKhuyenMai", SqlDbType.NVarChar).Value = loaikhuyenmai.TenLoaiKhuyenMai;
            
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Update LoaiKhuyenMai
        public string UpdateLoaiKhuyenMai(LoaiKhuyenMaiDTO loaikhuyenmai)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("updateLoaiKhuyenMai", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaLoaiKhuyenMai", SqlDbType.VarChar).Value = loaikhuyenmai.MaLoaiKhuyenMai;
            command.Parameters.Add("@TenLoaiKhuyenMai", SqlDbType.NVarChar).Value = loaikhuyenmai.TenLoaiKhuyenMai;

            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }
        // Delete LoaiKhuyenMai
        public string DeleteLoaiKhuyenMai(LoaiKhuyenMaiDTO loaikhuyenmai)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("deleteLoaiKhuyenMai", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaLoaiKhuyenMai", SqlDbType.VarChar).Value = loaikhuyenmai.MaLoaiKhuyenMai;

            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }


        // ---------------------------------------------------------> KhuyenMai 
        // Load data
        public static DataTable getDataKhuyenMai()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("showKhuyenMai", conn);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;

        }

        // Search KhuyenMai
        public static DataTable searchKhuyenMai(KhuyenMaiDTO khuyenmai)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            // Sqlcommand
            SqlCommand command = new SqlCommand("searchKHUYENMAI", conn);
            command.CommandType = CommandType.StoredProcedure;
            // Add Parameter
            command.Parameters.Add("@MaKhuyenMai", SqlDbType.VarChar).Value = khuyenmai.MaKhuyenMai;
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

        // Add KhuyenMai
        public string AddKhuyenMai(KhuyenMaiDTO khuyenmai)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("addKhuyenMai", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaKhuyenMai", SqlDbType.VarChar).Value = khuyenmai.MaKhuyenMai;
            command.Parameters.Add("@MaLoaiKhuyenMai", SqlDbType.Int).Value = khuyenmai.MaLoaiKhuyenMai;
            command.Parameters.Add("@GiaGiam", SqlDbType.Int).Value = khuyenmai.GiaGiam;
            command.Parameters.Add("@NgayBatDau", SqlDbType.DateTime).Value = khuyenmai.NgayBatDau;
            command.Parameters.Add("@NgayKetThuc", SqlDbType.DateTime).Value = khuyenmai.NgayKetThuc;

            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Update KhuyenMai
        public string UpdateKhuyenMai(KhuyenMaiDTO khuyenmai)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("updateKhuyenMai", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaKhuyenMai", SqlDbType.VarChar).Value = khuyenmai.MaKhuyenMai;
            command.Parameters.Add("@MaLoaiKhuyenMai", SqlDbType.Int).Value = khuyenmai.MaLoaiKhuyenMai;
            command.Parameters.Add("@GiaGiam", SqlDbType.Int).Value = khuyenmai.GiaGiam;
            command.Parameters.Add("@NgayBatDau", SqlDbType.DateTime).Value = khuyenmai.NgayBatDau;
            command.Parameters.Add("@NgayKetThuc", SqlDbType.DateTime).Value = khuyenmai.NgayKetThuc;

            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Delete KhuyenMai
        public string DeleteKhuyenMai(KhuyenMaiDTO khuyenmai)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("deleteKhuyenMai", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaKhuyenMai", SqlDbType.VarChar).Value = khuyenmai.MaKhuyenMai;
            
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
