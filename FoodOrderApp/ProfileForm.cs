using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FoodOrderApp
{
    public partial class ProfileForm : Form
    {
        private User currentUser;
        private User tempUser; // Để lưu thông tin tạm thời khi chỉnh sửa

        public ProfileForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            tempUser = new User
            {
                UserID = user.UserID,
                Username = user.Username,
                Password = user.Password,
                FullName = user.FullName,
                Phone = user.Phone,
                Email = user.Email,
                Address = user.Address,
                UserRole = user.UserRole
            };
            MessageBox.Show($"current pw {currentUser.Password}");
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            // Thiết lập một số thuộc tính cho form
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            // Hiển thị thông tin người dùng
            DisplayUserInfo();
        }

        private void DisplayUserInfo()
        {
            // Hiển thị avatar
            try
            {
                string avatarPath = Path.Combine(Application.StartupPath, "Images", "avatar.png");
                if (File.Exists(avatarPath))
                {
                    picAvatar.Image = Image.FromFile(avatarPath);
                }
            }
            catch { }

            // Hiển thị thông tin người dùng
            txtUsername.Text = tempUser.Username;
            txtFullName.Text = tempUser.FullName;
            txtPhone.Text = tempUser.Phone;
            txtEmail.Text = tempUser.Email ?? "";
            txtAddress.Text = tempUser.Address ?? "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            // Cập nhật thông tin tạm thời
            tempUser.FullName = txtFullName.Text.Trim();
            tempUser.Phone = txtPhone.Text.Trim();
            tempUser.Email = txtEmail.Text.Trim();
            tempUser.Address = txtAddress.Text.Trim();

            try
            {
                // Lưu thông tin người dùng vào cơ sở dữ liệu
                if (UserDAO.UpdateUserInfo(tempUser))
                {
                    // Cập nhật thông tin người dùng hiện tại
                    currentUser.FullName = tempUser.FullName;
                    currentUser.Phone = tempUser.Phone;
                    currentUser.Email = tempUser.Email;
                    currentUser.Address = tempUser.Address;

                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật thông tin! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            // Mở form đổi mật khẩu
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(currentUser.UserID, currentUser.Password);
            if (changePasswordForm.ShowDialog() == DialogResult.OK)
            {
                // Cập nhật mật khẩu cho người dùng hiện tại và người dùng tạm
                string newPassword = changePasswordForm.NewPassword;
                currentUser.Password = newPassword;
                tempUser.Password = newPassword;

                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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