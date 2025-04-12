using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace FoodOrderApp
{
    public class CSVHelper
    {
        public static bool ExportToCSV(DataGridView dgv, string filePath)
        {
            try
            {
                // Đảm bảo thư mục tồn tại
                string directoryPath = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Tạo stringbuilder để xây dựng nội dung CSV
                StringBuilder sb = new StringBuilder();

                // Thêm header từ tên cột
                string[] columnNames = new string[dgv.Columns.Count];
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    columnNames[i] = dgv.Columns[i].HeaderText;
                }
                sb.AppendLine(string.Join(",", columnNames));

                // Thêm dữ liệu từng dòng
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    string[] fields = new string[dgv.Columns.Count];
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        // Lấy giá trị của ô và định dạng phù hợp
                        object value = row.Cells[i].Value;
                        if (value != null)
                        {
                            // Định dạng số nếu là cột doanh thu hoặc số lượng
                            if (dgv.Columns[i].HeaderText.Contains("Doanh thu") ||
                                dgv.Columns[i].HeaderText.Contains("Số đơn"))
                            {
                                // Định dạng số
                                if (decimal.TryParse(value.ToString(), out decimal numValue))
                                {
                                    fields[i] = numValue.ToString("#,##0", CultureInfo.InvariantCulture);
                                }
                                else
                                {
                                    fields[i] = value.ToString();
                                }
                            }
                            else
                            {
                                // Nếu giá trị chứa dấu phẩy, đặt trong dấu ngoặc kép
                                string stringValue = value.ToString();
                                if (stringValue.Contains(",") || stringValue.Contains("\"") ||
                                    stringValue.Contains("\r") || stringValue.Contains("\n"))
                                {
                                    stringValue = "\"" + stringValue.Replace("\"", "\"\"") + "\"";
                                }
                                fields[i] = stringValue;
                            }
                        }
                        else
                        {
                            fields[i] = "";
                        }
                    }
                    sb.AppendLine(string.Join(",", fields));
                }

                // Ghi nội dung ra file
                File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất báo cáo CSV: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}