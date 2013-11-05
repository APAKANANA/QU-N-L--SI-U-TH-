namespace QuanLySieuThi
{
    partial class frmSanpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanpham));
            this.ts1 = new System.Windows.Forms.ToolStrip();
            this.btnUpdate = new System.Windows.Forms.ToolStripButton();
            this.grpThongtin = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ts2 = new System.Windows.Forms.ToolStrip();
            this.btnOK = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.txtLoai = new System.Windows.Forms.TextBox();
            this.txtNc = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtMasp = new System.Windows.Forms.TextBox();
            this.txtTensp = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.lbldvt = new System.Windows.Forms.Label();
            this.lblMasp = new System.Windows.Forms.Label();
            this.blbGianhap = new System.Windows.Forms.Label();
            this.lblTensp = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.ts3 = new System.Windows.Forms.ToolStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.grvSanPham = new System.Windows.Forms.DataGridView();
            this.Masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nuocsx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loaisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsExit = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tsbtnSearch = new System.Windows.Forms.ToolStrip();
            this.txtName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.ts1.SuspendLayout();
            this.grpThongtin.SuspendLayout();
            this.ts2.SuspendLayout();
            this.ts3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvSanPham)).BeginInit();
            this.tsExit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tsbtnSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // ts1
            // 
            this.ts1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ts1.Dock = System.Windows.Forms.DockStyle.None;
            this.ts1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUpdate});
            this.ts1.Location = new System.Drawing.Point(548, 73);
            this.ts1.Name = "ts1";
            this.ts1.Size = new System.Drawing.Size(48, 39);
            this.ts1.TabIndex = 22;
            this.ts1.Text = "toolStrip1";
            // 
            // btnUpdate
            // 
            this.btnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(36, 36);
            this.btnUpdate.Text = "tsbtnUpdate";
            this.btnUpdate.ToolTipText = "Sửa";
            // 
            // grpThongtin
            // 
            this.grpThongtin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpThongtin.BackColor = System.Drawing.Color.LightYellow;
            this.grpThongtin.Controls.Add(this.ts1);
            this.grpThongtin.Controls.Add(this.label3);
            this.grpThongtin.Controls.Add(this.label1);
            this.grpThongtin.Controls.Add(this.ts2);
            this.grpThongtin.Controls.Add(this.txtLoai);
            this.grpThongtin.Controls.Add(this.txtNc);
            this.grpThongtin.Controls.Add(this.txtGiaNhap);
            this.grpThongtin.Controls.Add(this.txtMasp);
            this.grpThongtin.Controls.Add(this.txtTensp);
            this.grpThongtin.Controls.Add(this.txtGia);
            this.grpThongtin.Controls.Add(this.txtDVT);
            this.grpThongtin.Controls.Add(this.lbldvt);
            this.grpThongtin.Controls.Add(this.lblMasp);
            this.grpThongtin.Controls.Add(this.blbGianhap);
            this.grpThongtin.Controls.Add(this.lblTensp);
            this.grpThongtin.Controls.Add(this.lblGia);
            this.grpThongtin.Enabled = false;
            this.grpThongtin.Location = new System.Drawing.Point(19, 58);
            this.grpThongtin.Name = "grpThongtin";
            this.grpThongtin.Size = new System.Drawing.Size(756, 133);
            this.grpThongtin.TabIndex = 21;
            this.grpThongtin.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(530, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Loại sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nước sản xuất";
            // 
            // ts2
            // 
            this.ts2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ts2.Dock = System.Windows.Forms.DockStyle.None;
            this.ts2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOK,
            this.toolStripSeparator3,
            this.btnCancel});
            this.ts2.Location = new System.Drawing.Point(596, 74);
            this.ts2.Name = "ts2";
            this.ts2.Size = new System.Drawing.Size(90, 39);
            this.ts2.TabIndex = 25;
            this.ts2.Text = "toolStrip3";
            // 
            // btnOK
            // 
            this.btnOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(36, 36);
            this.btnOK.Text = "toolStripButton4";
            this.btnOK.ToolTipText = "OK";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // btnCancel
            // 
            this.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(36, 36);
            this.btnCancel.Text = "toolStripButton5";
            this.btnCancel.ToolTipText = "Cancel";
            // 
            // txtLoai
            // 
            this.txtLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoai.Location = new System.Drawing.Point(643, 17);
            this.txtLoai.Name = "txtLoai";
            this.txtLoai.Size = new System.Drawing.Size(100, 22);
            this.txtLoai.TabIndex = 13;
            // 
            // txtNc
            // 
            this.txtNc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNc.Location = new System.Drawing.Point(382, 90);
            this.txtNc.Name = "txtNc";
            this.txtNc.Size = new System.Drawing.Size(100, 22);
            this.txtNc.TabIndex = 11;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaNhap.Location = new System.Drawing.Point(382, 16);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(100, 22);
            this.txtGiaNhap.TabIndex = 4;
            // 
            // txtMasp
            // 
            this.txtMasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasp.Location = new System.Drawing.Point(125, 16);
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.Size = new System.Drawing.Size(100, 22);
            this.txtMasp.TabIndex = 1;
            // 
            // txtTensp
            // 
            this.txtTensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTensp.Location = new System.Drawing.Point(125, 54);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(100, 22);
            this.txtTensp.TabIndex = 2;
            // 
            // txtGia
            // 
            this.txtGia.Enabled = false;
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(125, 90);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(100, 22);
            this.txtGia.TabIndex = 3;
            // 
            // txtDVT
            // 
            this.txtDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDVT.Location = new System.Drawing.Point(382, 54);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(100, 22);
            this.txtDVT.TabIndex = 5;
            // 
            // lbldvt
            // 
            this.lbldvt.AutoSize = true;
            this.lbldvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldvt.Location = new System.Drawing.Point(284, 60);
            this.lbldvt.Name = "lbldvt";
            this.lbldvt.Size = new System.Drawing.Size(68, 16);
            this.lbldvt.TabIndex = 10;
            this.lbldvt.Text = "Đơn vị tính";
            // 
            // lblMasp
            // 
            this.lblMasp.AutoSize = true;
            this.lblMasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasp.Location = new System.Drawing.Point(23, 19);
            this.lblMasp.Name = "lblMasp";
            this.lblMasp.Size = new System.Drawing.Size(89, 16);
            this.lblMasp.TabIndex = 6;
            this.lblMasp.Text = "Mã sản phẩm";
            // 
            // blbGianhap
            // 
            this.blbGianhap.AutoSize = true;
            this.blbGianhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbGianhap.Location = new System.Drawing.Point(284, 23);
            this.blbGianhap.Name = "blbGianhap";
            this.blbGianhap.Size = new System.Drawing.Size(62, 16);
            this.blbGianhap.TabIndex = 9;
            this.blbGianhap.Text = "Giá nhập";
            // 
            // lblTensp
            // 
            this.lblTensp.AutoSize = true;
            this.lblTensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTensp.Location = new System.Drawing.Point(23, 61);
            this.lblTensp.Name = "lblTensp";
            this.lblTensp.Size = new System.Drawing.Size(94, 16);
            this.lblTensp.TabIndex = 7;
            this.lblTensp.Text = "Tên sản phẩm";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(23, 97);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(55, 16);
            this.lblGia.TabIndex = 8;
            this.lblGia.Text = "Giá bán";
            // 
            // ts3
            // 
            this.ts3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ts3.Dock = System.Windows.Forms.DockStyle.None;
            this.ts3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh});
            this.ts3.Location = new System.Drawing.Point(589, 13);
            this.ts3.Name = "ts3";
            this.ts3.Size = new System.Drawing.Size(48, 39);
            this.ts3.TabIndex = 24;
            this.ts3.Text = "toolStrip2";
            this.ts3.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 36);
            this.btnRefresh.Text = "toolStripButton1";
            this.btnRefresh.ToolTipText = "Reload";
            // 
            // grvSanPham
            // 
            this.grvSanPham.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masp,
            this.Tensp,
            this.Giaban,
            this.Gianhap,
            this.DVT,
            this.Nuocsx,
            this.Loaisp});
            this.grvSanPham.Location = new System.Drawing.Point(19, 202);
            this.grvSanPham.Name = "grvSanPham";
            this.grvSanPham.Size = new System.Drawing.Size(756, 220);
            this.grvSanPham.TabIndex = 20;
            // 
            // Masp
            // 
            this.Masp.DataPropertyName = "Masp";
            this.Masp.HeaderText = "Mã sản phẩm";
            this.Masp.Name = "Masp";
            // 
            // Tensp
            // 
            this.Tensp.DataPropertyName = "Tensp";
            this.Tensp.HeaderText = "Tên sản phẩm";
            this.Tensp.Name = "Tensp";
            // 
            // Giaban
            // 
            this.Giaban.DataPropertyName = "Giaban";
            this.Giaban.HeaderText = "Giá bán";
            this.Giaban.Name = "Giaban";
            // 
            // Gianhap
            // 
            this.Gianhap.DataPropertyName = "Gianhap";
            this.Gianhap.HeaderText = "Giá nhập";
            this.Gianhap.Name = "Gianhap";
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.Name = "DVT";
            // 
            // Nuocsx
            // 
            this.Nuocsx.DataPropertyName = "Nuocsx";
            this.Nuocsx.HeaderText = "Nước sản xuất";
            this.Nuocsx.Name = "Nuocsx";
            // 
            // Loaisp
            // 
            this.Loaisp.DataPropertyName = "Loaisp";
            this.Loaisp.HeaderText = "Loại sản phẩm";
            this.Loaisp.Name = "Loaisp";
            // 
            // tsExit
            // 
            this.tsExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tsExit.Dock = System.Windows.Forms.DockStyle.None;
            this.tsExit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.toolStripSeparator4});
            this.tsExit.Location = new System.Drawing.Point(668, 0);
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(86, 71);
            this.tsExit.TabIndex = 35;
            this.tsExit.Text = "toolStrip3";
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(68, 68);
            this.btnExit.Text = "toolStripButton4";
            this.btnExit.ToolTipText = "Exit";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 71);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(19, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 42);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(206, 12);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(131, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Loại sản phẩm";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(46, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(128, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tên sản phẩm";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // tsbtnSearch
            // 
            this.tsbtnSearch.Dock = System.Windows.Forms.DockStyle.None;
            this.tsbtnSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtName,
            this.toolStripSeparator1,
            this.btnSearch});
            this.tsbtnSearch.Location = new System.Drawing.Point(413, 13);
            this.tsbtnSearch.Name = "tsbtnSearch";
            this.tsbtnSearch.Size = new System.Drawing.Size(156, 39);
            this.tsbtnSearch.TabIndex = 37;
            this.tsbtnSearch.Text = "toolStrip1";
            // 
            // txtName
            // 
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 39);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnSearch
            // 
            this.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 36);
            this.btnSearch.Text = "toolStripButton1";
            this.btnSearch.ToolTipText = "Tìm kiếm theo tên";
            // 
            // frmSanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(796, 433);
            this.Controls.Add(this.tsbtnSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tsExit);
            this.Controls.Add(this.grpThongtin);
            this.Controls.Add(this.ts3);
            this.Controls.Add(this.grvSanPham);
            this.Name = "frmSanpham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sản phẩm";
            this.ts1.ResumeLayout(false);
            this.ts1.PerformLayout();
            this.grpThongtin.ResumeLayout(false);
            this.grpThongtin.PerformLayout();
            this.ts2.ResumeLayout(false);
            this.ts2.PerformLayout();
            this.ts3.ResumeLayout(false);
            this.ts3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvSanPham)).EndInit();
            this.tsExit.ResumeLayout(false);
            this.tsExit.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tsbtnSearch.ResumeLayout(false);
            this.tsbtnSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ts1;
        private System.Windows.Forms.GroupBox grpThongtin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoai;
        private System.Windows.Forms.TextBox txtNc;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtMasp;
        private System.Windows.Forms.TextBox txtTensp;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Label lbldvt;
        private System.Windows.Forms.Label lblMasp;
        private System.Windows.Forms.Label blbGianhap;
        private System.Windows.Forms.Label lblTensp;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStrip ts3;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStrip ts2;
        private System.Windows.Forms.ToolStripButton btnOK;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.DataGridView grvSanPham;
        private System.Windows.Forms.ToolStripButton btnUpdate;
        private System.Windows.Forms.ToolStrip tsExit;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ToolStrip tsbtnSearch;
        private System.Windows.Forms.ToolStripTextBox txtName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nuocsx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loaisp;

    }
}