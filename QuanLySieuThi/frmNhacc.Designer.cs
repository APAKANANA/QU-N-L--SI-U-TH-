namespace QuanLySieuThi
{
    partial class frmNhacc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhacc));
            this.ts1 = new System.Windows.Forms.ToolStrip();
            this.btnInsert = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ts3 = new System.Windows.Forms.ToolStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.ts2 = new System.Windows.Forms.ToolStrip();
            this.btnOK = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tsbtnSearch = new System.Windows.Forms.ToolStrip();
            this.txtName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblMancc = new System.Windows.Forms.Label();
            this.lblTenncc = new System.Windows.Forms.Label();
            this.lblDchi = new System.Windows.Forms.Label();
            this.lblDthoai = new System.Windows.Forms.Label();
            this.txtMancc = new System.Windows.Forms.TextBox();
            this.txtTenncc = new System.Windows.Forms.TextBox();
            this.txtDchi = new System.Windows.Forms.TextBox();
            this.txtDthoai = new System.Windows.Forms.TextBox();
            this.Mancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dchi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ts1.SuspendLayout();
            this.ts3.SuspendLayout();
            this.ts2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tsbtnSearch.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ts1
            // 
            this.ts1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ts1.Dock = System.Windows.Forms.DockStyle.None;
            this.ts1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInsert,
            this.toolStripSeparator1,
            this.btnUpdate,
            this.toolStripSeparator2});
            this.ts1.Location = new System.Drawing.Point(376, 302);
            this.ts1.Name = "ts1";
            this.ts1.Size = new System.Drawing.Size(96, 39);
            this.ts1.TabIndex = 47;
            this.ts1.Text = "toolStrip1";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // ts3
            // 
            this.ts3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ts3.Dock = System.Windows.Forms.DockStyle.None;
            this.ts3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh});
            this.ts3.Location = new System.Drawing.Point(554, 302);
            this.ts3.Name = "ts3";
            this.ts3.Size = new System.Drawing.Size(48, 39);
            this.ts3.TabIndex = 48;
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
            // ts2
            // 
            this.ts2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ts2.Dock = System.Windows.Forms.DockStyle.None;
            this.ts2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOK,
            this.toolStripSeparator3,
            this.btnCancel});
            this.ts2.Location = new System.Drawing.Point(464, 302);
            this.ts2.Name = "ts2";
            this.ts2.Size = new System.Drawing.Size(90, 39);
            this.ts2.TabIndex = 49;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tsbtnSearch);
            this.groupBox2.Location = new System.Drawing.Point(539, -5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 67);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            // 
            // tsbtnSearch
            // 
            this.tsbtnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsbtnSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtName,
            this.toolStripSeparator6,
            this.toolStripButton1});
            this.tsbtnSearch.Location = new System.Drawing.Point(3, 16);
            this.tsbtnSearch.Name = "tsbtnSearch";
            this.tsbtnSearch.Size = new System.Drawing.Size(157, 48);
            this.tsbtnSearch.TabIndex = 0;
            this.tsbtnSearch.Text = "toolStrip1";
            // 
            // txtName
            // 
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 48);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 48);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 45);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Nhập tên cần tìm";
            // 
            // toolStrip4
            // 
            this.toolStrip4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip4.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit});
            this.toolStrip4.Location = new System.Drawing.Point(619, 293);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(80, 71);
            this.toolStrip4.TabIndex = 53;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(68, 68);
            this.btnExit.Text = "toolStripButton9";
            this.btnExit.ToolTipText = "Thoát";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mancc,
            this.Tenncc,
            this.Dchi,
            this.Dthoai});
            this.dataGridView1.Location = new System.Drawing.Point(12, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(471, 269);
            this.dataGridView1.TabIndex = 54;
            // 
            // lblMancc
            // 
            this.lblMancc.AutoSize = true;
            this.lblMancc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMancc.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMancc.Location = new System.Drawing.Point(495, 104);
            this.lblMancc.Name = "lblMancc";
            this.lblMancc.Size = new System.Drawing.Size(55, 15);
            this.lblMancc.TabIndex = 55;
            this.lblMancc.Text = "MaNCC";
            // 
            // lblTenncc
            // 
            this.lblTenncc.AutoSize = true;
            this.lblTenncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenncc.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTenncc.Location = new System.Drawing.Point(495, 141);
            this.lblTenncc.Name = "lblTenncc";
            this.lblTenncc.Size = new System.Drawing.Size(59, 15);
            this.lblTenncc.TabIndex = 56;
            this.lblTenncc.Text = "TenNCC";
            // 
            // lblDchi
            // 
            this.lblDchi.AutoSize = true;
            this.lblDchi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDchi.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDchi.Location = new System.Drawing.Point(495, 179);
            this.lblDchi.Name = "lblDchi";
            this.lblDchi.Size = new System.Drawing.Size(38, 15);
            this.lblDchi.TabIndex = 57;
            this.lblDchi.Text = "DChi";
            // 
            // lblDthoai
            // 
            this.lblDthoai.AutoSize = true;
            this.lblDthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDthoai.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDthoai.Location = new System.Drawing.Point(495, 219);
            this.lblDthoai.Name = "lblDthoai";
            this.lblDthoai.Size = new System.Drawing.Size(53, 15);
            this.lblDthoai.TabIndex = 58;
            this.lblDthoai.Text = "DThoai";
            // 
            // txtMancc
            // 
            this.txtMancc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMancc.Location = new System.Drawing.Point(572, 99);
            this.txtMancc.Name = "txtMancc";
            this.txtMancc.Size = new System.Drawing.Size(100, 21);
            this.txtMancc.TabIndex = 59;
            // 
            // txtTenncc
            // 
            this.txtTenncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenncc.Location = new System.Drawing.Point(572, 136);
            this.txtTenncc.Name = "txtTenncc";
            this.txtTenncc.Size = new System.Drawing.Size(100, 21);
            this.txtTenncc.TabIndex = 60;
            // 
            // txtDchi
            // 
            this.txtDchi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDchi.Location = new System.Drawing.Point(572, 174);
            this.txtDchi.Name = "txtDchi";
            this.txtDchi.Size = new System.Drawing.Size(100, 21);
            this.txtDchi.TabIndex = 61;
            // 
            // txtDthoai
            // 
            this.txtDthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDthoai.Location = new System.Drawing.Point(572, 214);
            this.txtDthoai.Name = "txtDthoai";
            this.txtDthoai.Size = new System.Drawing.Size(100, 21);
            this.txtDthoai.TabIndex = 62;
            // 
            // Mancc
            // 
            this.Mancc.DataPropertyName = "MANCC";
            this.Mancc.HeaderText = "Mã";
            this.Mancc.Name = "Mancc";
            // 
            // Tenncc
            // 
            this.Tenncc.DataPropertyName = "TENNCC";
            this.Tenncc.HeaderText = "Tên";
            this.Tenncc.Name = "Tenncc";
            // 
            // Dchi
            // 
            this.Dchi.DataPropertyName = "DCHI";
            this.Dchi.HeaderText = "Địa chỉ";
            this.Dchi.Name = "Dchi";
            // 
            // Dthoai
            // 
            this.Dthoai.DataPropertyName = "DTHOAI";
            this.Dthoai.HeaderText = "Điện thoại";
            this.Dthoai.Name = "Dthoai";
            // 
            // frmNhacc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(699, 363);
            this.Controls.Add(this.txtDthoai);
            this.Controls.Add(this.txtDchi);
            this.Controls.Add(this.txtTenncc);
            this.Controls.Add(this.txtMancc);
            this.Controls.Add(this.lblDthoai);
            this.Controls.Add(this.lblDchi);
            this.Controls.Add(this.lblTenncc);
            this.Controls.Add(this.lblMancc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ts1);
            this.Controls.Add(this.ts3);
            this.Controls.Add(this.ts2);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmNhacc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin nhà cung cấp";
            this.Load += new System.EventHandler(this.frmNhacc_Load);
            this.ts1.ResumeLayout(false);
            this.ts1.PerformLayout();
            this.ts3.ResumeLayout(false);
            this.ts3.PerformLayout();
            this.ts2.ResumeLayout(false);
            this.ts2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tsbtnSearch.ResumeLayout(false);
            this.tsbtnSearch.PerformLayout();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ts1;
        private System.Windows.Forms.ToolStripButton btnInsert;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip ts3;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStrip ts2;
        private System.Windows.Forms.ToolStripButton btnOK;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip tsbtnSearch;
        private System.Windows.Forms.ToolStripTextBox txtName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblMancc;
        private System.Windows.Forms.Label lblTenncc;
        private System.Windows.Forms.Label lblDchi;
        private System.Windows.Forms.Label lblDthoai;
        private System.Windows.Forms.TextBox txtMancc;
        private System.Windows.Forms.TextBox txtTenncc;
        private System.Windows.Forms.TextBox txtDchi;
        private System.Windows.Forms.TextBox txtDthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mancc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dchi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dthoai;
    }
}