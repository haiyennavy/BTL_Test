namespace FoodOrderApp
{
    partial class OrderHistoryForm
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
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.lvOrders = new System.Windows.Forms.ListView();
            this.columnOrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOrderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlOrderDetails = new System.Windows.Forms.Panel();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPaymentMethod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRate = new System.Windows.Forms.Button();
            this.lvOrderDetails = new System.Windows.Forms.ListView();
            this.columnFoodName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSubtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlOrders.SuspendLayout();
            this.pnlOrderDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(973, 49);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(928, 10);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 29);
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
            this.lblTitle.Location = new System.Drawing.Point(9, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(173, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Lịch Sử Đơn Hàng";
            // 
            // pnlOrders
            // 
            this.pnlOrders.Controls.Add(this.lvOrders);
            this.pnlOrders.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOrders.Location = new System.Drawing.Point(0, 49);
            this.pnlOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.pnlOrders.Size = new System.Drawing.Size(385, 439);
            this.pnlOrders.TabIndex = 1;
            // 
            // lvOrders
            // 
            this.lvOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnOrderID,
            this.columnOrderDate,
            this.columnTotal,
            this.columnStatus});
            this.lvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvOrders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvOrders.FullRowSelect = true;
            this.lvOrders.GridLines = true;
            this.lvOrders.HideSelection = false;
            this.lvOrders.Location = new System.Drawing.Point(8, 8);
            this.lvOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvOrders.MultiSelect = false;
            this.lvOrders.Name = "lvOrders";
            this.lvOrders.Size = new System.Drawing.Size(369, 423);
            this.lvOrders.TabIndex = 0;
            this.lvOrders.UseCompatibleStateImageBehavior = false;
            this.lvOrders.View = System.Windows.Forms.View.Details;
            this.lvOrders.SelectedIndexChanged += new System.EventHandler(this.lvOrders_SelectedIndexChanged);
            // 
            // columnOrderID
            // 
            this.columnOrderID.Text = "Mã ĐH";
            this.columnOrderID.Width = 70;
            // 
            // columnOrderDate
            // 
            this.columnOrderDate.Text = "Ngày đặt";
            this.columnOrderDate.Width = 100;
            // 
            // columnTotal
            // 
            this.columnTotal.Text = "Tổng tiền";
            this.columnTotal.Width = 100;
            // 
            // columnStatus
            // 
            this.columnStatus.Text = "Trạng thái";
            this.columnStatus.Width = 100;
            // 
            // pnlOrderDetails
            // 
            this.pnlOrderDetails.Controls.Add(this.btnRate);
            this.pnlOrderDetails.Controls.Add(this.txtNotes);
            this.pnlOrderDetails.Controls.Add(this.label7);
            this.pnlOrderDetails.Controls.Add(this.txtPaymentMethod);
            this.pnlOrderDetails.Controls.Add(this.label6);
            this.pnlOrderDetails.Controls.Add(this.txtPhone);
            this.pnlOrderDetails.Controls.Add(this.label5);
            this.pnlOrderDetails.Controls.Add(this.txtAddress);
            this.pnlOrderDetails.Controls.Add(this.label4);
            this.pnlOrderDetails.Controls.Add(this.lvOrderDetails);
            this.pnlOrderDetails.Controls.Add(this.label3);
            this.pnlOrderDetails.Controls.Add(this.txtStatus);
            this.pnlOrderDetails.Controls.Add(this.label2);
            this.pnlOrderDetails.Controls.Add(this.txtOrderDate);
            this.pnlOrderDetails.Controls.Add(this.label1);
            this.pnlOrderDetails.Controls.Add(this.lblOrderID);
            this.pnlOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrderDetails.Location = new System.Drawing.Point(385, 49);
            this.pnlOrderDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlOrderDetails.Name = "pnlOrderDetails";
            this.pnlOrderDetails.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.pnlOrderDetails.Size = new System.Drawing.Size(588, 439);
            this.pnlOrderDetails.TabIndex = 2;
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(117, 145);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ReadOnly = true;
            this.txtNotes.Size = new System.Drawing.Size(386, 41);
            this.txtNotes.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 147);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ghi chú:";
            // 
            // txtPaymentMethod
            // 
            this.txtPaymentMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentMethod.Location = new System.Drawing.Point(117, 117);
            this.txtPaymentMethod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPaymentMethod.Name = "txtPaymentMethod";
            this.txtPaymentMethod.ReadOnly = true;
            this.txtPaymentMethod.Size = new System.Drawing.Size(386, 23);
            this.txtPaymentMethod.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Phương thức T.toán:";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(321, 87);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(182, 23);
            this.txtPhone.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(253, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Điện thoại:";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(117, 89);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(132, 23);
            this.txtAddress.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Địa chỉ giao hàng:";
            // 
            // btnRate
            // 
            this.btnRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnRate.FlatAppearance.BorderSize = 0;
            this.btnRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRate.ForeColor = System.Drawing.Color.White;
            this.btnRate.Location = new System.Drawing.Point(240, 402);
            this.btnRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRate.Name = "btnRate";
            this.btnRate.Size = new System.Drawing.Size(88, 29);
            this.btnRate.TabIndex = 9;
            this.btnRate.Text = "Đánh giá";
            this.btnRate.UseVisualStyleBackColor = false;
            this.btnRate.Click += new System.EventHandler(this.btnRate_Click);
            // 
            // lvOrderDetails
            // 
            this.lvOrderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvOrderDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFoodName,
            this.columnQuantity,
            this.columnPrice,
            this.columnSubtotal});
            this.lvOrderDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvOrderDetails.FullRowSelect = true;
            this.lvOrderDetails.GridLines = true;
            this.lvOrderDetails.HideSelection = false;
            this.lvOrderDetails.Location = new System.Drawing.Point(10, 216);
            this.lvOrderDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvOrderDetails.Name = "lvOrderDetails";
            this.lvOrderDetails.Size = new System.Drawing.Size(578, 181);
            this.lvOrderDetails.TabIndex = 8;
            this.lvOrderDetails.UseCompatibleStateImageBehavior = false;
            this.lvOrderDetails.View = System.Windows.Forms.View.Details;
            // 
            // columnFoodName
            // 
            this.columnFoodName.Text = "Tên món";
            this.columnFoodName.Width = 230;
            // 
            // columnQuantity
            // 
            this.columnQuantity.Text = "Số lượng";
            this.columnQuantity.Width = 80;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Đơn giá";
            this.columnPrice.Width = 120;
            // 
            // columnSubtotal
            // 
            this.columnSubtotal.Text = "Thành tiền";
            this.columnSubtotal.Width = 140;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chi tiết đơn hàng:";
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(321, 60);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(182, 23);
            this.txtStatus.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trạng thái:";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderDate.Location = new System.Drawing.Point(117, 62);
            this.txtOrderDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(132, 23);
            this.txtOrderDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày đặt:";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.lblOrderID.Location = new System.Drawing.Point(10, 22);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(147, 21);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "Đơn hàng #000000";
            // 
            // OrderHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 488);
            this.Controls.Add(this.pnlOrderDetails);
            this.Controls.Add(this.pnlOrders);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OrderHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OrderHistoryForm";
            this.Load += new System.EventHandler(this.OrderHistoryForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlOrders.ResumeLayout(false);
            this.pnlOrderDetails.ResumeLayout(false);
            this.pnlOrderDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.ListView lvOrders;
        private System.Windows.Forms.ColumnHeader columnOrderID;
        private System.Windows.Forms.ColumnHeader columnOrderDate;
        private System.Windows.Forms.ColumnHeader columnTotal;
        private System.Windows.Forms.ColumnHeader columnStatus;
        private System.Windows.Forms.Panel pnlOrderDetails;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvOrderDetails;
        private System.Windows.Forms.ColumnHeader columnFoodName;
        private System.Windows.Forms.ColumnHeader columnQuantity;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnSubtotal;
        private System.Windows.Forms.Button btnRate;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPaymentMethod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
    }
}