//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;

//namespace FoodOrderApp
//{
//    public class FoodDAO
//    {
//        // Phương thức lấy tất cả món ăn
//        public static List<Food> GetAllFoods()
//        {
//            List<Food> foods = new List<Food>();

//            string query = @"SELECT f.*, c.CategoryName 
//                            FROM Foods f 
//                            INNER JOIN Categories c ON f.CategoryID = c.CategoryID
//                            WHERE f.IsAvailable = 1";

//            DataTable dataTable = DatabaseHelper.ExecuteDataTable(query, CommandType.Text);

//            foreach (DataRow row in dataTable.Rows)
//            {
//                Food food = new Food
//                {
//                    FoodID = Convert.ToInt32(row["FoodID"]),
//                    FoodName = row["FoodName"].ToString(),
//                    CategoryID = Convert.ToInt32(row["CategoryID"]),
//                    CategoryName = row["CategoryName"].ToString(),
//                    Description = row["Description"].ToString(),
//                    Price = Convert.ToDecimal(row["Price"]),
//                    ImageName = row["ImageName"].ToString(),
//                    IsAvailable = Convert.ToBoolean(row["IsAvailable"])
//                };

//                foods.Add(food);
//            }

//            return foods;
//        }

//        // Phương thức lấy món ăn theo danh mục
//        public static List<Food> GetFoodsByCategory(int categoryID)
//        {
//            List<Food> foods = new List<Food>();

//            SqlParameter[] parameters = new SqlParameter[]
//            {
//                new SqlParameter("@CategoryID", categoryID)
//            };

//            string query = @"SELECT f.*, c.CategoryName 
//                            FROM Foods f 
//                            INNER JOIN Categories c ON f.CategoryID = c.CategoryID
//                            WHERE f.CategoryID = @CategoryID AND f.IsAvailable = 1";

//            DataTable dataTable = DatabaseHelper.ExecuteDataTable(query, CommandType.Text, parameters);

//            foreach (DataRow row in dataTable.Rows)
//            {
//                Food food = new Food
//                {
//                    FoodID = Convert.ToInt32(row["FoodID"]),
//                    FoodName = row["FoodName"].ToString(),
//                    CategoryID = Convert.ToInt32(row["CategoryID"]),
//                    CategoryName = row["CategoryName"].ToString(),
//                    Description = row["Description"].ToString(),
//                    Price = Convert.ToDecimal(row["Price"]),
//                    ImageName = row["ImageName"].ToString(),
//                    IsAvailable = Convert.ToBoolean(row["IsAvailable"])
//                };

//                foods.Add(food);
//            }

//            return foods;
//        }

//        // Phương thức tìm kiếm món ăn theo từ khóa
//        public static List<Food> SearchFoods(string keyword)
//        {
//            List<Food> foods = new List<Food>();

//            SqlParameter[] parameters = new SqlParameter[]
//            {
//                new SqlParameter("@Keyword", "%" + keyword + "%")
//            };

//            string query = @"SELECT f.*, c.CategoryName 
//                            FROM Foods f 
//                            INNER JOIN Categories c ON f.CategoryID = c.CategoryID
//                            WHERE (f.FoodName LIKE @Keyword OR f.Description LIKE @Keyword) 
//                            AND f.IsAvailable = 1";

//            DataTable dataTable = DatabaseHelper.ExecuteDataTable(query, CommandType.Text, parameters);

//            foreach (DataRow row in dataTable.Rows)
//            {
//                Food food = new Food
//                {
//                    FoodID = Convert.ToInt32(row["FoodID"]),
//                    FoodName = row["FoodName"].ToString(),
//                    CategoryID = Convert.ToInt32(row["CategoryID"]),
//                    CategoryName = row["CategoryName"].ToString(),
//                    Description = row["Description"].ToString(),
//                    Price = Convert.ToDecimal(row["Price"]),
//                    ImageName = row["ImageName"].ToString(),
//                    IsAvailable = Convert.ToBoolean(row["IsAvailable"])
//                };

//                foods.Add(food);
//            }

//            return foods;
//        }

//        // Phương thức lấy 1 món ăn theo ID
//        public static Food GetFoodByID(int foodID)
//        {
//            SqlParameter[] parameters = new SqlParameter[]
//            {
//                new SqlParameter("@FoodID", foodID)
//            };

//            string query = @"SELECT f.*, c.CategoryName 
//                            FROM Foods f 
//                            INNER JOIN Categories c ON f.CategoryID = c.CategoryID
//                            WHERE f.FoodID = @FoodID";

//            DataTable dataTable = DatabaseHelper.ExecuteDataTable(query, CommandType.Text, parameters);

//            if (dataTable.Rows.Count > 0)
//            {
//                DataRow row = dataTable.Rows[0];

