namespace FoodOrderApp
{
    partial class RatingsManagementForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboRating = new System.Windows.Forms.ComboBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.cboFood = new System.Windows.Forms.ComboBox();
            this.lblFood = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.dgvRatings = new System.Windows.Forms.DataGridView();
            this.pnlStatistics = new System.Windows.Forms.Panel();
            this.lblRatingDistribution = new System.Windows.Forms.Label();
            this.lblAverageRating = new System.Windows.Forms.Label();
            this.lblTotalRatings = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRatings)).BeginInit();
            this.pnlStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1100, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(217, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ratings Management";
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFilter.Controls.Add(this.btnExport);
            this.pnlFilter.Controls.Add(this.btnRefresh);
            this.pnlFilter.Controls.Add(this.btnReset);
            this.pnlFilter.Controls.Add(this.btnSearch);
            this.pnlFilter.Controls.Add(this.cboRating);
            this.pnlFilter.Controls.Add(this.lblRating);
            this.pnlFilter.Controls.Add(this.cboUser);
            this.pnlFilter.Controls.Add(this.lblUser);
            this.pnlFilter.Controls.Add(this.cboFood);
            this.pnlFilter.Controls.Add(this.lblFood);
            this.pnlFilter.Controls.Add(this.dtpToDate);
            this.pnlFilter.Controls.Add(this.lblTo);
            this.pnlFilter.Controls.Add(this.dtpFromDate);
            this.pnlFilter.Controls.Add(this.lblFromDate);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 60);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1100, 100);
            this.pnlFilter.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(768, 53);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 30);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(677, 53);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 30);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(586, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 30);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboRating
            // 
            this.cboRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRating.FormattingEnabled = true;
            this.cboRating.Location = new System.Drawing.Point(498, 53);
            this.cboRating.Name = "cboRating";
            this.cboRating.Size = new System.Drawing.Size(75, 25);
            this.cboRating.TabIndex = 9;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(445, 56);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(47, 17);
            this.lblRating.TabIndex = 8;
            this.lblRating.Text = "Rating:";
            // 
            // cboUser
            // 
            this.cboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Location = new System.Drawing.Point(307, 53);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(132, 25);
            this.cboUser.TabIndex = 7;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(273, 56);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(37, 17);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "User:";
            // 
            // cboFood
            // 
            this.cboFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFood.FormattingEnabled = true;
            this.cboFood.Location = new System.Drawing.Point(82, 53);
            this.cboFood.Name = "cboFood";
            this.cboFood.Size = new System.Drawing.Size(185, 25);
            this.cboFood.TabIndex = 5;
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Location = new System.Drawing.Point(15, 56);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(39, 17);
            this.lblFood.TabIndex = 4;
            this.lblFood.Text = "Food:";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(273, 15);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(120, 25);
            this.dtpToDate.TabIndex = 3;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(244, 19);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 17);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "to:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(82, 15);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(120, 25);
            this.dtpFromDate.TabIndex = 1;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(15, 19);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(61, 17);
            this.lblFromDate.TabIndex = 0;
            this.lblFromDate.Text = "Date from:";
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.dgvRatings);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(0, 160);
            this.pnlData.Name = "pnlData";
            this.pnlData.Padding = new System.Windows.Forms.Padding(15);
            this.pnlData.Size = new System.Drawing.Size(1100, 390);
            this.pnlData.TabIndex = 2;
            // 
            // dgvRatings
            // 
            this.dgvRatings.AllowUserToAddRows = false;
            this.dgvRatings.AllowUserToDeleteRows = false;
            this.dgvRatings.BackgroundColor = System.Drawing.Color.White;
            this.dgvRatings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRatings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRatings.Location = new System.Drawing.Point(15, 15);
            this.dgvRatings.Name = "dgvRatings";
            this.dgvRatings.ReadOnly = true;
            this.dgvRatings.RowHeadersWidth = 51;
            this.dgvRatings.Size = new System.Drawing.Size(1070, 360);
            this.dgvRatings.TabIndex = 0;
            this.dgvRatings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRatings_CellClick);
            // 
            // pnlStatistics
            // 
            this.pnlStatistics.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlStatistics.Controls.Add(this.lblRatingDistribution);
            this.pnlStatistics.Controls.Add(this.lblAverageRating);
            this.pnlStatistics.Controls.Add(this.lblTotalRatings);
            this.pnlStatistics.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatistics.Location = new System.Drawing.Point(0, 550);
            this.pnlStatistics.Name = "pnlStatistics";
            this.pnlStatistics.Size = new System.Drawing.Size(1100, 50);
            this.pnlStatistics.TabIndex = 3;
            // 
            // lblRatingDistribution
            // 
            this.lblRatingDistribution.AutoSize = true;
            this.lblRatingDistribution.Location = new System.Drawing.Point(523, 16);
            this.lblRatingDistribution.Name = "lblRatingDistribution";
            this.lblRatingDistribution.Size = new System.Drawing.Size(148, 17);
            this.lblRatingDistribution.TabIndex = 2;
            this.lblRatingDistribution.Text = "Distribution: 5★: 0, 4★: 0, 3★: 0, 2★: 0, 1★: 0";
            // 
            // lblAverageRating
            // 
            this.lblAverageRating.AutoSize = true;
            this.lblAverageRating.Location = new System.Drawing.Point(273, 16);
            this.lblAverageRating.Name = "lblAverageRating";
            this.lblAverageRating.Size = new System.Drawing.Size(122, 17);
            this.lblAverageRating.TabIndex = 1;
            this.lblAverageRating.Text = "Average Rating: 0.0";
            // 
            // lblTotalRatings
            // 
            this.lblTotalRatings.AutoSize = true;
            this.lblTotalRatings.Location = new System.Drawing.Point(15, 16);
            this.lblTotalRatings.Name = "lblTotalRatings";
            this.lblTotalRatings.Size = new System.Drawing.Size(91, 17);
            this.lblTotalRatings.TabIndex = 0;
            this.lblTotalRatings.Text = "Total Ratings: 0";
            // 
            // btnExport
            // 
            // btnExport (continued)
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(859, 53);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 30);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "Export CSV";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // RatingsManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlStatistics);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "RatingsManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ratings Management";
            this.Load += new System.EventHandler(this.RatingsManagementForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRatings)).EndInit();
            this.pnlStatistics.ResumeLayout(false);
            this.pnlStatistics.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboRating;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.ComboBox cboUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox cboFood;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView dgvRatings;
        private System.Windows.Forms.Panel pnlStatistics;
        private System.Windows.Forms.Label lblRatingDistribution;
        private System.Windows.Forms.Label lblAverageRating;
        private System.Windows.Forms.Label lblTotalRatings;
        private System.Windows.Forms.Button btnExport;
    }
}