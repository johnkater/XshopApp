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

    }
}
