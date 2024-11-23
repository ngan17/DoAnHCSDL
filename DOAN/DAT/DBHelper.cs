using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT
{
    internal class DBHelper
    {
        private string connectionString = "Server=.;Database=QuanLyCuaHangQuanAo;User Id=sa;Password=quocDat132002;";

        //mo ket noi
        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Hàm thực thi Stored Procedure không trả về dữ liệu (INSERT, UPDATE, DELETE)
        public int ExecuteNonQuery(string procedureName, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Hàm thực thi Stored Procedure trả về dữ liệu (SELECT)
        public DataTable ExecuteQuery(string procedureName, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // Hàm thực thi Stored Procedure trả về dữ liệu đơn (SELECT)
        public object ExecuteScalar(string procedureName, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteScalar();
                }
            }
        }







    }
}
