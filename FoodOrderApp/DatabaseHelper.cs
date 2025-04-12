using System;
using System.Data;
using System.Data.SqlClient;

namespace FoodOrderApp
{
    public class DatabaseHelper
    {
        public static string connectionString = @"Data Source=DESKTOP-CGTH67O;Initial Catalog=FoodOrderDB;Integrated Security=True";

        // Phương thức thực thi truy vấn không trả về dữ liệu (INSERT, UPDATE, DELETE)
        public static int ExecuteNonQuery(string commandText, CommandType commandType, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.CommandType = commandType;

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        // Phương thức thực thi truy vấn và trả về SqlDataReader
        public static SqlDataReader ExecuteReader(string commandText, CommandType commandType, SqlParameter[] parameters = null)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(commandText, connection);
            command.CommandType = commandType;

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        // Phương thức thực thi truy vấn và trả về DataTable
        public static DataTable ExecuteDataTable(string commandText, CommandType commandType, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.CommandType = commandType;

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        // Phương thức thực thi truy vấn và trả về giá trị đơn
        public static object ExecuteScalar(string commandText, CommandType commandType, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.CommandType = commandType;

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    connection.Open();
                    return command.ExecuteScalar();
                }
            }
        }
    }
}