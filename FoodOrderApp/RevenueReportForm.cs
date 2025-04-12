using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FoodOrderApp
{
    public partial class RevenueReportForm : Form
    {
        public RevenueReportForm()
        {
            InitializeComponent();

            // Thêm đệm để form không bị chật
            this.Padding = new Padding(10);
            this.pnlFilters.Padding = new Padding(5);
            this.pnlFooter.Padding = new Padding(10, 5, 10, 5);
        }

        private void RevenueReportForm_Load(object sender, EventArgs e)
        {
            // Thiết lập các giá trị mặc định
            dtpFromDate.Value = DateTime.Now.AddMonths(-1);
            dtpToDate.Value = DateTime.Now;
            cboReportType.SelectedIndex = 0; // Mặc định là báo cáo theo ngày

            // Load báo cáo ban đầu
            LoadReport();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            try
            {
                DateTime fromDate = dtpFromDate.Value.Date;
                DateTime toDate = dtpToDate.Value.Date.AddDays(1).AddSeconds(-1); // Đến cuối ngày
                string reportType = cboReportType.SelectedItem.ToString();

                // Gọi DAO để lấy dữ liệu báo cáo
                DataTable reportData = ReportDAO.GetRevenueReport(fromDate, toDate, reportType);

                // Hiển thị dữ liệu trong DataGridView
                DisplayReportData(reportData);

                // Tính tổng doanh thu
                decimal totalRevenue = CalculateTotalRevenue(reportData);
                lblTotalRevenue.Text = string.Format("{0:#,##0}₫", totalRevenue);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải báo cáo doanh thu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayReportData(DataTable reportData)
        {
            dgvReport.DataSource = reportData;

            // Định dạng cột
            if (dgvReport.Columns.Contains("Doanh thu"))
            {
                dgvReport.Columns["Doanh thu"].DefaultCellStyle.Format = "N0";
                dgvReport.Columns["Doanh thu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvReport.Columns.Contains("Số đơn"))
            {
                dgvReport.Columns["Số đơn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Thêm các dòng này để cải thiện kiểu dáng DataGridView
            dgvReport.BorderStyle = BorderStyle.None;
            dgvReport.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
            dgvReport.EnableHeadersVisualStyles = false;
            dgvReport.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 255);
            dgvReport.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvReport.ColumnHeadersHeight = 35;
        }

        private decimal CalculateTotalRevenue(DataTable reportData)
        {
            decimal total = 0;

            foreach (DataRow row in reportData.Rows)
            {
                total += Convert.ToDecimal(row["Doanh thu"]);
            }

            return total;
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // Sử dụng SaveFileDialog để chọn vị trí lưu
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveDialog.Title = "Xuất báo cáo doanh thu";
                saveDialog.FileName = $"BaoCaoDoanhThu_{DateTime.Now:yyyyMMdd}";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Xuất báo cáo ra file Excel
                    if (ExcelHelper.ExportToExcel(dgvReport, saveDialog.FileName))
                    {
                        MessageBox.Show("Xuất báo cáo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể xuất báo cáo! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất báo cáo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại in
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Triển khai in báo cáo
                // (Thường sử dụng PrintDocument và có thể cần triển khai thêm)
                MessageBox.Show("Chức năng in đang được phát triển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            try
            {
                // Sử dụng SaveFileDialog để chọn vị trí lưu
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "CSV files (*.csv)|*.csv";
                saveDialog.Title = "Xuất báo cáo doanh thu";
                saveDialog.FileName = $"BaoCaoDoanhThu_{DateTime.Now:yyyyMMdd}";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Xuất báo cáo ra file CSV
                    if (CSVHelper.ExportToCSV(dgvReport, saveDialog.FileName))
                    {
                        MessageBox.Show("Xuất báo cáo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể xuất báo cáo! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất báo cáo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}