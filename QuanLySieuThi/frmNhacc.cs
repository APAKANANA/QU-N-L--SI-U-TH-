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
using System.Data.SqlClient;

namespace QuanLySieuThi
{
    public partial class frmNhacc : Form
    {
        public frmNhacc()
        {
            InitializeComponent();
        }

        private void frmNhacc_Load(object sender, EventArgs e)
        {
            NhaccBUL cls = new NhaccBUL();
            dataGridView1.DataSource = cls.Danhsachnhacungcap();
            dataGridView1.AutoResizeColumns();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                NhaccBUL cls = new NhaccBUL();
                NhaccPublic p = new NhaccPublic();
                p.Mancc = txtMancc.Text;
                p.Tenncc = txtTenncc.Text;
                p.Dchi = txtDchi.Text;
                p.Dthoai = txtDthoai.Text;
                cls.Themnhacc(p);
                frmNhacc_Load(sender, e);
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi không thêm được Nhà cung cấp");
            }
        }

    }
}
