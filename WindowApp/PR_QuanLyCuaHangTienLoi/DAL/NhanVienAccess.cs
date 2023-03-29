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
    public class NhanVienAccess:DatabaseAccess
    {
        // Load data
        public static DataTable getData()
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("showNhanVien", conn);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;

        }

        // Add NhanVien
        public string AddNhanVien(NhanVienDTO nhanvien)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            // Sqlcommand
            SqlCommand command = new SqlCommand("addNhanVien", conn);
            command.CommandType = CommandType.StoredProcedure;
            // Add Parameter
            command.Parameters.Add("@MaNhanVien", SqlDbType.VarChar).Value = nhanvien.MaNhanVien;
            command.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = nhanvien.HoTen;
            command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = nhanvien.GioiTinh;
            command.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = nhanvien.NgaySinh.Date;
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nhanvien.DiaChi;
            command.Parameters.Add("@QueQuan", SqlDbType.NVarChar).Value = nhanvien.QueQuan;
            command.Parameters.Add("@SoDienThoai", SqlDbType.VarChar).Value = nhanvien.SoDienThoai;
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = nhanvien.Email;
            command.Parameters.Add("@HinhAnh", SqlDbType.VarChar).Value = nhanvien.HinhAnh;
            // Execution 
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";

            
        }

        // Update NhanVien
        public string UpdateNhanVien(NhanVienDTO nhanvien)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            // Sqlcommand
            SqlCommand command = new SqlCommand("updateNhanVien", conn);
            command.CommandType = CommandType.StoredProcedure;
            // Add Parameter
            command.Parameters.Add("@MaNhanVien", SqlDbType.VarChar).Value = nhanvien.MaNhanVien;
            command.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = nhanvien.HoTen;
            command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = nhanvien.GioiTinh;
            command.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = nhanvien.NgaySinh.Date;
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nhanvien.DiaChi;
            command.Parameters.Add("@QueQuan", SqlDbType.NVarChar).Value = nhanvien.QueQuan;
            command.Parameters.Add("@SoDienThoai", SqlDbType.VarChar).Value = nhanvien.SoDienThoai;
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = nhanvien.Email;
            command.Parameters.Add("@HinhAnh", SqlDbType.VarChar).Value = nhanvien.HinhAnh;
            // Execution 
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
            
        }

        // Delete NhanVien
        public string DeleteNhanVien(NhanVienDTO nhanvien)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            // Sqlcommand
            SqlCommand command = new SqlCommand("deleteNhanVien", conn);
            command.CommandType = CommandType.StoredProcedure;
            // Add Parameter
            command.Parameters.Add("@MaNhanVien", SqlDbType.VarChar).Value = nhanvien.MaNhanVien;
            // Execution 
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
          
        }

        // Search NhanVien
        public static DataTable searchNhanVien(NhanVienDTO nhanvien)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            // Sqlcommand
            SqlCommand command = new SqlCommand("searchNHANVIEN", conn);
            command.CommandType = CommandType.StoredProcedure;
            // Add Parameter
            command.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = nhanvien.HoTen;
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

    }
}
