using FoodOrderApp.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FoodOrderApp
{

    public partial class MainForm : Form
    {
        private User currentUser;
        private List<Food> allFoods;
        private List<CartItem> cartItems;
        private decimal totalAmount = 0;
        private decimal deliveryFee = 15000;

        public MainForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            cartItems = new List<CartItem>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Hiển thị tên người dùng
            lblUserName.Text = $"Xin chào, {currentUser.FullName}";

            // Nạp địa chỉ người dùng nếu có
            if (!string.IsNullOrEmpty(currentUser.Address))
            {
                txtDeliveryAddress.Text = currentUser.Address;
            }

            // Tải danh sách món ăn
            LoadFoods();

            // Khôi phục giỏ hàng đã lưu
            LoadSavedCart();
        }

        private void LoadFoods()
        {
            try
            {
                // Xóa các món ăn hiện tại
                flpFoods.Controls.Clear();

                // Lấy danh sách món ăn từ cơ sở dữ liệu
                allFoods = FoodDAO.GetAllFoods();

                // Hiển thị các món ăn
                DisplayFoods(allFoods);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách món ăn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Thêm phương thức để khôi phục giỏ hàng đã lưu
        private void LoadSavedCart()
        {
            try
            {
                // Lấy giỏ hàng đã lưu từ cơ sở dữ liệu
                List<CartItem> savedCart = CartDAO.LoadCart(currentUser.UserID);

                if (savedCart.Count > 0)
                {
                    // Hiển thị thông báo nếu có giỏ hàng đã lưu
                    DialogResult result = MessageBox.Show(
                        "Bạn có giỏ hàng chưa hoàn tất. Bạn có muốn khôi phục không?",
                        "Khôi phục giỏ hàng",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Khôi phục giỏ hàng
                        cartItems = savedCart;
                        UpdateCartDisplay();
                    }
                    else
                    {
                        // Xóa giỏ hàng đã lưu
                        CartDAO.ClearCart(currentUser.UserID);
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi một cách lặng lẽ, không hiển thị thông báo lỗi
                Console.WriteLine($"Error loading saved cart: {ex.Message}");
            }
        }

        private void DisplayFoods(List<Food> foods)
        {
            foreach (Food food in foods)
            {
                // Tạo panel cho mỗi món ăn
                Panel foodPanel = new Panel
                {
                    Width = 220,
                    Height = 280,
                    Margin = new Padding(10),
                    BackColor = Color.White
                };

                // Tạo PictureBox cho hình ảnh món ăn
                PictureBox pbImage = new PictureBox
                {
                    Width = 200,
                    Height = 150,
                    Location = new Point(10, 10),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BackColor = Color.WhiteSmoke
                };

                // Tải hình ảnh (nếu có)
                try
                {
                    string imagePath = Path.Combine(Application.StartupPath, "Images", food.ImageName);
                    if (File.Exists(imagePath))
                    {
                        pbImage.Image = Image.FromFile(imagePath);
                    }
                }
                catch { }

                // Label tên món ăn
                Label lblFoodName = new Label
                {
                    Text = food.FoodName,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Location = new Point(10, 170),
                    Size = new Size(200, 20)
                };

                // Label mô tả
                Label lblDescription = new Label
                {
                    Text = food.Description,
                    Font = new Font("Segoe UI", 8),
                    ForeColor = Color.Gray,
                    Location = new Point(10, 195),
                    Size = new Size(200, 30)
                };

                // Label giá
                Label lblPrice = new Label
                {
                    Text = string.Format("{0:#,##0}₫", food.Price),
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = Color.FromArgb(192, 0, 0),
                    Location = new Point(10, 235),
                    Size = new Size(100, 20)
                };

                // Button Thêm vào giỏ
                Button btnAdd = new Button
                {
                    Text = "Thêm vào giỏ",
                    Font = new Font("Segoe UI", 9),
                    BackColor = Color.FromArgb(0, 122, 255),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Location = new Point(110, 230),
                    Size = new Size(100, 30),
                    Tag = food.FoodID
                };
                btnAdd.FlatAppearance.BorderSize = 0;
                btnAdd.Click += new EventHandler(AddToCart_Click);

                // Thêm các control vào panel
                foodPanel.Controls.Add(pbImage);
                foodPanel.Controls.Add(lblFoodName);
                foodPanel.Controls.Add(lblDescription);
                foodPanel.Controls.Add(lblPrice);
                foodPanel.Controls.Add(btnAdd);

                // Thêm panel vào flow layout
                flpFoods.Controls.Add(foodPanel);
            }
        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int foodID = (int)btn.Tag;

            // Tìm món ăn trong danh sách
            Food selectedFood = allFoods.FirstOrDefault(f => f.FoodID == foodID);
            if (selectedFood != null)
            {
                // Kiểm tra nếu món ăn đã có trong giỏ hàng
                CartItem existingItem = cartItems.FirstOrDefault(item => item.FoodID == foodID);
                if (existingItem != null)
                {
                    existingItem.Quantity += 1;
                }
                else
                {
                    // Thêm món ăn mới vào giỏ hàng
                    CartItem newItem = new CartItem
                    {
                        FoodID = selectedFood.FoodID,
                        FoodName = selectedFood.FoodName,
                        Price = selectedFood.Price,
                        Quantity = 1
                    };
                    cartItems.Add(newItem);
                }

                // Cập nhật hiển thị giỏ hàng
                UpdateCartDisplay();
            }
        }

        private void UpdateCartDisplay()
        {
            // Xóa các item hiện tại trong giỏ hàng
            flpCartItems.Controls.Clear();

            // Tính tổng tiền
            decimal subtotal = 0;

            foreach (CartItem item in cartItems)
            {
                // Tạo panel cho mỗi món trong giỏ hàng
                Panel itemPanel = new Panel
                {
                    Width = flpCartItems.Width - 20,
                    Height = 80,
                    Margin = new Padding(5),
                    BorderStyle = BorderStyle.FixedSingle
                };

                // Label tên món
                Label lblName = new Label
                {
                    Text = item.FoodName,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    Location = new Point(10, 10),
                    Size = new Size(200, 20)
                };

                // Label giá
                Label lblPrice = new Label
                {
                    Text = string.Format("{0:#,##0}₫", item.Price),
                    Font = new Font("Segoe UI", 9),
                    Location = new Point(10, 35),
                    Size = new Size(80, 20)
                };

                // NumericUpDown để chọn số lượng
                NumericUpDown numQuantity = new NumericUpDown
                {
                    Value = item.Quantity,
                    Minimum = 1,
                    Maximum = 10,
                    Location = new Point(100, 35),
                    Size = new Size(50, 25),
                    Tag = item
                };
                numQuantity.ValueChanged += new EventHandler(Quantity_Changed);

                // Button Xóa
                Button btnRemove = new Button
                {
                    Text = "X",
                    Font = new Font("Segoe UI", 8),
                    BackColor = Color.FromArgb(220, 53, 69),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    //Location = new Point(260, 10),
                    Location = new Point(150, 35),
                    Size = new Size(25, 20),
                    Tag = item
                };
                btnRemove.FlatAppearance.BorderSize = 0;
                btnRemove.Click += new EventHandler(RemoveFromCart_Click);
                btnRemove.BringToFront();

                // Label tổng tiền theo món
                Label lblItemTotal = new Label
                {
                    Text = string.Format("{0:#,##0}₫", item.Total),
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    ForeColor = Color.FromArgb(192, 0, 0),
                    Location = new Point(170, 35),
                    Size = new Size(120, 20),
                    TextAlign = ContentAlignment.MiddleRight
                };

                // Thêm controls vào panel
                itemPanel.Controls.Add(lblName);
                itemPanel.Controls.Add(lblPrice);
                itemPanel.Controls.Add(numQuantity);
                itemPanel.Controls.Add(lblItemTotal);
                itemPanel.Controls.Add(btnRemove);

                // Thêm panel vào flow layout
                flpCartItems.Controls.Add(itemPanel);

                // Cộng tổng tiền
                subtotal += item.Total;
            }

            // Cập nhật hiển thị tổng tiền
            lblSubtotal.Text = string.Format("{0:#,##0}₫", subtotal);

            // Tổng cộng = tạm tính + phí giao hàng
            totalAmount = subtotal + deliveryFee;
            lblTotal.Text = string.Format("{0:#,##0}₫", totalAmount);
        }

        private void Quantity_Changed(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            CartItem item = (CartItem)num.Tag;
            item.Quantity = (int)num.Value;

            // Cập nhật hiển thị giỏ hàng
            UpdateCartDisplay();
        }

        private void RemoveFromCart_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            CartItem item = (CartItem)btn.Tag;

            // Xóa món khỏi giỏ hàng
            cartItems.Remove(item);

            // Cập nhật hiển thị giỏ hàng
            UpdateCartDisplay();
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int categoryID = Convert.ToInt32(btn.Tag);

            // Đổi màu button được chọn
            foreach (Control control in pnlCategories.Controls)
            {
                if (control is Button categoryBtn)
                {
                    if (categoryBtn == btn)
                    {
                        categoryBtn.BackColor = Color.FromArgb(0, 122, 255);
                        categoryBtn.ForeColor = Color.White;
                    }
                    else
                    {
                        categoryBtn.BackColor = Color.White;
                        categoryBtn.ForeColor = Color.Black;
                    }
                }
            }

            try
            {
                // Lọc món ăn theo danh mục
                List<Food> filteredFoods;
                if (categoryID == 0) // Tất cả
                {
                    filteredFoods = allFoods;
                }
                else
                {
                    filteredFoods = allFoods.Where(f => f.CategoryID == categoryID).ToList();
                }

                // Hiển thị các món ăn đã lọc
                flpFoods.Controls.Clear();
                DisplayFoods(filteredFoods);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lọc món ăn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                // Hiển thị tất cả món ăn
                flpFoods.Controls.Clear();
                DisplayFoods(allFoods);
            }
            else
            {
                // Lọc món ăn theo từ khóa tìm kiếm
                List<Food> searchResults = allFoods
                    .Where(f => f.FoodName.ToLower().Contains(searchText) ||
                                f.Description.ToLower().Contains(searchText))
                    .ToList();

                // Hiển thị kết quả tìm kiếm
                flpFoods.Controls.Clear();
                DisplayFoods(searchResults);
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã chọn món ăn chưa
            if (cartItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra địa chỉ giao hàng
            if (string.IsNullOrWhiteSpace(txtDeliveryAddress.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ giao hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDeliveryAddress.Focus();
                return;
            }

            try
            {
                // Tạo đơn hàng mới
                Order order = new Order
                {
                    UserID = currentUser.UserID,
                    DeliveryAddress = txtDeliveryAddress.Text.Trim(),
                    PhoneNumber = currentUser.Phone,
                    PaymentMethod = cboPaymentMethod.Text,
                    Notes = txtNotes.Text,
                    Status = "Pending",
                    TotalAmount = totalAmount
                };

                // Thêm chi tiết đơn hàng
                foreach (CartItem item in cartItems)
                {
                    OrderDetail detail = new OrderDetail
                    {
                        FoodID = item.FoodID,
                        Quantity = item.Quantity,
                        UnitPrice = item.Price
                    };

                    order.OrderDetails.Add(detail);
                }

                // Lưu đơn hàng vào cơ sở dữ liệu
                int orderID = OrderDAO.CreateOrder(order);

                if (orderID > 0)
                {
                    MessageBox.Show($"Đặt hàng thành công! Mã đơn hàng của bạn là: {orderID}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xóa giỏ hàng
                    cartItems.Clear();
                    UpdateCartDisplay();

                    // Hiển thị cảm ơn
                    MessageBox.Show("Cảm ơn bạn đã đặt hàng! Chúng tôi sẽ giao hàng trong thời gian sớm nhất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đặt hàng thất bại! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đặt hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // Làm mới danh sách món ăn
            btnAllFoods.PerformClick();
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            // Mở form lịch sử đơn hàng
            OrderHistoryForm historyForm = new OrderHistoryForm(currentUser.UserID);
            historyForm.ShowDialog();
        }

        private void btnRatings_Click(object sender, EventArgs e)
        {
            // Mở form xem đánh giá của người dùng
            UserRatingsViewForm ratingsForm = new UserRatingsViewForm(currentUser.UserID);
            ratingsForm.ShowDialog();
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            // Mở form hỗ trợ khách hàng
            MessageBox.Show("Chức năng hỗ trợ đang được phát triển!\n\nHotline: 1900-1234\nEmail: support@foodorder.com", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            // Mở form cài đặt tài khoản
            ProfileForm profileForm = new ProfileForm(currentUser);
            if (profileForm.ShowDialog() == DialogResult.OK)
            {
                // Cập nhật thông tin hiển thị
                lblUserName.Text = $"Xin chào, {currentUser.FullName}";

                // Cập nhật địa chỉ giao hàng nếu có
                if (!string.IsNullOrEmpty(currentUser.Address))
                {
                    txtDeliveryAddress.Text = currentUser.Address;
                }

                MessageBox.Show("Thông tin cá nhân đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Xác nhận đăng xuất
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Đóng form hiện tại và mở form đăng nhập
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }

    }
}