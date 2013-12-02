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

        bool IorU = false;
        TextBox[] chuatextbox = new TextBox[4];

        public frmPhongban()
        {
            InitializeComponent();
            int j = 0;
            for (int i = 0; i < grpIU.Controls.Count; i++)
            {
                if (grpIU.Controls[i] is TextBox)
                {
                    chuatextbox[i] = (grpIU.Controls[i]) as TextBox;
                    j++;
                }
            }
        }

        

        private void frmPhongban_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                chuatextbox[i].Enabled = false;
            }
            PhongbanBUL cls = new PhongbanBUL();
            dataGridView1.DataSource = cls.Danhsachphongban();
            dataGridView1.AutoResizeColumns();
            btnOK.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.RowCount - 2;
            string Maphongbantruoc = dataGridView1.Rows[r].Cells[0].Value.ToString();
            string[] mapbcu = new string[2];
            mapbcu = Maphongbantruoc.Split('B');
            int mapbmoi = Convert.ToInt32(mapbcu[1].Trim()) + 1;
            if (mapbmoi > 9)
                txtId.Text = "PB" + mapbmoi.ToString();
            else txtId.Text = "PB0" + mapbmoi.ToString();
            IorU = true;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnOK.Enabled = true;
            btnCancel.Enabled = true;
            for (int i = 0; i < 4; i++)
            {
                chuatextbox[i].Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {    
            txtId.DataBindings.Add("text", dataGridView1.DataSource, "MAPB");
            txtName.DataBindings.Add("text", dataGridView1.DataSource, "TENPB");
            txtInterest.DataBindings.Add("text", dataGridView1.DataSource, "TENNDN");
            txtPass.DataBindings.Add("text", dataGridView1.DataSource, "PASS");
            IorU = false;
            for (int i = 0; i < 4; i++)
            {
                chuatextbox[i].Enabled = true;
            }
            btnOK.Enabled = true;
            btnCancel.Enabled = true;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            if (IorU == true)
            {
                try
                {
                    bool checklbl = true;
                    if (txtId.Text == "" && txtName.Text == "")
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

                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi, không thêm được");
                }
            }
            else if (IorU == false)
            {
                try
                {
                    PhongbanPublic p = new PhongbanPublic();
                    PhongbanBUL cls = new PhongbanBUL();
                    p.Mapb = txtId.Text;
                    p.Tenpb = txtName.Text;
                    p.Tenndn = txtInterest.Text;
                    p.Pass = txtPass.Text;
                    cls.Suaphongban(p);

                    for (int i = 0; i < chuatextbox.Count(); i++)
                    {
                        chuatextbox[i].DataBindings.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi, không sửa được");
                }
                
            }

            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            
            for (int i = 0; i < 4; i++)
            {
                chuatextbox[i].Enabled = false;
                chuatextbox[i].Clear();
            }
            frmPhongban_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (IorU == false)
            {
                for (int i = 0; i < chuatextbox.Count(); i++)
                {
                    chuatextbox[i].DataBindings.Clear();
                }
            }
            for (int i = 0; i < chuatextbox.Count(); i++)
            {
                chuatextbox[i].Clear();
                chuatextbox[i].Enabled = false;
            }
            frmPhongban_Load(sender, e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmPhongban_Load(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
