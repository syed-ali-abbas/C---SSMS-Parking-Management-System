using System;
using System.Data;
using System.Data.SqlClient;

namespace ParkingManagementSystem
{
    class DBHandler
    {
        static string connectionString = @"Data Source=SYEDASARAMOOSVI\SQLEXPRESS;Initial Catalog=parkingdb;Integrated Security=True";
        public static bool executeInsertQuery(SqlCommand sqlCommand)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                if (sqlConnection.State == System.Data.ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                //sqlConnection.Open();
                sqlCommand.Connection = sqlConnection;
                int count = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                if (count < 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }                              
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static DataTable executeSelectQuery(string query)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                if (sqlConnection.State == ConnectionState.Closed) { sqlConnection.Open(); }
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(query, sqlConnection);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                sqlConnection.Close();
            }
            return dt;            
        }
    }
}
