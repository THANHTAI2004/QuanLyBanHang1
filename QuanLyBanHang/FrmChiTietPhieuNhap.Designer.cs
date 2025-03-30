namespace QuanLyBanHang
{
    partial class FrmChiTietPhieuNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iconPictureBox8 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhaPhanPhoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnToday = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataChiTietPhieuNhap)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconPictureBox8
            // 
            this.iconPictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconPictureBox8.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.iconPictureBox8.IconColor = System.Drawing.Color.White;
            this.iconPictureBox8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox8.IconSize = 90;
            this.iconPictureBox8.Location = new System.Drawing.Point(1827, 3);
            this.iconPictureBox8.Name = "iconPictureBox8";
            this.iconPictureBox8.Size = new System.Drawing.Size(90, 94);
            this.iconPictureBox8.TabIndex = 38;
            this.iconPictureBox8.TabStop = false;
            this.iconPictureBox8.Click += new System.EventHandler(this.iconPictureBox8_Click);
            // 
            // iconPictureBox7
            // 
            this.iconPictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconPictureBox7.IconColor = System.Drawing.Color.White;
            this.iconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox7.IconSize = 90;
            this.iconPictureBox7.Location = new System.Drawing.Point(1731, 3);
            this.iconPictureBox7.Name = "iconPictureBox7";
            this.iconPictureBox7.Size = new System.Drawing.Size(90, 94);
            this.iconPictureBox7.TabIndex = 37;
            this.iconPictureBox7.TabStop = false;
            this.iconPictureBox7.Click += new System.EventHandler(this.iconPictureBox7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(195, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1530, 100);
            this.label3.TabIndex = 124;
            this.label3.Text = "Chi tiết phiếu nhập";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataChiTietPhieuNhap
            // 
            this.dataChiTietPhieuNhap.AllowUserToAddRows = false;
            this.dataChiTietPhieuNhap.AllowUserToDeleteRows = false;
            this.dataChiTietPhieuNhap.AllowUserToResizeColumns = false;
            this.dataChiTietPhieuNhap.AllowUserToResizeRows = false;
            this.dataChiTietPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataChiTietPhieuNhap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.dataChiTietPhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataChiTietPhieuNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataChiTietPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataChiTietPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.colTenSP,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.colNhaPhanPhoi});
            this.dataChiTietPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataChiTietPhieuNhap.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataChiTietPhieuNhap.EnableHeadersVisualStyles = false;
            this.dataChiTietPhieuNhap.GridColor = System.Drawing.Color.LightSlateGray;
            this.dataChiTietPhieuNhap.Location = new System.Drawing.Point(240, 50);
            this.dataChiTietPhieuNhap.Margin = new System.Windows.Forms.Padding(50);
            this.dataChiTietPhieuNhap.MultiSelect = false;
            this.dataChiTietPhieuNhap.Name = "dataChiTietPhieuNhap";
            this.dataChiTietPhieuNhap.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataChiTietPhieuNhap.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataChiTietPhieuNhap.RowHeadersVisible = false;
            this.dataChiTietPhieuNhap.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataChiTietPhieuNhap.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataChiTietPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataChiTietPhieuNhap.Size = new System.Drawing.Size(1439, 615);
            this.dataChiTietPhieuNhap.TabIndex = 125;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "MaPN";
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Mã PN";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // colTenSP
            // 
            this.colTenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTenSP.DataPropertyName = "TenSP";
            this.colTenSP.Frozen = true;
            this.colTenSP.HeaderText = "Tên Sản Phẩm";
            this.colTenSP.MinimumWidth = 6;
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.ReadOnly = true;
            this.colTenSP.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaSP";
            this.Column3.HeaderText = "Mã SP";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DonGiaNhap";
            this.Column4.HeaderText = "Đơn giá nhập";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SoLuongNhap";
            this.Column5.HeaderText = "Số lượng nhập";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NgayNhap";
            this.Column6.HeaderText = "Ngày nhập";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // colNhaPhanPhoi
            // 
            this.colNhaPhanPhoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNhaPhanPhoi.DataPropertyName = "TenNSX";
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colNhaPhanPhoi.DefaultCellStyle = dataGridViewCellStyle6;
            this.colNhaPhanPhoi.HeaderText = "Nhà Phân Phối";
            this.colNhaPhanPhoi.MinimumWidth = 6;
            this.colNhaPhanPhoi.Name = "colNhaPhanPhoi";
            this.colNhaPhanPhoi.ReadOnly = true;
            this.colNhaPhanPhoi.Width = 124;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnXuatExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatExcel.FlatAppearance.BorderSize = 0;
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(1049, 41);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(128, 34);
            this.btnXuatExcel.TabIndex = 132;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(820, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 32);
            this.dateTimePicker1.TabIndex = 131;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(816, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 19);
            this.label2.TabIndex = 130;
            this.label2.Text = "Lọc theo ngày tháng năm";
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(656, 54);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(77, 34);
            this.btnReload.TabIndex = 129;
            this.btnReload.Text = "Tìm kiếm";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(367, 88);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(238, 1);
            this.panel7.TabIndex = 127;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.White;
            this.txtTimKiem.Location = new System.Drawing.Point(370, 63);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(238, 19);
            this.txtTimKiem.TabIndex = 128;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(366, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 19);
            this.label1.TabIndex = 126;
            this.label1.Text = "Tìm kiếm tên sản phẩm từng nhập";
            // 
            // btnToday
            // 
            this.btnToday.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToday.FlatAppearance.BorderSize = 0;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.ForeColor = System.Drawing.Color.White;
            this.btnToday.Location = new System.Drawing.Point(367, 107);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(128, 34);
            this.btnToday.TabIndex = 134;
            this.btnToday.Text = "Hôm nay";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.iconPictureBox7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.iconPictureBox8, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1920, 100);
            this.tableLayoutPanel1.TabIndex = 135;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnToday);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.btnXuatExcel);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(193, 718);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1533, 259);
            this.panel1.TabIndex = 136;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.895833F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.15625F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.895833F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dataChiTietPhieuNhap, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.95918F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.04082F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1920, 980);
            this.tableLayoutPanel2.TabIndex = 137;
            // 
            // FrmChiTietPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmChiTietPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmChiTietPhieuNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmChiTietPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataChiTietPhieuNhap)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox8;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataChiTietPhieuNhap;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhaPhanPhoi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}