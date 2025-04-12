using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

// CartDAO để lưu giỏ hàng khi người dùng đăng xuất và khôi phục khi đăng nhập lại:
namespace FoodOrderApp
{
    public class CartDAO
    {
        // Lưu giỏ hàng vào cơ sở dữ liệu
        public static bool SaveCart(int userID, List<CartItem> cartItems)
        {
            SqlConnection connection = null;
            SqlTransaction transaction = null;

            try
            {
                // Bắt đầu transaction
                connection = new SqlConnection(DatabaseHelper.connectionString);
                connection.Open();
                transaction = connection.BeginTransaction();

                // Xóa giỏ hàng cũ (nếu có)
                SqlCommand deleteCommand = new SqlCommand("DELETE FROM SavedCarts WHERE UserID = @UserID", connection, transaction);
                deleteCommand.Parameters.AddWithValue("@UserID", userID);
                deleteCommand.ExecuteNonQuery();

                // Không cần lưu nếu giỏ hàng trống
                if (cartItems.Count == 0)
                {
                    transaction.Commit();
                    return true;
                }

                // Thêm các món vào giỏ hàng
                foreach (CartItem item in cartItems)
                {
                    SqlCommand insertCommand = new SqlCommand(
                        @"INSERT INTO SavedCarts (UserID, FoodID, Quantity, SavedDate)
                        VALUES (@UserID, @FoodID, @Quantity, GETDATE())", connection, transaction);

                    insertCommand.Parameters.AddWithValue("@UserID", userID);
                    insertCommand.Parameters.AddWithValue("@FoodID", item.FoodID);
                    insertCommand.Parameters.AddWithValue("@Quantity", item.Quantity);

                    insertCommand.ExecuteNonQuery();
                }

                // Commit transaction
                transaction.Commit();
                return true;
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

        // Tải giỏ hàng từ cơ sở dữ liệu
        public static List<CartItem> LoadCart(int userID)
        {
            List<CartItem> cartItems = new List<CartItem>();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserID", userID)
            };

            string query = @"SELECT sc.FoodID, sc.Quantity, f.FoodName, f.Price 
                            FROM SavedCarts sc
                            INNER JOIN Foods f ON sc.FoodID = f.FoodID
                            WHERE sc.UserID = @UserID";

            using (SqlDataReader reader = DatabaseHelper.ExecuteReader(query, CommandType.Text, parameters))
            {
                while (reader.Read())
                {
                    CartItem item = new CartItem
                    {
                        FoodID = Convert.ToInt32(reader["FoodID"]),
                        FoodName = reader["FoodName"].ToString(),
                        Price = Convert.ToDecimal(reader["Price"]),
                        Quantity = Convert.ToInt32(reader["Quantity"])
                    };

                    cartItems.Add(item);
                }
            }

            return cartItems;
        }

        // Xóa giỏ hàng
        public static bool ClearCart(int userID)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserID", userID)
            };

            string query = "DELETE FROM SavedCarts WHERE UserID = @UserID";

            int result = DatabaseHelper.ExecuteNonQuery(query, CommandType.Text, parameters);

            return true; // Luôn trả về true vì nếu không có item nào bị xóa vẫn là thành công
        }
    }
}