using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi
{
    public partial class frmMain : Form
    {
        frmlogin login;
        frmSanpham sp;
        frmNhanvien nv;
        frmNhacc ncc;
        frmPhieunhap pn;
        frmTracuuKH searchkh;
        frmTracuuNV searchnv;
        frmTracuuSp searchsp;
        frmThongke tk;
        frmAbout about;
        frmKhachhang kh;
        frmLapHoaDon laphd;
        frmPhongban pb;
        Report.frmBaoBieu bb;
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            login = new frmlogin();
            login.ShowDialog();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuSanpham_Click(object sender, EventArgs e)
        {
            sp = new frmSanpham();
            sp.ShowDialog();
        }

        private void mnuKhachhang_Click(object sender, EventArgs e)
        {
            kh = new frmKhachhang();
            kh.ShowDialog();
        }

        private void mnuNhanvien_Click(object sender, EventArgs e)
        {
            nv = new frmNhanvien();
            nv.ShowDialog();
        }

        private void mnuPhongban_Click(object sender, EventArgs e)
        {
            pb = new frmPhongban();
            pb.ShowDialog();
        }

        private void mnuNhacc_Click(object sender, EventArgs e)
        {
            ncc = new frmNhacc();
            ncc.ShowDialog();
        }

        private void mnuLaphd_Click(object sender, EventArgs e)
        {
            laphd = new frmLapHoaDon();
            laphd.ShowDialog();
        }

        private void mnuNhapsp_Click(object sender, EventArgs e)
        {
            pn = new frmPhieunhap();
            pn.ShowDialog();
        }

        private void mnuSearchkh_Click(object sender, EventArgs e)
        {
            searchkh = new frmTracuuKH();
            searchkh.ShowDialog();
        }

        private void mnuSearchNv_Click(object sender, EventArgs e)
        {
            searchnv = new frmTracuuNV();
            searchnv.ShowDialog();
        }

        private void mnuDoanhthu_Click(object sender, EventArgs e)
        {
            tk = new frmThongke();
            tk.ShowDialog();
        }

        private void mnuSearchsp_Click(object sender, EventArgs e)
        {
            searchsp = new frmTracuuSp();
            searchsp.ShowDialog();
        }

        private void mnuLapbaocao_Click(object sender, EventArgs e)
        {
            bb = new Report.frmBaoBieu();
            bb.ShowDialog();
        }
       

        


       

    }
}
