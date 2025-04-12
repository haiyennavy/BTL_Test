using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FoodOrderApp
{
    public partial class RatingForm : Form
    {
        private Order order;
        private int rating = 0;
        private Image starEmpty;
        private Image starFilled;

        public RatingForm(Order order)
        {
            InitializeComponent();
            this.order = order;
        }

        private void RatingForm_Load(object sender, EventArgs e)
        {
            // Thiết lập một số thuộc tính cho form
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            // Hiển thị thông tin đơn hàng
            lblOrderID.Text = $"Đơn hàng #{order.OrderID:D6}";

            // Tải hình ảnh sao
            try
            {
                string emptyStarPath = Path.Combine(Application.StartupPath, "Images", "star_empty.png");
                string filledStarPath = Path.Combine(Application.StartupPath, "Images", "star_filled.png");

                if (File.Exists(emptyStarPath) && File.Exists(filledStarPath))
                {
                    starEmpty = Image.FromFile(emptyStarPath);
                    starFilled = Image.FromFile(filledStarPath);
                }
                else
                {
                    // Nếu không có hình ảnh, sử dụng hình đại diện
                    starEmpty = CreateStarImage(false);
                    starFilled = CreateStarImage(true);
                }
            }
            catch
            {
                // Trong trường hợp không tải được hình ảnh, tạo ảnh mới
                starEmpty = CreateStarImage(false);
                starFilled = CreateStarImage(true);
            }

            // Thiết lập hình ảnh sao ban đầu
            picStar1.Image = starEmpty;
            picStar2.Image = starEmpty;
            picStar3.Image = starEmpty;
            picStar4.Image = starEmpty;
            picStar5.Image = starEmpty;

            // Nếu đã có đánh giá trước đó, hiển thị
            CheckPreviousRating();
        }

        private void CheckPreviousRating()
        {
            try
            {
                // Kiểm tra xem người dùng đã đánh giá đơn hàng này chưa
                Rating existingRating = RatingDAO.GetRatingByOrder(order.OrderID, order.UserID);

                if (existingRating != null)
                {
                    // Hiển thị đánh giá đã tồn tại
                    rating = existingRating.RatingValue;
                    UpdateStars(rating);
                    txtComment.Text = existingRating.Comment;

                    MessageBox.Show("Bạn đã đánh giá đơn hàng này. Bạn có thể chỉnh sửa đánh giá.");
                }
                else
                {
                    MessageBox.Show("Hãy đánh giá trải nghiệm của bạn với đơn hàng này.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi kiểm tra đánh giá: {ex.Message}");
            }
        }

        private Image CreateStarImage(bool isFilled)
        {
            // Tạo hình ảnh sao nếu không có file ảnh
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

        private void StarClick(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            rating = int.Parse(pic.Tag.ToString());
            UpdateStars(rating);
        }

        private void StarMouseEnter(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            int value = int.Parse(pic.Tag.ToString());
            UpdateStars(value, true);
        }

        private void StarMouseLeave(object sender, EventArgs e)
        {
            UpdateStars(rating);
        }

        private void UpdateStars(int count, bool isHover = false)
        {
            picStar1.Image = count >= 1 ? starFilled : starEmpty;
            picStar2.Image = count >= 2 ? starFilled : starEmpty;
            picStar3.Image = count >= 3 ? starFilled : starEmpty;
            picStar4.Image = count >= 4 ? starFilled : starEmpty;
            picStar5.Image = count >= 5 ? starFilled : starEmpty;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rating == 0)
            {
                MessageBox.Show("Vui lòng chọn số sao đánh giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Tạo đối tượng đánh giá
                Rating newRating = new Rating
                {
                    OrderID = order.OrderID,
                    UserID = order.UserID,
                    RatingValue = rating,
                    Comment = txtComment.Text,
                    RatingDate = DateTime.Now
                };

                // Lưu đánh giá vào cơ sở dữ liệu
                if (RatingDAO.SaveRating(newRating))
                {
                    MessageBox.Show("Cảm ơn bạn đã đánh giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể lưu đánh giá! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gửi đánh giá: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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