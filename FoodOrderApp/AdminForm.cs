using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using FoodOrderApp.Admin;

namespace FoodOrderApp
{
    public partial class AdminForm : Form
    {
        private User currentAdmin;
        private List<Food> allFoods;
        private List<Category> allCategories;
        private List<User> allUsers;
        private List<Order> allOrders;
        private Food currentFood = null;
        private Category currentCategory = null;
        private User currentUser = null;
        private Order currentOrder = null;
        private bool isAddingFood = false;
        private bool isAddingCategory = false;
        private bool isAddingUser = false;
        private string tempImagePath = null;

        public AdminForm(User admin)
        {
            InitializeComponent();
            currentAdmin = admin;

            // Thiết lập OpenFileDialog cho việc chọn hình ảnh
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            openFileDialog.Title = "Chọn hình ảnh món ăn";
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // Hiển thị tên admin
            lblAdminName.Text = currentAdmin.FullName;

            // Hiển thị panel Dashboard mặc định
            ShowPanel(pnlDashboard);
            SetActiveButton(btnDashboard);
            //ShowPanel(pnlFoodManagement);


            // Load dữ liệu Dashboard
            LoadDashboardData();

            // Load dữ liệu danh mục (cho combobox)
            LoadCategories();

            // Load dữ liệu món ăn
            LoadFoods();

            // Khởi tạo giao diện
            InitializeFoodDetail(false);
            InitializeCategoryDetail(false);
            InitializeUserDetail(false);
            InitializeOrderDetail();
            InitializeUserRoleComboBox();
        }

        #region Common Methods

        private void ShowPanel(Panel panel)
        {
            //Ẩn tất cả các panel
            pnlDashboard.Visible = false;
            pnlFoodManagement.Visible = false;
            pnlCategoryManagement.Visible = false;
            pnlOrderManagement.Visible = false;
            pnlUserManagement.Visible = false;

            // Hiển thị panel được chọn
            panel.Visible = true;
            panel.Dock = DockStyle.Fill;
        }

        private void SetActiveButton(Button button)
        {
            // Đặt lại màu cho tất cả các nút
            btnDashboard.BackColor = Color.FromArgb(52, 58, 64);
            btnFoods.BackColor = Color.FromArgb(52, 58, 64);
            btnCategories.BackColor = Color.FromArgb(52, 58, 64);
            btnOrders.BackColor = Color.FromArgb(52, 58, 64);
            btnUsers.BackColor = Color.FromArgb(52, 58, 64);

            // Đặt màu cho nút được chọn
            button.BackColor = Color.FromArgb(0, 122, 255);

            // Cập nhật tiêu đề
            lblTitle.Text = button.Text.Trim();
        }

        #endregion

        #region Dashboard

