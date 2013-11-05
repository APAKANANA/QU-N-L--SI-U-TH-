using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Public;
using BUL;

namespace QuanLySieuThi
{
    public partial class frmPhongban : Form
    {
        public frmPhongban()
        {
            InitializeComponent();
        }

        private void frmPhongban_Load(object sender, EventArgs e)
        {
            PhongbanBUL cls = new PhongbanBUL();
            dataGridView1.DataSource = cls.Danhsachphongban();
            dataGridView1.AutoResizeColumns();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool checklbl = true;
            if (txtId.Text == "" && txtName.Text=="")
            {
                MessageBox.Show("Nhập giá trị cho phòng ban", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checklbl = false;
            }
            if (checklbl == true)
            {
                PhongbanBUL cls = new PhongbanBUL();
                PhongbanPublic p = new PhongbanPublic();
                p.Mapb = txtId.Text;
                p.Tenpb = txtName.Text;
                p.Tenndn = txtInterest.Text;
                p.Pass = txtPass.Text;
                cls.Themphongban(p);
                frmPhongban_Load(sender, e);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {    
            txtId.DataBindings.Add("text", dataGridView1.DataSource, "MAPB");
            txtName.DataBindings.Add("text", dataGridView1.DataSource, "TENPB");
            txtInterest.DataBindings.Add("text", dataGridView1.DataSource, "TENNDN");
            txtPass.DataBindings.Add("text", dataGridView1.DataSource, "PASS");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            PhongbanPublic p = new PhongbanPublic();
            PhongbanBUL cls = new PhongbanBUL();
            p.Mapb = txtId.Text;
            p.Tenpb = txtName.Text;
            p.Tenndn = txtInterest.Text;
            p.Pass = txtPass.Text;
            cls.Suaphongban(p);

            txtId.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtInterest.DataBindings.Clear();
            txtPass.DataBindings.Clear();

            frmPhongban_Load(sender, e);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtId.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtInterest.DataBindings.Clear();
            txtPass.DataBindings.Clear();
            frmPhongban_Load(sender, e);
        }

        
    }
}
