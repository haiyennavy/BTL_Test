using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace FoodOrderApp
{
    public class CategoryDAO
    {
        // Lấy tất cả danh mục
        public static List<Category> GetAllCategories()
        {
            List<Category> categories = new List<Category>();

            string query = "SELECT * FROM Categories ORDER BY CategoryName";

            DataTable dataTable = DatabaseHelper.ExecuteDataTable(query, CommandType.Text);

            foreach (DataRow row in dataTable.Rows)
            {
                Category category = new Category
                {
                    CategoryID = Convert.ToInt32(row["CategoryID"]),
                    CategoryName = row["CategoryName"].ToString(),
                    Description = row["Description"].ToString()
                };

                categories.Add(category);
            }

            return categories;
        }

        // Lấy danh mục theo ID
        public static Category GetCategoryByID(int categoryID)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@CategoryID", categoryID)
            };

            string query = "SELECT * FROM Categories WHERE CategoryID = @CategoryID";

            DataTable dataTable = DatabaseHelper.ExecuteDataTable(query, CommandType.Text, parameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];

                Category category = new Category
                {
                    CategoryID = Convert.ToInt32(row["CategoryID"]),
                    CategoryName = row["CategoryName"].ToString(),
                    Description = row["Description"].ToString()
                };

                return category;
            }

            return null;
        }

        // Thêm danh mục mới
        public static int AddCategory(Category category)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@CategoryName", category.CategoryName),
                new SqlParameter("@Description", string.IsNullOrEmpty(category.Description) ? (object)DBNull.Value : category.Description)
            };

            string query = @"INSERT INTO Categories (CategoryName, Description) 
                          VALUES (@CategoryName, @Description);
                          SELECT SCOPE_IDENTITY()";

            object result = DatabaseHelper.ExecuteScalar(query, CommandType.Text, parameters);

            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }

            return 0;
        }

        // Cập nhật danh mục
        public static bool UpdateCategory(Category category)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@CategoryID", category.CategoryID),
                new SqlParameter("@CategoryName", category.CategoryName),
                new SqlParameter("@Description", string.IsNullOrEmpty(category.Description) ? (object)DBNull.Value : category.Description)
            };

            string query = @"UPDATE Categories 
                          SET CategoryName = @CategoryName, Description = @Description 
                          WHERE CategoryID = @CategoryID";

            int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, CommandType.Text, parameters);

            return rowsAffected > 0;
        }

        // Xóa danh mục
        public static bool DeleteCategory(int categoryID)
        {
            SqlConnection connection = null;
            SqlTransaction transaction = null;

            try
            {
                // Bắt đầu transaction
                connection = new SqlConnection(DatabaseHelper.connectionString);
                connection.Open();
                transaction = connection.BeginTransaction();

                // Xóa tất cả món ăn thuộc danh mục này
                SqlCommand deleteFoodsCommand = new SqlCommand(
                    "DELETE FROM Foods WHERE CategoryID = @CategoryID", connection, transaction);
                deleteFoodsCommand.Parameters.AddWithValue("@CategoryID", categoryID);
                deleteFoodsCommand.ExecuteNonQuery();

                // Xóa danh mục
                SqlCommand deleteCategoryCommand = new SqlCommand(
                    "DELETE FROM Categories WHERE CategoryID = @CategoryID", connection, transaction);
                deleteCategoryCommand.Parameters.AddWithValue("@CategoryID", categoryID);
                int rowsAffected = deleteCategoryCommand.ExecuteNonQuery();

                // Commit transaction
                transaction.Commit();
                return rowsAffected > 0;
            }
            catch
            {
                // Rollback transaction nếu có lỗi
                transaction?.Rollback();
                throw;
            }
            finally
            {
                // Đóng kết nối
                connection?.Close();
            }
        }
    }
}