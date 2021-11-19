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
    public partial class frmMainQL : Form
    {
        public frmMainQL()
        {
            InitializeComponent();
        }
        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmKhachHang();
            frm.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmNhanVien();
            frm.ShowDialog();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmSanPham();
            frm.ShowDialog();
        }

        private void lôHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmLoHang();
            frm.ShowDialog();
        }

        private void chiTiếtLôHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmLoHangChiTiet();
            frm.ShowDialog();
        }

        private void hoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmHoaDon();
            frm.ShowDialog();
        }

        private void hợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmChiTietHoaDon();
            frm.ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmCongTy();
            frm.ShowDialog();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmDangNhap();
            frm.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmDangKy();
            frm.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc chưa nà ^^ ", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmThongTinTaiKhoan();
            frm.ShowDialog();
        }
    }
}