//                Food food = new Food
//                {
//                    FoodID = Convert.ToInt32(row["FoodID"]),
//                    FoodName = row["FoodName"].ToString(),
//                    CategoryID = Convert.ToInt32(row["CategoryID"]),
//                    CategoryName = row["CategoryName"].ToString(),
//                    Description = row["Description"].ToString(),
//                    Price = Convert.ToDecimal(row["Price"]),
//                    ImageName = row["ImageName"].ToString(),
//                    IsAvailable = Convert.ToBoolean(row["IsAvailable"])
//                };

//                return food;
//            }

//            return null;
//        }
//    }
//}
// Thêm các phương thức mới vào lớp FoodDAO

// Thêm phương thức lấy tất cả món ăn (có thể bao gồm cả không có sẵn)
using FoodOrderApp;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;
namespace FoodOrderApp.Admin
{
    public class FoodDAO
    {
        public static List<Food> GetAllFoods(bool includeUnavailable = false)
        {
            List<Food> foods = new List<Food>();

            string query = @"SELECT f.*, c.CategoryName 
                    FROM Foods f 
                    INNER JOIN Categories c ON f.CategoryID = c.CategoryID";

            if (!includeUnavailable)
            {
                query += " WHERE f.IsAvailable = 1";
            }

            DataTable dataTable = DatabaseHelper.ExecuteDataTable(query, CommandType.Text);

            foreach (DataRow row in dataTable.Rows)
            {
                Food food = new Food
                {
                    FoodID = Convert.ToInt32(row["FoodID"]),
                    FoodName = row["FoodName"].ToString(),
                    CategoryID = Convert.ToInt32(row["CategoryID"]),
                    CategoryName = row["CategoryName"].ToString(),
                    Description = row["Description"].ToString(),
                    Price = Convert.ToDecimal(row["Price"]),
                    ImageName = row["ImageName"].ToString(),
                    IsAvailable = Convert.ToBoolean(row["IsAvailable"]),
                    Quantity = Convert.ToInt32(row["Quantity"])
                };

                foods.Add(food);
            }

            return foods;
        }

        // Thêm món ăn mới
        public static int AddFood(Food food)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@FoodName", food.FoodName),
        new SqlParameter("@CategoryID", food.CategoryID),
        new SqlParameter("@Description", food.Description),
        new SqlParameter("@Price", food.Price),
        new SqlParameter("@ImageName", food.ImageName),
        new SqlParameter("@IsAvailable", food.IsAvailable),
        new SqlParameter("@Quantity", food.Quantity) // Thêm tham số mới
            };

            string query = @"INSERT INTO Foods (FoodName, CategoryID, Description, Price, ImageName, IsAvailable, Quantity)
                    VALUES (@FoodName, @CategoryID, @Description, @Price, @ImageName, @IsAvailable, @Quantity);
                    SELECT SCOPE_IDENTITY()";

            object result = DatabaseHelper.ExecuteScalar(query, CommandType.Text, parameters);

            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }

            return 0;
        }


        // Cập nhật món ăn
        public static bool UpdateFood(Food food)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@FoodID", food.FoodID),
        new SqlParameter("@FoodName", food.FoodName),
        new SqlParameter("@CategoryID", food.CategoryID),
        new SqlParameter("@Description", food.Description),
        new SqlParameter("@Price", food.Price),
        new SqlParameter("@ImageName", food.ImageName),
        new SqlParameter("@IsAvailable", food.IsAvailable),
        new SqlParameter("@Quantity", food.Quantity) // Thêm tham số mới
            };

            string query = @"UPDATE Foods 
                    SET FoodName = @FoodName, CategoryID = @CategoryID, Description = @Description,
                        Price = @Price, ImageName = @ImageName, IsAvailable = @IsAvailable, Quantity = @Quantity
                    WHERE FoodID = @FoodID";

            int result = DatabaseHelper.ExecuteNonQuery(query, CommandType.Text, parameters);

            return result > 0;
        }

        // Xóa món ăn
        public static bool DeleteFood(int foodID)
        {
            SqlConnection connection = null;
            SqlTransaction transaction = null;

            try
            {
                // Bắt đầu transaction
                connection = new SqlConnection(DatabaseHelper.connectionString);
                connection.Open();
                transaction = connection.BeginTransaction();

                // Xóa các chi tiết đơn hàng liên quan đến món ăn này (nếu cần)
                // Lưu ý: Tùy thuộc vào yêu cầu, có thể không xóa chi tiết đơn hàng

                // Xóa món ăn
                SqlCommand deleteFoodCommand = new SqlCommand(
                    "DELETE FROM Foods WHERE FoodID = @FoodID", connection, transaction);
                deleteFoodCommand.Parameters.AddWithValue("@FoodID", foodID);
                int rowsAffected = deleteFoodCommand.ExecuteNonQuery();

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