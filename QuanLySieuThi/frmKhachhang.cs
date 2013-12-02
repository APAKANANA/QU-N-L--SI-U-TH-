using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

using Public;
using BUL;


namespace QuanLySieuThi
{
    public partial class frmKhachhang : Form
    {
        bool IorU;
        TextBox[] chua = new TextBox[8];
        public frmKhachhang()
        {
            
            InitializeComponent();
            int j = 0;
            for (int i = 0; i < grpThemsua.Controls.Count; i++)
            {
                if (grpThemsua.Controls[i] is TextBox)
                {
                    chua[j] = grpThemsua.Controls[i] as TextBox;
                    j++;
                }
            }
        }

        private void frmKhachhang_Load(object sender, EventArgs e)
        {
            KhachhangBUL cls = new KhachhangBUL();
            dataGridView1.DataSource = cls.DanhsachKhachhang();
            dataGridView1.AutoResizeColumns();
            btnOK.Enabled = false;
            btnCancel.Enabled = false;

            for (int i = 0; i < 8; i++)
            {
                chua[i].Enabled = false;
            }
            dtpNgsinh.Enabled = false;
            dtpNgdk.Enabled = false;
        }

        private void Hambinding()
        {
            txtMakh.DataBindings.Add("text", dataGridView1.DataSource, "MAKH");
            txtHoten.DataBindings.Add("text", dataGridView1.DataSource, "HOTEN");
            txtGtinh.DataBindings.Add("text", dataGridView1.DataSource, "GIOITINH");
            txtCmnd.DataBindings.Add("text", dataGridView1.DataSource, "CMND");
            dtpNgsinh.DataBindings.Add("text", dataGridView1.DataSource, "NGSINH");
            dtpNgdk.DataBindings.Add("text", dataGridView1.DataSource, "NGAYDK");
            txtDchi.DataBindings.Add("text", dataGridView1.DataSource, "DIACHI");
            txtDthoai.DataBindings.Add("text", dataGridView1.DataSource, "DTHOAI");
            txtDiem.DataBindings.Add("text", dataGridView1.DataSource, "DIEM");
            txtLoaikh.DataBindings.Add("text", dataGridView1.DataSource, "LOAIKH");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.RowCount - 2;
            string MaKhachHangtruoc = dataGridView1.Rows[r].Cells[0].Value.ToString();

            string[] makhcu = new string[2];
            makhcu = MaKhachHangtruoc.Split('H');
            int makhmoi = Convert.ToInt32(makhcu[1].Trim()) + 1;
            if (makhmoi > 9)
                txtMakh.Text = "KH" + makhmoi.ToString();
            else txtMakh.Text = "KH0" + makhmoi.ToString();

            IorU = true;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDel.Enabled = false;
            btnOK.Enabled = true;
            btnCancel.Enabled = true;

            for (int i = 0; i < chua.Count(); i++)
            {
                chua[i].Enabled = true;
            }
            dtpNgdk.Enabled = true;
            dtpNgsinh.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            IorU = false;
            Hambinding();
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDel.Enabled = false;
            btnOK.Enabled = true;
            btnCancel.Enabled = true;
            for (int i = 0; i < chua.Count(); i++)
            {
                chua[i].Enabled = true;
            }

            dtpNgdk.Enabled = true;
            dtpNgsinh.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)

        {
            KhachhangBUL cls = new KhachhangBUL();
            KhachhangPublic p = new KhachhangPublic();
            p.MaKH1 = txtMakh.Text.Trim();
            p.HoTen1 = txtHoten.Text.Trim();
            p.CMND1 = txtCmnd.Text.Trim();
            p.GioiTinh1 = txtGtinh.Text.Trim();
            //string NgaySinh = DateTime.ParseExact(dtpNgdk.Value.ToString(), "dd/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy");
            p.NgSinh1 = dtpNgsinh.Value.Date.ToString("MM/dd/yyyy");
            p.NgayDK1 = dtpNgdk.Value.Date.ToString("MM/dd/yyyy");
            p.DiaChi1 = txtDchi.Text.Trim();
            p.DThoai1 = txtDthoai.Text.Trim();
            p.Diem1 = Convert.ToInt32(txtDiem.Text.Trim());
            p.LoaiKh1 = txtLoaikh.Text.Trim();

            if (IorU == true)
            {
                cls.ThemKhachhang(p);
            }
            else if (IorU == false)
            {
                cls.SuaKhachhang(p);
                dtpNgdk.DataBindings.Clear();
                dtpNgsinh.DataBindings.Clear();
                for (int i = 0; i < chua.Count(); i++)
                {
                    chua[i].DataBindings.Clear();
                }
            }

            for (int i = 0; i < chua.Count(); i++)
            {
                chua[i].Clear();
                chua[i].Enabled = false;
            }
            dtpNgdk.Enabled = false;
            dtpNgsinh.Enabled = false;

            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDel.Enabled = true;
            btnOK.Enabled = false;
            btnCancel.Enabled = false;
            btnRefresh.Enabled = true;

            frmKhachhang_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chua.Count(); i++)
            {
                chua[i].Clear();
                chua[i].Enabled = false;
            }

            if (IorU == false)
            {
                for (int i = 0; i < chua.Count(); i++)
                {
                    chua[i].DataBindings.Clear();
                }
                dtpNgdk.DataBindings.Clear();
                dtpNgsinh.DataBindings.Clear();
            }

            dtpNgdk.Enabled = false;
            dtpNgsinh.Enabled = false;
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDel.Enabled = true;
            btnOK.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            KhachhangBUL cls = new KhachhangBUL();
            KhachhangPublic p = new KhachhangPublic();
            int r = dataGridView1.CurrentCell.RowIndex;
            string Makhachhang = dataGridView1.Rows[r].Cells[0].Value.ToString();
            p.MaKH1 = Makhachhang;
            cls.XoaKhachhang(p);
            frmKhachhang_Load(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmKhachhang_Load(sender, e);
        }

        string Searchby = "";

        private void btnSearch_Click(object sender, EventArgs e)
        {
            KhachhangBUL cls = new KhachhangBUL();
            if (txtName.Text.Trim() == "")
                frmKhachhang_Load(sender, e);
            else
            {
                if (optMa.Checked == true)
                    Searchby = "MAKH";
                string Search = txtName.Text.Trim();
                dataGridView1.DataSource = cls.TimKhachhang(Searchby, Search);
                txtName.Clear();
            }
        }

        private void optMa_CheckedChanged(object sender, EventArgs e)
        {
            Searchby = "MAKH";
            btnSearch.ToolTipText = "Tìm theo mã";
        }

        private void optHoten_CheckedChanged(object sender, EventArgs e)
        {
            Searchby = "HoTen";
            btnSearch.ToolTipText = "Tìm theo tên";
        }

        private void optCmnd_CheckedChanged(object sender, EventArgs e)
        {
            Searchby = "CMND";
            btnSearch.ToolTipText = "Tìm theo CMND";
        }

        private void optLoaikh_CheckedChanged(object sender, EventArgs e)
        {
            Searchby = "LoaiKH";
            btnSearch.ToolTipText = "Tìm theo loại khách hàng";
        }




    }
}
