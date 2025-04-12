using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace FoodOrderApp
{
    public class RatingDAO
    {
        // Lưu đánh giá vào cơ sở dữ liệu
        public static bool SaveRating(Rating rating)
        {
            try
            {
                // Kiểm tra xem đã có đánh giá cho đơn hàng này chưa
                SqlParameter[] checkParams = new SqlParameter[]
                {
                    new SqlParameter("@OrderID", rating.OrderID),
                    new SqlParameter("@UserID", rating.UserID)
                };

                string checkQuery = "SELECT COUNT(*) FROM Ratings WHERE OrderID = @OrderID AND UserID = @UserID";
                int existingCount = Convert.ToInt32(DatabaseHelper.ExecuteScalar(checkQuery, CommandType.Text, checkParams));

                // Nếu đã có đánh giá, cập nhật đánh giá hiện tại
                if (existingCount > 0)
                {
                    SqlParameter[] updateParams = new SqlParameter[]
                    {
                        new SqlParameter("@OrderID", rating.OrderID),
                        new SqlParameter("@UserID", rating.UserID),
                        new SqlParameter("@Rating", rating.RatingValue),
                        new SqlParameter("@Comment", string.IsNullOrEmpty(rating.Comment) ? (object)DBNull.Value : rating.Comment),
                        new SqlParameter("@RatingDate", DateTime.Now)
                    };

                    string updateQuery = @"UPDATE Ratings 
                                         SET Rating = @Rating, Comment = @Comment, RatingDate = @RatingDate 
                                         WHERE OrderID = @OrderID AND UserID = @UserID";

                    int result = DatabaseHelper.ExecuteNonQuery(updateQuery, CommandType.Text, updateParams);
                    return result > 0;
                }
                else
                {
                    // Thêm đánh giá mới
                    SqlParameter[] insertParams = new SqlParameter[]
                    {
                        new SqlParameter("@OrderID", rating.OrderID),
                        new SqlParameter("@UserID", rating.UserID),
                        new SqlParameter("@Rating", rating.RatingValue),
                        new SqlParameter("@Comment", string.IsNullOrEmpty(rating.Comment) ? (object)DBNull.Value : rating.Comment),
                        new SqlParameter("@RatingDate", DateTime.Now)
                    };

                    string insertQuery = @"INSERT INTO Ratings (OrderID, UserID, Rating, Comment, RatingDate) 
                                         VALUES (@OrderID, @UserID, @Rating, @Comment, @RatingDate)";

                    int result = DatabaseHelper.ExecuteNonQuery(insertQuery, CommandType.Text, insertParams);
                    return result > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Lấy đánh giá theo đơn hàng
        public static Rating GetRatingByOrder(int orderID, int userID)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID", orderID),
                new SqlParameter("@UserID", userID)
            };

            string query = "SELECT * FROM Ratings WHERE OrderID = @OrderID AND UserID = @UserID";

            using (SqlDataReader reader = DatabaseHelper.ExecuteReader(query, CommandType.Text, parameters))
            {
                if (reader.Read())
                {
                    Rating rating = new Rating
                    {
                        RatingID = Convert.ToInt32(reader["RatingID"]),
                        OrderID = Convert.ToInt32(reader["OrderID"]),
                        UserID = Convert.ToInt32(reader["UserID"]),
                        RatingValue = Convert.ToInt32(reader["Rating"]),
                        RatingDate = Convert.ToDateTime(reader["RatingDate"])
                    };

                    if (reader["Comment"] != DBNull.Value)
                    {
                        rating.Comment = reader["Comment"].ToString();
                    }

                    return rating;
                }
            }

            return null;
        }

        // Lấy đánh giá cho món ăn
        public static List<Rating> GetRatingsByFood(int foodID)
        {
            List<Rating> ratings = new List<Rating>();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@FoodID", foodID)
            };

            string query = @"SELECT r.* 
                           FROM Ratings r 
                           INNER JOIN OrderDetails od ON r.OrderID = od.OrderID 
                           WHERE od.FoodID = @FoodID";

            DataTable dataTable = DatabaseHelper.ExecuteDataTable(query, CommandType.Text, parameters);

            foreach (DataRow row in dataTable.Rows)
            {
                Rating rating = new Rating
                {
                    RatingID = Convert.ToInt32(row["RatingID"]),
                    OrderID = Convert.ToInt32(row["OrderID"]),
                    UserID = Convert.ToInt32(row["UserID"]),
                    RatingValue = Convert.ToInt32(row["Rating"]),
                    RatingDate = Convert.ToDateTime(row["RatingDate"])
                };

                if (row["Comment"] != DBNull.Value)
                {
                    rating.Comment = row["Comment"].ToString();
                }

                ratings.Add(rating);
            }

            return ratings;
        }

        // Tính điểm đánh giá trung bình cho món ăn
        public static double GetAverageRatingForFood(int foodID)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@FoodID", foodID)
            };

            string query = @"SELECT AVG(CAST(r.Rating AS FLOAT)) AS AvgRating
                           FROM Ratings r 
                           INNER JOIN OrderDetails od ON r.OrderID = od.OrderID 
                           WHERE od.FoodID = @FoodID";

            object result = DatabaseHelper.ExecuteScalar(query, CommandType.Text, parameters);

            if (result != null && result != DBNull.Value)
            {
                return Convert.ToDouble(result);
            }

            return 0;
        }
        // Lấy tất cả đánh giá
        public static List<Rating> GetAllRatings()
        {
            List<Rating> ratings = new List<Rating>();

            string query = "SELECT * FROM Ratings ORDER BY RatingDate DESC";

            DataTable dataTable = DatabaseHelper.ExecuteDataTable(query, CommandType.Text, null);

            foreach (DataRow row in dataTable.Rows)
            {
                Rating rating = new Rating
                {
                    RatingID = Convert.ToInt32(row["RatingID"]),
                    OrderID = Convert.ToInt32(row["OrderID"]),
                    UserID = Convert.ToInt32(row["UserID"]),
                    RatingValue = Convert.ToInt32(row["Rating"]),
                    RatingDate = Convert.ToDateTime(row["RatingDate"])
                };

                if (row["Comment"] != DBNull.Value)
                {
                    rating.Comment = row["Comment"].ToString();
                }

                ratings.Add(rating);
            }

            return ratings;
        }

        // Xóa đánh giá
        public static bool DeleteRating(int ratingID)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@RatingID", ratingID)
                };

                string query = "DELETE FROM Ratings WHERE RatingID = @RatingID";
                int result = DatabaseHelper.ExecuteNonQuery(query, CommandType.Text, parameters);
                return result > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
        // Lấy đánh giá theo người dùng
        public static List<Rating> GetRatingsByUser(int userID)
        {
            List<Rating> ratings = new List<Rating>();

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@UserID", userID)
            };

            string query = "SELECT * FROM Ratings WHERE UserID = @UserID ORDER BY RatingDate DESC";

            DataTable dataTable = DatabaseHelper.ExecuteDataTable(query, CommandType.Text, parameters);

            foreach (DataRow row in dataTable.Rows)
            {
                Rating rating = new Rating
                {
                    RatingID = Convert.ToInt32(row["RatingID"]),
                    OrderID = Convert.ToInt32(row["OrderID"]),
                    UserID = Convert.ToInt32(row["UserID"]),
                    RatingValue = Convert.ToInt32(row["Rating"]),
                    RatingDate = Convert.ToDateTime(row["RatingDate"])
                };

                if (row["Comment"] != DBNull.Value)
                {
                    rating.Comment = row["Comment"].ToString();
                }

                ratings.Add(rating);
            }

            return ratings;
        }
    }
}
