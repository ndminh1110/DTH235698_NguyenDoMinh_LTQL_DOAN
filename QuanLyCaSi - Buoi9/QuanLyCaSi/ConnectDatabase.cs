using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace QuanLyCaSi
{
    class Database
    {
        // Chuỗi kết nối SQL Server
        private static string connectionString = @"Data Source=ADMIN-PC;
                                                Initial Catalog=QLCaSi;
                                                Integrated Security=True;
                                                TrustServerCertificate=True";

        // Hàm mở kết nối
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }

        // Hàm lấy dữ liệu (SELECT)
        public static DataTable GetData(string query)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Hàm thực thi INSERT, UPDATE, DELETE
        public static int Execute(string query)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                int result = cmd.ExecuteNonQuery();

                return result;
            }
        }
    }
}