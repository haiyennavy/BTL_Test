using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace FoodOrderApp
{
    public class OrderDAO
    {
        // Add this method to OrderDAO.cs
        public static List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();

            string query = @"SELECT o.*, u.FullName 
                    FROM Orders o 
                    INNER JOIN Users u ON o.UserID = u.UserID 
                    ORDER BY o.OrderDate DESC";

            DataTable dataTable = DatabaseHelper.ExecuteDataTable(query, CommandType.Text, null);

            foreach (DataRow row in dataTable.Rows)
            {
                Order order = new Order
                {
                    OrderID = Convert.ToInt32(row["OrderID"]),
                    UserID = Convert.ToInt32(row["UserID"]),
                    OrderDate = Convert.ToDateTime(row["OrderDate"]),
                    TotalAmount = Convert.ToDecimal(row["TotalAmount"]),
                    Status = row["Status"].ToString(),
                    DeliveryAddress = row["DeliveryAddress"].ToString(),
                    PhoneNumber = row["PhoneNumber"].ToString(),
                    PaymentMethod = row["PaymentMethod"].ToString()
                };

                if (row["Notes"] != DBNull.Value)
                {
                    order.Notes = row["Notes"].ToString();
                }

                // Store customer name (not in Order class but needed for display)
                order.CustomerName = row["FullName"].ToString();

                // Get order details
                order.OrderDetails = GetOrderDetailsByOrderID(order.OrderID);

                orders.Add(order);
            }

            return orders;
        }
        public static List<Order> SearchOrders(string keyword, string status, DateTime? fromDate, DateTime? toDate)
        {
            List<Order> orders = new List<Order>();
            List<SqlParameter> parameters = new List<SqlParameter>();

            string query = @"SELECT o.*, u.FullName 
                    FROM Orders o 
                    INNER JOIN Users u ON o.UserID = u.UserID 
                    WHERE 1=1";

            // Thêm điều kiện tìm kiếm
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                // Tìm kiếm theo họ tên, số điện thoại hoặc ID đơn hàng
                query += @" AND (u.FullName LIKE @Keyword 
                    OR o.PhoneNumber LIKE @Keyword 
                    OR CAST(o.OrderID AS NVARCHAR) = @ExactKeyword
                    OR o.DeliveryAddress LIKE @Keyword)";
                parameters.Add(new SqlParameter("@Keyword", "%" + keyword + "%"));
                parameters.Add(new SqlParameter("@ExactKeyword", keyword));
            }

            if (!string.IsNullOrWhiteSpace(status))
            {
                query += " AND o.Status = @Status";
                parameters.Add(new SqlParameter("@Status", status));
            }

            if (fromDate.HasValue)
            {
                query += " AND o.OrderDate >= @FromDate";
                parameters.Add(new SqlParameter("@FromDate", fromDate.Value.Date)); // Lấy ngày, đặt giờ = 00:00:00
            }

            if (toDate.HasValue)
            {
                // Thêm 1 ngày và trừ 1 giây để lấy đến cuối ngày
                DateTime endDate = toDate.Value.Date.AddDays(1).AddSeconds(-1);
                query += " AND o.OrderDate <= @ToDate";
                parameters.Add(new SqlParameter("@ToDate", endDate));
            }

            query += " ORDER BY o.OrderDate DESC";

            try
            {
                DataTable dataTable = DatabaseHelper.ExecuteDataTable(query, CommandType.Text, parameters.ToArray());

                foreach (DataRow row in dataTable.Rows)
                {
                    Order order = new Order
                    {
                        OrderID = Convert.ToInt32(row["OrderID"]),
                        UserID = Convert.ToInt32(row["UserID"]),
                        OrderDate = Convert.ToDateTime(row["OrderDate"]),
                        TotalAmount = Convert.ToDecimal(row["TotalAmount"]),
                        Status = row["Status"].ToString(),
                        DeliveryAddress = row["DeliveryAddress"].ToString(),
                        PhoneNumber = row["PhoneNumber"].ToString(),
                        PaymentMethod = row["PaymentMethod"].ToString()
                    };

                    if (row["Notes"] != DBNull.Value)
                    {
                        order.Notes = row["Notes"].ToString();
                    }

                    // Lưu tên khách hàng
                    order.CustomerName = row["FullName"].ToString();

                    // Lấy chi tiết đơn hàng
                    order.OrderDetails = GetOrderDetailsByOrderID(order.OrderID);

                    orders.Add(order);
                }
            }
            catch (Exception ex)
            {
                // Ghi log lỗi hoặc xử lý
                System.Diagnostics.Debug.WriteLine($"Error in SearchOrders: {ex.Message}");
                throw; // Re-throw để xử lý ở tầng giao diện
            }

            return orders;
        }
        // Thêm phương thức hỗ trợ
        private static int GetFoodQuantity(int foodID)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@FoodID", foodID)
            };

            string query = "SELECT Quantity FROM Foods WHERE FoodID = @FoodID";

            object result = DatabaseHelper.ExecuteScalar(query, CommandType.Text, parameters);

            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }

            return 0;
        }
        // Phương thức tạo đơn hàng mới
        public static int CreateOrder(Order order)
        {
            SqlConnection connection = null;
            SqlTransaction transaction = null;

            try
            {
                // Kiểm tra số lượng còn lại trước khi tạo đơn hàng
                foreach (OrderDetail detail in order.OrderDetails)
                {
                    // Lấy số lượng hiện có
                    int availableQuantity = GetFoodQuantity(detail.FoodID);

                    // Kiểm tra nếu đủ số lượng
                    if (availableQuantity < detail.Quantity)
                    {
                        throw new Exception($"Món ăn '{detail.FoodName}' chỉ còn {availableQuantity} phần!");
                    }
                }
                // Bắt đầu transaction
                connection = new SqlConnection(DatabaseHelper.connectionString);
                connection.Open();
                transaction = connection.BeginTransaction();

                // Tạo đơn hàng
                SqlCommand command = new SqlCommand(
                    @"INSERT INTO Orders (UserID, OrderDate, TotalAmount, Status, DeliveryAddress, PhoneNumber, PaymentMethod, Notes)
                    VALUES (@UserID, GETDATE(), @TotalAmount, @Status, @DeliveryAddress, @PhoneNumber, @PaymentMethod, @Notes);
                    SELECT SCOPE_IDENTITY()", connection, transaction);

                command.Parameters.AddWithValue("@UserID", order.UserID);
                command.Parameters.AddWithValue("@TotalAmount", order.TotalAmount);
                command.Parameters.AddWithValue("@Status", order.Status);
                command.Parameters.AddWithValue("@DeliveryAddress", order.DeliveryAddress);
                command.Parameters.AddWithValue("@PhoneNumber", order.PhoneNumber);
                command.Parameters.AddWithValue("@PaymentMethod", order.PaymentMethod);
                command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(order.Notes) ? (object)DBNull.Value : order.Notes);

                // Lấy orderID vừa tạo
                int orderID = Convert.ToInt32(command.ExecuteScalar());

                // Thêm chi tiết đơn hàng
                foreach (OrderDetail detail in order.OrderDetails)
                {
                    command = new SqlCommand(
                        @"INSERT INTO OrderDetails (OrderID, FoodID, Quantity, UnitPrice)
                        VALUES (@OrderID, @FoodID, @Quantity, @UnitPrice)", connection, transaction);

                    command.Parameters.AddWithValue("@OrderID", orderID);
                    command.Parameters.AddWithValue("@FoodID", detail.FoodID);
                    command.Parameters.AddWithValue("@Quantity", detail.Quantity);
                    command.Parameters.AddWithValue("@UnitPrice", detail.UnitPrice);

                    command.ExecuteNonQuery();
                }


                // Cập nhật số lượng món ăn
                foreach (OrderDetail detail in order.OrderDetails)
                {
                    SqlCommand updateQuantityCommand = new SqlCommand(
                        @"UPDATE Foods 
                  SET Quantity = Quantity - @OrderQuantity 
                  WHERE FoodID = @FoodID", connection, transaction);

                    updateQuantityCommand.Parameters.AddWithValue("@FoodID", detail.FoodID);
                    updateQuantityCommand.Parameters.AddWithValue("@OrderQuantity", detail.Quantity);
                    updateQuantityCommand.ExecuteNonQuery();
                }
                // Commit transaction
                transaction.Commit();
                return orderID;
            }
            catch (Exception)
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

        // Phương thức lấy đơn hàng theo người dùng
        public static List<Order> GetOrdersByUser(int userID)
        {
            List<Order> orders = new List<Order>();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserID", userID)
            };

            string query = "SELECT * FROM Orders WHERE UserID = @UserID ORDER BY OrderDate DESC";

            DataTable dataTable = DatabaseHelper.ExecuteDataTable(query, CommandType.Text, parameters);

            foreach (DataRow row in dataTable.Rows)
            {
                Order order = new Order
                {
                    OrderID = Convert.ToInt32(row["OrderID"]),
                    UserID = Convert.ToInt32(row["UserID"]),
                    OrderDate = Convert.ToDateTime(row["OrderDate"]),
                    TotalAmount = Convert.ToDecimal(row["TotalAmount"]),
                    Status = row["Status"].ToString(),
                    DeliveryAddress = row["DeliveryAddress"].ToString(),
                    PhoneNumber = row["PhoneNumber"].ToString(),
                    PaymentMethod = row["PaymentMethod"].ToString()
                };

                if (row["Notes"] != DBNull.Value)
                {
                    order.Notes = row["Notes"].ToString();
                }

                // Lấy chi tiết đơn hàng
                order.OrderDetails = GetOrderDetailsByOrderID(order.OrderID);

                orders.Add(order);
            }

            return orders;
        }

        // Phương thức lấy chi tiết đơn hàng theo OrderID
        public static List<OrderDetail> GetOrderDetailsByOrderID(int orderID)
        {
            List<OrderDetail> details = new List<OrderDetail>();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID", orderID)
            };

            string query = @"SELECT od.*, f.FoodName, f.ImageName 
                            FROM OrderDetails od 
                            INNER JOIN Foods f ON od.FoodID = f.FoodID 
                            WHERE od.OrderID = @OrderID";

            DataTable dataTable = DatabaseHelper.ExecuteDataTable(query, CommandType.Text, parameters);

            foreach (DataRow row in dataTable.Rows)
            {
                OrderDetail detail = new OrderDetail
                {
                    OrderDetailID = Convert.ToInt32(row["OrderDetailID"]),
                    OrderID = Convert.ToInt32(row["OrderID"]),
                    FoodID = Convert.ToInt32(row["FoodID"]),
                    FoodName = row["FoodName"].ToString(),
                    ImageName = row["ImageName"].ToString(),
                    Quantity = Convert.ToInt32(row["Quantity"]),
                    UnitPrice = Convert.ToDecimal(row["UnitPrice"])
                };

                details.Add(detail);
            }

            return details;
        }

        // Phương thức lấy đơn hàng theo ID
        public static Order GetOrderByID(int orderID)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@OrderID", orderID)
            };

            string query = @"SELECT o.*, u.FullName 
                    FROM Orders o 
                    INNER JOIN Users u ON o.UserID = u.UserID 
                    WHERE o.OrderID = @OrderID";

            DataTable dataTable = DatabaseHelper.ExecuteDataTable(query, CommandType.Text, parameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];

                Order order = new Order
                {
                    OrderID = Convert.ToInt32(row["OrderID"]),
                    UserID = Convert.ToInt32(row["UserID"]),
                    OrderDate = Convert.ToDateTime(row["OrderDate"]),
                    TotalAmount = Convert.ToDecimal(row["TotalAmount"]),
                    Status = row["Status"].ToString(),
                    DeliveryAddress = row["DeliveryAddress"].ToString(),
                    PhoneNumber = row["PhoneNumber"].ToString(),
                    PaymentMethod = row["PaymentMethod"].ToString()
                };

                if (row["Notes"] != DBNull.Value)
                {
                    order.Notes = row["Notes"].ToString();
                }

                // Lưu tên khách hàng
                order.CustomerName = row["FullName"].ToString();

                // Lấy chi tiết đơn hàng
                order.OrderDetails = GetOrderDetailsByOrderID(order.OrderID);

                return order;
            }

            return null;
        }

        // Phương thức cập nhật trạng thái đơn hàng
        public static bool UpdateOrderStatus(int orderID, string status)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID", orderID),
                new SqlParameter("@Status", status)
            };

            string query = "UPDATE Orders SET Status = @Status WHERE OrderID = @OrderID";

            int result = DatabaseHelper.ExecuteNonQuery(query, CommandType.Text, parameters);

            return result > 0;
        }
    }
}