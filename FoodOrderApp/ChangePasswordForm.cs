using System;
using System.Drawing;
using System.Windows.Forms;

namespace FoodOrderApp
{
    public partial class ChangePasswordForm : Form
    {
        private int userID;
        private string currentPassword;
        public string NewPassword { get; private set; }

        public ChangePasswordForm(int userID, string currentPassword)
        {
            InitializeComponent();
            this.userID = userID;
            this.currentPassword = currentPassword;
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            // Thiết lập một số thuộc tính cho form
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"current pass: {currentPassword}");
            // Kiểm tra mật khẩu hiện tại
            // check lai bug nay =============================================================================
            //if (txtCurrentPassword.Text != currentPassword)
            if (!UserDAO.VerifyPassword(userID, txtCurrentPassword.Text))
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCurrentPassword.Focus();
                return;
            }

            // Kiểm tra mật khẩu mới
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            // Kiểm tra xác nhận mật khẩu
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return;
            }

            try
            {
                // Cập nhật mật khẩu
                if (UserDAO.UpdatePassword(userID, txtNewPassword.Text))
                {
                    NewPassword = txtNewPassword.Text;
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể đổi mật khẩu! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}