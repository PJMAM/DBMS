using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjFinally
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form frm = new frmDangKy();
            frm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form frm = new frmQuenMatKhau();
            frm.ShowDialog();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (radQL.Checked == true)
            {
                Form frm = new frmMainQL();
                frm.ShowDialog();
            }
            if (radNV.Checked == true)
            {
                Form frm = new frmMainNV();
                frm.ShowDialog();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc chưa nà ^^ ", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
