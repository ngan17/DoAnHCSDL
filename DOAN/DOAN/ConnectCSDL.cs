using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN.Item;

namespace DOAN
{
    internal class ConnectCSDL
    {
        private static string link = "Data Source=NGAN\\SQLEXPRESS;Initial Catalog = QuanLyCuaHangQuanAo; Integrated Security = True; ";
        private static SqlConnection Connect()
        {
            return new SqlConnection(link);
        }

        public static void ExecuteNonQuery(string sql)
        {
            SqlConnection conn = Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }
        public static DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();

            // Sử dụng "using" để tự động đóng và giải phóng tài nguyên
            using (SqlConnection conn = Connect())
            {
                conn.Open();

                // Sử dụng "using" cho SqlDataAdapter
                using (SqlDataAdapter dat = new SqlDataAdapter(sql, conn))
                {
                    dat.Fill(dt);
                }
            }

            // Trả về DataTable sau khi hoàn thành
            return dt;
        }

        public static string ExecuteScalar(string sql)
        {
            SqlConnection conn = Connect();
            conn.Open();
            SqlCommand cm = new SqlCommand(sql, conn);
            Object kq = cm.ExecuteScalar();
            conn.Close();
            conn.Dispose();
            if (kq != null)
            {
                return kq.ToString();
            }
            else
            {
                return "";
            }
        }
        public static class TaiKhoanInfo
        {
            // Thuộc tính lưu tên tài khoản
            public static string TenTaiKhoan { get; set; }

            // Thuộc tính lưu tên người dùng
            public static string MaNV{ get; set; }

            // Thuộc tính lưu chucvu
            public static string passhash { get; set; }
            public static string passsalt { get; set; }
            public static int role { get; set; }
            public static string status{ get; set; }
        }
    }
}
