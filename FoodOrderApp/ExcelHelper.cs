using System;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace FoodOrderApp
{
    public class ExcelHelper
    {
        public static bool ExportToExcel(DataGridView dgv, string filePath)
        {
            Microsoft.Office.Interop.Excel.Application excel = null;
            Microsoft.Office.Interop.Excel.Workbook workbook = null;
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;

            try
            {
                // Tạo đối tượng Excel
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                // Tạo Workbook mới
                workbook = excel.Workbooks.Add(Type.Missing);

                // Lấy Worksheet đầu tiên
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
                worksheet.Name = "Báo cáo doanh thu";

                // Thiết lập định dạng tiêu đề
                Microsoft.Office.Interop.Excel.Range headerRange = worksheet.Range["A1", GetExcelColumnName(dgv.Columns.Count - 1) + "1"];
                headerRange.Font.Bold = true;
                headerRange.Font.Size = 12;
                headerRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                headerRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                headerRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Thiết lập tiêu đề cột
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
                }

                // Thiết lập độ rộng cột tự động
                worksheet.Columns.AutoFit();

                // Thêm dữ liệu
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        if (dgv.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }

                // Định dạng các cột số
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    if (dgv.Columns[i].HeaderText.Contains("Doanh thu") ||
                        dgv.Columns[i].HeaderText.Contains("Số lượng") ||
                        dgv.Columns[i].HeaderText.Contains("Số đơn"))
                    {
                        Microsoft.Office.Interop.Excel.Range numberRange = worksheet.Range[
                            GetExcelColumnName(i) + "2",
                            GetExcelColumnName(i) + (dgv.Rows.Count + 1).ToString()];

                        numberRange.NumberFormat = "#,##0";
                        numberRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    }
                }

                // Đảm bảo thư mục tồn tại trước khi lưu
                string directoryPath = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Thêm thử logic để xử lý lỗi xuất file
                try
                {
                    // Đóng file nếu đã tồn tại
                    if (File.Exists(filePath))
                    {
                        try { File.Delete(filePath); } catch { }
                    }

                    // Lưu file với định dạng xlsx
                    workbook.SaveAs(filePath, XlFileFormat.xlOpenXMLWorkbook, Type.Missing, Type.Missing,
                        false, false, XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing, Type.Missing);
                }
                catch (Exception ex)
                {
                    // Thử lưu với tên file khác nếu có lỗi
                    string alternativeFilePath = Path.Combine(
                        Path.GetDirectoryName(filePath),
                        Path.GetFileNameWithoutExtension(filePath) + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xlsx");

                    workbook.SaveAs(alternativeFilePath, XlFileFormat.xlOpenXMLWorkbook);
                }

                // Đóng và giải phóng tài nguyên
                workbook.Close(true);
                excel.Quit();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất báo cáo Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // Giải phóng tài nguyên COM
                if (worksheet != null) Marshal.ReleaseComObject(worksheet);
                if (workbook != null) Marshal.ReleaseComObject(workbook);
                if (excel != null)
                {
                    excel.Quit();
                    Marshal.ReleaseComObject(excel);
                }

                // Ép GC thu gom rác
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        // Hàm chuyển đổi số thành tên cột Excel (1 -> A, 2 -> B, 27 -> AA)
        private static string GetExcelColumnName(int columnNumber)
        {
            string columnName = "";

            while (columnNumber >= 0)
            {
                columnName = Convert.ToChar(65 + (columnNumber % 26)) + columnName;
                columnNumber = (columnNumber / 26) - 1;
            }

            return columnName;
        }
    }
}