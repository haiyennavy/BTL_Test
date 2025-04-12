using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace FoodOrderApp
{
    partial class MainForm
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSupport = new System.Windows.Forms.Button();
            this.btnRatings = new System.Windows.Forms.Button();
            this.btnOrderHistory = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.picUserAvatar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.flpFoods = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCategories = new System.Windows.Forms.Panel();
            this.btnBeverages = new System.Windows.Forms.Button();
            this.btnNoodles = new System.Windows.Forms.Button();
            this.btnPho = new System.Windows.Forms.Button();
            this.btnRice = new System.Windows.Forms.Button();
            this.btnAllFoods = new System.Windows.Forms.Button();
            this.lblCategories = new System.Windows.Forms.Label();
            this.pnlCart = new System.Windows.Forms.Panel();
            this.pnlCheckout = new System.Windows.Forms.Panel();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeliveryAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDeliveryFee = new System.Windows.Forms.Label();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblSubtotalTitle = new System.Windows.Forms.Label();
            this.pnlCartItems = new System.Windows.Forms.Panel();
            this.flpCartItems = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCartTitle = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlCategories.SuspendLayout();
            this.pnlCart.SuspendLayout();
            this.pnlCheckout.SuspendLayout();
            this.pnlCartItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnSettings);
            this.pnlSidebar.Controls.Add(this.btnSupport);
            this.pnlSidebar.Controls.Add(this.btnRatings);
            this.pnlSidebar.Controls.Add(this.btnOrderHistory);
            this.pnlSidebar.Controls.Add(this.btnHome);
            this.pnlSidebar.Controls.Add(this.lblUserName);
            this.pnlSidebar.Controls.Add(this.picUserAvatar);
            this.pnlSidebar.Controls.Add(this.pictureBox1);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(165, 618);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 576);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(165, 39);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "  Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 254);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(165, 39);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "  Cài đặt";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSupport
            // 
            this.btnSupport.FlatAppearance.BorderSize = 0;
            this.btnSupport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupport.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupport.ForeColor = System.Drawing.Color.White;
            this.btnSupport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupport.Location = new System.Drawing.Point(0, 214);
            this.btnSupport.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupport.Name = "btnSupport";
            this.btnSupport.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnSupport.Size = new System.Drawing.Size(165, 39);
            this.btnSupport.TabIndex = 6;
            this.btnSupport.Text = "  Hỗ trợ";
            this.btnSupport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupport.UseVisualStyleBackColor = true;
            this.btnSupport.Click += new System.EventHandler(this.btnSupport_Click);
            // 
            // btnRatings
            // 
            this.btnRatings.FlatAppearance.BorderSize = 0;
            this.btnRatings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRatings.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRatings.ForeColor = System.Drawing.Color.White;
            this.btnRatings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRatings.Location = new System.Drawing.Point(0, 176);
            this.btnRatings.Margin = new System.Windows.Forms.Padding(2);
            this.btnRatings.Name = "btnRatings";
            this.btnRatings.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnRatings.Size = new System.Drawing.Size(165, 39);
            this.btnRatings.TabIndex = 5;
            this.btnRatings.Text = "  Đánh giá";
            this.btnRatings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRatings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRatings.UseVisualStyleBackColor = true;
            this.btnRatings.Click += new System.EventHandler(this.btnRatings_Click);
            // 
            // btnOrderHistory
            // 
            this.btnOrderHistory.FlatAppearance.BorderSize = 0;
            this.btnOrderHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderHistory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderHistory.ForeColor = System.Drawing.Color.White;
            this.btnOrderHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderHistory.Location = new System.Drawing.Point(0, 136);
            this.btnOrderHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderHistory.Name = "btnOrderHistory";
            this.btnOrderHistory.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnOrderHistory.Size = new System.Drawing.Size(165, 39);
            this.btnOrderHistory.TabIndex = 4;
            this.btnOrderHistory.Text = "  Lịch sử đơn hàng";
            this.btnOrderHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrderHistory.UseVisualStyleBackColor = true;
            this.btnOrderHistory.Click += new System.EventHandler(this.btnOrderHistory_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 98);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(165, 39);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "  Trang chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(0, 67);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(165, 20);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Xin chào, Nguyễn Văn A";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picUserAvatar
            // 
            this.picUserAvatar.Location = new System.Drawing.Point(64, 10);
            this.picUserAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.picUserAvatar.Name = "picUserAvatar";
            this.picUserAvatar.Size = new System.Drawing.Size(38, 41);
            this.picUserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserAvatar.TabIndex = 1;
            this.picUserAvatar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.txtSearch);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(165, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(783, 49);
            this.pnlHeader.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(574, 13);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(196, 26);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(13, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(206, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "FoodOrder - Đặt Món";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlMenu);
            this.pnlMain.Controls.Add(this.pnlCart);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(165, 49);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(783, 569);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.pnlCategories);
            this.pnlMenu.Controls.Add(this.flpFoods);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(543, 569);
            this.pnlMenu.TabIndex = 1;
            // 
            // flpFoods
            // 
            this.flpFoods.AutoScroll = true;
            this.flpFoods.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpFoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFoods.Location = new System.Drawing.Point(0, 0);
            this.flpFoods.Margin = new System.Windows.Forms.Padding(2);
            this.flpFoods.Name = "flpFoods";
            this.flpFoods.Padding = new System.Windows.Forms.Padding(8);
            this.flpFoods.Size = new System.Drawing.Size(543, 569);
            this.flpFoods.TabIndex = 1;
            // 
            // pnlCategories
            // 
            this.pnlCategories.BackColor = System.Drawing.Color.White;
            this.pnlCategories.Controls.Add(this.btnBeverages);
            this.pnlCategories.Controls.Add(this.btnNoodles);
            this.pnlCategories.Controls.Add(this.btnPho);
            this.pnlCategories.Controls.Add(this.btnRice);
            this.pnlCategories.Controls.Add(this.btnAllFoods);
            this.pnlCategories.Controls.Add(this.lblCategories);
            this.pnlCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCategories.Location = new System.Drawing.Point(0, 0);
            this.pnlCategories.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Size = new System.Drawing.Size(543, 49);
            this.pnlCategories.TabIndex = 0;
            // 
            // btnBeverages
            // 
            this.btnBeverages.BackColor = System.Drawing.Color.White;
            this.btnBeverages.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBeverages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeverages.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeverages.Location = new System.Drawing.Point(353, 12);
            this.btnBeverages.Margin = new System.Windows.Forms.Padding(2);
            this.btnBeverages.Name = "btnBeverages";
            this.btnBeverages.Size = new System.Drawing.Size(68, 26);
            this.btnBeverages.TabIndex = 5;
            this.btnBeverages.Tag = "4";
            this.btnBeverages.Text = "Đồ uống";
            this.btnBeverages.UseVisualStyleBackColor = false;
            this.btnBeverages.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // btnNoodles
            // 
            this.btnNoodles.BackColor = System.Drawing.Color.White;
            this.btnNoodles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNoodles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoodles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoodles.Location = new System.Drawing.Point(285, 12);
            this.btnNoodles.Margin = new System.Windows.Forms.Padding(2);
            this.btnNoodles.Name = "btnNoodles";
            this.btnNoodles.Size = new System.Drawing.Size(68, 26);
            this.btnNoodles.TabIndex = 4;
            this.btnNoodles.Tag = "3";
            this.btnNoodles.Text = "Bún";
            this.btnNoodles.UseVisualStyleBackColor = false;
            this.btnNoodles.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // btnPho
            // 
            this.btnPho.BackColor = System.Drawing.Color.White;
            this.btnPho.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPho.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPho.Location = new System.Drawing.Point(218, 12);
            this.btnPho.Margin = new System.Windows.Forms.Padding(2);
            this.btnPho.Name = "btnPho";
            this.btnPho.Size = new System.Drawing.Size(68, 26);
            this.btnPho.TabIndex = 3;
            this.btnPho.Tag = "2";
            this.btnPho.Text = "Phở";
            this.btnPho.UseVisualStyleBackColor = false;
            this.btnPho.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // btnRice
            // 
            this.btnRice.BackColor = System.Drawing.Color.White;
            this.btnRice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRice.Location = new System.Drawing.Point(150, 12);
            this.btnRice.Margin = new System.Windows.Forms.Padding(2);
            this.btnRice.Name = "btnRice";
            this.btnRice.Size = new System.Drawing.Size(68, 26);
            this.btnRice.TabIndex = 2;
            this.btnRice.Tag = "1";
            this.btnRice.Text = "Cơm";
            this.btnRice.UseVisualStyleBackColor = false;
            this.btnRice.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // btnAllFoods
            // 
            this.btnAllFoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnAllFoods.FlatAppearance.BorderSize = 0;
            this.btnAllFoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllFoods.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllFoods.ForeColor = System.Drawing.Color.White;
            this.btnAllFoods.Location = new System.Drawing.Point(83, 12);
            this.btnAllFoods.Margin = new System.Windows.Forms.Padding(2);
            this.btnAllFoods.Name = "btnAllFoods";
            this.btnAllFoods.Size = new System.Drawing.Size(68, 26);
            this.btnAllFoods.TabIndex = 1;
            this.btnAllFoods.Tag = "0";
            this.btnAllFoods.Text = "Tất cả";
            this.btnAllFoods.UseVisualStyleBackColor = false;
            this.btnAllFoods.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.Location = new System.Drawing.Point(10, 15);
            this.lblCategories.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(66, 15);
            this.lblCategories.TabIndex = 0;
            this.lblCategories.Text = "Danh mục:";
            // 
            // pnlCart
            // 
            this.pnlCart.BackColor = System.Drawing.Color.White;
            this.pnlCart.Controls.Add(this.pnlCheckout);
            this.pnlCart.Controls.Add(this.pnlCartItems);
            this.pnlCart.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCart.Location = new System.Drawing.Point(543, 0);
            this.pnlCart.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.Size = new System.Drawing.Size(240, 569);
            this.pnlCart.TabIndex = 0;
            // 
            // pnlCheckout
            // 
            this.pnlCheckout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCheckout.Controls.Add(this.txtNotes);
            this.pnlCheckout.Controls.Add(this.label4);
            this.pnlCheckout.Controls.Add(this.cboPaymentMethod);
            this.pnlCheckout.Controls.Add(this.label3);
            this.pnlCheckout.Controls.Add(this.txtDeliveryAddress);
            this.pnlCheckout.Controls.Add(this.label2);
            this.pnlCheckout.Controls.Add(this.btnPlaceOrder);
            this.pnlCheckout.Controls.Add(this.lblTotal);
            this.pnlCheckout.Controls.Add(this.label1);
            this.pnlCheckout.Controls.Add(this.lblDeliveryFee);
            this.pnlCheckout.Controls.Add(this.lblDelivery);
            this.pnlCheckout.Controls.Add(this.lblSubtotal);
            this.pnlCheckout.Controls.Add(this.lblSubtotalTitle);
            this.pnlCheckout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCheckout.Location = new System.Drawing.Point(0, 285);
            this.pnlCheckout.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCheckout.Name = "pnlCheckout";
            this.pnlCheckout.Size = new System.Drawing.Size(240, 284);
            this.pnlCheckout.TabIndex = 1;
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(12, 202);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(2);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(214, 37);
            this.txtNotes.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ghi chú";
            // 
            // cboPaymentMethod
            // 
            this.cboPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPaymentMethod.FormattingEnabled = true;
            this.cboPaymentMethod.Items.AddRange(new object[] {
            "Tiền mặt",
            "Thẻ ngân hàng",
            "Ví điện tử"});
            this.cboPaymentMethod.Location = new System.Drawing.Point(12, 155);
            this.cboPaymentMethod.Margin = new System.Windows.Forms.Padding(2);
            this.cboPaymentMethod.Name = "cboPaymentMethod";
            this.cboPaymentMethod.Size = new System.Drawing.Size(214, 23);
            this.cboPaymentMethod.TabIndex = 11;
            this.cboPaymentMethod.Text = "Tiền mặt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Phương thức thanh toán";
            // 
            // txtDeliveryAddress
            // 
            this.txtDeliveryAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeliveryAddress.Location = new System.Drawing.Point(12, 108);
            this.txtDeliveryAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeliveryAddress.Multiline = true;
            this.txtDeliveryAddress.Name = "txtDeliveryAddress";
            this.txtDeliveryAddress.Size = new System.Drawing.Size(214, 24);
            this.txtDeliveryAddress.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Địa chỉ giao hàng";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnPlaceOrder.FlatAppearance.BorderSize = 0;
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Location = new System.Drawing.Point(64, 249);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(109, 32);
            this.btnPlaceOrder.TabIndex = 7;
            this.btnPlaceOrder.Text = "Đặt Hàng";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(112, 65);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(113, 19);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "0₫";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tổng cộng";
            // 
            // lblDeliveryFee
            // 
            this.lblDeliveryFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeliveryFee.Location = new System.Drawing.Point(112, 45);
            this.lblDeliveryFee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeliveryFee.Name = "lblDeliveryFee";
            this.lblDeliveryFee.Size = new System.Drawing.Size(113, 14);
            this.lblDeliveryFee.TabIndex = 4;
            this.lblDeliveryFee.Text = "15,000₫";
            this.lblDeliveryFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Location = new System.Drawing.Point(11, 45);
            this.lblDelivery.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(74, 13);
            this.lblDelivery.TabIndex = 3;
            this.lblDelivery.Text = "Phí giao hàng";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotal.Location = new System.Drawing.Point(112, 24);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(113, 14);
            this.lblSubtotal.TabIndex = 2;
            this.lblSubtotal.Text = "0₫";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtotalTitle
            // 
            this.lblSubtotalTitle.AutoSize = true;
            this.lblSubtotalTitle.Location = new System.Drawing.Point(11, 24);
            this.lblSubtotalTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtotalTitle.Name = "lblSubtotalTitle";
            this.lblSubtotalTitle.Size = new System.Drawing.Size(50, 13);
            this.lblSubtotalTitle.TabIndex = 1;
            this.lblSubtotalTitle.Text = "Tạm tính";
            // 
            // pnlCartItems
            // 
            this.pnlCartItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCartItems.Controls.Add(this.flpCartItems);
            this.pnlCartItems.Controls.Add(this.lblCartTitle);
            this.pnlCartItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCartItems.Location = new System.Drawing.Point(0, 0);
            this.pnlCartItems.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCartItems.Name = "pnlCartItems";
            this.pnlCartItems.Size = new System.Drawing.Size(240, 285);
            this.pnlCartItems.TabIndex = 0;
            // 
            // flpCartItems
            // 
            this.flpCartItems.AutoScroll = true;
            this.flpCartItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCartItems.Location = new System.Drawing.Point(0, 32);
            this.flpCartItems.Margin = new System.Windows.Forms.Padding(2);
            this.flpCartItems.Name = "flpCartItems";
            this.flpCartItems.Padding = new System.Windows.Forms.Padding(4);
            this.flpCartItems.Size = new System.Drawing.Size(238, 251);
            this.flpCartItems.TabIndex = 1;
            // 
            // lblCartTitle
            // 
            this.lblCartTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.lblCartTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCartTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartTitle.ForeColor = System.Drawing.Color.White;
            this.lblCartTitle.Location = new System.Drawing.Point(0, 0);
            this.lblCartTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCartTitle.Name = "lblCartTitle";
            this.lblCartTitle.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblCartTitle.Size = new System.Drawing.Size(238, 32);
            this.lblCartTitle.TabIndex = 0;
            this.lblCartTitle.Text = "Giỏ Hàng";
            this.lblCartTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 618);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(964, 657);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodOrder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlCategories.ResumeLayout(false);
            this.pnlCategories.PerformLayout();
            this.pnlCart.ResumeLayout(false);
            this.pnlCheckout.ResumeLayout(false);
            this.pnlCheckout.PerformLayout();
            this.pnlCartItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox picUserAvatar;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnOrderHistory;
        private System.Windows.Forms.Button btnRatings;
        private System.Windows.Forms.Button btnSupport;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlCart;
        private System.Windows.Forms.Panel pnlCartItems;
        private System.Windows.Forms.Label lblCartTitle;
        private System.Windows.Forms.FlowLayoutPanel flpCartItems;
        private System.Windows.Forms.Panel pnlCheckout;
        private System.Windows.Forms.Label lblSubtotalTitle;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.Label lblDeliveryFee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDeliveryAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPaymentMethod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlCategories;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Button btnAllFoods;
        private System.Windows.Forms.Button btnRice;
        private System.Windows.Forms.Button btnPho;
        private System.Windows.Forms.Button btnNoodles;
        private System.Windows.Forms.Button btnBeverages;
        private System.Windows.Forms.FlowLayoutPanel flpFoods;
    }
}