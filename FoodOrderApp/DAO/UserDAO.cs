using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace FoodOrderApp
{
    public class UserDAO
    {
        // Phương thức đăng nhập chua hash
        //public static User Login(string username, string password)
        //{
        //    SqlParameter[] parameters = new SqlParameter[]
        //    {
        //        new SqlParameter("@Username", username),
        //        new SqlParameter("@Password", password)
        //    };

        //    string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";

        //    using (SqlDataReader reader = DatabaseHelper.ExecuteReader(query, CommandType.Text, parameters))
        //    {
        //        if (reader.Read())
        //        {
        //            User user = new User
        //            {
        //                UserID = Convert.ToInt32(reader["UserID"]),
        //                Username = reader["Username"].ToString(),
        //                Password = reader["Password"].ToString(),
        //                FullName = reader["FullName"].ToString(),
        //                Phone = reader["Phone"].ToString(),
        //                Email = reader["Email"].ToString(),
        //                Address = reader["Address"].ToString(),
        //                UserRole = reader["UserRole"].ToString()
        //            };

        //            return user;
        //        }
        //    }

        //    return null;
        //}
        //Phương thức đăng nhập
        public static User Login(string username, string password)
        {
            // Hash mật khẩu trước khi truy vấn
            string hashedPassword = HashPassword(password);

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@Username", username),
        new SqlParameter("@Password", hashedPassword)
            };

            string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";

            using (SqlDataReader reader = DatabaseHelper.ExecuteReader(query, CommandType.Text, parameters))
            {
                if (reader.Read())
                {
                    User user = new User
                    {
                        UserID = Convert.ToInt32(reader["UserID"]),
                        Username = reader["Username"].ToString(),
                        Password = reader["Password"].ToString(),
                        FullName = reader["FullName"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Email = reader["Email"].ToString(),
                        Address = reader["Address"].ToString(),
                        UserRole = reader["UserRole"].ToString()
                    };

                    return user;
                }
            }

            return null;
        }

        // Phương thức đăng ký chua hash
        //public static bool Register(User user)
        //{
        //    SqlParameter[] parameters = new SqlParameter[]
        //    {
        //        new SqlParameter("@Username", user.Username),
        //        new SqlParameter("@Password", user.Password),
        //        new SqlParameter("@FullName", user.FullName),
        //        new SqlParameter("@Phone", user.Phone),
        //        new SqlParameter("@Email", user.Email),
        //        new SqlParameter("@Address", user.Address)
        //    };

        //    string query = @"INSERT INTO Users (Username, Password, FullName, Phone, Email, Address, UserRole) 
        //                    VALUES (@Username, @Password, @FullName, @Phone, @Email, @Address, 'Customer')";

        //    int result = DatabaseHelper.ExecuteNonQuery(query, CommandType.Text, parameters);

        //    return result > 0;
        //}

        // Phương thức đăng ký
        public static bool Register(User user)
        {
            // Hash mật khẩu trước khi lưu
            string hashedPassword = HashPassword(user.Password);

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@Username", user.Username),
        new SqlParameter("@Password", hashedPassword),
        new SqlParameter("@FullName", user.FullName),
        new SqlParameter("@Phone", user.Phone),
        new SqlParameter("@Email", user.Email),
        new SqlParameter("@Address", user.Address)
            };

            string query = @"INSERT INTO Users (Username, Password, FullName, Phone, Email, Address, UserRole) 
                    VALUES (@Username, @Password, @FullName, @Phone, @Email, @Address, 'Customer')";

            int result = DatabaseHelper.ExecuteNonQuery(query, CommandType.Text, parameters);

            return result > 0;
        }

        // Phương thức cập nhật thông tin người dùng
        public static bool UpdateUserInfo(User user)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@UserID", user.UserID),
        new SqlParameter("@FullName", user.FullName),
        new SqlParameter("@Phone", user.Phone),
        new SqlParameter("@Email", user.Email ?? (object)DBNull.Value),
        new SqlParameter("@Address", user.Address ?? (object)DBNull.Value)
            };

            string query = @"UPDATE Users 
                    SET FullName = @FullName, Phone = @Phone, Email = @Email, Address = @Address 
                    WHERE UserID = @UserID";

            int result = DatabaseHelper.ExecuteNonQuery(query, CommandType.Text, parameters);

            return result > 0;
        }

        // Phương thức cập nhật mật khẩu chua hash
        //public static bool UpdatePassword(int userID, string newPassword)
        //{
        //    SqlParameter[] parameters = new SqlParameter[]
        //    {
        //new SqlParameter("@UserID", userID),
        //new SqlParameter("@Password", newPassword)
        //    };

        //    string query = "UPDATE Users SET Password = @Password WHERE UserID = @UserID";

        //    int result = DatabaseHelper.ExecuteNonQuery(query, CommandType.Text, parameters);

        //    return result > 0;
        //}
        public static bool UpdatePassword(int userID, string newPassword)
        {
            // Hash mật khẩu mới trước khi lưu
            string hashedPassword = HashPassword(newPassword);

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@UserID", userID),
        new SqlParameter("@Password", hashedPassword)
            };

            string query = "UPDATE Users SET Password = @Password WHERE UserID = @UserID";

            int result = DatabaseHelper.ExecuteNonQuery(query, CommandType.Text, parameters);

            return result > 0;
        }
        // Phương thức xác minh mật khẩu
        public static bool VerifyPassword(int userID, string password)
        {
            // Hash mật khẩu trước khi so sánh
            string hashedPassword = HashPassword(password);

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@UserID", userID),
        new SqlParameter("@Password", hashedPassword)
            };

            string query = "SELECT COUNT(*) FROM Users WHERE UserID = @UserID AND Password = @Password";

            int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, CommandType.Text, parameters));

            return count > 0;
        }
        public static User GetUserByID(int userID)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserID", userID)
            };

            string query = "SELECT * FROM Users WHERE UserID = @UserID";

            DataTable dataTable = DatabaseHelper.ExecuteDataTable(query, CommandType.Text, parameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];

                User user = new User
                {
                    UserID = Convert.ToInt32(row["UserID"]),
                    Username = row["Username"].ToString(),
                    FullName = row["FullName"].ToString(),
                    Phone = row["Phone"].ToString(),
                    Email = row["Email"].ToString(),
                    Address = row["Address"].ToString(),
                    UserRole = row["UserRole"].ToString()
                };

                return user;
            }

            return null;
        }
            // Phương thức lấy tất cả người dùng
        public static List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            string query = "SELECT * FROM Users ORDER BY UserID";

            DataTable dataTable = DatabaseHelper.ExecuteDataTable(query, CommandType.Text, null);

            foreach (DataRow row in dataTable.Rows)
            {
                User user = new User
                {
                    UserID = Convert.ToInt32(row["UserID"]),
                    Username = row["Username"].ToString(),
                    FullName = row["FullName"].ToString(),
                    Phone = row["Phone"].ToString(),
                    Email = row["Email"].ToString(),
                    Address = row["Address"].ToString(),
                    UserRole = row["UserRole"].ToString()
                };

                users.Add(user);
            }

            return users;
        }

        //// Phương thức lấy người dùng theo ID
        //public static User GetUserByID(int userID)
        //{
        //    SqlParameter[] parameters = new SqlParameter[]
        //    {
        //        new SqlParameter("@UserID", userID)
        //    };

        //    string query = "SELECT * FROM Users WHERE UserID = @UserID";

        //    DataTable dataTable = DatabaseHelper.ExecuteDataTable(query, CommandType.Text, parameters);

        //    if (dataTable.Rows.Count > 0)
        //    {
        //        DataRow row = dataTable.Rows[0];

        //        User user = new User
        //        {
        //            UserID = Convert.ToInt32(row["UserID"]),
        //            Username = row["Username"].ToString(),
        //            FullName = row["FullName"].ToString(),
        //            Phone = row["Phone"].ToString(),
        //            Email = row["Email"].ToString(),
        //            Address = row["Address"].ToString(),
        //            UserRole = row["UserRole"].ToString()
        //        };

        //        return user;
        //    }

        //    return null;
        //}

        // Phương thức thêm người dùng mới
        public static int AddUser(User user)
        {
            // Kiểm tra xem username đã tồn tại chưa
            if (IsUsernameExists(user.Username))
            {
                throw new Exception("Tên đăng nhập đã tồn tại!");
            }

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", user.Username),
                new SqlParameter("@Password", HashPassword(user.Password)),
                new SqlParameter("@FullName", user.FullName),
                new SqlParameter("@Phone", user.Phone),
                new SqlParameter("@Email", string.IsNullOrEmpty(user.Email) ? DBNull.Value : (object)user.Email),
                new SqlParameter("@Address", string.IsNullOrEmpty(user.Address) ? DBNull.Value : (object)user.Address),
                new SqlParameter("@UserRole", user.UserRole)
            };

            string query = @"INSERT INTO Users (Username, Password, FullName, Phone, Email, Address, UserRole)
                            VALUES (@Username, @Password, @FullName, @Phone, @Email, @Address, @UserRole);
                            SELECT SCOPE_IDENTITY()";

            object result = DatabaseHelper.ExecuteScalar(query, CommandType.Text, parameters);

            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }

            return 0;
        }

        // Phương thức cập nhật thông tin người dùng
        public static bool UpdateUser(User user)
        {
            // Kiểm tra xem username đã tồn tại cho người dùng khác chưa
            if (IsUsernameExistsForOthers(user.Username, user.UserID))
            {
                throw new Exception("Tên đăng nhập đã tồn tại!");
            }

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserID", user.UserID),
                new SqlParameter("@Username", user.Username),
                new SqlParameter("@FullName", user.FullName),
                new SqlParameter("@Phone", user.Phone),
                new SqlParameter("@Email", string.IsNullOrEmpty(user.Email) ? DBNull.Value : (object)user.Email),
                new SqlParameter("@Address", string.IsNullOrEmpty(user.Address) ? DBNull.Value : (object)user.Address),
                new SqlParameter("@UserRole", user.UserRole)
            };

            string query = @"UPDATE Users 
                            SET Username = @Username, FullName = @FullName, Phone = @Phone, 
                                Email = @Email, Address = @Address, UserRole = @UserRole
                            WHERE UserID = @UserID";

            int result = DatabaseHelper.ExecuteNonQuery(query, CommandType.Text, parameters);

            return result > 0;
        }

        // Phương thức xóa người dùng
        public static bool DeleteUser(int userID)
        {
            // Kiểm tra xem người dùng có đơn hàng nào không
            if (HasOrders(userID))
            {
                throw new Exception("Không thể xóa người dùng này vì họ đã có đơn hàng!");
            }

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserID", userID)
            };

            string query = "DELETE FROM Users WHERE UserID = @UserID";

            int result = DatabaseHelper.ExecuteNonQuery(query, CommandType.Text, parameters);

            return result > 0;
        }

        // Phương thức đặt lại mật khẩu
        public static bool ResetPassword(int userID, string newPassword)
        {
            // Hash mật khẩu mới trước khi lưu
            string hashedPassword = HashPassword(newPassword);

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@UserID", userID),
        new SqlParameter("@Password", hashedPassword)
            };

            string query = "UPDATE Users SET Password = @Password WHERE UserID = @UserID";

            int result = DatabaseHelper.ExecuteNonQuery(query, CommandType.Text, parameters);

            return result > 0;
        }
        // Kiểm tra xem username đã tồn tại chưa
        private static bool IsUsernameExists(string username)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username)
            };

            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";

            object result = DatabaseHelper.ExecuteScalar(query, CommandType.Text, parameters);

            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result) > 0;
            }

            return false;
        }

        // Kiểm tra xem username đã tồn tại cho người dùng khác chưa
        private static bool IsUsernameExistsForOthers(string username, int userID)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@UserID", userID)
            };

            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND UserID != @UserID";

            object result = DatabaseHelper.ExecuteScalar(query, CommandType.Text, parameters);

            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result) > 0;
            }

            return false;
        }


        // Kiểm tra xem người dùng có đơn hàng nào không
        private static bool HasOrders(int userID)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserID", userID)
            };

            string query = "SELECT COUNT(*) FROM Orders WHERE UserID = @UserID";

            object result = DatabaseHelper.ExecuteScalar(query, CommandType.Text, parameters);

            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result) > 0;
            }

            return false;
        }

        // Hàm mã hóa mật khẩu
        private static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    builder.Append(hash[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}