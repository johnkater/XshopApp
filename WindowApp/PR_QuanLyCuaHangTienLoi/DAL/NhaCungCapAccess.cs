using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class NhaCungCapAccess: DatabaseAccess
    {
        // Load data
        public static DataTable getData()
        {          
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("queryNHACUNGCAP", conn);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;

        }
        
        // Add NhaCungCap
        public string AddNhaCungCap (NhaCungCapDTO nhacungcap) {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("addNHACUNGCAP", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaNhaCungCap", SqlDbType.VarChar).Value = nhacungcap.MaNhaCungCap;
            command.Parameters.Add("@TenNhaCungCap", SqlDbType.VarChar).Value = nhacungcap.TenNhaCungCap;
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nhacungcap.DiaChi;
            command.Parameters.Add("@SoDienThoai", SqlDbType.VarChar).Value = nhacungcap.SoDienThoai;
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = nhacungcap.Email;
            command.Parameters.Add("@HinhAnh", SqlDbType.Text).Value = nhacungcap.HinhAnh;
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Update NhaCungCap
        public string UpdateNhaCungCap(NhaCungCapDTO nhacungcap)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            // Create Sqlcommand
            SqlCommand command = new SqlCommand("updateNHACUNGCAP", conn);
            command.CommandType = CommandType.StoredProcedure;
            // Add Parameters
            command.Parameters.Add("@MaNhaCungCap", SqlDbType.VarChar).Value = nhacungcap.MaNhaCungCap;
            command.Parameters.Add("@TenNhaCungCap", SqlDbType.VarChar).Value = nhacungcap.TenNhaCungCap;
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nhacungcap.DiaChi;
            command.Parameters.Add("@SoDienThoai", SqlDbType.VarChar).Value = nhacungcap.SoDienThoai;
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = nhacungcap.Email;
            command.Parameters.Add("@HinhAnh", SqlDbType.Text).Value = nhacungcap.HinhAnh;
            // Execution 
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
            
        }
        // Delete NhaCungCap
        public string DeleteNhaCungCap(NhaCungCapDTO nhacungcap)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            // Create Sqlcommand
            SqlCommand command = new SqlCommand("deleteNHACUNGCAP", conn);
            command.CommandType = CommandType.StoredProcedure;
            // Add Parameters
            command.Parameters.Add("@MaNhaCungCap", SqlDbType.VarChar).Value = nhacungcap.MaNhaCungCap;
            // Execution 
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {

                return "success";
            }
            else
                return "failure";
        }

        // Search NhaCungCap
        public static DataTable SearchNhaCungCap(NhaCungCapDTO nhacungcap)
        {
            // Open connection
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("searchNHACUNGCAP", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@TenNhaCungCap", SqlDbType.VarChar).Value = nhacungcap.TenNhaCungCap;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

    }
}
