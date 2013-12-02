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
        bool IorU = false;
        TextBox[] chuatextbox = new TextBox[7];
        public frmNhanvien()
        {
            InitializeComponent();
            int j = 0;
            for (int i = 0; i < grptxt.Controls.Count; i++)
            {
                if (grptxt.Controls[i] is TextBox )
                {
                    chuatextbox[j] = (grptxt.Controls[i]) as TextBox;
                    j++;
                }
            }
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            NhanvienBUL cls = new NhanvienBUL();
            dataGridView1.DataSource = cls.DanhsachNhanvien();
            dataGridView1.AutoResizeColumns();
            for (int i = 0; i < 7; i++)
            {
                chuatextbox[i].Enabled = false;
            }

            dtpNgsinh.Enabled = false;
            dtpNgvl.Enabled = false;
            btnOK.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.RowCount - 2;
            string MaNhanVientruoc = dataGridView1.Rows[r].Cells[0].Value.ToString();

            string[] manvcu = new string[2];
            manvcu = MaNhanVientruoc.Split('V');
            int manvmoi = Convert.ToInt32(manvcu[1].Trim()) + 1;
            if (manvmoi > 9)
                txtManv.Text = "NV" + manvmoi.ToString();
            else txtManv.Text = "NV0" + manvmoi.ToString();

            IorU = true;
            for (int i = 0; i < 7; i++)
            {
                chuatextbox[i].Enabled = true;
            }
            btnUpdate.Enabled = false;
            btnDel.Enabled = false;
            btnInsert.Enabled = false;

            dtpNgsinh.Enabled = true;
            dtpNgvl.Enabled = true;
            btnOK.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            IorU = false;
            Hambinding();
            for (int i = 0; i < 7; i++)
            {
                chuatextbox[i].Enabled = true;
            }

            dtpNgsinh.Enabled = true;
            dtpNgvl.Enabled = true;
            btnOK.Enabled = true;
            btnCancel.Enabled = true;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDel.Enabled = false;
           
        }

        string Searchby = "MaNV";

        private void btnSearch_Click(object sender, EventArgs e)
        {
            NhanvienBUL cls = new NhanvienBUL();
            if (txtName.Text == "")
                frmNhanvien_Load(sender, e);
            else
            {
                string Search=txtName.Text.Trim();
                dataGridView1.DataSource= cls.TimNhanvien(Searchby, Search);
                txtName.Clear();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            NhanvienBUL cls = new NhanvienBUL();
            NhanvienPublic p = new NhanvienPublic();
            p.Manv = txtManv.Text.Trim();
            p.Tennv = txtTennv.Text.Trim();
            p.Gioitinh = txtGtinh.Text.Trim();
            p.Cmnd = txtCmnd.Text.Trim();
            p.Ngaysinh = dtpNgsinh.Value.Date.ToString("MM/dd/yyyy");
            p.Ngayvl = dtpNgvl.Value.Date.ToString("MM/dd/yyyy");
            p.Dchi = txtDchi.Text.Trim();
            p.Dthoai = txtDthoai.Text.Trim();
            p.Mapb = txtMapb.Text.Trim();

            if (IorU == true)
            {
                try
                {
                    
                    cls.ThemNhanvien(p);
                }
             catch(Exception ex)
                {
                    MessageBox.Show("Lỗi không thêm được nhân viên");
                }
            }
            else if (IorU == false)
            {
                {
                    try
                    {
                        
                        cls.SuaNhanvien(p);
                        dtpNgsinh.DataBindings.Clear();
                        dtpNgvl.DataBindings.Clear();
                        for (int i = 0; i < chuatextbox.Count(); i++)
                        {
                            chuatextbox[i].DataBindings.Clear();
                        }
                        
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi không sửa được");
                    }
                }
            }
            for (int i = 0; i < 7; i++)
            {
                chuatextbox[i].Enabled = false;
                chuatextbox[i].Clear();
            }
            dtpNgsinh.Enabled = false;
            dtpNgvl.Enabled = false;

            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDel.Enabled = true;
            btnRefresh.Enabled = true;

            btnOK.Enabled = false;
            btnCancel.Enabled = false;
            frmNhanvien_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           for (int i = 0; i < 7; i++)
           {
               chuatextbox[i].Enabled = false;
               chuatextbox[i].Clear();
           }
            
           if (IorU == false)
            {
                dtpNgsinh.DataBindings.Clear();
                dtpNgvl.DataBindings.Clear();
                for (int i = 0; i < 7; i++)
                {
                    chuatextbox[i].DataBindings.Clear();
                }
            }

            dtpNgsinh.Enabled = false;
            dtpNgvl.Enabled = false;

            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDel.Enabled = true;

            btnOK.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {                     

            NhanvienBUL cls = new NhanvienBUL();
            NhanvienPublic p = new NhanvienPublic();
            HoadonPublic q = new HoadonPublic();
            int r = dataGridView1.CurrentCell.RowIndex;
            string MaNhanVien = dataGridView1.Rows[r].Cells[0].Value.ToString();
            q.Manv = MaNhanVien;
            cls.SuaManvtrongHD(q);

            p.Manv = MaNhanVien;
            cls.XoaNhanvien(p);
            frmNhanvien_Load (sender, e);

        }

        private void Hambinding()
        {
            txtManv.DataBindings.Add("text", dataGridView1.DataSource, "MANV");
            txtTennv.DataBindings.Add("text", dataGridView1.DataSource, "TENNV");
            txtGtinh.DataBindings.Add("text", dataGridView1.DataSource, "GIOITINH");
            txtCmnd.DataBindings.Add("text", dataGridView1.DataSource, "CMND");
            dtpNgsinh.DataBindings.Add("text", dataGridView1.DataSource, "NGAYSINH");
            dtpNgvl.DataBindings.Add("text", dataGridView1.DataSource, "NGAYVL");
            txtDchi.DataBindings.Add("text", dataGridView1.DataSource, "DCHI");
            txtDthoai.DataBindings.Add("text", dataGridView1.DataSource, "DTHOAI");
            txtMapb.DataBindings.Add("text", dataGridView1.DataSource, "MAPB");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmNhanvien_Load(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void optMaNV_CheckedChanged(object sender, EventArgs e)
        {
            Searchby = "MaNV";
            btnSearch.ToolTipText = "Tìm theo mã";
        }

        private void optHoten_CheckedChanged(object sender, EventArgs e)
        {
            Searchby = "TenNV";
            btnSearch.ToolTipText = "Tìm theo tên";
        }

        private void optCmnd_CheckedChanged(object sender, EventArgs e)
        {
            Searchby = "Cmnd";
            btnSearch.ToolTipText = "Tìm theo CMND";
        }

        private void optPhongban_CheckedChanged(object sender, EventArgs e)
        {
            Searchby = "MaPB";
            btnSearch.ToolTipText = "Tìm theo phòng ban";
        }

        private void btnInbaocao_Click(object sender, EventArgs e)
        {

        }

    }
}
