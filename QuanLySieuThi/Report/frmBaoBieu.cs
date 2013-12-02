using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
namespace QuanLySieuThi.Report
{
    public partial class frmBaoBieu : Form
    {
        public frmBaoBieu()
        {
            InitializeComponent();
        }
        public static DataTable dt;
      //  public static int Type;
        private void frmBaoBieu_Load(object sender, EventArgs e)
        {
            //if (Type == 1)
            //{
            //    Khachhangreport obj = new Khachhangreport();
            //    obj.SetDataSource(dt);
            //    crystalReportViewer1.ReportSource = obj;
            //    crystalReportViewer1.Refresh();
            //}
        }

        private void btnDanhsachKhachhang_Click(object sender, EventArgs e)
        {
            KhachhangBUL cls = new KhachhangBUL();
            Report.frmBaoBieu.dt = cls.DanhsachKhachhang();
            Khachhangreport obj = new Khachhangreport();
            obj.SetDataSource(dt);
            crystalReportViewer1.ReportSource = obj;
            crystalReportViewer1.Refresh();
        }

        private void btnDanhsachNhanvien_Click(object sender, EventArgs e)
        {
            NhanvienBUL cls = new NhanvienBUL();
            Report.frmBaoBieu.dt = cls.DanhsachNhanvien();
            Nhanvienreport obj = new Nhanvienreport();
            obj.SetDataSource(dt);
            crystalReportViewer1.ReportSource = obj;
            crystalReportViewer1.Refresh();
        }

        private void btnDanhsachPhongban_Click(object sender, EventArgs e)
        {
            PhongbanBUL cls = new PhongbanBUL();
            Report.frmBaoBieu.dt = cls.Danhsachphongban();
            Phongbanreport obj = new Phongbanreport();
            obj.SetDataSource(dt);
            crystalReportViewer1.ReportSource = obj;
            crystalReportViewer1.Refresh();
        }
    }
}
