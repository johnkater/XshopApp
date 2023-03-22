using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{

    public class SqlConnectionData
    {
        // Tao chuoi ket noi voi co so du lieu
        public static SqlConnection Connect()
        {
            string _connectionString = "Server=DESKTOP-KKRAQC8\\MSSQLSERVER01; Database=CuaHangTienLoi; Integrated Security=true";
            SqlConnection conn = new SqlConnection(_connectionString);
            return conn;
        }
        
    }

    public class DatabaseAccess
    {
        public static string CheckLoginDTO(TaiKhoan taikhoan)
        {
            string user = null;
            // ket noi toi database
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("proc_login",conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user",taikhoan.TenTaiKhoan);
            command.Parameters.AddWithValue("@pass", taikhoan.MatKhau);
            // kiem tra quyen ...{}

            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    user = reader.GetString(1);
                    return user;
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác";
            }

            return user;

        }

    }
}
