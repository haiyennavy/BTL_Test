namespace FoodOrderApp
{
    partial class RatingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlRating = new System.Windows.Forms.Panel();
            this.picStar5 = new System.Windows.Forms.PictureBox();
            this.picStar4 = new System.Windows.Forms.PictureBox();
            this.picStar3 = new System.Windows.Forms.PictureBox();
            this.picStar2 = new System.Windows.Forms.PictureBox();
            this.picStar1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlRating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(500, 60);
            this.pnlHeader.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(449, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 36);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(193, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Đánh giá món ăn";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.lblOrderID.Location = new System.Drawing.Point(17, 17);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(163, 23);
            this.lblOrderID.TabIndex = 2;
            this.lblOrderID.Text = "Đơn hàng #000000";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtComment);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pnlRating);
            this.panel1.Controls.Add(this.lblOrderID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 390);
            this.panel1.TabIndex = 3;
            // 
            // pnlRating
            // 
            this.pnlRating.Controls.Add(this.picStar5);
            this.pnlRating.Controls.Add(this.picStar4);
            this.pnlRating.Controls.Add(this.picStar3);
            this.pnlRating.Controls.Add(this.picStar2);
            this.pnlRating.Controls.Add(this.picStar1);
            this.pnlRating.Location = new System.Drawing.Point(21, 84);
            this.pnlRating.Name = "pnlRating";
            this.pnlRating.Size = new System.Drawing.Size(458, 66);
            this.pnlRating.TabIndex = 3;
            // 
            // picStar5
            // 
            this.picStar5.Location = new System.Drawing.Point(374, 13);
            this.picStar5.Name = "picStar5";
            this.picStar5.Size = new System.Drawing.Size(40, 40);
            this.picStar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStar5.TabIndex = 4;
            this.picStar5.TabStop = false;
            this.picStar5.Tag = "5";
            this.picStar5.Click += new System.EventHandler(this.StarClick);
            this.picStar5.MouseEnter += new System.EventHandler(this.StarMouseEnter);
            this.picStar5.MouseLeave += new System.EventHandler(this.StarMouseLeave);
            // 
            // picStar4
            // 
            this.picStar4.Location = new System.Drawing.Point(283, 13);
            this.picStar4.Name = "picStar4";
            this.picStar4.Size = new System.Drawing.Size(40, 40);
            this.picStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStar4.TabIndex = 3;
            this.picStar4.TabStop = false;
            this.picStar4.Tag = "4";
            this.picStar4.Click += new System.EventHandler(this.StarClick);
            this.picStar4.MouseEnter += new System.EventHandler(this.StarMouseEnter);
            this.picStar4.MouseLeave += new System.EventHandler(this.StarMouseLeave);
            // 
            // picStar3
            // 
            this.picStar3.Location = new System.Drawing.Point(196, 13);
            this.picStar3.Name = "picStar3";
            this.picStar3.Size = new System.Drawing.Size(40, 40);
            this.picStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStar3.TabIndex = 2;
            this.picStar3.TabStop = false;
            this.picStar3.Tag = "3";
            this.picStar3.Click += new System.EventHandler(this.StarClick);
            this.picStar3.MouseEnter += new System.EventHandler(this.StarMouseEnter);
            this.picStar3.MouseLeave += new System.EventHandler(this.StarMouseLeave);
            // 
            // picStar2
            // 
            this.picStar2.Location = new System.Drawing.Point(109, 13);
            this.picStar2.Name = "picStar2";
            this.picStar2.Size = new System.Drawing.Size(40, 40);
            this.picStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStar2.TabIndex = 1;
            this.picStar2.TabStop = false;
            this.picStar2.Tag = "2";
            this.picStar2.Click += new System.EventHandler(this.StarClick);
            this.picStar2.MouseEnter += new System.EventHandler(this.StarMouseEnter);
            this.picStar2.MouseLeave += new System.EventHandler(this.StarMouseLeave);
            // 
            // picStar1
            // 
            this.picStar1.Location = new System.Drawing.Point(23, 13);
            this.picStar1.Name = "picStar1";
            this.picStar1.Size = new System.Drawing.Size(40, 40);
            this.picStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStar1.TabIndex = 0;
            this.picStar1.TabStop = false;
            this.picStar1.Tag = "1";
            this.picStar1.Click += new System.EventHandler(this.StarClick);
            this.picStar1.MouseEnter += new System.EventHandler(this.StarMouseEnter);
            this.picStar1.MouseLeave += new System.EventHandler(this.StarMouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bạn đánh giá bao nhiêu sao?";
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Location = new System.Drawing.Point(21, 187);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(458, 135);
            this.txtComment.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Viết nhận xét của bạn:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(293, 337);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(142, 41);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Gửi đánh giá";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(159, 337);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 41);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // RatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RatingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RatingForm";
            this.Load += new System.EventHandler(this.RatingForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlRating.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlRating;
        private System.Windows.Forms.PictureBox picStar5;
        private System.Windows.Forms.PictureBox picStar4;
        private System.Windows.Forms.PictureBox picStar3;
        private System.Windows.Forms.PictureBox picStar2;
        private System.Windows.Forms.PictureBox picStar1;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
    }
}