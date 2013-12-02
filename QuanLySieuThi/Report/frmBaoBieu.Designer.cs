namespace QuanLySieuThi.Report
{
    partial class frmBaoBieu
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnDanhsachKhachhang = new System.Windows.Forms.Button();
            this.btnDanhsachNhanvien = new System.Windows.Forms.Button();
            this.btnDanhsachPhongban = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(-1, 47);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(779, 461);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // btnDanhsachKhachhang
            // 
            this.btnDanhsachKhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhsachKhachhang.ForeColor = System.Drawing.Color.Blue;
            this.btnDanhsachKhachhang.Location = new System.Drawing.Point(12, 12);
            this.btnDanhsachKhachhang.Name = "btnDanhsachKhachhang";
            this.btnDanhsachKhachhang.Size = new System.Drawing.Size(190, 29);
            this.btnDanhsachKhachhang.TabIndex = 1;
            this.btnDanhsachKhachhang.Text = "Danh sách Khách hàng";
            this.btnDanhsachKhachhang.UseVisualStyleBackColor = true;
            this.btnDanhsachKhachhang.Click += new System.EventHandler(this.btnDanhsachKhachhang_Click);
            // 
            // btnDanhsachNhanvien
            // 
            this.btnDanhsachNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhsachNhanvien.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDanhsachNhanvien.Location = new System.Drawing.Point(232, 12);
            this.btnDanhsachNhanvien.Name = "btnDanhsachNhanvien";
            this.btnDanhsachNhanvien.Size = new System.Drawing.Size(190, 29);
            this.btnDanhsachNhanvien.TabIndex = 2;
            this.btnDanhsachNhanvien.Text = "Danh sách Nhân viên";
            this.btnDanhsachNhanvien.UseVisualStyleBackColor = true;
            this.btnDanhsachNhanvien.Click += new System.EventHandler(this.btnDanhsachNhanvien_Click);
            // 
            // btnDanhsachPhongban
            // 
            this.btnDanhsachPhongban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhsachPhongban.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnDanhsachPhongban.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhsachPhongban.Location = new System.Drawing.Point(449, 12);
            this.btnDanhsachPhongban.Name = "btnDanhsachPhongban";
            this.btnDanhsachPhongban.Size = new System.Drawing.Size(190, 29);
            this.btnDanhsachPhongban.TabIndex = 3;
            this.btnDanhsachPhongban.Text = "Danh sách Phòng ban";
            this.btnDanhsachPhongban.UseVisualStyleBackColor = true;
            this.btnDanhsachPhongban.Click += new System.EventHandler(this.btnDanhsachPhongban_Click);
            // 
            // frmBaoBieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 508);
            this.Controls.Add(this.btnDanhsachPhongban);
            this.Controls.Add(this.btnDanhsachNhanvien);
            this.Controls.Add(this.btnDanhsachKhachhang);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frmBaoBieu";
            this.Text = "frmBaoBieu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaoBieu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnDanhsachKhachhang;
        private System.Windows.Forms.Button btnDanhsachNhanvien;
        private System.Windows.Forms.Button btnDanhsachPhongban;
    }
}