using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FoodOrderApp
{
    public partial class UserRatingsViewForm : Form
    {
        private int userID;

        public UserRatingsViewForm(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void UserRatingsViewForm_Load(object sender, EventArgs e)
        {
            // Thiết lập thuộc tính form
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            // Load danh sách đánh giá
            LoadUserRatings();
        }

        private void LoadUserRatings()
        {
            try
            {
                // Lấy danh sách đánh giá của người dùng
                List<Rating> userRatings = RatingDAO.GetRatingsByUser(userID);

                // Xóa danh sách hiện tại
                lvRatings.Items.Clear();

                if (userRatings.Count > 0)
                {
                    // Hiển thị danh sách đánh giá
                    foreach (Rating rating in userRatings)
                    {
                        // Lấy thông tin đơn hàng
                        Order order = OrderDAO.GetOrderByID(rating.OrderID);

                        if (order != null)
                        {
                            ListViewItem item = new ListViewItem(order.OrderID.ToString());
                            item.SubItems.Add(order.OrderDate.ToString("dd/MM/yyyy"));

                            // Lấy tên món ăn đầu tiên trong đơn hàng
                            string firstFood = order.OrderDetails.Count > 0 ?
                                order.OrderDetails[0].FoodName : "Unknown";

                            item.SubItems.Add(firstFood);
                            item.SubItems.Add(rating.RatingValue.ToString() + " ★");
                            item.SubItems.Add(rating.RatingDate.ToString("dd/MM/yyyy"));
                            item.Tag = rating;

                            // Đổi màu dựa trên rating
                            item.ForeColor = GetRatingColor(rating.RatingValue);

                            lvRatings.Items.Add(item);
                        }
                    }

                    // Chọn đánh giá đầu tiên
                    if (lvRatings.Items.Count > 0)
                    {
                        lvRatings.Items[0].Selected = true;
                    }
                    else
                    {
                        ClearRatingDetails();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa có đánh giá nào!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearRatingDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải đánh giá: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Color GetRatingColor(int ratingValue)
        {
            switch (ratingValue)
            {
                case 5:
                    return Color.DarkGreen;
                case 4:
                    return Color.Green;
                case 3:
                    return Color.DarkOrange;
                case 2:
                    return Color.OrangeRed;
                case 1:
                    return Color.Red;
                default:
                    return Color.Black;
            }
        }

        private void lvRatings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRatings.SelectedItems.Count > 0)
            {
                // Lấy đánh giá được chọn
                ListViewItem selectedItem = lvRatings.SelectedItems[0];
                Rating selectedRating = (Rating)selectedItem.Tag;

                // Hiển thị chi tiết đánh giá
                DisplayRatingDetails(selectedRating);
            }
        }

        private void DisplayRatingDetails(Rating rating)
        {
            // Hiển thị thông tin đánh giá
            lblOrderID.Text = $"Đơn hàng #{rating.OrderID:D6}";

            // Hiển thị số sao
            DisplayStars(rating.RatingValue);

            // Hiển thị comment
            txtComment.Text = rating.Comment ?? "(Không có nhận xét)";

            // Hiển thị ngày đánh giá
            lblRatingDate.Text = $"Đánh giá ngày: {rating.RatingDate.ToString("dd/MM/yyyy HH:mm")}";

            // Hiển thị chi tiết đơn hàng
            Order order = OrderDAO.GetOrderByID(rating.OrderID);
            if (order != null)
            {
                lvOrderDetails.Items.Clear();
                foreach (OrderDetail detail in order.OrderDetails)
                {
                    ListViewItem item = new ListViewItem(detail.FoodName);
                    item.SubItems.Add(detail.Quantity.ToString());
                    item.SubItems.Add(string.Format("{0:#,##0}₫", detail.UnitPrice));
                    lvOrderDetails.Items.Add(item);
                }
            }
        }

        private void DisplayStars(int rating)
        {
            //Giả sử bạn có 5 PictureBox để hiển thị sao: picStar1, picStar2, ...
            PictureBox[] stars = { picStar1, picStar2, picStar3, picStar4, picStar5 };

            // Tải hình ảnh sao từ thư mục Images
            Image starEmpty;
            Image starFilled;

            //try
            //{
            //    string emptyStarPath = Path.Combine(Application.StartupPath, "Images", "star_empty.png");
            //    string filledStarPath = Path.Combine(Application.StartupPath, "Images", "star_filled.png");
            //    MessageBox.Show(emptyStarPath);
            //    if (File.Exists(emptyStarPath) && File.Exists(filledStarPath))
            //    {
            //        starEmpty = Image.FromFile(emptyStarPath);
            //        starFilled = Image.FromFile(filledStarPath);
            //    }
            //    else
            //    {
            //        MessageBox.Show("img !ok");

            //        // Nếu không tìm thấy file, sử dụng phương thức tạo ảnh
            //        starEmpty = CreateStarImage(false);
            //        starFilled = CreateStarImage(true);
            //    }
            //}
            //catch
            //{
            //    // Trong trường hợp có lỗi, sử dụng phương thức tạo ảnh
            //    starEmpty = CreateStarImage(false);
            //    starFilled = CreateStarImage(true);
            //}
            starEmpty = CreateStarImage(false);
            starFilled = CreateStarImage(true);


            // Hiển thị số sao đánh giá
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].Image = (i < rating) ? starFilled : starEmpty;
            }
        }
        private Image CreateStarImage(bool isFilled)
        {
            // Tạo hình ảnh sao
            Bitmap bmp = new Bitmap(40, 40);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                // Vẽ sao
                PointF[] points = new PointF[10];
                float cx = 20, cy = 20, r1 = 18, r2 = 8;

                for (int i = 0; i < 10; i++)
                {
                    float angle = (float)(Math.PI / 2 + i * Math.PI * 2 / 10);
                    float r = i % 2 == 0 ? r1 : r2;
                    points[i] = new PointF(
                        cx + (float)Math.Cos(angle) * r,
                        cy - (float)Math.Sin(angle) * r);
                }

                using (SolidBrush brush = new SolidBrush(isFilled ? Color.Gold : Color.LightGray))
                using (Pen pen = new Pen(Color.DarkGray, 1))
                {
                    g.FillPolygon(brush, points);
                    g.DrawPolygon(pen, points);
                }
            }
            return bmp;
        }

        private void ClearRatingDetails()
        {
            lblOrderID.Text = "Đơn hàng #000000";
            lblRatingDate.Text = "Đánh giá ngày: --/--/----";
            txtComment.Text = "";
            lvOrderDetails.Items.Clear();

            // Xóa các sao
            PictureBox[] stars = { picStar1, picStar2, picStar3, picStar4, picStar5 };
            foreach (var star in stars)
            {
                star.Image = null;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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