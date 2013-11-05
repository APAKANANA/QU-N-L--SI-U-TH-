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
using Public;

namespace QuanLySieuThi
{
    public partial class frmNhanvien : Form
    {
        public frmNhanvien()
        {
            InitializeComponent();
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            NhanvienBUL cls = new NhanvienBUL();
            dataGridView1.DataSource = cls.Danhsachnhanvien();
            dataGridView1.AutoResizeColumns();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            NhanvienBUL cls = new NhanvienBUL();
            NhanvienPublic p = new NhanvienPublic();
            p.Manv = txtManv.Text;
            p.Tennv = txtTennv.Text;
            p.Gtinh = txtGtinh.Text;
            p.Cmnd = txtCmnd.Text;
            p.Ngsinh = Convert.ToDateTime(txtNgsinh.Text);
            p.Ngayvl = Convert.ToDateTime(txtNgayvl.Text);
            p.Dchi = txtDchi.Text;
            p.Mapb = txtMapb.Text;
            cls.Themnhanvien(p);
            frmNhanvien_Load(sender, e);

        }
    }
}
