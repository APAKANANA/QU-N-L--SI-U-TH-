﻿namespace QuanLySieuThi
{
    partial class frmNhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanvien));
            this.optPhongban = new System.Windows.Forms.RadioButton();
            this.optCmnd = new System.Windows.Forms.RadioButton();
            this.optHoten = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optMaNV = new System.Windows.Forms.RadioButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnOK = new System.Windows.Forms.ToolStripButton();
            this.ts2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.ts3 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnInsert = new System.Windows.Forms.ToolStripButton();
            this.ts1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnSearch = new System.Windows.Forms.ToolStrip();
            this.txtName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.lblManv = new System.Windows.Forms.Label();
            this.lblTennv = new System.Windows.Forms.Label();
            this.lblGtinh = new System.Windows.Forms.Label();
            this.lblCmnd = new System.Windows.Forms.Label();
            this.lblNgsinh = new System.Windows.Forms.Label();
            this.lblNgayvl = new System.Windows.Forms.Label();
            this.lblDchi = new System.Windows.Forms.Label();
            this.lblDthoai = new System.Windows.Forms.Label();
            this.lblMapb = new System.Windows.Forms.Label();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.txtTennv = new System.Windows.Forms.TextBox();
            this.txtGtinh = new System.Windows.Forms.TextBox();
            this.txtCmnd = new System.Windows.Forms.TextBox();
            this.txtDchi = new System.Windows.Forms.TextBox();
            this.txtDthoai = new System.Windows.Forms.TextBox();
            this.txtMapb = new System.Windows.Forms.TextBox();
            this.grptxt = new System.Windows.Forms.GroupBox();
            this.dtpNgvl = new System.Windows.Forms.DateTimePicker();
            this.dtpNgsinh = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYVL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInbaocao = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.ts2.SuspendLayout();
            this.ts3.SuspendLayout();
            this.ts1.SuspendLayout();
            this.tsbtnSearch.SuspendLayout();
            this.grptxt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // optPhongban
            // 
            this.optPhongban.AutoSize = true;
            this.optPhongban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optPhongban.ForeColor = System.Drawing.Color.Black;
            this.optPhongban.Location = new System.Drawing.Point(428, 12);
            this.optPhongban.Name = "optPhongban";
            this.optPhongban.Size = new System.Drawing.Size(104, 24);
            this.optPhongban.TabIndex = 2;
            this.optPhongban.Text = "Phòng ban";
            this.optPhongban.UseVisualStyleBackColor = true;
            this.optPhongban.CheckedChanged += new System.EventHandler(this.optPhongban_CheckedChanged);
            // 
            // optCmnd
            // 
            this.optCmnd.AutoSize = true;
            this.optCmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optCmnd.ForeColor = System.Drawing.Color.Black;
            this.optCmnd.Location = new System.Drawing.Point(300, 12);
            this.optCmnd.Name = "optCmnd";
            this.optCmnd.Size = new System.Drawing.Size(74, 24);
            this.optCmnd.TabIndex = 2;
            this.optCmnd.Text = "CMND";
            this.optCmnd.UseVisualStyleBackColor = true;
            this.optCmnd.CheckedChanged += new System.EventHandler(this.optCmnd_CheckedChanged);
            // 
            // optHoten
            // 
            this.optHoten.AutoSize = true;
            this.optHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optHoten.ForeColor = System.Drawing.Color.Black;
            this.optHoten.Location = new System.Drawing.Point(149, 12);
            this.optHoten.Name = "optHoten";
            this.optHoten.Size = new System.Drawing.Size(79, 24);
            this.optHoten.TabIndex = 1;
            this.optHoten.Text = "Họ Tên";
            this.optHoten.UseVisualStyleBackColor = true;
            this.optHoten.CheckedChanged += new System.EventHandler(this.optHoten_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optPhongban);
            this.groupBox1.Controls.Add(this.optCmnd);
            this.groupBox1.Controls.Add(this.optHoten);
            this.groupBox1.Controls.Add(this.optMaNV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 42);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo:";
            // 
            // optMaNV
            // 
            this.optMaNV.AutoSize = true;
            this.optMaNV.Checked = true;
            this.optMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMaNV.ForeColor = System.Drawing.Color.Black;
            this.optMaNV.Location = new System.Drawing.Point(33, 12);
            this.optMaNV.Name = "optMaNV";
            this.optMaNV.Size = new System.Drawing.Size(49, 24);
            this.optMaNV.TabIndex = 0;
            this.optMaNV.TabStop = true;
            this.optMaNV.Text = "Mã";
            this.optMaNV.UseVisualStyleBackColor = true;
            this.optMaNV.CheckedChanged += new System.EventHandler(this.optMaNV_CheckedChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 34);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 31);
            this.btnExit.Text = "toolStripButton4";
            this.btnExit.ToolTipText = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toolStrip3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.toolStripSeparator4});
            this.toolStrip3.Location = new System.Drawing.Point(705, 401);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(73, 34);
            this.toolStrip3.TabIndex = 48;
            this.toolStrip3.Text = "toolStrip3";
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
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ts2
            // 
            this.ts2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ts2.Dock = System.Windows.Forms.DockStyle.None;
            this.ts2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOK,
            this.toolStripSeparator3,
            this.btnCancel});
            this.ts2.Location = new System.Drawing.Point(569, 396);
            this.ts2.Name = "ts2";
            this.ts2.Size = new System.Drawing.Size(90, 39);
            this.ts2.TabIndex = 47;
            this.ts2.Text = "toolStrip3";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 36);
            this.btnRefresh.Text = "toolStripButton1";
            this.btnRefresh.ToolTipText = "Reload";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ts3
            // 
            this.ts3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ts3.Dock = System.Windows.Forms.DockStyle.None;
            this.ts3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh});
            this.ts3.Location = new System.Drawing.Point(655, 396);
            this.ts3.Name = "ts3";
            this.ts3.Size = new System.Drawing.Size(48, 39);
            this.ts3.TabIndex = 46;
            this.ts3.Text = "toolStrip2";
            this.ts3.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // btnDel
            // 
            this.btnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(36, 36);
            this.btnDel.Text = "tsbtnDel";
            this.btnDel.ToolTipText = "Xóa";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
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
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnInsert
            // 
            this.btnInsert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(36, 36);
            this.btnInsert.Text = "tsbtnInsert";
            this.btnInsert.ToolTipText = "Thêm";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // ts1
            // 
            this.ts1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ts1.Dock = System.Windows.Forms.DockStyle.None;
            this.ts1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInsert,
            this.toolStripSeparator1,
            this.btnUpdate,
            this.toolStripSeparator2,
            this.btnDel,
            this.toolStripSeparator5});
            this.ts1.Location = new System.Drawing.Point(440, 396);
            this.ts1.Name = "ts1";
            this.ts1.Size = new System.Drawing.Size(138, 39);
            this.ts1.TabIndex = 45;
            this.ts1.Text = "toolStrip1";
            // 
            // tsbtnSearch
            // 
            this.tsbtnSearch.Dock = System.Windows.Forms.DockStyle.None;
            this.tsbtnSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtName,
            this.toolStripSeparator6,
            this.btnSearch});
            this.tsbtnSearch.Location = new System.Drawing.Point(558, 9);
            this.tsbtnSearch.Name = "tsbtnSearch";
            this.tsbtnSearch.Size = new System.Drawing.Size(156, 39);
            this.tsbtnSearch.TabIndex = 3;
            this.tsbtnSearch.Text = "toolStrip1";
            // 
            // txtName
            // 
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 39);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
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
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblManv
            // 
            this.lblManv.AutoSize = true;
            this.lblManv.BackColor = System.Drawing.Color.LightCyan;
            this.lblManv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManv.ForeColor = System.Drawing.Color.Black;
            this.lblManv.Location = new System.Drawing.Point(537, 72);
            this.lblManv.Name = "lblManv";
            this.lblManv.Size = new System.Drawing.Size(45, 15);
            this.lblManv.TabIndex = 50;
            this.lblManv.Text = "MaNV";
            // 
            // lblTennv
            // 
            this.lblTennv.AutoSize = true;
            this.lblTennv.BackColor = System.Drawing.Color.LightCyan;
            this.lblTennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTennv.ForeColor = System.Drawing.Color.Black;
            this.lblTennv.Location = new System.Drawing.Point(537, 104);
            this.lblTennv.Name = "lblTennv";
            this.lblTennv.Size = new System.Drawing.Size(49, 15);
            this.lblTennv.TabIndex = 51;
            this.lblTennv.Text = "TenNV";
            // 
            // lblGtinh
            // 
            this.lblGtinh.AutoSize = true;
            this.lblGtinh.BackColor = System.Drawing.Color.LightCyan;
            this.lblGtinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGtinh.ForeColor = System.Drawing.Color.Black;
            this.lblGtinh.Location = new System.Drawing.Point(537, 139);
            this.lblGtinh.Name = "lblGtinh";
            this.lblGtinh.Size = new System.Drawing.Size(45, 15);
            this.lblGtinh.TabIndex = 52;
            this.lblGtinh.Text = "GTinh";
            // 
            // lblCmnd
            // 
            this.lblCmnd.AutoSize = true;
            this.lblCmnd.BackColor = System.Drawing.Color.LightCyan;
            this.lblCmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmnd.ForeColor = System.Drawing.Color.Black;
            this.lblCmnd.Location = new System.Drawing.Point(537, 174);
            this.lblCmnd.Name = "lblCmnd";
            this.lblCmnd.Size = new System.Drawing.Size(48, 15);
            this.lblCmnd.TabIndex = 53;
            this.lblCmnd.Text = "CMND";
            // 
            // lblNgsinh
            // 
            this.lblNgsinh.AutoSize = true;
            this.lblNgsinh.BackColor = System.Drawing.Color.LightCyan;
            this.lblNgsinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgsinh.ForeColor = System.Drawing.Color.Black;
            this.lblNgsinh.Location = new System.Drawing.Point(537, 210);
            this.lblNgsinh.Name = "lblNgsinh";
            this.lblNgsinh.Size = new System.Drawing.Size(54, 15);
            this.lblNgsinh.TabIndex = 54;
            this.lblNgsinh.Text = "NgSinh";
            // 
            // lblNgayvl
            // 
            this.lblNgayvl.AutoSize = true;
            this.lblNgayvl.BackColor = System.Drawing.Color.LightCyan;
            this.lblNgayvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayvl.ForeColor = System.Drawing.Color.Black;
            this.lblNgayvl.Location = new System.Drawing.Point(537, 249);
            this.lblNgayvl.Name = "lblNgayvl";
            this.lblNgayvl.Size = new System.Drawing.Size(55, 15);
            this.lblNgayvl.TabIndex = 55;
            this.lblNgayvl.Text = "NgayVL";
            // 
            // lblDchi
            // 
            this.lblDchi.AutoSize = true;
            this.lblDchi.BackColor = System.Drawing.Color.LightCyan;
            this.lblDchi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDchi.ForeColor = System.Drawing.Color.Black;
            this.lblDchi.Location = new System.Drawing.Point(537, 288);
            this.lblDchi.Name = "lblDchi";
            this.lblDchi.Size = new System.Drawing.Size(38, 15);
            this.lblDchi.TabIndex = 56;
            this.lblDchi.Text = "DChi";
            // 
            // lblDthoai
            // 
            this.lblDthoai.AutoSize = true;
            this.lblDthoai.BackColor = System.Drawing.Color.LightCyan;
            this.lblDthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDthoai.ForeColor = System.Drawing.Color.Black;
            this.lblDthoai.Location = new System.Drawing.Point(537, 325);
            this.lblDthoai.Name = "lblDthoai";
            this.lblDthoai.Size = new System.Drawing.Size(53, 15);
            this.lblDthoai.TabIndex = 57;
            this.lblDthoai.Text = "DThoai";
            // 
            // lblMapb
            // 
            this.lblMapb.AutoSize = true;
            this.lblMapb.BackColor = System.Drawing.Color.LightCyan;
            this.lblMapb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapb.ForeColor = System.Drawing.Color.Black;
            this.lblMapb.Location = new System.Drawing.Point(537, 361);
            this.lblMapb.Name = "lblMapb";
            this.lblMapb.Size = new System.Drawing.Size(45, 15);
            this.lblMapb.TabIndex = 58;
            this.lblMapb.Text = "MaPB";
            // 
            // txtManv
            // 
            this.txtManv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManv.Location = new System.Drawing.Point(11, 13);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(106, 21);
            this.txtManv.TabIndex = 60;
            // 
            // txtTennv
            // 
            this.txtTennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTennv.Location = new System.Drawing.Point(11, 42);
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Size = new System.Drawing.Size(105, 21);
            this.txtTennv.TabIndex = 61;
            // 
            // txtGtinh
            // 
            this.txtGtinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGtinh.Location = new System.Drawing.Point(11, 77);
            this.txtGtinh.Name = "txtGtinh";
            this.txtGtinh.Size = new System.Drawing.Size(104, 21);
            this.txtGtinh.TabIndex = 62;
            // 
            // txtCmnd
            // 
            this.txtCmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCmnd.Location = new System.Drawing.Point(11, 112);
            this.txtCmnd.Name = "txtCmnd";
            this.txtCmnd.Size = new System.Drawing.Size(105, 21);
            this.txtCmnd.TabIndex = 63;
            // 
            // txtDchi
            // 
            this.txtDchi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDchi.Location = new System.Drawing.Point(11, 226);
            this.txtDchi.Name = "txtDchi";
            this.txtDchi.Size = new System.Drawing.Size(105, 21);
            this.txtDchi.TabIndex = 66;
            // 
            // txtDthoai
            // 
            this.txtDthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDthoai.Location = new System.Drawing.Point(11, 262);
            this.txtDthoai.Name = "txtDthoai";
            this.txtDthoai.Size = new System.Drawing.Size(104, 21);
            this.txtDthoai.TabIndex = 67;
            // 
            // txtMapb
            // 
            this.txtMapb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMapb.Location = new System.Drawing.Point(11, 299);
            this.txtMapb.Name = "txtMapb";
            this.txtMapb.Size = new System.Drawing.Size(104, 21);
            this.txtMapb.TabIndex = 68;
            // 
            // grptxt
            // 
            this.grptxt.Controls.Add(this.dtpNgvl);
            this.grptxt.Controls.Add(this.dtpNgsinh);
            this.grptxt.Controls.Add(this.txtManv);
            this.grptxt.Controls.Add(this.txtMapb);
            this.grptxt.Controls.Add(this.txtTennv);
            this.grptxt.Controls.Add(this.txtDthoai);
            this.grptxt.Controls.Add(this.txtGtinh);
            this.grptxt.Controls.Add(this.txtDchi);
            this.grptxt.Controls.Add(this.txtCmnd);
            this.grptxt.Location = new System.Drawing.Point(598, 56);
            this.grptxt.Name = "grptxt";
            this.grptxt.Size = new System.Drawing.Size(159, 342);
            this.grptxt.TabIndex = 69;
            this.grptxt.TabStop = false;
            // 
            // dtpNgvl
            // 
            this.dtpNgvl.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgvl.Location = new System.Drawing.Point(11, 188);
            this.dtpNgvl.Name = "dtpNgvl";
            this.dtpNgvl.Size = new System.Drawing.Size(106, 20);
            this.dtpNgvl.TabIndex = 65;
            // 
            // dtpNgsinh
            // 
            this.dtpNgsinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgsinh.Location = new System.Drawing.Point(11, 149);
            this.dtpNgsinh.Name = "dtpNgsinh";
            this.dtpNgsinh.Size = new System.Drawing.Size(106, 20);
            this.dtpNgsinh.TabIndex = 64;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.TENNV,
            this.GIOITINH,
            this.CMND,
            this.NGAYSINH,
            this.NGAYVL,
            this.DCHI,
            this.DTHOAI,
            this.MAPB});
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(504, 319);
            this.dataGridView1.TabIndex = 59;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã NV";
            this.MANV.Name = "MANV";
            // 
            // TENNV
            // 
            this.TENNV.DataPropertyName = "TENNV";
            this.TENNV.HeaderText = "Tên NV";
            this.TENNV.Name = "TENNV";
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới Tính";
            this.GIOITINH.Name = "GIOITINH";
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày Sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            // 
            // NGAYVL
            // 
            this.NGAYVL.DataPropertyName = "NGAYVL";
            this.NGAYVL.HeaderText = "Ngày Vào Làm";
            this.NGAYVL.Name = "NGAYVL";
            // 
            // DCHI
            // 
            this.DCHI.DataPropertyName = "DCHI";
            this.DCHI.HeaderText = "Địa Chỉ";
            this.DCHI.Name = "DCHI";
            // 
            // DTHOAI
            // 
            this.DTHOAI.DataPropertyName = "DTHOAI";
            this.DTHOAI.HeaderText = "Điện Thoại";
            this.DTHOAI.Name = "DTHOAI";
            // 
            // MAPB
            // 
            this.MAPB.DataPropertyName = "MAPB";
            this.MAPB.HeaderText = "Mã Phòng";
            this.MAPB.Name = "MAPB";
            // 
            // btnInbaocao
            // 
            this.btnInbaocao.Location = new System.Drawing.Point(120, 415);
            this.btnInbaocao.Name = "btnInbaocao";
            this.btnInbaocao.Size = new System.Drawing.Size(75, 23);
            this.btnInbaocao.TabIndex = 70;
            this.btnInbaocao.Text = "In Báo Cáo";
            this.btnInbaocao.UseVisualStyleBackColor = true;
            this.btnInbaocao.Click += new System.EventHandler(this.btnInbaocao_Click);
            // 
            // frmNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(769, 444);
            this.Controls.Add(this.btnInbaocao);
            this.Controls.Add(this.grptxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblMapb);
            this.Controls.Add(this.lblDthoai);
            this.Controls.Add(this.lblDchi);
            this.Controls.Add(this.lblNgayvl);
            this.Controls.Add(this.lblNgsinh);
            this.Controls.Add(this.lblCmnd);
            this.Controls.Add(this.lblGtinh);
            this.Controls.Add(this.lblTennv);
            this.Controls.Add(this.lblManv);
            this.Controls.Add(this.tsbtnSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.ts2);
            this.Controls.Add(this.ts3);
            this.Controls.Add(this.ts1);
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.Name = "frmNhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhanvien";
            this.Load += new System.EventHandler(this.frmNhanvien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ts2.ResumeLayout(false);
            this.ts2.PerformLayout();
            this.ts3.ResumeLayout(false);
            this.ts3.PerformLayout();
            this.ts1.ResumeLayout(false);
            this.ts1.PerformLayout();
            this.tsbtnSearch.ResumeLayout(false);
            this.tsbtnSearch.PerformLayout();
            this.grptxt.ResumeLayout(false);
            this.grptxt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optPhongban;
        private System.Windows.Forms.RadioButton optCmnd;
        private System.Windows.Forms.RadioButton optHoten;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optMaNV;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripButton btnOK;
        private System.Windows.Forms.ToolStrip ts2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStrip ts3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnInsert;
        private System.Windows.Forms.ToolStrip ts1;
        private System.Windows.Forms.ToolStrip tsbtnSearch;
        private System.Windows.Forms.ToolStripTextBox txtName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.Label lblManv;
        private System.Windows.Forms.Label lblTennv;
        private System.Windows.Forms.Label lblGtinh;
        private System.Windows.Forms.Label lblCmnd;
        private System.Windows.Forms.Label lblNgsinh;
        private System.Windows.Forms.Label lblNgayvl;
        private System.Windows.Forms.Label lblDchi;
        private System.Windows.Forms.Label lblDthoai;
        private System.Windows.Forms.Label lblMapb;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.TextBox txtTennv;
        private System.Windows.Forms.TextBox txtGtinh;
        private System.Windows.Forms.TextBox txtCmnd;
        private System.Windows.Forms.TextBox txtDchi;
        private System.Windows.Forms.TextBox txtDthoai;
        private System.Windows.Forms.TextBox txtMapb;
        private System.Windows.Forms.GroupBox grptxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYVL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTHOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPB;
        private System.Windows.Forms.DateTimePicker dtpNgvl;
        private System.Windows.Forms.DateTimePicker dtpNgsinh;
        private System.Windows.Forms.Button btnInbaocao;
    }
}