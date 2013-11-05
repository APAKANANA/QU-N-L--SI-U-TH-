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
        TextBox[] chuatextbox = new TextBox[9];
        public frmNhanvien()
        {
            InitializeComponent();
            int j = 0;
            for (int i = 0; i < grptxt.Controls.Count; i++)
            {
                if(grptxt.Controls[i] is TextBox)
                {
                    chuatextbox[j]=(grptxt.Controls[i]) as TextBox;
                    j++;
                }
            }
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //txtManv.DataBindings.Add("text", dataGridView1.DataSource, "MANV");
            //txtTennv.DataBindings.Add("text", dataGridView1.DataSource, "TENNV");
            //txtGtinh.DataBindings.Add("text", dataGridView1.DataSource, "GIOITINH");
            //txtCmnd.DataBindings.Add("text", dataGridView1.DataSource, "CMND");
            //txtNgsinh.DataBindings.Add("text", dataGridView1.DataSource, "NGAYSINH");
            //txtNgayvl.DataBindings.Add("text", dataGridView1.DataSource, "NGAYVL");
            //txtDchi.DataBindings.Add("text", dataGridView1.DataSource, "DCHI");
            //txtDthoai.DataBindings.Add("text", dataGridView1.DataSource, "DTHOAI");
            //txtMapb.DataBindings.Add("text", dataGridView1.DataSource, "MAPB");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //NhanvienBUL cls = new NhanvienBUL();
            //NhanvienPublic p = new NhanvienPublic();
            //p.Manv = txtManv.Text;
            //p.Tennv = txtTennv.Text;
            //p.Gtinh = txtGtinh.Text;
            //p.Cmnd = txtCmnd.Text;
            //p.Ngsinh = Convert.ToDateTime(txtNgsinh.Text);
            //p.Ngayvl = Convert.ToDateTime(txtNgayvl.Text);
            //p.Dchi = txtDchi.Text;
            //p.Mapb = txtMapb.Text;
            //cls.SuaNhanvien(p);
            //frmNhanvien_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < 9; i++)
            //{
            //    chuatextbox[i].DataBindings.Clear();
                
            //}
            //frmNhanvien_Load(sender, e);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //NhanvienBUL cls = new NhanvienBUL();
            //NhanvienPublic p = new NhanvienPublic();
            //int r = dataGridView1.CurrentCell.RowIndex;
            //string MaNhanvien= dataGridView1.Rows[r].Cells[0].Value.ToString();
            //p.Manv = MaNhanvien;
            //cls.Themnhanvien(p);
            //frmNhanvien_Load(sender, e);
        }

       
    }
}
