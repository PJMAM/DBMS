using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ProjFinally
{
    public partial class frmChiTietHoaDon : Form
    {
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string MaKhachHang = textBox1.Text;
            //  Tao Connection
            SqlDataAdapter da;
            DataConnection cnn = new DataConnection();
            //
            // Tạo câu lệnh truy vấn lấy toàn bộ view THONGKEBANHANG noi MaKH = MaKhachHang
            string sql = "SELECT * FROM THONGKEBANHANG WHERE MaKH LIKE N'%" + MaKhachHang + "%'";
            // Tạo một kết nối đến sql
            SqlConnection con = cnn.GetConnection();
            // khởi tạo đối tượng của lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con);
            //mở kết nối
            con.Open();
            // Đổ dữ liệu từ sqlDataAdapter vào DataTable
            DataTable dtt = new DataTable();
            da.Fill(dtt);
            // Đóng kết nối
            con.Close();
            dataGridView1.DataSource = dtt;

            int tong = 0;
            foreach (DataRow row in dtt.Rows)
            {
                tong = tong +  Convert.ToInt32(row["ThanhTien"]);
            }
            textBox2.Text = tong.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMainQL fm = new frmMainQL();
            Hide();
            fm.ShowDialog();
        }

        
        //
         
        private void btnXoa_Click(object sender, EventArgs e)
        {

            
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
