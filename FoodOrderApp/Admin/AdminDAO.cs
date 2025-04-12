using System;
using System.Data;

namespace FoodOrderApp
{
    public class AdminDAO
    {
        // Lớp chứa thông tin thống kê cho dashboard
        public class DashboardStats
        {
            public int TotalOrders { get; set; }
            public int PendingOrders { get; set; }
            public int CompletedOrders { get; set; }
            public decimal TotalRevenue { get; set; }
        }

        // Lấy thông tin thống kê cho dashboard
        public static DashboardStats GetDashboardStats()
        {
            DashboardStats stats = new DashboardStats();

            try
            {
                // Tổng số đơn hàng
                string totalOrdersQuery = "SELECT COUNT(*) FROM Orders";
                stats.TotalOrders = Convert.ToInt32(DatabaseHelper.ExecuteScalar(totalOrdersQuery, CommandType.Text));

                // Số đơn hàng chờ xử lý
                string pendingOrdersQuery = "SELECT COUNT(*) FROM Orders WHERE Status IN ('Pending', 'Confirmed', 'Delivering')";
                stats.PendingOrders = Convert.ToInt32(DatabaseHelper.ExecuteScalar(pendingOrdersQuery, CommandType.Text));

                // Số đơn hàng đã hoàn thành
                string completedOrdersQuery = "SELECT COUNT(*) FROM Orders WHERE Status = 'Delivered'";
                stats.CompletedOrders = Convert.ToInt32(DatabaseHelper.ExecuteScalar(completedOrdersQuery, CommandType.Text));

                // Tổng doanh thu
                string revenueQuery = "SELECT ISNULL(SUM(TotalAmount), 0) FROM Orders WHERE Status = 'Delivered'";
                stats.TotalRevenue = Convert.ToDecimal(DatabaseHelper.ExecuteScalar(revenueQuery, CommandType.Text));
            }
            catch (Exception)
            {
                // Nếu có lỗi, trả về giá trị mặc định
                stats.TotalOrders = 0;
                stats.PendingOrders = 0;
                stats.CompletedOrders = 0;
                stats.TotalRevenue = 0;
            }

            return stats;
        }
    }
}