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
    public class KhachHangAccess:DatabaseAccess
    {
        // -------------------------------------------------------------------------> KhachHang
        // Load data
        public static DataTable getData()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("showKhachHang", conn);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;

        }

        // Search KhachHang
        public static DataTable SearchKhachHang(KhachHangDTO khachhang)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("searchKHACHHANG", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = khachhang.HoTen;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        // Add KhachHang
        public string AddKhachHang(KhachHangDTO khachhang)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("addKhachHang", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaKhachHang", SqlDbType.VarChar).Value = khachhang.MaKhachHang;
            command.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = khachhang.HoTen;
            command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = khachhang.GioiTinh;
            command.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = khachhang.NgaySinh.Date;
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = khachhang.DiaChi;
            command.Parameters.Add("@SoDienThoai", SqlDbType.VarChar).Value = khachhang.SoDienThoai;
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = khachhang.Email;
            command.Parameters.Add("@HinhAnh", SqlDbType.Text).Value = khachhang.HinhAnh;
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Update KhachHang
        public string UpdateKhachHang(KhachHangDTO khachhang)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("updateKhachHang", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaKhachHang", SqlDbType.VarChar).Value = khachhang.MaKhachHang;
            command.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = khachhang.HoTen;
            command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = khachhang.GioiTinh;
            command.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = khachhang.NgaySinh.Date;
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = khachhang.DiaChi;
            command.Parameters.Add("@SoDienThoai", SqlDbType.VarChar).Value = khachhang.SoDienThoai;
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = khachhang.Email;
            command.Parameters.Add("@HinhAnh", SqlDbType.Text).Value = khachhang.HinhAnh;
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Delete KhachHang
        public string DeleteKhachHang(KhachHangDTO khachhang)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("deleteKhachHang", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaKhachHang", SqlDbType.VarChar).Value = khachhang.MaKhachHang;
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }
        // -----------------------------------------------------------> TheKhachHang

        // Load data TheKhachHang
        public static DataTable getDataTheKhachHang()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("showTheKhachHang", conn);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;

        }
        // Search TheKhachHang
        public static DataTable SearchTheKhachHang(KhachHangDTO khachhang)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("searchTheKhachHang", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = khachhang.HoTen;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        // Add TheKhachHang
        public string AddTheKhachHang(TheKhachHangDTO thekhachhang)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("addTheKhachHang", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaTheKhachHang", SqlDbType.VarChar).Value = thekhachhang.MaTheKhachHang;
            command.Parameters.Add("@MaKhachHang", SqlDbType.VarChar).Value = thekhachhang.MaKhachhang;
            command.Parameters.Add("@NgayLap", SqlDbType.DateTime).Value = thekhachhang.NgayLap;
            command.Parameters.Add("@TichDiem", SqlDbType.Int).Value = thekhachhang.TichDiem;
            command.Parameters.Add("@MaLoaiTheKhachHang", SqlDbType.Int).Value = thekhachhang.MaLoaiTheKhachHang;

            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Update TheKhachHang
        public string UpdateTheKhachHang(TheKhachHangDTO thekhachhang)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("updateTheKhachHang", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaTheKhachHang", SqlDbType.VarChar).Value = thekhachhang.MaTheKhachHang;
            command.Parameters.Add("@MaKhachHang", SqlDbType.VarChar).Value = thekhachhang.MaKhachhang;
            command.Parameters.Add("@NgayLap", SqlDbType.DateTime).Value = thekhachhang.NgayLap;
            command.Parameters.Add("@TichDiem", SqlDbType.Int).Value = thekhachhang.TichDiem;
            command.Parameters.Add("@MaLoaiTheKhachHang", SqlDbType.Int).Value = thekhachhang.MaLoaiTheKhachHang;

            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }
        // Delete TheKhachHang
        public string DeleteTheKhachHang(TheKhachHangDTO thekhachhang)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("deleteTheKhachHang", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaTheKhachHang", SqlDbType.VarChar).Value = thekhachhang.MaTheKhachHang;
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // ----------------------------------------------------------> LoaiTheKhachHang

        // Load data LoaiTheKhachHang
        public static DataTable getDataLoaiTheKhachHang()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("showLoaiTheKhachHang", conn);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;

        }
        // Add LoaiTheKhachHang
        public string AddLoaiTheKhachHang(LoaiTheKhachHangDTO loaiThekhachhang)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("addLoaiTheKhachHang", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaLoaiTheKhachHang", SqlDbType.Int).Value = loaiThekhachhang.MaLoaiTheKhachHang;
            command.Parameters.Add("@TenLoaiTheKhachHang", SqlDbType.NVarChar).Value = loaiThekhachhang.TenLoaiTheKhachHang;
          
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }
        // Update LoaiTheKhachHang
        public string UpdateLoaiTheKhachHang(LoaiTheKhachHangDTO loaiThekhachhang)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("updateLoaiTheKhachHang", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaLoaiTheKhachHang", SqlDbType.Int).Value = loaiThekhachhang.MaLoaiTheKhachHang;
            command.Parameters.Add("@TenLoaiTheKhachHang", SqlDbType.NVarChar).Value = loaiThekhachhang.TenLoaiTheKhachHang;

            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }
        // Delete LoaiTheKhachHang
        public string DeleteLoaiTheKhachHang(LoaiTheKhachHangDTO loaiThekhachhang)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("deleteLoaiTheKhachHang", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaLoaiTheKhachHang", SqlDbType.Int).Value = loaiThekhachhang.MaLoaiTheKhachHang;

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
