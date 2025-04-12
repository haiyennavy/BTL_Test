using System;
using System.Data;
using System.Data.SqlClient;

namespace FoodOrderApp
{
    public class ReportDAO
    {
        // Phương thức lấy báo cáo doanh thu
        public static DataTable GetRevenueReport(DateTime fromDate, DateTime toDate, string reportType)
        {
            string groupByClause;
            string selectClause;

            // Xác định cách nhóm dữ liệu dựa trên loại báo cáo
            switch (reportType)
            {
                case "Theo ngày":
                    selectClause = "CONVERT(DATE, o.OrderDate) AS Ngày";
                    groupByClause = "CONVERT(DATE, o.OrderDate)";
                    break;
                case "Theo tháng":
                    selectClause = "FORMAT(o.OrderDate, 'MM/yyyy') AS Tháng";
                    groupByClause = "FORMAT(o.OrderDate, 'MM/yyyy')";
                    break;
                case "Theo năm":
                    selectClause = "YEAR(o.OrderDate) AS Năm";
                    groupByClause = "YEAR(o.OrderDate)";
                    break;
                default:
                    selectClause = "CONVERT(DATE, o.OrderDate) AS Ngày";
                    groupByClause = "CONVERT(DATE, o.OrderDate)";
                    break;
            }

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@FromDate", fromDate),
                new SqlParameter("@ToDate", toDate)
            };

            string query = $@"
                SELECT 
                    {selectClause},
                    COUNT(o.OrderID) AS [Số đơn],
                    SUM(o.TotalAmount) AS [Doanh thu]
                FROM 
                    Orders o
                WHERE 
                    o.Status = 'Delivered' AND
                    o.OrderDate BETWEEN @FromDate AND @ToDate
                GROUP BY 
                    {groupByClause}
                ORDER BY 
                    {groupByClause}";

            DataTable dataTable = DatabaseHelper.ExecuteDataTable(query, CommandType.Text, parameters);

            return dataTable;
        }

        // Phương thức lấy chi tiết doanh thu theo món ăn
        public static DataTable GetRevenueByFood(DateTime fromDate, DateTime toDate)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@FromDate", fromDate),
                new SqlParameter("@ToDate", toDate)
            };

            string query = @"
                SELECT 
                    f.FoodID,
                    f.FoodName AS [Tên món],
                    SUM(od.Quantity) AS [Số lượng bán],
                    SUM(od.Quantity * od.UnitPrice) AS [Doanh thu]
                FROM 
                    OrderDetails od
                    JOIN Orders o ON od.OrderID = o.OrderID
                    JOIN Foods f ON od.FoodID = f.FoodID
                WHERE 
                    o.Status = 'Delivered' AND
                    o.OrderDate BETWEEN @FromDate AND @ToDate
                GROUP BY 
                    f.FoodID, f.FoodName
                ORDER BY 
                    [Doanh thu] DESC";

            DataTable dataTable = DatabaseHelper.ExecuteDataTable(query, CommandType.Text, parameters);

            return dataTable;
        }

        // Phương thức lấy chi tiết doanh thu theo danh mục
        public static DataTable GetRevenueByCategory(DateTime fromDate, DateTime toDate)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@FromDate", fromDate),
                new SqlParameter("@ToDate", toDate)
            };

            string query = @"
                SELECT 
                    c.CategoryName AS [Danh mục],
                    COUNT(DISTINCT o.OrderID) AS [Số đơn],
                    SUM(od.Quantity) AS [Số lượng món],
                    SUM(od.Quantity * od.UnitPrice) AS [Doanh thu]
                FROM 
                    OrderDetails od
                    JOIN Orders o ON od.OrderID = o.OrderID
                    JOIN Foods f ON od.FoodID = f.FoodID
                    JOIN Categories c ON f.CategoryID = c.CategoryID
                WHERE 
                    o.Status = 'Delivered' AND
                    o.OrderDate BETWEEN @FromDate AND @ToDate
                GROUP BY 
                    c.CategoryName
                ORDER BY 
                    [Doanh thu] DESC";

            DataTable dataTable = DatabaseHelper.ExecuteDataTable(query, CommandType.Text, parameters);

            return dataTable;
        }
    }
}