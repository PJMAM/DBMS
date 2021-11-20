using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjFinally
{
    
    // 
    class HOADON
    {
        public int MaHD { set; get; }
        public DateTime NgayLapHD { set; get; }
        public string MaNV { set; get; }
        public string MaKH { set; get; }
        public string MaSP { set; get; }
        public int SoLuong { set; get; }
        public int Gia { set; get; }
        public int MucGiamGia { set; get; }

    }

    // 
    class HOADONBLL
    {
        HOADONDAL dalhoadon;
        public HOADONBLL()
        {
            dalhoadon = new HOADONDAL();
        }
        public DataTable getAllHOADON()
        {
            return dalhoadon.getAllHOADON();
        }
        public bool InsertHOADON(HOADON hoadon)
        {
            return dalhoadon.InsertHOADON(hoadon);
        }
        public bool UpdateHOADON(HOADON hoadon)
        {
            return dalhoadon.UpdateHOADON(hoadon);
        }
        public bool DeleteHOADON(HOADON hoadon)
        {
            return dalhoadon.DeleteHOADON(hoadon);
        }

    }

    //
    class HOADONDAL
    {
        //  Tao Connection
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public HOADONDAL()
        {
            dc = new DataConnection();
        }

        
        //  Do du lieu vao datatable cho view them , xoa , sua
        public DataTable getAllHOADON()
        {
            // Tạo câu lệnh truy vấn lấy toàn bộ view THONGKEBANHANG
            string sql = "SELECT * FROM THONGKEBANHANG";
            // Tạo một kết nối đến sql
            SqlConnection con = dc.GetConnection();
            // khởi tạo đối tượng của lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con);
            //mở kết nối
            con.Open();
            // Đổ dữ liệu từ sqlDataAdapter vào DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            // Đóng kết nối
            con.Close();
            return dt;

        }

        // Chuc nang them vao
        public bool InsertHOADON(HOADON hoadon)
        {
            string sql = "exec taoHOADON @NgayLapHD, @MaNV, @MaKH , @MaSP, @SoLuong, @Gia, @MucGiamGia";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@NgayLapHD", SqlDbType.DateTime).Value = hoadon.NgayLapHD;
                cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = hoadon.MaNV;
                cmd.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = hoadon.MaKH;
                cmd.Parameters.Add("@MaSP", SqlDbType.NVarChar).Value = hoadon.MaSP;
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = hoadon.SoLuong;
                cmd.Parameters.Add("@Gia", SqlDbType.Int).Value = hoadon.Gia;
                cmd.Parameters.Add("@MucGiamGia", SqlDbType.Int).Value = hoadon.MucGiamGia;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        // Chuc nang sua
        public bool UpdateHOADON(HOADON hoadon)
        {
            string sql = "exec suaHOADON @MaHD,@NgayLapHD, @MaNV, @MaKH , @MaSP, @SoLuong, @Gia, @MucGiamGia";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaHD", SqlDbType.Int).Value = hoadon.MaHD;
                cmd.Parameters.Add("@NgayLapHD", SqlDbType.DateTime).Value = hoadon.NgayLapHD;
                cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = hoadon.MaNV;
                cmd.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = hoadon.MaKH;
                cmd.Parameters.Add("@MaSP", SqlDbType.NVarChar).Value = hoadon.MaSP;
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = hoadon.SoLuong;
                cmd.Parameters.Add("@Gia", SqlDbType.Int).Value = hoadon.Gia;
                cmd.Parameters.Add("@MucGiamGia", SqlDbType.Int).Value = hoadon.MucGiamGia;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        // Chuc nang xoa
        public bool DeleteHOADON(HOADON hoadon)
        {
            string sql = "exec xoaHOADON @MaHD";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaHD", SqlDbType.Int).Value = hoadon.MaHD;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

    }


}
