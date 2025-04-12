using FoodOrderApp.Admin;
using FoodOrderApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FoodOrderApp
{
    public partial class RatingsManagementForm : Form
    {
        private List<Rating> _allRatings;

        public RatingsManagementForm()
        {
            InitializeComponent();
        }

        private void RatingsManagementForm_Load(object sender, EventArgs e)
        {
            // Load form data
            LoadRatings();
            SetupFilters();
            SetupDataGridView();
        }

        private void LoadRatings()
        {
            try
            {
                _allRatings = RatingDAO.GetAllRatings();
                DisplayRatings(_allRatings);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading ratings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupFilters()
        {
            // Setup date filters
            dtpFromDate.Value = DateTime.Now.AddMonths(-1);
            dtpToDate.Value = DateTime.Now;

            // Setup food filter
            var foods = FoodDAO.GetAllFoods(true);
            cboFood.DataSource = foods;
            cboFood.DisplayMember = "FoodName";
            cboFood.ValueMember = "FoodID";
            cboFood.SelectedIndex = -1;
            cboFood.Text = "-- All Foods --";

            // Setup user filter
            var users = UserDAO.GetAllUsers();
            cboUser.DataSource = users;
            cboUser.DisplayMember = "FullName";
            cboUser.ValueMember = "UserID";
            cboUser.SelectedIndex = -1;
            cboUser.Text = "-- All Users --";

            // Setup rating filter
            List<int> ratings = new List<int> { 1, 2, 3, 4, 5 };
            cboRating.DataSource = ratings;
            cboRating.SelectedIndex = -1;
            cboRating.Text = "-- All Ratings --";
        }

        private void SetupDataGridView()
        {
            // Configure DataGridView
            dgvRatings.AutoGenerateColumns = false;

            // Add columns
            //dgvRatings.Columns.Add(new DataGridViewTextBoxColumn
            //{
            //    Name = "RatingID",
            //    HeaderText = "Rating ID",
            //    DataPropertyName = "RatingID",
            //    Width = 80
            //});

            //dgvRatings.Columns.Add(new DataGridViewTextBoxColumn
            //{
            //    Name = "OrderID",
            //    HeaderText = "Order ID",
            //    DataPropertyName = "OrderID",
            //    Width = 80
            //});

            //dgvRatings.Columns.Add(new DataGridViewTextBoxColumn
            //{
            //    Name = "UserName",
            //    HeaderText = "User",
            //    DataPropertyName = "UserName",
            //    Width = 120
            //});

            //dgvRatings.Columns.Add(new DataGridViewTextBoxColumn
            //{
            //    Name = "FoodName",
            //    HeaderText = "Food",
            //    DataPropertyName = "FoodName",
            //    Width = 150
            //});

            //dgvRatings.Columns.Add(new DataGridViewTextBoxColumn
            //{
            //    Name = "RatingValue",
            //    HeaderText = "Rating",
            //    DataPropertyName = "RatingValue",
            //    Width = 80
            //});

            //dgvRatings.Columns.Add(new DataGridViewTextBoxColumn
            //{
            //    Name = "Comment",
            //    HeaderText = "Comment",
            //    DataPropertyName = "Comment",
            //    Width = 250
            //});

            //dgvRatings.Columns.Add(new DataGridViewTextBoxColumn
            //{
            //    Name = "RatingDate",
            //    HeaderText = "Date",
            //    DataPropertyName = "RatingDate",
            //    Width = 120
            //});

            // Add action buttons
            var deleteButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Action",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Width = 80
            };
            dgvRatings.Columns.Add(deleteButtonColumn);
        }
        private void DisplayRatings(List<Rating> ratings)
        {
            // Tạo một danh sách RatingViewModel để hiển thị trên DataGridView
            List<RatingViewModel> ratingViewModels = new List<RatingViewModel>();

            foreach (var r in ratings)
            {
                RatingViewModel viewModel = new RatingViewModel
                {
                    RatingID = r.RatingID,
                    OrderID = r.OrderID,
                    UserID = r.UserID,
                    UserName = UserDAO.GetUserByID(r.UserID)?.FullName ?? "Unknown",
                    FoodName = GetFoodNameFromOrder(r.OrderID),
                    RatingValue = r.RatingValue,
                    Comment = r.Comment,
                    RatingDate = r.RatingDate
                };

                ratingViewModels.Add(viewModel);
            }

            dgvRatings.DataSource = new BindingList<RatingViewModel>(ratingViewModels);

            lblTotalRatings.Text = $"Total Ratings: {ratings.Count}";

            // Calculate statistics
            if (ratings.Count > 0)
            {
                double avgRating = ratings.Average(r => r.RatingValue);
                lblAverageRating.Text = $"Average Rating: {avgRating:F1}";

                int fiveStarCount = ratings.Count(r => r.RatingValue == 5);
                int fourStarCount = ratings.Count(r => r.RatingValue == 4);
                int threeStarCount = ratings.Count(r => r.RatingValue == 3);
                int twoStarCount = ratings.Count(r => r.RatingValue == 2);
                int oneStarCount = ratings.Count(r => r.RatingValue == 1);

                lblRatingDistribution.Text = $"Distribution: |5★:{fiveStarCount}| 4★: {fourStarCount}| 3★: {threeStarCount}| 2★: {twoStarCount}| 1★: {oneStarCount}|";
            }
            else
            {
                lblAverageRating.Text = "Average Rating: N/A";
                lblRatingDistribution.Text = "Distribution: N/A";
            }
        }

        // Lớp mô hình dùng để hiển thị trên DataGridView

        private string GetFoodNameFromOrder(int orderID)
        {
            // This method would need OrderDetailDAO.GetOrderDetailsByOrderId
            // Since we need to use existing classes, we'll get the order details from OrderDAO
            var order = OrderDAO.GetOrderByID(orderID);
            if (order != null && order.OrderDetails.Count > 0)
            {
                return order.OrderDetails[0].FoodName; // Return name of first food item
            }
            return "Unknown Food";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset all filters
            dtpFromDate.Value = DateTime.Now.AddMonths(-1);
            dtpToDate.Value = DateTime.Now;
            cboFood.SelectedIndex = -1;
            cboUser.SelectedIndex = -1;
            cboRating.SelectedIndex = -1;

            // Display all ratings
            DisplayRatings(_allRatings);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "CSV files (*.csv)|*.csv",
                    Title = "Export Ratings"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToCSV(saveFileDialog.FileName);
                    MessageBox.Show("Ratings exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting ratings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToCSV(string filePath)
        {
            // Get the current filtered data
            var dataSource = (BindingList<RatingViewModel>)dgvRatings.DataSource;

            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filePath))
            {
                // Write header
                writer.WriteLine("RatingID,OrderID,User,Food,Rating,Comment,Date");

                // Write data
                foreach (var item in dataSource)
                {
                    string comment = item.Comment?.Replace(",", " ")?.Replace("\r\n", " ") ?? "";
                    writer.WriteLine($"{item.RatingID},{item.OrderID},{item.UserName},{item.FoodName},{item.RatingValue},\"{comment}\",{item.RatingDate}");
                }
            }
        }

        private void ApplyFilters()
        {
            DateTime fromDate = dtpFromDate.Value.Date;
            DateTime toDate = dtpToDate.Value.Date.AddDays(1).AddSeconds(-1); // End of the day

            int? selectedFoodID = cboFood.SelectedValue as int?;
            int? selectedUserID = cboUser.SelectedValue as int?;
            int? selectedRating = cboRating.SelectedValue as int?;

            // Filter the ratings
            var filteredRatings = _allRatings.Where(r =>
                r.RatingDate >= fromDate && r.RatingDate <= toDate &&
                (!selectedUserID.HasValue || r.UserID == selectedUserID.Value) &&
                (!selectedRating.HasValue || r.RatingValue == selectedRating.Value)
            ).ToList();

            // Additional filter for food (requires additional lookup)
            if (selectedFoodID.HasValue)
            {
                filteredRatings = filteredRatings.Where(r => {
                    var order = OrderDAO.GetOrderByID(r.OrderID);
                    if (order != null)
                    {
                        return order.OrderDetails.Any(od => od.FoodID == selectedFoodID.Value);
                    }
                    return false;
                }).ToList();
            }

            DisplayRatings(filteredRatings);
        }

        private void dgvRatings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is a delete button
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvRatings.Columns.Count - 1)
            {
                var dataSource = (BindingList<RatingViewModel>)dgvRatings.DataSource;
                var ratingId = dataSource[e.RowIndex].RatingID;

                if (MessageBox.Show("Are you sure you want to delete this rating?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        bool success = RatingDAO.DeleteRating(ratingId);
                        if (success)
                        {
                            MessageBox.Show("Rating deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadRatings(); // Reload all ratings
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete rating", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting rating: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        /*
         * Tải lại dữ liệu từ cơ sở dữ liệu
            Cập nhật danh sách hiển thị với dữ liệu mới nhất
            Giữ nguyên các bộ lọc mà người dùng đã thiết lập
            Hữu ích khi có thay đổi dữ liệu từ người dùng khác hoặc từ hệ thống
         */

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRatings();
        }
    }
}