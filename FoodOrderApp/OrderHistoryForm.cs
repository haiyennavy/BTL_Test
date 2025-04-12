using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FoodOrderApp
{
    public partial class OrderHistoryForm : Form
    {
        private int userID;
        private List<Order> orders;
        private Order selectedOrder;

        public OrderHistoryForm(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }
        public OrderHistoryForm()
        {
            InitializeComponent();
        }
        private void OrderHistoryForm_Load(object sender, EventArgs e)
        {
            // Thiết lập một số thuộc tính cho form
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            // Load danh sách đơn hàng
            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                // Lấy danh sách đơn hàng của người dùng
                orders = OrderDAO.GetOrdersByUser(userID);

                // Xóa danh sách hiện tại
                lvOrders.Items.Clear();

                // Hiển thị danh sách đơn hàng
                foreach (Order order in orders)
                {
                    ListViewItem item = new ListViewItem(order.OrderID.ToString());
                    item.SubItems.Add(order.OrderDate.ToString("dd/MM/yyyy HH:mm"));
                    item.SubItems.Add(string.Format("{0:#,##0}₫", order.TotalAmount));
                    item.SubItems.Add(GetStatusText(order.Status));
                    item.Tag = order;

                    // Đổi màu theo trạng thái
                    item.ForeColor = GetStatusColor(order.Status);

                    lvOrders.Items.Add(item);
                }

                // Nếu có đơn hàng thì chọn đơn hàng đầu tiên
                if (lvOrders.Items.Count > 0)
                {
                    lvOrders.Items[0].Selected = true;
                }
                else
                {
                    ClearOrderDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetStatusText(string status)
        {
            switch (status)
            {
                case "Pending":
                    return "Chờ xác nhận";
                case "Confirmed":
                    return "Đã xác nhận";
                case "Delivering":
                    return "Đang giao";
                case "Delivered":
                    return "Đã giao";
                case "Cancelled":
                    return "Đã hủy";
                default:
                    return status;
            }
        }

        private Color GetStatusColor(string status)
        {
            switch (status)
            {
                case "Pending":
                    return Color.DarkOrange;
                case "Confirmed":
                    return Color.Blue;
                case "Delivering":
                    return Color.DarkViolet;
                case "Delivered":
                    return Color.Green;
                case "Cancelled":
                    return Color.Red;
                default:
                    return Color.Black;
            }
        }

        private void lvOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvOrders.SelectedItems.Count > 0)
            {
                // Lấy đơn hàng được chọn
                ListViewItem selectedItem = lvOrders.SelectedItems[0];
                selectedOrder = (Order)selectedItem.Tag;

                // Hiển thị thông tin đơn hàng
                DisplayOrderDetails(selectedOrder);
            }
        }

        private void DisplayOrderDetails(Order order)
        {
            // Hiển thị thông tin cơ bản
            lblOrderID.Text = $"Đơn hàng #{order.OrderID:D6}";
            txtOrderDate.Text = order.OrderDate.ToString("dd/MM/yyyy HH:mm");
            txtStatus.Text = GetStatusText(order.Status);
            txtStatus.ForeColor = GetStatusColor(order.Status);

            txtAddress.Text = order.DeliveryAddress;
            txtPhone.Text = order.PhoneNumber;
            txtPaymentMethod.Text = order.PaymentMethod;
            txtNotes.Text = order.Notes;

            // Hiển thị chi tiết đơn hàng
            lvOrderDetails.Items.Clear();

            foreach (OrderDetail detail in order.OrderDetails)
            {
                ListViewItem item = new ListViewItem(detail.FoodName);
                item.SubItems.Add(detail.Quantity.ToString());
                item.SubItems.Add(string.Format("{0:#,##0}₫", detail.UnitPrice));
                item.SubItems.Add(string.Format("{0:#,##0}₫", detail.Subtotal));
                item.Tag = detail;

                lvOrderDetails.Items.Add(item);
            }

            // Chỉ hiển thị nút đánh giá nếu đơn hàng đã giao
            btnRate.Visible = (order.Status == "Delivered");
        }

        private void ClearOrderDetails()
        {
            lblOrderID.Text = "Đơn hàng #000000";
            txtOrderDate.Text = "";
            txtStatus.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtPaymentMethod.Text = "";
            txtNotes.Text = "";
            lvOrderDetails.Items.Clear();
            btnRate.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            if (selectedOrder != null)
            {
                // Mở form đánh giá
                RatingForm ratingForm = new RatingForm(selectedOrder);
                if (ratingForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Cảm ơn bạn đã đánh giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Cho phép di chuyển form không có viền
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTCLIENT = 1;
            const int HTCAPTION = 2;

            if (m.Msg == WM_NCHITTEST)
            {
                int result = HTCLIENT;
                if (this.pnlHeader.ClientRectangle.Contains(this.pnlHeader.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16))))
                {
                    result = HTCAPTION;
                }
                m.Result = (IntPtr)result;
                return;
            }

            base.WndProc(ref m);
        }
    }
}