namespace FoodOrderApp
{
    partial class UserRatingsViewForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvRatings = new System.Windows.Forms.ListView();
            this.colOrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOrderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRatingDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlRatingDetails = new System.Windows.Forms.Panel();
            this.lvOrderDetails = new System.Windows.Forms.ListView();
            this.colFoodName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlStars = new System.Windows.Forms.Panel();
            this.picStar5 = new System.Windows.Forms.PictureBox();
            this.picStar4 = new System.Windows.Forms.PictureBox();
            this.picStar3 = new System.Windows.Forms.PictureBox();
            this.picStar2 = new System.Windows.Forms.PictureBox();
            this.picStar1 = new System.Windows.Forms.PictureBox();
            this.lblRatingDate = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlRatingDetails.SuspendLayout();
            this.pnlStars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(854, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 50);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Đánh giá của bạn";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvRatings);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlRatingDetails);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Size = new System.Drawing.Size(900, 500);
            this.splitContainer1.SplitterDistance = 450;
            this.splitContainer1.TabIndex = 1;
            // 
            // lvRatings
            // 
            this.lvRatings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colOrderID,
            this.colOrderDate,
            this.colFood,
            this.colRating,
            this.colRatingDate});
            this.lvRatings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRatings.FullRowSelect = true;
            this.lvRatings.GridLines = true;
            this.lvRatings.HideSelection = false;
            this.lvRatings.Location = new System.Drawing.Point(10, 10);
            this.lvRatings.MultiSelect = false;
            this.lvRatings.Name = "lvRatings";
            this.lvRatings.Size = new System.Drawing.Size(430, 480);
            this.lvRatings.TabIndex = 0;
            this.lvRatings.UseCompatibleStateImageBehavior = false;
            this.lvRatings.View = System.Windows.Forms.View.Details;
            this.lvRatings.SelectedIndexChanged += new System.EventHandler(this.lvRatings_SelectedIndexChanged);
            // 
            // colOrderID
            // 
            this.colOrderID.Text = "Mã ĐH";
            this.colOrderID.Width = 55;
            // 
            // colOrderDate
            // 
            this.colOrderDate.Text = "Ngày đặt";
            this.colOrderDate.Width = 90;
            // 
            // colFood
            // 
            this.colFood.Text = "Món ăn";
            this.colFood.Width = 120;
            // 
            // colRating
            // 
            this.colRating.Text = "Đánh giá";
            this.colRating.Width = 65;
            // 
            // colRatingDate
            // 
            this.colRatingDate.Text = "Ngày đánh giá";
            this.colRatingDate.Width = 90;
            // 
            // pnlRatingDetails
            // 
            this.pnlRatingDetails.BackColor = System.Drawing.Color.White;
            this.pnlRatingDetails.Controls.Add(this.lvOrderDetails);
            this.pnlRatingDetails.Controls.Add(this.label2);
            this.pnlRatingDetails.Controls.Add(this.txtComment);
            this.pnlRatingDetails.Controls.Add(this.label1);
            this.pnlRatingDetails.Controls.Add(this.pnlStars);
            this.pnlRatingDetails.Controls.Add(this.lblRatingDate);
            this.pnlRatingDetails.Controls.Add(this.lblOrderID);
            this.pnlRatingDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRatingDetails.Location = new System.Drawing.Point(10, 10);
            this.pnlRatingDetails.Name = "pnlRatingDetails";
            this.pnlRatingDetails.Size = new System.Drawing.Size(426, 480);
            this.pnlRatingDetails.TabIndex = 0;
            // 
            // lvOrderDetails
            // 
            this.lvOrderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvOrderDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFoodName,
            this.colQuantity,
            this.colPrice});
            this.lvOrderDetails.GridLines = true;
            this.lvOrderDetails.HideSelection = false;
            this.lvOrderDetails.Location = new System.Drawing.Point(18, 300);
            this.lvOrderDetails.Name = "lvOrderDetails";
            this.lvOrderDetails.Size = new System.Drawing.Size(392, 165);
            this.lvOrderDetails.TabIndex = 6;
            this.lvOrderDetails.UseCompatibleStateImageBehavior = false;
            this.lvOrderDetails.View = System.Windows.Forms.View.Details;
            // 
            // colFoodName
            // 
            this.colFoodName.Text = "Tên món";
            this.colFoodName.Width = 220;
            // 
            // colQuantity
            // 
            this.colQuantity.Text = "Số lượng";
            this.colQuantity.Width = 65;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Đơn giá";
            this.colPrice.Width = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chi tiết đơn hàng";
            // 
            // txtComment
            // 
            this.txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComment.Location = new System.Drawing.Point(18, 140);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ReadOnly = true;
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComment.Size = new System.Drawing.Size(392, 120);
            this.txtComment.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhận xét";
            // 
            // pnlStars
            // 
            this.pnlStars.Controls.Add(this.picStar5);
            this.pnlStars.Controls.Add(this.picStar4);
            this.pnlStars.Controls.Add(this.picStar3);
            this.pnlStars.Controls.Add(this.picStar2);
            this.pnlStars.Controls.Add(this.picStar1);
            this.pnlStars.Location = new System.Drawing.Point(18, 70);
            this.pnlStars.Name = "pnlStars";
            this.pnlStars.Size = new System.Drawing.Size(250, 40);
            this.pnlStars.TabIndex = 2;
            // 
            // picStar5
            // 
            this.picStar5.Location = new System.Drawing.Point(200, 0);
            this.picStar5.Name = "picStar5";
            this.picStar5.Size = new System.Drawing.Size(40, 40);
            this.picStar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStar5.TabIndex = 4;
            this.picStar5.TabStop = false;
            // 
            // picStar4
            // 
            this.picStar4.Location = new System.Drawing.Point(150, 0);
            this.picStar4.Name = "picStar4";
            this.picStar4.Size = new System.Drawing.Size(40, 40);
            this.picStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStar4.TabIndex = 3;
            this.picStar4.TabStop = false;
            // 
            // picStar3
            // 
            this.picStar3.Location = new System.Drawing.Point(100, 0);
            this.picStar3.Name = "picStar3";
            this.picStar3.Size = new System.Drawing.Size(40, 40);
            this.picStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStar3.TabIndex = 2;
            this.picStar3.TabStop = false;
            // 
            // picStar2
            // 
            this.picStar2.Location = new System.Drawing.Point(50, 0);
            this.picStar2.Name = "picStar2";
            this.picStar2.Size = new System.Drawing.Size(40, 40);
            this.picStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStar2.TabIndex = 1;
            this.picStar2.TabStop = false;
            // 
            // picStar1
            // 
            this.picStar1.Location = new System.Drawing.Point(0, 0);
            this.picStar1.Name = "picStar1";
            this.picStar1.Size = new System.Drawing.Size(40, 40);
            this.picStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStar1.TabIndex = 0;
            this.picStar1.TabStop = false;
            // 
            // lblRatingDate
            // 
            this.lblRatingDate.AutoSize = true;
            this.lblRatingDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatingDate.Location = new System.Drawing.Point(15, 40);
            this.lblRatingDate.Name = "lblRatingDate";
            this.lblRatingDate.Size = new System.Drawing.Size(126, 17);
            this.lblRatingDate.TabIndex = 1;
            this.lblRatingDate.Text = "Đánh giá ngày: --/--";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(14, 14);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(138, 21);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "Đơn hàng #0000";
            // 
            // UserRatingsViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserRatingsViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đánh giá của bạn";
            this.Load += new System.EventHandler(this.UserRatingsViewForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlRatingDetails.ResumeLayout(false);
            this.pnlRatingDetails.PerformLayout();
            this.pnlStars.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lvRatings;
        private System.Windows.Forms.ColumnHeader colOrderID;
        private System.Windows.Forms.ColumnHeader colOrderDate;
        private System.Windows.Forms.ColumnHeader colFood;
        private System.Windows.Forms.ColumnHeader colRating;
        private System.Windows.Forms.ColumnHeader colRatingDate;
        private System.Windows.Forms.Panel pnlRatingDetails;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblRatingDate;
        private System.Windows.Forms.Panel pnlStars;
        private System.Windows.Forms.PictureBox picStar5;
        private System.Windows.Forms.PictureBox picStar4;
        private System.Windows.Forms.PictureBox picStar3;
        private System.Windows.Forms.PictureBox picStar2;
        private System.Windows.Forms.PictureBox picStar1;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvOrderDetails;
        private System.Windows.Forms.ColumnHeader colFoodName;
        private System.Windows.Forms.ColumnHeader colQuantity;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.Label label2;
    }
}