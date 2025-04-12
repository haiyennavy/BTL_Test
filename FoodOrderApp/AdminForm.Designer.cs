using System;
using System.Windows.Forms;

namespace FoodOrderApp
{
    partial class AdminForm
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnFoods = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.picAppLogo = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlUserManagement = new System.Windows.Forms.Panel();
            this.pnlUserDetail = new System.Windows.Forms.Panel();
            this.cboUserRole = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnCancelUser = new System.Windows.Forms.Button();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.txtUserAddress = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtUserPhone = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtUserFullName = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.pnlUserList = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblRevenueValue = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCompletedOrdersValue = new System.Windows.Forms.Label();
            this.lblCompletedOrders = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPendingOrdersValue = new System.Windows.Forms.Label();
            this.lblPendingOrders = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalOrdersValue = new System.Windows.Forms.Label();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.pnlFoodManagement = new System.Windows.Forms.Panel();
            this.pnlFoodDetail = new System.Windows.Forms.Panel();
            this.btnCancelFood = new System.Windows.Forms.Button();
            this.btnSaveFood = new System.Windows.Forms.Button();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.picFoodImage = new System.Windows.Forms.PictureBox();
            this.chkIsAvailable = new System.Windows.Forms.CheckBox();
            this.cboFoodCategory = new System.Windows.Forms.ComboBox();
            this.txtFoodPrice = new System.Windows.Forms.TextBox();
            this.txtFoodDescription = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFoodQuantity = new System.Windows.Forms.Label();
            this.numFoodQuantity = new System.Windows.Forms.NumericUpDown();
            this.pnlFoodList = new System.Windows.Forms.Panel();
            this.dgvFoods = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.txtSearchFood = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlCategoryManagement = new System.Windows.Forms.Panel();
            this.pnlCategoryDetail = new System.Windows.Forms.Panel();
            this.btnCancelCategory = new System.Windows.Forms.Button();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.txtCategoryDescription = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlCategoryList = new System.Windows.Forms.Panel();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtSearchCategory = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlOrderManagement = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtpOrderTo = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.dtpOrderFrom = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.cboOrderStatus = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSearchOrder = new System.Windows.Forms.Button();
            this.txtSearchOrder = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlOrderDetail = new System.Windows.Forms.Panel();
            this.cboNewStatus = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.txtOrderNotes = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtOrderAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtOrderCustomer = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnRevenueReport = new System.Windows.Forms.Button();
            this.btnManageRatings = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAppLogo)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlUserManagement.SuspendLayout();
            this.pnlUserDetail.SuspendLayout();
            this.pnlUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.panel8.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlFoodManagement.SuspendLayout();
            this.pnlFoodDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoodImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFoodQuantity)).BeginInit();
            this.pnlFoodList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).BeginInit();
            this.panel5.SuspendLayout();
            this.pnlCategoryManagement.SuspendLayout();
            this.pnlCategoryDetail.SuspendLayout();
            this.pnlCategoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.panel7.SuspendLayout();
            this.pnlOrderManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.panel6.SuspendLayout();
            this.pnlOrderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.pnlSidebar.Controls.Add(this.btnManageRatings);
            this.pnlSidebar.Controls.Add(this.btnReport);
            this.pnlSidebar.Controls.Add(this.btnFoods);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnUsers);
            this.pnlSidebar.Controls.Add(this.btnOrders);
            this.pnlSidebar.Controls.Add(this.btnCategories);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.lblAdminName);
            this.pnlSidebar.Controls.Add(this.lblAppName);
            this.pnlSidebar.Controls.Add(this.picAppLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(188, 618);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 289);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(188, 41);
            this.btnReport.TabIndex = 9;
            this.btnReport.Text = "  Báo cáo";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnFoods
            // 
            this.btnFoods.FlatAppearance.BorderSize = 0;
            this.btnFoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoods.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoods.ForeColor = System.Drawing.Color.White;
            this.btnFoods.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoods.Location = new System.Drawing.Point(0, 133);
            this.btnFoods.Margin = new System.Windows.Forms.Padding(2);
            this.btnFoods.Name = "btnFoods";
            this.btnFoods.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnFoods.Size = new System.Drawing.Size(188, 41);
            this.btnFoods.TabIndex = 4;
            this.btnFoods.Text = "  Món ăn";
            this.btnFoods.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoods.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFoods.UseVisualStyleBackColor = true;
            this.btnFoods.Click += new System.EventHandler(this.btnFoods_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 578);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(188, 41);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "  Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 255);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(188, 41);
            this.btnUsers.TabIndex = 7;
            this.btnUsers.Text = "  Người dùng";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(0, 214);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnOrders.Size = new System.Drawing.Size(188, 41);
            this.btnOrders.TabIndex = 6;
            this.btnOrders.Text = "  Đơn hàng";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.ForeColor = System.Drawing.Color.White;
            this.btnCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.Location = new System.Drawing.Point(0, 174);
            this.btnCategories.Margin = new System.Windows.Forms.Padding(2);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnCategories.Size = new System.Drawing.Size(188, 41);
            this.btnCategories.TabIndex = 5;
            this.btnCategories.Text = "  Danh mục";
            this.btnCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 93);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(188, 41);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "  Tổng quan";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // lblAdminName
            // 
            this.lblAdminName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.ForeColor = System.Drawing.Color.White;
            this.lblAdminName.Location = new System.Drawing.Point(0, 66);
            this.lblAdminName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(188, 19);
            this.lblAdminName.TabIndex = 2;
            this.lblAdminName.Text = "Admin";
            this.lblAdminName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(50, 20);
            this.lblAppName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(117, 25);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "FoodAdmin";
            // 
            // picAppLogo
            // 
            this.picAppLogo.ErrorImage = null;
            this.picAppLogo.Location = new System.Drawing.Point(9, 10);
            this.picAppLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picAppLogo.Name = "picAppLogo";
            this.picAppLogo.Size = new System.Drawing.Size(36, 39);
            this.picAppLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAppLogo.TabIndex = 0;
            this.picAppLogo.TabStop = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(188, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(760, 49);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(13, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tổng quan";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlFoodManagement);
            this.pnlMain.Controls.Add(this.pnlCategoryManagement);
            this.pnlMain.Controls.Add(this.pnlOrderManagement);
            this.pnlMain.Controls.Add(this.pnlUserManagement);
            this.pnlMain.Controls.Add(this.pnlDashboard);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(188, 49);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(760, 569);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlUserManagement
            // 
            this.pnlUserManagement.Controls.Add(this.pnlUserDetail);
            this.pnlUserManagement.Controls.Add(this.pnlUserList);
            this.pnlUserManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserManagement.Location = new System.Drawing.Point(0, 0);
            this.pnlUserManagement.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUserManagement.Name = "pnlUserManagement";
            this.pnlUserManagement.Size = new System.Drawing.Size(760, 569);
            this.pnlUserManagement.TabIndex = 4;
            // 
            // pnlUserDetail
            // 
            this.pnlUserDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUserDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUserDetail.Controls.Add(this.cboUserRole);
            this.pnlUserDetail.Controls.Add(this.label28);
            this.pnlUserDetail.Controls.Add(this.btnResetPassword);
            this.pnlUserDetail.Controls.Add(this.btnCancelUser);
            this.pnlUserDetail.Controls.Add(this.btnSaveUser);
            this.pnlUserDetail.Controls.Add(this.txtUserAddress);
            this.pnlUserDetail.Controls.Add(this.label27);
            this.pnlUserDetail.Controls.Add(this.txtUserEmail);
            this.pnlUserDetail.Controls.Add(this.label26);
            this.pnlUserDetail.Controls.Add(this.txtUserPhone);
            this.pnlUserDetail.Controls.Add(this.label25);
            this.pnlUserDetail.Controls.Add(this.txtUserFullName);
            this.pnlUserDetail.Controls.Add(this.label24);
            this.pnlUserDetail.Controls.Add(this.txtUsername);
            this.pnlUserDetail.Controls.Add(this.label23);
            this.pnlUserDetail.Location = new System.Drawing.Point(14, 365);
            this.pnlUserDetail.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUserDetail.Name = "pnlUserDetail";
            this.pnlUserDetail.Size = new System.Drawing.Size(733, 194);
            this.pnlUserDetail.TabIndex = 5;
            // 
            // cboUserRole
            // 
            this.cboUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUserRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUserRole.FormattingEnabled = true;
            this.cboUserRole.Items.AddRange(new object[] {
            "Customer",
            "Admin"});
            this.cboUserRole.Location = new System.Drawing.Point(362, 66);
            this.cboUserRole.Margin = new System.Windows.Forms.Padding(2);
            this.cboUserRole.Name = "cboUserRole";
            this.cboUserRole.Size = new System.Drawing.Size(122, 23);
            this.cboUserRole.TabIndex = 25;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(277, 68);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(43, 15);
            this.label28.TabIndex = 24;
            this.label28.Text = "Vai trò:";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnResetPassword.FlatAppearance.BorderSize = 0;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.Location = new System.Drawing.Point(437, 148);
            this.btnResetPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(90, 32);
            this.btnResetPassword.TabIndex = 23;
            this.btnResetPassword.Text = "Đặt lại MK";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnCancelUser
            // 
            this.btnCancelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancelUser.FlatAppearance.BorderSize = 0;
            this.btnCancelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelUser.ForeColor = System.Drawing.Color.White;
            this.btnCancelUser.Location = new System.Drawing.Point(531, 148);
            this.btnCancelUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelUser.Name = "btnCancelUser";
            this.btnCancelUser.Size = new System.Drawing.Size(90, 32);
            this.btnCancelUser.TabIndex = 15;
            this.btnCancelUser.Text = "Hủy";
            this.btnCancelUser.UseVisualStyleBackColor = false;
            this.btnCancelUser.Click += new System.EventHandler(this.btnCancelUser_Click);
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnSaveUser.FlatAppearance.BorderSize = 0;
            this.btnSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUser.ForeColor = System.Drawing.Color.White;
            this.btnSaveUser.Location = new System.Drawing.Point(626, 148);
            this.btnSaveUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(90, 32);
            this.btnSaveUser.TabIndex = 14;
            this.btnSaveUser.Text = "Lưu";
            this.btnSaveUser.UseVisualStyleBackColor = false;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // txtUserAddress
            // 
            this.txtUserAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserAddress.Location = new System.Drawing.Point(100, 119);
            this.txtUserAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserAddress.Name = "txtUserAddress";
            this.txtUserAddress.Size = new System.Drawing.Size(616, 23);
            this.txtUserAddress.TabIndex = 22;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(14, 121);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(46, 15);
            this.label27.TabIndex = 21;
            this.label27.Text = "Địa chỉ:";
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserEmail.Location = new System.Drawing.Point(100, 92);
            this.txtUserEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(173, 23);
            this.txtUserEmail.TabIndex = 20;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(14, 94);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(39, 15);
            this.label26.TabIndex = 19;
            this.label26.Text = "Email:";
            // 
            // txtUserPhone
            // 
            this.txtUserPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPhone.Location = new System.Drawing.Point(100, 66);
            this.txtUserPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserPhone.Name = "txtUserPhone";
            this.txtUserPhone.Size = new System.Drawing.Size(173, 23);
            this.txtUserPhone.TabIndex = 18;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(14, 68);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(64, 15);
            this.label25.TabIndex = 17;
            this.label25.Text = "Điện thoại:";
            // 
            // txtUserFullName
            // 
            this.txtUserFullName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserFullName.Location = new System.Drawing.Point(362, 39);
            this.txtUserFullName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserFullName.Name = "txtUserFullName";
            this.txtUserFullName.Size = new System.Drawing.Size(354, 23);
            this.txtUserFullName.TabIndex = 16;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(277, 41);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 15);
            this.label24.TabIndex = 15;
            this.label24.Text = "Họ và tên:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(100, 39);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(173, 23);
            this.txtUsername.TabIndex = 14;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(14, 41);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(61, 15);
            this.label23.TabIndex = 13;
            this.label23.Text = "Tài khoản:";
            // 
            // pnlUserList
            // 
            this.pnlUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUserList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUserList.Controls.Add(this.dgvUsers);
            this.pnlUserList.Controls.Add(this.panel8);
            this.pnlUserList.Location = new System.Drawing.Point(14, 15);
            this.pnlUserList.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUserList.Name = "pnlUserList";
            this.pnlUserList.Size = new System.Drawing.Size(733, 345);
            this.pnlUserList.TabIndex = 4;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(0, 49);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(731, 294);
            this.dgvUsers.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnDeleteUser);
            this.panel8.Controls.Add(this.btnEditUser);
            this.panel8.Controls.Add(this.btnAddUser);
            this.panel8.Controls.Add(this.txtSearchUser);
            this.panel8.Controls.Add(this.label29);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(731, 49);
            this.panel8.TabIndex = 1;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(656, 11);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(60, 26);
            this.btnDeleteUser.TabIndex = 4;
            this.btnDeleteUser.Text = "Xóa";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditUser.FlatAppearance.BorderSize = 0;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.ForeColor = System.Drawing.Color.White;
            this.btnEditUser.Location = new System.Drawing.Point(591, 11);
            this.btnEditUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(60, 26);
            this.btnEditUser.TabIndex = 3;
            this.btnEditUser.Text = "Sửa";
            this.btnEditUser.UseVisualStyleBackColor = false;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(527, 11);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(60, 26);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Thêm";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchUser.Location = new System.Drawing.Point(83, 14);
            this.txtSearchUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(432, 23);
            this.txtSearchUser.TabIndex = 1;
            this.txtSearchUser.TextChanged += new System.EventHandler(this.txtSearchUser_TextChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(13, 16);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(60, 15);
            this.label29.TabIndex = 0;
            this.label29.Text = "Tìm kiếm:";
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.tableLayoutPanel1);
            this.pnlDashboard.Controls.Add(this.lblDashboardTitle);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(760, 569);
            this.pnlDashboard.TabIndex = 0;
            this.pnlDashboard.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 50);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(725, 98);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(83)))));
            this.panel4.Controls.Add(this.lblRevenueValue);
            this.panel4.Controls.Add(this.lblRevenue);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(545, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(178, 94);
            this.panel4.TabIndex = 3;
            // 
            // lblRevenueValue
            // 
            this.lblRevenueValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRevenueValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueValue.Location = new System.Drawing.Point(0, 41);
            this.lblRevenueValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRevenueValue.Name = "lblRevenueValue";
            this.lblRevenueValue.Size = new System.Drawing.Size(178, 33);
            this.lblRevenueValue.TabIndex = 1;
            this.lblRevenueValue.Text = "0₫";
            this.lblRevenueValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRevenue
            // 
            this.lblRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRevenue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenue.Location = new System.Drawing.Point(0, 11);
            this.lblRevenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(178, 20);
            this.lblRevenue.TabIndex = 0;
            this.lblRevenue.Text = "Doanh thu";
            this.lblRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.lblCompletedOrdersValue);
            this.panel3.Controls.Add(this.lblCompletedOrders);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(364, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(177, 94);
            this.panel3.TabIndex = 2;
            // 
            // lblCompletedOrdersValue
            // 
            this.lblCompletedOrdersValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompletedOrdersValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletedOrdersValue.Location = new System.Drawing.Point(0, 41);
            this.lblCompletedOrdersValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompletedOrdersValue.Name = "lblCompletedOrdersValue";
            this.lblCompletedOrdersValue.Size = new System.Drawing.Size(177, 33);
            this.lblCompletedOrdersValue.TabIndex = 1;
            this.lblCompletedOrdersValue.Text = "0";
            this.lblCompletedOrdersValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompletedOrders
            // 
            this.lblCompletedOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompletedOrders.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletedOrders.Location = new System.Drawing.Point(0, 11);
            this.lblCompletedOrders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompletedOrders.Name = "lblCompletedOrders";
            this.lblCompletedOrders.Size = new System.Drawing.Size(177, 20);
            this.lblCompletedOrders.TabIndex = 0;
            this.lblCompletedOrders.Text = "Đơn hàng đã giao";
            this.lblCompletedOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.lblPendingOrdersValue);
            this.panel2.Controls.Add(this.lblPendingOrders);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(183, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 94);
            this.panel2.TabIndex = 1;
            // 
            // lblPendingOrdersValue
            // 
            this.lblPendingOrdersValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPendingOrdersValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingOrdersValue.Location = new System.Drawing.Point(0, 41);
            this.lblPendingOrdersValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPendingOrdersValue.Name = "lblPendingOrdersValue";
            this.lblPendingOrdersValue.Size = new System.Drawing.Size(177, 33);
            this.lblPendingOrdersValue.TabIndex = 1;
            this.lblPendingOrdersValue.Text = "0";
            this.lblPendingOrdersValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPendingOrders
            // 
            this.lblPendingOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPendingOrders.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingOrders.Location = new System.Drawing.Point(0, 11);
            this.lblPendingOrders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPendingOrders.Name = "lblPendingOrders";
            this.lblPendingOrders.Size = new System.Drawing.Size(177, 20);
            this.lblPendingOrders.TabIndex = 0;
            this.lblPendingOrders.Text = "Đơn hàng chờ xử lý";
            this.lblPendingOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblTotalOrdersValue);
            this.panel1.Controls.Add(this.lblTotalOrders);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 94);
            this.panel1.TabIndex = 0;
            // 
            // lblTotalOrdersValue
            // 
            this.lblTotalOrdersValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalOrdersValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrdersValue.Location = new System.Drawing.Point(0, 41);
            this.lblTotalOrdersValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalOrdersValue.Name = "lblTotalOrdersValue";
            this.lblTotalOrdersValue.Size = new System.Drawing.Size(177, 33);
            this.lblTotalOrdersValue.TabIndex = 1;
            this.lblTotalOrdersValue.Text = "0";
            this.lblTotalOrdersValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalOrders.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrders.Location = new System.Drawing.Point(0, 11);
            this.lblTotalOrders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(177, 20);
            this.lblTotalOrders.TabIndex = 0;
            this.lblTotalOrders.Text = "Tổng số đơn hàng";
            this.lblTotalOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardTitle.Location = new System.Drawing.Point(14, 15);
            this.lblDashboardTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(127, 21);
            this.lblDashboardTitle.TabIndex = 0;
            this.lblDashboardTitle.Text = "Thống kê chung";
            // 
            // pnlFoodManagement
            // 
            this.pnlFoodManagement.Controls.Add(this.pnlFoodDetail);
            this.pnlFoodManagement.Controls.Add(this.pnlFoodList);
            this.pnlFoodManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFoodManagement.Location = new System.Drawing.Point(0, 0);
            this.pnlFoodManagement.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFoodManagement.Name = "pnlFoodManagement";
            this.pnlFoodManagement.Size = new System.Drawing.Size(760, 569);
            this.pnlFoodManagement.TabIndex = 1;
            // 
            // pnlFoodDetail
            // 
            this.pnlFoodDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFoodDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFoodDetail.Controls.Add(this.btnCancelFood);
            this.pnlFoodDetail.Controls.Add(this.btnSaveFood);
            this.pnlFoodDetail.Controls.Add(this.btnBrowseImage);
            this.pnlFoodDetail.Controls.Add(this.picFoodImage);
            this.pnlFoodDetail.Controls.Add(this.chkIsAvailable);
            this.pnlFoodDetail.Controls.Add(this.cboFoodCategory);
            this.pnlFoodDetail.Controls.Add(this.txtFoodPrice);
            this.pnlFoodDetail.Controls.Add(this.txtFoodDescription);
            this.pnlFoodDetail.Controls.Add(this.txtFoodName);
            this.pnlFoodDetail.Controls.Add(this.label5);
            this.pnlFoodDetail.Controls.Add(this.label4);
            this.pnlFoodDetail.Controls.Add(this.label3);
            this.pnlFoodDetail.Controls.Add(this.label2);
            this.pnlFoodDetail.Controls.Add(this.label1);
            this.pnlFoodDetail.Controls.Add(this.lblFoodQuantity);
            this.pnlFoodDetail.Controls.Add(this.numFoodQuantity);
            this.pnlFoodDetail.Location = new System.Drawing.Point(14, 365);
            this.pnlFoodDetail.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFoodDetail.Name = "pnlFoodDetail";
            this.pnlFoodDetail.Size = new System.Drawing.Size(733, 194);
            this.pnlFoodDetail.TabIndex = 1;
            // 
            // btnCancelFood
            // 
            this.btnCancelFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancelFood.FlatAppearance.BorderSize = 0;
            this.btnCancelFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelFood.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelFood.ForeColor = System.Drawing.Color.White;
            this.btnCancelFood.Location = new System.Drawing.Point(531, 148);
            this.btnCancelFood.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelFood.Name = "btnCancelFood";
            this.btnCancelFood.Size = new System.Drawing.Size(90, 32);
            this.btnCancelFood.TabIndex = 13;
            this.btnCancelFood.Text = "Hủy";
            this.btnCancelFood.UseVisualStyleBackColor = false;
            this.btnCancelFood.Click += new System.EventHandler(this.btnCancelFood_Click);
            // 
            // btnSaveFood
            // 
            this.btnSaveFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnSaveFood.FlatAppearance.BorderSize = 0;
            this.btnSaveFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFood.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFood.ForeColor = System.Drawing.Color.White;
            this.btnSaveFood.Location = new System.Drawing.Point(626, 148);
            this.btnSaveFood.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveFood.Name = "btnSaveFood";
            this.btnSaveFood.Size = new System.Drawing.Size(90, 32);
            this.btnSaveFood.TabIndex = 12;
            this.btnSaveFood.Text = "Lưu";
            this.btnSaveFood.UseVisualStyleBackColor = false;
            this.btnSaveFood.Click += new System.EventHandler(this.btnSaveFood_Click);
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnBrowseImage.FlatAppearance.BorderSize = 0;
            this.btnBrowseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseImage.ForeColor = System.Drawing.Color.White;
            this.btnBrowseImage.Location = new System.Drawing.Point(626, 115);
            this.btnBrowseImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(90, 24);
            this.btnBrowseImage.TabIndex = 11;
            this.btnBrowseImage.Text = "Chọn ảnh";
            this.btnBrowseImage.UseVisualStyleBackColor = false;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // picFoodImage
            // 
            this.picFoodImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picFoodImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFoodImage.Location = new System.Drawing.Point(626, 15);
            this.picFoodImage.Margin = new System.Windows.Forms.Padding(2);
            this.picFoodImage.Name = "picFoodImage";
            this.picFoodImage.Size = new System.Drawing.Size(90, 98);
            this.picFoodImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoodImage.TabIndex = 10;
            this.picFoodImage.TabStop = false;
            // 
            // chkIsAvailable
            // 
            this.chkIsAvailable.AutoSize = true;
            this.chkIsAvailable.Checked = true;
            this.chkIsAvailable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsAvailable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsAvailable.Location = new System.Drawing.Point(100, 158);
            this.chkIsAvailable.Margin = new System.Windows.Forms.Padding(2);
            this.chkIsAvailable.Name = "chkIsAvailable";
            this.chkIsAvailable.Size = new System.Drawing.Size(163, 19);
            this.chkIsAvailable.TabIndex = 9;
            this.chkIsAvailable.Text = "Có sẵn (đang kinh doanh)";
            this.chkIsAvailable.UseVisualStyleBackColor = true;
            // 
            // cboFoodCategory
            // 
            this.cboFoodCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFoodCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFoodCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFoodCategory.FormattingEnabled = true;
            this.cboFoodCategory.Location = new System.Drawing.Point(100, 102);
            this.cboFoodCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cboFoodCategory.Name = "cboFoodCategory";
            this.cboFoodCategory.Size = new System.Drawing.Size(522, 23);
            this.cboFoodCategory.TabIndex = 8;
            // 
            // txtFoodPrice
            // 
            this.txtFoodPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFoodPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodPrice.Location = new System.Drawing.Point(100, 130);
            this.txtFoodPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtFoodPrice.Name = "txtFoodPrice";
            this.txtFoodPrice.Size = new System.Drawing.Size(522, 23);
            this.txtFoodPrice.TabIndex = 7;
            // 
            // txtFoodDescription
            // 
            this.txtFoodDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFoodDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodDescription.Location = new System.Drawing.Point(100, 73);
            this.txtFoodDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtFoodDescription.Name = "txtFoodDescription";
            this.txtFoodDescription.Size = new System.Drawing.Size(522, 23);
            this.txtFoodDescription.TabIndex = 6;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFoodName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodName.Location = new System.Drawing.Point(100, 45);
            this.txtFoodName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(522, 23);
            this.txtFoodName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Danh mục:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mô tả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên món:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin món ăn";
            // 
            // lblFoodQuantity
            // 
            this.lblFoodQuantity.AutoSize = true;
            this.lblFoodQuantity.Location = new System.Drawing.Point(20, 180);
            this.lblFoodQuantity.Name = "lblFoodQuantity";
            this.lblFoodQuantity.Size = new System.Drawing.Size(52, 13);
            this.lblFoodQuantity.TabIndex = 14;
            this.lblFoodQuantity.Text = "Số lượng:";
            // 
            // numFoodQuantity
            // 
            this.numFoodQuantity.Location = new System.Drawing.Point(120, 180);
            this.numFoodQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numFoodQuantity.Name = "numFoodQuantity";
            this.numFoodQuantity.Size = new System.Drawing.Size(120, 20);
            this.numFoodQuantity.TabIndex = 15;
            // 
            // pnlFoodList
            // 
            this.pnlFoodList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFoodList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFoodList.Controls.Add(this.dgvFoods);
            this.pnlFoodList.Controls.Add(this.panel5);
            this.pnlFoodList.Location = new System.Drawing.Point(14, 15);
            this.pnlFoodList.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFoodList.Name = "pnlFoodList";
            this.pnlFoodList.Size = new System.Drawing.Size(733, 345);
            this.pnlFoodList.TabIndex = 0;
            // 
            // dgvFoods
            // 
            this.dgvFoods.AllowUserToAddRows = false;
            this.dgvFoods.AllowUserToDeleteRows = false;
            this.dgvFoods.AllowUserToResizeRows = false;
            this.dgvFoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoods.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFoods.Location = new System.Drawing.Point(0, 49);
            this.dgvFoods.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFoods.MultiSelect = false;
            this.dgvFoods.Name = "dgvFoods";
            this.dgvFoods.ReadOnly = true;
            this.dgvFoods.RowHeadersWidth = 51;
            this.dgvFoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoods.Size = new System.Drawing.Size(731, 294);
            this.dgvFoods.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnDeleteFood);
            this.panel5.Controls.Add(this.btnEditFood);
            this.panel5.Controls.Add(this.btnAddFood);
            this.panel5.Controls.Add(this.txtSearchFood);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(731, 49);
            this.panel5.TabIndex = 0;
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDeleteFood.FlatAppearance.BorderSize = 0;
            this.btnDeleteFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFood.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFood.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFood.Location = new System.Drawing.Point(656, 11);
            this.btnDeleteFood.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(60, 26);
            this.btnDeleteFood.TabIndex = 4;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.UseVisualStyleBackColor = false;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnEditFood
            // 
            this.btnEditFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditFood.FlatAppearance.BorderSize = 0;
            this.btnEditFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditFood.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditFood.ForeColor = System.Drawing.Color.White;
            this.btnEditFood.Location = new System.Drawing.Point(591, 11);
            this.btnEditFood.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(60, 26);
            this.btnEditFood.TabIndex = 3;
            this.btnEditFood.Text = "Sửa";
            this.btnEditFood.UseVisualStyleBackColor = false;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAddFood.FlatAppearance.BorderSize = 0;
            this.btnAddFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFood.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.ForeColor = System.Drawing.Color.White;
            this.btnAddFood.Location = new System.Drawing.Point(527, 11);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(60, 26);
            this.btnAddFood.TabIndex = 2;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // txtSearchFood
            // 
            this.txtSearchFood.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchFood.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchFood.Location = new System.Drawing.Point(83, 14);
            this.txtSearchFood.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchFood.Name = "txtSearchFood";
            this.txtSearchFood.Size = new System.Drawing.Size(432, 23);
            this.txtSearchFood.TabIndex = 1;
            this.txtSearchFood.TextChanged += new System.EventHandler(this.txtSearchFood_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tìm kiếm:";
            // 
            // pnlCategoryManagement
            // 
            this.pnlCategoryManagement.Controls.Add(this.pnlCategoryDetail);
            this.pnlCategoryManagement.Controls.Add(this.pnlCategoryList);
            this.pnlCategoryManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCategoryManagement.Location = new System.Drawing.Point(0, 0);
            this.pnlCategoryManagement.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCategoryManagement.Name = "pnlCategoryManagement";
            this.pnlCategoryManagement.Size = new System.Drawing.Size(760, 569);
            this.pnlCategoryManagement.TabIndex = 2;
            // 
            // pnlCategoryDetail
            // 
            this.pnlCategoryDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCategoryDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCategoryDetail.Controls.Add(this.btnCancelCategory);
            this.pnlCategoryDetail.Controls.Add(this.btnSaveCategory);
            this.pnlCategoryDetail.Controls.Add(this.txtCategoryDescription);
            this.pnlCategoryDetail.Controls.Add(this.txtCategoryName);
            this.pnlCategoryDetail.Controls.Add(this.label8);
            this.pnlCategoryDetail.Controls.Add(this.label9);
            this.pnlCategoryDetail.Location = new System.Drawing.Point(14, 365);
            this.pnlCategoryDetail.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCategoryDetail.Name = "pnlCategoryDetail";
            this.pnlCategoryDetail.Size = new System.Drawing.Size(733, 194);
            this.pnlCategoryDetail.TabIndex = 3;
            // 
            // btnCancelCategory
            // 
            this.btnCancelCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancelCategory.FlatAppearance.BorderSize = 0;
            this.btnCancelCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCategory.ForeColor = System.Drawing.Color.White;
            this.btnCancelCategory.Location = new System.Drawing.Point(531, 148);
            this.btnCancelCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelCategory.Name = "btnCancelCategory";
            this.btnCancelCategory.Size = new System.Drawing.Size(90, 32);
            this.btnCancelCategory.TabIndex = 15;
            this.btnCancelCategory.Text = "Hủy";
            this.btnCancelCategory.UseVisualStyleBackColor = false;
            this.btnCancelCategory.Click += new System.EventHandler(this.btnCancelCategory_Click);
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnSaveCategory.FlatAppearance.BorderSize = 0;
            this.btnSaveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCategory.ForeColor = System.Drawing.Color.White;
            this.btnSaveCategory.Location = new System.Drawing.Point(626, 148);
            this.btnSaveCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(90, 32);
            this.btnSaveCategory.TabIndex = 14;
            this.btnSaveCategory.Text = "Lưu";
            this.btnSaveCategory.UseVisualStyleBackColor = false;
            this.btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click);
            // 
            // txtCategoryDescription
            // 
            this.txtCategoryDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategoryDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryDescription.Location = new System.Drawing.Point(100, 73);
            this.txtCategoryDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoryDescription.Multiline = true;
            this.txtCategoryDescription.Name = "txtCategoryDescription";
            this.txtCategoryDescription.Size = new System.Drawing.Size(616, 61);
            this.txtCategoryDescription.TabIndex = 10;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategoryName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.Location = new System.Drawing.Point(100, 45);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(616, 23);
            this.txtCategoryName.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 76);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Mô tả:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 47);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Tên danh mục:";
            // 
            // pnlCategoryList
            // 
            this.pnlCategoryList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCategoryList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCategoryList.Controls.Add(this.dgvCategories);
            this.pnlCategoryList.Controls.Add(this.panel7);
            this.pnlCategoryList.Location = new System.Drawing.Point(14, 15);
            this.pnlCategoryList.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCategoryList.Name = "pnlCategoryList";
            this.pnlCategoryList.Size = new System.Drawing.Size(733, 345);
            this.pnlCategoryList.TabIndex = 2;
            // 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.AllowUserToDeleteRows = false;
            this.dgvCategories.AllowUserToResizeRows = false;
            this.dgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategories.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategories.Location = new System.Drawing.Point(0, 49);
            this.dgvCategories.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCategories.MultiSelect = false;
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.ReadOnly = true;
            this.dgvCategories.RowHeadersWidth = 51;
            this.dgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategories.Size = new System.Drawing.Size(731, 294);
            this.dgvCategories.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnDeleteCategory);
            this.panel7.Controls.Add(this.btnEditCategory);
            this.panel7.Controls.Add(this.btnAddCategory);
            this.panel7.Controls.Add(this.txtSearchCategory);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(731, 49);
            this.panel7.TabIndex = 1;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDeleteCategory.FlatAppearance.BorderSize = 0;
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Location = new System.Drawing.Point(656, 11);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(60, 26);
            this.btnDeleteCategory.TabIndex = 4;
            this.btnDeleteCategory.Text = "Xóa";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditCategory.FlatAppearance.BorderSize = 0;
            this.btnEditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCategory.ForeColor = System.Drawing.Color.White;
            this.btnEditCategory.Location = new System.Drawing.Point(591, 11);
            this.btnEditCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(60, 26);
            this.btnEditCategory.TabIndex = 3;
            this.btnEditCategory.Text = "Sửa";
            this.btnEditCategory.UseVisualStyleBackColor = false;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Location = new System.Drawing.Point(527, 11);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(60, 26);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtSearchCategory
            // 
            this.txtSearchCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCategory.Location = new System.Drawing.Point(83, 14);
            this.txtSearchCategory.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchCategory.Name = "txtSearchCategory";
            this.txtSearchCategory.Size = new System.Drawing.Size(432, 23);
            this.txtSearchCategory.TabIndex = 1;
            this.txtSearchCategory.TextChanged += new System.EventHandler(this.txtSearchCategory_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tìm kiếm:";
            // 
            // pnlOrderManagement
            // 
            this.pnlOrderManagement.Controls.Add(this.splitContainer1);
            this.pnlOrderManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrderManagement.Location = new System.Drawing.Point(0, 0);
            this.pnlOrderManagement.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOrderManagement.Name = "pnlOrderManagement";
            this.pnlOrderManagement.Size = new System.Drawing.Size(760, 569);
            this.pnlOrderManagement.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(14, 15);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvOrders);
            this.splitContainer1.Panel1.Controls.Add(this.panel6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlOrderDetail);
            this.splitContainer1.Size = new System.Drawing.Size(733, 543);
            this.splitContainer1.SplitterDistance = 360;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AllowUserToResizeRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(0, 116);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(360, 427);
            this.dgvOrders.TabIndex = 1;
            this.dgvOrders.SelectionChanged += new System.EventHandler(this.dgvOrders_SelectionChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dtpOrderTo);
            this.panel6.Controls.Add(this.label18);
            this.panel6.Controls.Add(this.dtpOrderFrom);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.cboOrderStatus);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.btnSearchOrder);
            this.panel6.Controls.Add(this.txtSearchOrder);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(360, 116);
            this.panel6.TabIndex = 0;
            // 
            // dtpOrderTo
            // 
            this.dtpOrderTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOrderTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderTo.Location = new System.Drawing.Point(266, 72);
            this.dtpOrderTo.Margin = new System.Windows.Forms.Padding(2);
            this.dtpOrderTo.Name = "dtpOrderTo";
            this.dtpOrderTo.Size = new System.Drawing.Size(92, 23);
            this.dtpOrderTo.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(227, 76);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 15);
            this.label18.TabIndex = 8;
            this.label18.Text = "đến:";
            // 
            // dtpOrderFrom
            // 
            this.dtpOrderFrom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOrderFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderFrom.Location = new System.Drawing.Point(125, 72);
            this.dtpOrderFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dtpOrderFrom.Name = "dtpOrderFrom";
            this.dtpOrderFrom.Size = new System.Drawing.Size(92, 23);
            this.dtpOrderFrom.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(13, 76);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(123, 15);
            this.label17.TabIndex = 6;
            this.label17.Text = "Thời gian đặt từ ngày:";
            // 
            // cboOrderStatus
            // 
            this.cboOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOrderStatus.FormattingEnabled = true;
            this.cboOrderStatus.Items.AddRange(new object[] {
            "Tất cả",
            "Chờ xác nhận",
            "Đã xác nhận",
            "Đang giao",
            "Đã giao",
            "Đã hủy"});
            this.cboOrderStatus.Location = new System.Drawing.Point(125, 43);
            this.cboOrderStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cboOrderStatus.Name = "cboOrderStatus";
            this.cboOrderStatus.Size = new System.Drawing.Size(151, 23);
            this.cboOrderStatus.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 46);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 15);
            this.label16.TabIndex = 4;
            this.label16.Text = "Trạng thái:";
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSearchOrder.FlatAppearance.BorderSize = 0;
            this.btnSearchOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchOrder.ForeColor = System.Drawing.Color.White;
            this.btnSearchOrder.Location = new System.Drawing.Point(280, 11);
            this.btnSearchOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(68, 26);
            this.btnSearchOrder.TabIndex = 3;
            this.btnSearchOrder.Text = "Tìm kiếm";
            this.btnSearchOrder.UseVisualStyleBackColor = false;
            this.btnSearchOrder.Click += new System.EventHandler(this.btnSearchOrder_Click);
            // 
            // txtSearchOrder
            // 
            this.txtSearchOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchOrder.Location = new System.Drawing.Point(125, 14);
            this.txtSearchOrder.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchOrder.Name = "txtSearchOrder";
            this.txtSearchOrder.Size = new System.Drawing.Size(151, 23);
            this.txtSearchOrder.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã đơn hàng/SĐT:";
            // 
            // pnlOrderDetail
            // 
            this.pnlOrderDetail.Controls.Add(this.cboNewStatus);
            this.pnlOrderDetail.Controls.Add(this.label15);
            this.pnlOrderDetail.Controls.Add(this.btnUpdateStatus);
            this.pnlOrderDetail.Controls.Add(this.dgvOrderDetails);
            this.pnlOrderDetail.Controls.Add(this.label14);
            this.pnlOrderDetail.Controls.Add(this.txtOrderNotes);
            this.pnlOrderDetail.Controls.Add(this.label13);
            this.pnlOrderDetail.Controls.Add(this.txtOrderAddress);
            this.pnlOrderDetail.Controls.Add(this.label12);
            this.pnlOrderDetail.Controls.Add(this.txtOrderTotal);
            this.pnlOrderDetail.Controls.Add(this.txtOrderDate);
            this.pnlOrderDetail.Controls.Add(this.txtOrderCustomer);
            this.pnlOrderDetail.Controls.Add(this.txtOrderID);
            this.pnlOrderDetail.Controls.Add(this.label22);
            this.pnlOrderDetail.Controls.Add(this.label21);
            this.pnlOrderDetail.Controls.Add(this.label20);
            this.pnlOrderDetail.Controls.Add(this.label19);
            this.pnlOrderDetail.Controls.Add(this.label11);
            this.pnlOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrderDetail.Location = new System.Drawing.Point(0, 0);
            this.pnlOrderDetail.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOrderDetail.Name = "pnlOrderDetail";
            this.pnlOrderDetail.Size = new System.Drawing.Size(370, 543);
            this.pnlOrderDetail.TabIndex = 0;
            // 
            // cboNewStatus
            // 
            this.cboNewStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNewStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNewStatus.FormattingEnabled = true;
            this.cboNewStatus.Items.AddRange(new object[] {
            "Pending",
            "Confirmed",
            "Delivering",
            "Delivered",
            "Cancelled"});
            this.cboNewStatus.Location = new System.Drawing.Point(116, 202);
            this.cboNewStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cboNewStatus.Name = "cboNewStatus";
            this.cboNewStatus.Size = new System.Drawing.Size(151, 23);
            this.cboNewStatus.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 204);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 15);
            this.label15.TabIndex = 18;
            this.label15.Text = "Trạng thái mới: *";
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnUpdateStatus.FlatAppearance.BorderSize = 0;
            this.btnUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStatus.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStatus.Location = new System.Drawing.Point(273, 199);
            this.btnUpdateStatus.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(87, 26);
            this.btnUpdateStatus.TabIndex = 17;
            this.btnUpdateStatus.Text = "Cập nhật";
            this.btnUpdateStatus.UseVisualStyleBackColor = false;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AllowUserToAddRows = false;
            this.dgvOrderDetails.AllowUserToDeleteRows = false;
            this.dgvOrderDetails.AllowUserToResizeRows = false;
            this.dgvOrderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Location = new System.Drawing.Point(13, 251);
            this.dgvOrderDetails.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOrderDetails.MultiSelect = false;
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.ReadOnly = true;
            this.dgvOrderDetails.RowHeadersWidth = 51;
            this.dgvOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetails.Size = new System.Drawing.Size(347, 282);
            this.dgvOrderDetails.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 232);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 15);
            this.label14.TabIndex = 15;
            this.label14.Text = "Chi tiết đơn hàng:";
            // 
            // txtOrderNotes
            // 
            this.txtOrderNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderNotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderNotes.Location = new System.Drawing.Point(116, 157);
            this.txtOrderNotes.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderNotes.Multiline = true;
            this.txtOrderNotes.Name = "txtOrderNotes";
            this.txtOrderNotes.ReadOnly = true;
            this.txtOrderNotes.Size = new System.Drawing.Size(247, 33);
            this.txtOrderNotes.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 159);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "Ghi chú:";
            // 
            // txtOrderAddress
            // 
            this.txtOrderAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderAddress.Location = new System.Drawing.Point(116, 130);
            this.txtOrderAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderAddress.Name = "txtOrderAddress";
            this.txtOrderAddress.ReadOnly = true;
            this.txtOrderAddress.Size = new System.Drawing.Size(247, 23);
            this.txtOrderAddress.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 132);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "Địa chỉ:";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtOrderTotal.Location = new System.Drawing.Point(116, 103);
            this.txtOrderTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(247, 23);
            this.txtOrderTotal.TabIndex = 10;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderDate.Location = new System.Drawing.Point(116, 76);
            this.txtOrderDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(247, 23);
            this.txtOrderDate.TabIndex = 8;
            // 
            // txtOrderCustomer
            // 
            this.txtOrderCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderCustomer.Location = new System.Drawing.Point(116, 50);
            this.txtOrderCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderCustomer.Name = "txtOrderCustomer";
            this.txtOrderCustomer.ReadOnly = true;
            this.txtOrderCustomer.Size = new System.Drawing.Size(247, 23);
            this.txtOrderCustomer.TabIndex = 7;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderID.Location = new System.Drawing.Point(116, 23);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(247, 23);
            this.txtOrderID.TabIndex = 6;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(13, 106);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 15);
            this.label22.TabIndex = 5;
            this.label22.Text = "Tổng tiền:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(13, 79);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 15);
            this.label21.TabIndex = 4;
            this.label21.Text = "Ngày đặt:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(13, 52);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 15);
            this.label20.TabIndex = 3;
            this.label20.Text = "Khách hàng:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(13, 25);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 15);
            this.label19.TabIndex = 2;
            this.label19.Text = "Mã đơn hàng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 4);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Thông tin đơn hàng";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnRevenueReport
            // 
            this.btnRevenueReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnRevenueReport.FlatAppearance.BorderSize = 0;
            this.btnRevenueReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenueReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRevenueReport.ForeColor = System.Drawing.Color.White;
            this.btnRevenueReport.Location = new System.Drawing.Point(20, 350);
            this.btnRevenueReport.Name = "btnRevenueReport";
            this.btnRevenueReport.Size = new System.Drawing.Size(180, 40);
            this.btnRevenueReport.TabIndex = 6;
            this.btnRevenueReport.Text = "Báo cáo doanh thu";
            this.btnRevenueReport.UseVisualStyleBackColor = false;
            // 
            // btnManageRatings
            // 
            this.btnManageRatings.FlatAppearance.BorderSize = 0;
            this.btnManageRatings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageRatings.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageRatings.ForeColor = System.Drawing.Color.White;
            this.btnManageRatings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageRatings.Location = new System.Drawing.Point(2, 334);
            this.btnManageRatings.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageRatings.Name = "btnManageRatings";
            this.btnManageRatings.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnManageRatings.Size = new System.Drawing.Size(188, 41);
            this.btnManageRatings.TabIndex = 10;
            this.btnManageRatings.Text = "  Đánh giá";
            this.btnManageRatings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageRatings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageRatings.UseVisualStyleBackColor = true;
            this.btnManageRatings.Click += new System.EventHandler(this.btnManageRatings_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 618);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(964, 657);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodAdmin - Quản trị hệ thống";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAppLogo)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlUserManagement.ResumeLayout(false);
            this.pnlUserDetail.ResumeLayout(false);
            this.pnlUserDetail.PerformLayout();
            this.pnlUserList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlFoodManagement.ResumeLayout(false);
            this.pnlFoodDetail.ResumeLayout(false);
            this.pnlFoodDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoodImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFoodQuantity)).EndInit();
            this.pnlFoodList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlCategoryManagement.ResumeLayout(false);
            this.pnlCategoryDetail.ResumeLayout(false);
            this.pnlCategoryDetail.PerformLayout();
            this.pnlCategoryList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.pnlOrderManagement.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.pnlOrderDetail.ResumeLayout(false);
            this.pnlOrderDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnFoods;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.PictureBox picAppLogo;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblRevenueValue;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCompletedOrdersValue;
        private System.Windows.Forms.Label lblCompletedOrders;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPendingOrdersValue;
        private System.Windows.Forms.Label lblPendingOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalOrdersValue;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.Panel pnlFoodManagement;
        private System.Windows.Forms.Panel pnlFoodDetail;
        private System.Windows.Forms.Button btnCancelFood;
        private System.Windows.Forms.Button btnSaveFood;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.PictureBox picFoodImage;
        private System.Windows.Forms.CheckBox chkIsAvailable;
        private System.Windows.Forms.ComboBox cboFoodCategory;
        private System.Windows.Forms.TextBox txtFoodPrice;
        private System.Windows.Forms.TextBox txtFoodDescription;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlFoodList;
        private System.Windows.Forms.DataGridView dgvFoods;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.TextBox txtSearchFood;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlCategoryManagement;
        private System.Windows.Forms.Panel pnlCategoryDetail;
        private System.Windows.Forms.Button btnCancelCategory;
        private System.Windows.Forms.Button btnSaveCategory;
        private System.Windows.Forms.TextBox txtCategoryDescription;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlCategoryList;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox txtSearchCategory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlOrderManagement;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker dtpOrderTo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtpOrderFrom;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cboOrderStatus;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSearchOrder;
        private System.Windows.Forms.TextBox txtSearchOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlOrderDetail;
        private System.Windows.Forms.ComboBox cboNewStatus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtOrderNotes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtOrderAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtOrderCustomer;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlUserManagement;
        private System.Windows.Forms.Panel pnlUserDetail;
        private System.Windows.Forms.ComboBox cboUserRole;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnCancelUser;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.TextBox txtUserAddress;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtUserPhone;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtUserFullName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel pnlUserList;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.OpenFileDialog openFileDialog;

        // Thêm button báo cáo doanh thu vào form admin
        private Button btnRevenueReport;
        private Button btnReport;

        // food quantity
        private System.Windows.Forms.Label lblFoodQuantity;
        private System.Windows.Forms.NumericUpDown numFoodQuantity;
        private Button btnManageRatings;
    }
}