        private void LoadDashboardData()
        {
            try
            {
                // Lấy số liệu thống kê từ cơ sở dữ liệu
                var stats = AdminDAO.GetDashboardStats();

                // Cập nhật giao diện
                lblTotalOrdersValue.Text = stats.TotalOrders.ToString();
                lblPendingOrdersValue.Text = stats.PendingOrders.ToString();
                lblCompletedOrdersValue.Text = stats.CompletedOrders.ToString();
                lblRevenueValue.Text = string.Format("{0:#,##0}₫", stats.TotalRevenue);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu thống kê: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        #region Food Management

        private void LoadFoods()
        {
            try
            {
                // Lấy danh sách món ăn từ cơ sở dữ liệu
                allFoods = FoodDAO.GetAllFoods(true); // Lấy tất cả món ăn, kể cả không có sẵn

                // Hiển thị danh sách món ăn trong DataGridView
                DisplayFoods(allFoods);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách món ăn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DisplayFoods(List<Food> foods)
        {
            // Tạo DataTable cho DataGridView
            var dt = new System.Data.DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Tên món", typeof(string));
            dt.Columns.Add("Danh mục", typeof(string));
            dt.Columns.Add("Giá", typeof(decimal));
            dt.Columns.Add("Số lượng", typeof(int)); // Thêm cột số lượng
            dt.Columns.Add("Có sẵn", typeof(bool));

            // Thêm dữ liệu
            foreach (var food in foods)
            {
                dt.Rows.Add(food.FoodID, food.FoodName, food.CategoryName, food.Price, food.Quantity,food.IsAvailable);
            }

            // Gán DataTable cho DataGridView
            dgvFoods.DataSource = dt;

            // Ẩn cột ID
            dgvFoods.Columns["ID"].Visible = false;

            // Định dạng cột Giá
            dgvFoods.Columns["Giá"].DefaultCellStyle.Format = "N0";
            dgvFoods.Columns["Giá"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }


        private void EnableControls(bool enabled)
        {
            // Kích hoạt hoặc vô hiệu hóa controls
            txtFoodName.Enabled = enabled;
            txtFoodDescription.Enabled = enabled;
            txtFoodPrice.Enabled = enabled;
            cboFoodCategory.Enabled = enabled;
            chkIsAvailable.Enabled = enabled;
            btnBrowseImage.Enabled = enabled;
            btnSaveFood.Enabled = enabled;
            btnCancelFood.Enabled = enabled;
        }

        private void InitializeFoodDetail(bool enabled)
        {
            // Xóa thông tin hiện tại
            txtFoodName.Clear();
            txtFoodDescription.Clear();
            txtFoodPrice.Clear();
            cboFoodCategory.SelectedIndex = -1;
            chkIsAvailable.Checked = true;
            picFoodImage.Image = null;
            tempImagePath = null;

            // Kích hoạt hoặc vô hiệu hóa controls
            txtFoodName.Enabled = enabled;
            txtFoodDescription.Enabled = enabled;
            txtFoodPrice.Enabled = enabled;
            cboFoodCategory.Enabled = enabled;
            chkIsAvailable.Enabled = enabled;
            btnBrowseImage.Enabled = enabled;
            btnSaveFood.Enabled = enabled;
            btnCancelFood.Enabled = enabled;
        }


        private void LoadCategories()
        {
            try
            {
                // Lấy danh sách danh mục từ cơ sở dữ liệu
                allCategories = CategoryDAO.GetAllCategories();

                // Cập nhật ComboBox
                cboFoodCategory.Items.Clear();
                foreach (var category in allCategories)
                {
                    cboFoodCategory.Items.Add(category.CategoryName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách danh mục: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAddFood_Click(object sender, EventArgs e)
        {
            isAddingFood = true;
            currentFood = null;
            InitializeFoodDetail(true);
            txtFoodName.Focus();
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có dòng được chọn
            if (dgvFoods.SelectedRows.Count > 0)
            {

                int foodID = Convert.ToInt32(dgvFoods.SelectedRows[0].Cells["ID"].Value);
                currentFood = allFoods.Find(f => f.FoodID == foodID);

                if (currentFood != null)
                {
                    isAddingFood = false;

                    // Hiển thị thông tin món ăn
                    txtFoodName.Text = currentFood.FoodName;
                    txtFoodDescription.Text = currentFood.Description;
                    txtFoodPrice.Text = currentFood.Price.ToString();
                    // Chọn danh mục
                    for (int i = 0; i < cboFoodCategory.Items.Count; i++)
                    {
                        if (cboFoodCategory.Items[i].ToString() == currentFood.CategoryName)
                        {
                            cboFoodCategory.SelectedIndex = i;
                            break;
                        }
                    }

                    chkIsAvailable.Checked = currentFood.IsAvailable;
                    numFoodQuantity.Value = currentFood.Quantity;

                    // Hiển thị hình ảnh
                    try
                    {
                        string imagePath = Path.Combine(Application.StartupPath, "Images", currentFood.ImageName);
                        if (File.Exists(imagePath))
                        {
                            picFoodImage.Image = Image.FromFile(imagePath);
                        }
                    }
                    catch {
                        MessageBox.Show("Edit Food Click Exception: " + e.ToString());
                    }

                // Kích hoạt controls
                EnableControls(true);

                // bo cai nay
                //InitializeFoodDetail(true);
            }
        }
            else
            {
                MessageBox.Show("Vui lòng chọn một món ăn để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có dòng được chọn
            if (dgvFoods.SelectedRows.Count > 0)
            {
                int foodID = Convert.ToInt32(dgvFoods.SelectedRows[0].Cells["ID"].Value);
                string foodName = dgvFoods.SelectedRows[0].Cells["Tên món"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa món ăn '{foodName}'?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Xóa món ăn
                        if (FoodDAO.DeleteFood(foodID))
                        {
                            MessageBox.Show("Xóa món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Tải lại danh sách món ăn
                            LoadFoods();

                            // Đặt lại controls
                            InitializeFoodDetail(false);
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa món ăn! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa món ăn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một món ăn để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Lưu đường dẫn tạm thời
                    tempImagePath = openFileDialog.FileName;

                    // Hiển thị hình ảnh được chọn
                    picFoodImage.Image = Image.FromFile(tempImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải hình ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveFood_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (string.IsNullOrWhiteSpace(txtFoodName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFoodName.Focus();
                return;
            }

            if (cboFoodCategory.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn danh mục món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboFoodCategory.Focus();
                return;
            }

            decimal price = 0;
            if (!decimal.TryParse(txtFoodPrice.Text, out price) || price <= 0)
            {
                MessageBox.Show("Vui lòng nhập giá hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFoodPrice.Focus();
                return;
            }

            try
            {
                // Xử lý hình ảnh
                string imageName = ProcessFoodImage();

                // Tạo đối tượng Food
                Food food = new Food
                {
                    FoodName = txtFoodName.Text.Trim(),
                    CategoryID = allCategories[cboFoodCategory.SelectedIndex].CategoryID,
                    Description = txtFoodDescription.Text.Trim(),
                    Price = price,
                    ImageName = imageName,
                    IsAvailable = chkIsAvailable.Checked,
                    Quantity = (int)numFoodQuantity.Value // Thêm dòng này
                };

                if (isAddingFood)
                {
                    // Thêm món ăn mới
                    int newFoodID = FoodDAO.AddFood(food);
                    if (newFoodID > 0)
                    {
                        MessageBox.Show("Thêm món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm món ăn! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Cập nhật món ăn
                    food.FoodID = currentFood.FoodID;
                    if (FoodDAO.UpdateFood(food))
                    {
                        MessageBox.Show("Cập nhật món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật món ăn! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Tải lại danh sách món ăn
                LoadFoods();

                // Đặt lại controls
                InitializeFoodDetail(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu món ăn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string ProcessFoodImage()
        {
            string imageName = "";

            // Nếu không có hình ảnh mới
            if (string.IsNullOrEmpty(tempImagePath))
            {
                // Nếu đang chỉnh sửa, giữ nguyên tên hình ảnh cũ
                if (!isAddingFood && currentFood != null)
                {
                    imageName = currentFood.ImageName;
                }
                return imageName;
            }

            try
            {
                // Đảm bảo thư mục Images tồn tại
                string imagesPath = Path.Combine(Application.StartupPath, "Images");
                if (!Directory.Exists(imagesPath))
                {
                    Directory.CreateDirectory(imagesPath);
                }

                // Tạo tên file mới dựa trên thời gian
                string extension = Path.GetExtension(tempImagePath);
                imageName = $"food_{DateTime.Now.ToString("yyyyMMddHHmmss")}{extension}";
                string destinationPath = Path.Combine(imagesPath, imageName);

                // Sao chép file hình ảnh
                File.Copy(tempImagePath, destinationPath, true);

                return imageName;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xử lý hình ảnh: {ex.Message}");
            }
        }


        private void btnCancelFood_Click(object sender, EventArgs e)
        {
            InitializeFoodDetail(false);
        }

        private void txtSearchFood_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchFood.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                // Hiển thị tất cả món ăn
                DisplayFoods(allFoods);
            }
            else
            {
                // Lọc món ăn theo từ khóa tìm kiếm
                List<Food> searchResults = allFoods
                    .Where(f => f.FoodName.ToLower().Contains(searchText) ||
                                f.Description.ToLower().Contains(searchText) ||
                                f.CategoryName.ToLower().Contains(searchText))
                    .ToList();

                // Hiển thị kết quả tìm kiếm
                DisplayFoods(searchResults);
            }
        }


        #endregion

        #region Category Management

        private void LoadCategoriesList()
        {
            try
            {
                // Lấy danh sách danh mục từ cơ sở dữ liệu
                allCategories = CategoryDAO.GetAllCategories();

                // Hiển thị danh sách danh mục trong DataGridView
                DisplayCategories(allCategories);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách danh mục: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayCategories(List<Category> categories)
        {
            // Tạo DataTable cho DataGridView
            var dt = new System.Data.DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Tên danh mục", typeof(string));
            dt.Columns.Add("Mô tả", typeof(string));

            // Thêm dữ liệu
            foreach (var category in categories)
            {
                dt.Rows.Add(category.CategoryID, category.CategoryName, category.Description);
            }

            // Gán DataTable cho DataGridView
            dgvCategories.DataSource = dt;

            // Ẩn cột ID
            dgvCategories.Columns["ID"].Visible = false;
        }


        private void enableCatergoryControl(bool enabled)
        {
            //vô hiệu hóa controls
            txtCategoryName.Enabled = enabled;
            txtCategoryDescription.Enabled = enabled;
            btnSaveCategory.Enabled = enabled;
            btnCancelCategory.Enabled = enabled;
        }

        private void InitializeCategoryDetail(bool enabled)
        {
            // Xóa thông tin hiện tại
            txtCategoryName.Clear();
            txtCategoryDescription.Clear();

            // Kích hoạt hoặc vô hiệu hóa controls
            txtCategoryName.Enabled = enabled;
            txtCategoryDescription.Enabled = enabled;
            btnSaveCategory.Enabled = enabled;
            btnCancelCategory.Enabled = enabled;
        }


        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            isAddingCategory = true;
            currentCategory = null;
            InitializeCategoryDetail(true);
            txtCategoryName.Focus();
        }


        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có dòng được chọn
            if (dgvCategories.SelectedRows.Count > 0)
            {
                int categoryID = Convert.ToInt32(dgvCategories.SelectedRows[0].Cells["ID"].Value);
                currentCategory = allCategories.Find(c => c.CategoryID == categoryID);

                if (currentCategory != null)
                {
                    isAddingCategory = false;

                    // Hiển thị thông tin danh mục
                    txtCategoryName.Text = currentCategory.CategoryName;
                    txtCategoryDescription.Text = currentCategory.Description;

                    // Kích hoạt controls
                    enableCatergoryControl(true);
                    //InitializeCategoryDetail(true);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một danh mục để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có dòng được chọn
            if (dgvCategories.SelectedRows.Count > 0)
            {
                int categoryID = Convert.ToInt32(dgvCategories.SelectedRows[0].Cells["ID"].Value);
                string categoryName = dgvCategories.SelectedRows[0].Cells["Tên danh mục"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa danh mục '{categoryName}'?\n\nLưu ý: Tất cả món ăn thuộc danh mục này cũng sẽ bị xóa.",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Xóa danh mục
                        if (CategoryDAO.DeleteCategory(categoryID))
                        {
                            MessageBox.Show("Xóa danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Tải lại danh sách danh mục
                            LoadCategoriesList();

                            // Tải lại danh sách món ăn
                            LoadFoods();

                            // Đặt lại controls
                            InitializeCategoryDetail(false);
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa danh mục! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa danh mục: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một danh mục để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên danh mục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoryName.Focus();
                return;
            }

            try
            {
                // Tạo đối tượng Category
                Category category = new Category
                {
                    CategoryName = txtCategoryName.Text.Trim(),
                    Description = txtCategoryDescription.Text.Trim()
                };

                if (isAddingCategory)
                {
                    // Thêm danh mục mới
                    int newCategoryID = CategoryDAO.AddCategory(category);
                    if (newCategoryID > 0)
                    {
                        MessageBox.Show("Thêm danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm danh mục! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Cập nhật danh mục
                    category.CategoryID = currentCategory.CategoryID;
                    if (CategoryDAO.UpdateCategory(category))
                    {
                        MessageBox.Show("Cập nhật danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật danh mục! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Tải lại danh sách danh mục
                LoadCategoriesList();

                // Tải lại danh mục cho ComboBox
                LoadCategories();

                // Đặt lại controls
                InitializeCategoryDetail(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu danh mục: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancelCategory_Click(object sender, EventArgs e)
        {
            InitializeCategoryDetail(false);
        }

        private void txtSearchCategory_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchCategory.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                // Hiển thị tất cả danh mục
                DisplayCategories(allCategories);
            }
            else
            {
                // Lọc danh mục theo từ khóa tìm kiếm
                List<Category> searchResults = allCategories
                    .Where(c => c.CategoryName.ToLower().Contains(searchText) ||
                                c.Description.ToLower().Contains(searchText))
                    .ToList();

                // Hiển thị kết quả tìm kiếm
                DisplayCategories(searchResults);
            }
        }


        #endregion

        #region Order Management

        private void LoadOrders()
        {
            try
            {
                // Lấy danh sách đơn hàng từ cơ sở dữ liệu
                allOrders = OrderDAO.GetAllOrders();

                // Hiển thị danh sách đơn hàng trong DataGridView
                DisplayOrders(allOrders);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayOrders(List<Order> orders)
        {
            // Tạo DataTable cho DataGridView
            var dt = new System.Data.DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Khách hàng", typeof(string));
            dt.Columns.Add("Ngày đặt", typeof(DateTime));
            dt.Columns.Add("Tổng tiền", typeof(decimal));
            dt.Columns.Add("Trạng thái", typeof(string));

            // Thêm dữ liệu
            foreach (var order in orders)
            {

                dt.Rows.Add(order.OrderID, order.CustomerName, order.OrderDate, order.TotalAmount, order.Status);
            }

            // Gán DataTable cho DataGridView
            dgvOrders.DataSource = dt;

            // Ẩn cột ID
            dgvOrders.Columns["ID"].Visible = false;

            // Định dạng các cột
            dgvOrders.Columns["Ngày đặt"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dgvOrders.Columns["Tổng tiền"].DefaultCellStyle.Format = "N0";
            dgvOrders.Columns["Tổng tiền"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void InitializeOrderDetail()
        {
            txtOrderID.Clear();
            txtOrderCustomer.Clear();
            txtOrderDate.Clear();
            txtOrderTotal.Clear();
            txtOrderAddress.Clear();
            txtOrderNotes.Clear();
            cboNewStatus.SelectedIndex = -1;
            btnUpdateStatus.Enabled = false;

            // Xóa dữ liệu bảng chi tiết đơn hàng
            dgvOrderDetails.DataSource = null;
        }

        private void LoadOrderDetail(int orderID)
        {
            try
            {
                // Lấy thông tin đơn hàng từ cơ sở dữ liệu
                Order order = OrderDAO.GetOrderByID(orderID);

                if (order != null)
                {
                    currentOrder = order;

                    // Hiển thị thông tin đơn hàng
                    txtOrderID.Text = order.OrderID.ToString();
                    txtOrderCustomer.Text = order.CustomerName;
                    txtOrderDate.Text = order.OrderDate.ToString("dd/MM/yyyy HH:mm");
                    txtOrderTotal.Text = string.Format("{0:#,##0}₫", order.TotalAmount);
                    txtOrderAddress.Text = order.DeliveryAddress;
                    txtOrderNotes.Text = order.Notes;

                    // Chọn trạng thái hiện tại
                    for (int i = 0; i < cboNewStatus.Items.Count; i++)
                    {
                        if (cboNewStatus.Items[i].ToString() == order.Status)
                        {
                            cboNewStatus.SelectedIndex = i;
                            break;
                        }
                    }

                    // Kích hoạt nút cập nhật trạng thái
                    btnUpdateStatus.Enabled = true;

                    // Tải danh sách các món ăn trong đơn hàng
                    LoadOrderItems(orderID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //private void LoadOrderItems(int orderID)
        //{
        //    try
        //    {
        //        // Lấy danh sách món ăn trong đơn hàng
        //        List<OrderItem> orderItems = OrderDAO.GetOrderItems(orderID);

        //        // Tạo DataTable cho DataGridView
        //        var dt = new System.Data.DataTable();
        //        dt.Columns.Add("Món ăn", typeof(string));
        //        dt.Columns.Add("Số lượng", typeof(int));
        //        dt.Columns.Add("Đơn giá", typeof(decimal));
        //        dt.Columns.Add("Thành tiền", typeof(decimal));

        //        // Thêm dữ liệu
        //        foreach (var item in orderItems)
        //        {
        //            dt.Rows.Add(item.FoodName, item.Quantity, item.Price, item.TotalPrice);
        //        }

        //        // Gán DataTable cho DataGridView
        //        dgvOrderDetails.DataSource = dt;

        //        // Định dạng các cột
        //        dgvOrderDetails.Columns["Đơn giá"].DefaultCellStyle.Format = "N0";
        //        dgvOrderDetails.Columns["Đơn giá"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        //        dgvOrderDetails.Columns["Thành tiền"].DefaultCellStyle.Format = "N0";
        //        dgvOrderDetails.Columns["Thành tiền"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Lỗi khi tải chi tiết đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        private void LoadOrderItems(int orderID)
        {
            try
            {
                // Lấy danh sách món ăn trong đơn hàng
                List<OrderDetail> orderDetails = OrderDAO.GetOrderDetailsByOrderID(orderID);

                // Tạo DataTable cho DataGridView
                var dt = new System.Data.DataTable();
                dt.Columns.Add("Món ăn", typeof(string));
                dt.Columns.Add("Số lượng", typeof(int));
                dt.Columns.Add("Đơn giá", typeof(decimal));
                dt.Columns.Add("Thành tiền", typeof(decimal));

                // Thêm dữ liệu
                foreach (var detail in orderDetails)
                {
                    decimal totalPrice = detail.Quantity * detail.UnitPrice;
                    dt.Rows.Add(detail.FoodName, detail.Quantity, detail.UnitPrice, totalPrice);
                }

                // Gán DataTable cho DataGridView
                dgvOrderDetails.DataSource = dt;

                // Định dạng các cột
                dgvOrderDetails.Columns["Đơn giá"].DefaultCellStyle.Format = "N0";
                dgvOrderDetails.Columns["Đơn giá"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvOrderDetails.Columns["Thành tiền"].DefaultCellStyle.Format = "N0";
                dgvOrderDetails.Columns["Thành tiền"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải chi tiết đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                int orderID = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["ID"].Value);
                LoadOrderDetail(orderID);
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (currentOrder != null && cboNewStatus.SelectedIndex >= 0)
            {
                string newStatus = cboNewStatus.SelectedItem.ToString();

                if (newStatus != currentOrder.Status)
                {
                    DialogResult result = MessageBox.Show(
                        $"Bạn có chắc chắn muốn thay đổi trạng thái đơn hàng từ '{currentOrder.Status}' thành '{newStatus}'?",
                        "Xác nhận cập nhật",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            // Cập nhật trạng thái
                            if (OrderDAO.UpdateOrderStatus(currentOrder.OrderID, newStatus))
                            {
                                MessageBox.Show("Cập nhật trạng thái đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Tải lại danh sách đơn hàng
                                LoadOrders();

                                // Tải lại thông tin Dashboard
                                LoadDashboardData();
                            }
                            else
                            {
                                MessageBox.Show("Không thể cập nhật trạng thái đơn hàng! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi cập nhật trạng thái đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private string MapStatusToEnglish(string vietnameseStatus)
        {
            switch (vietnameseStatus)
            {
                case "Đang chờ": return "Pending";
                case "Đã xác nhận": return "Confirmed";
                case "Đang giao": return "Delivering";
                case "Đã giao": return "Delivered";
                case "Đã hủy": return "Cancelled";
                default: return "";
            }
        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            SearchOrders();
        }

        //private void SearchOrders()
        //{
        //    try
        //    {
        //        string keyword = txtSearchOrder.Text.Trim();
        //        string status = cboOrderStatus.SelectedIndex > 0 ? cboOrderStatus.SelectedItem.ToString() : "";
        //        DateTime? fromDate = dtpOrderFrom.Checked ? dtpOrderFrom.Value : (DateTime?)null;
        //        DateTime? toDate = dtpOrderTo.Checked ? dtpOrderTo.Value.AddDays(1).AddSeconds(-1) : (DateTime?)null;

        //        // Tìm kiếm đơn hàng
        //        List<Order> searchResults = OrderDAO.SearchOrders(keyword, status, fromDate, toDate);

        //        // Hiển thị kết quả tìm kiếm
        //        DisplayOrders(searchResults);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Lỗi khi tìm kiếm đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        private void SearchOrders()
        {
            try
            {
                string keyword = txtSearchOrder.Text.Trim();

                // Lấy trạng thái nếu có chọn (không phải là "Tất cả")
                string status = null;
                if (cboOrderStatus.SelectedIndex > 0) // Giả sử 0 là "Tất cả"
                {
                    status = cboOrderStatus.SelectedItem.ToString();
                    status = MapStatusToEnglish(status);
                }

                // Chỉ lấy ngày nếu checkbox được chọn
                DateTime? fromDate = dtpOrderFrom.Checked ? dtpOrderFrom.Value : (DateTime?)null;
                DateTime? toDate = dtpOrderTo.Checked ? dtpOrderTo.Value : (DateTime?)null;

                // Thêm logging để debug
                Console.WriteLine($"Search params: keyword={keyword}, status={status}, from={fromDate}, to={toDate}");

                // Tìm kiếm đơn hàng
                List<Order> searchResults = OrderDAO.SearchOrders(keyword, status, fromDate, toDate);

                // Hiển thị kết quả tìm kiếm
                DisplayOrders(searchResults);

                // Hiển thị thông báo số kết quả tìm được
                //lblResultCount.Text = $"Tìm thấy {searchResults.Count} kết quả";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region User Management

        private void LoadUsers()
        {
            try
            {
                // Lấy danh sách người dùng từ cơ sở dữ liệu
                allUsers = UserDAO.GetAllUsers();

                // Hiển thị danh sách người dùng trong DataGridView
                DisplayUsers(allUsers);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách người dùng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayUsers(List<User> users)
        {
            // Tạo DataTable cho DataGridView
            var dt = new System.Data.DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Tên đăng nhập", typeof(string));
            dt.Columns.Add("Họ tên", typeof(string));
            dt.Columns.Add("SĐT", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Vai trò", typeof(string));

            // Thêm dữ liệu
            foreach (var user in users)
            {
                dt.Rows.Add(user.UserID, user.Username, user.FullName, user.Phone, user.Email, user.UserRole);
            }

            // Gán DataTable cho DataGridView
            dgvUsers.DataSource = dt;

            // Ẩn cột ID
            dgvUsers.Columns["ID"].Visible = false;
        }

        private void InitializeUserDetail(bool enabled)
        {
            // Xóa thông tin hiện tại
            txtUsername.Clear();
            txtUserFullName.Clear();
            txtUserPhone.Clear();
            txtUserEmail.Clear();
            txtUserAddress.Clear();
            cboUserRole.SelectedIndex = -1;

            // Kích hoạt hoặc vô hiệu hóa controls
            txtUsername.Enabled = enabled && isAddingUser; // Chỉ cho phép sửa username khi thêm mới
            txtUserFullName.Enabled = enabled;
            txtUserPhone.Enabled = enabled;
            txtUserEmail.Enabled = enabled;
            txtUserAddress.Enabled = enabled;
            cboUserRole.Enabled = enabled;
            btnSaveUser.Enabled = enabled;
            btnCancelUser.Enabled = enabled;
            btnResetPassword.Enabled = enabled && !isAddingUser; // Chỉ cho phép reset mật khẩu khi chỉnh sửa
        }



        private void btnAddUser_Click(object sender, EventArgs e)
        {
            isAddingUser = true;
            currentUser = null;
            InitializeUserDetail(true);
            txtUsername.Focus();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có dòng được chọn
            if (dgvUsers.SelectedRows.Count > 0)
            {
                int userID = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["ID"].Value);
                currentUser = allUsers.Find(u => u.UserID == userID);

                if (currentUser != null)
                {
                    isAddingUser = false;

                    // Hiển thị thông tin người dùng
                    txtUsername.Text = currentUser.Username;
                    txtUserFullName.Text = currentUser.FullName;
                    txtUserPhone.Text = currentUser.Phone;
                    txtUserEmail.Text = currentUser.Email;
                    txtUserAddress.Text = currentUser.Address;

                    // Chọn vai trò
                    for (int i = 0; i < cboUserRole.Items.Count; i++)
                    {
                        if (cboUserRole.Items[i].ToString() == currentUser.UserRole)
                        {
                            cboUserRole.SelectedIndex = i;
                            break;
                        }
                    }

                    // Kích hoạt controls
                    //InitializeUserDetail(true);
                    EnableControlsUsers(true);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một người dùng để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void EnableControlsUsers(bool enabled)
        {
            // Kích hoạt hoặc vô hiệu hóa controls
            txtUsername.Enabled = enabled && isAddingUser; // Chỉ cho phép sửa username khi thêm mới
            txtUserFullName.Enabled = enabled;
            txtUserPhone.Enabled = enabled;
            txtUserEmail.Enabled = enabled;
            txtUserAddress.Enabled = enabled;
            cboUserRole.Enabled = enabled;
            btnSaveUser.Enabled = enabled;
            btnCancelUser.Enabled = enabled;
            btnResetPassword.Enabled = enabled && !isAddingUser; // Chỉ cho phép reset mật khẩu khi chỉnh sửa
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có dòng được chọn
            if (dgvUsers.SelectedRows.Count > 0)
            {
                int userID = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["ID"].Value);
                string username = dgvUsers.SelectedRows[0].Cells["Tên đăng nhập"].Value.ToString();

                // Ngăn không cho xóa tài khoản đang đăng nhập
                if (userID == currentAdmin.UserID)
                {
                    MessageBox.Show("Bạn không thể xóa tài khoản đang đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa người dùng '{username}'?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Xóa người dùng
                        if (UserDAO.DeleteUser(userID))
                        {
                            MessageBox.Show("Xóa người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Tải lại danh sách người dùng
                            LoadUsers();

                            // Đặt lại controls
                            InitializeUserDetail(false);
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa người dùng! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa người dùng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một người dùng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUserFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserFullName.Focus();
                return;
            }

            if (cboUserRole.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn vai trò người dùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboUserRole.Focus();
                return;
            }

            try
            {
                // Tạo đối tượng User
                User user = new User
                {
                    Username = txtUsername.Text.Trim(),
                    FullName = txtUserFullName.Text.Trim(),
                    Phone = txtUserPhone.Text.Trim(),
                    Email = txtUserEmail.Text.Trim(),
                    Address = txtUserAddress.Text.Trim(),
                    UserRole = cboUserRole.SelectedItem.ToString()
                };

                if (isAddingUser)
                {
                    // Đặt mật khẩu mặc định
                    user.Password = "123456"; // Mật khẩu mặc định sẽ được mã hóa trong DAO

                    // Thêm người dùng mới
                    int newUserID = UserDAO.AddUser(user);
                    if (newUserID > 0)
                    {
                        MessageBox.Show("Thêm người dùng thành công!\nMật khẩu mặc định là: 123456", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm người dùng! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Cập nhật người dùng
                    user.UserID = currentUser.UserID;
                    if (UserDAO.UpdateUser(user))
                    {
                        MessageBox.Show("Cập nhật người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật người dùng! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Tải lại danh sách người dùng
                LoadUsers();

                // Đặt lại controls
                InitializeUserDetail(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu người dùng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnCancelUser_Click(object sender, EventArgs e)
        {
            InitializeUserDetail(false);
        }

        // btnResetPassword_Click
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            if (currentUser != null && !isAddingUser)
            {
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn đặt lại mật khẩu cho tài khoản '{currentUser.Username}'?\n\nMật khẩu mới sẽ là: 123456",
                    "Xác nhận đặt lại mật khẩu",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Đặt lại mật khẩu
                        if (UserDAO.ResetPassword(currentUser.UserID, "123456"))
                        {
                            MessageBox.Show("Đặt lại mật khẩu thành công!\nMật khẩu mới là: 123456", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không thể đặt lại mật khẩu! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi đặt lại mật khẩu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchUser.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                // Hiển thị tất cả người dùng
                DisplayUsers(allUsers);
            }
            else
            {
                // Lọc người dùng theo từ khóa tìm kiếm
                List<User> searchResults = allUsers
                    .Where(u => u.Username.ToLower().Contains(searchText) ||
                                u.FullName.ToLower().Contains(searchText) ||
                                u.Phone.ToLower().Contains(searchText) ||
                                u.Email.ToLower().Contains(searchText))
                    .ToList();

                // Hiển thị kết quả tìm kiếm
                DisplayUsers(searchResults);
            }
        }
        // InitializeUserRoleComboBox
        private void InitializeUserRoleComboBox()
        {
            cboUserRole.Items.Clear();
            cboUserRole.Items.Add("Customer");
            cboUserRole.Items.Add("Admin");
            cboUserRole.SelectedIndex = 0; // Mặc định là Customer
        }

        #endregion

        #region Navigation Events

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlDashboard);
            SetActiveButton(btnDashboard);
            LoadDashboardData();
        }

        private void btnFoods_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlFoodManagement);
            SetActiveButton(btnFoods);
            LoadFoods();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlCategoryManagement);
            SetActiveButton(btnCategories);
            LoadCategoriesList();
        }


        private void btnOrders_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlOrderManagement);
            SetActiveButton(btnOrders);
            LoadOrders();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlUserManagement);
            SetActiveButton(btnUsers);
            LoadUsers();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất không?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Mở form đăng nhập
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }

        #endregion

        private void btnReport_Click(object sender, EventArgs e)
        {
            // Hiển thị form báo cáo doanh thu
            RevenueReportForm reportForm = new RevenueReportForm();
            reportForm.ShowDialog();
        }

        private void btnManageRatings_Click(object sender, EventArgs e)
        {
            RatingsManagementForm r = new RatingsManagementForm();
            r.ShowDialog();
        }
    }
}