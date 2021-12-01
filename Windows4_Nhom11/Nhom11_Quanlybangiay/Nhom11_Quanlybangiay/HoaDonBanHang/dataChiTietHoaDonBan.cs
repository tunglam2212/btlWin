using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Nhom11_Quanlybangiay.HoaDonBanHang
{
    class dataChiTietHoaDonBan
    {
        public SqlConnection con = new SqlConnection();
        public dataChiTietHoaDonBan()
        {
            // KẾT NỐI FORM
            string connnect = @"Data Source=LAPTOP-0560TPMD\SQLEXPRESS;Initial Catalog=qlgiay;Integrated Security=True";
            con = new SqlConnection(connnect);
        }
        int[] slcon = new int[100];
        public DataTable Layrasanpham()
        {
            // LẤY RA TẤT CẢ SẢN PHẨM
            con.Open();
            DataTable dt = new DataTable();
            String sql = "select * from sanpham";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable Layranguoiquanli()
        {
            // LẤY RA NGƯỜI QUẢN LÍ
            con.Open();
            DataTable dt = new DataTable();
            String sql = "select * from nguoiquanli";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }
        public void themKhachhang(String makh,String hoten,String dienthoai,String diachi)
        {
            try
            {
                // THÊM MỘT KHÁCH HÀNG MỚI
                con.Open();
                string sql = "Insert into  Khachhang values('" + makh + "','" + hoten + "','" + dienthoai + "','" + diachi + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Có lỗi:");
            }
        }
        public void themhoadonban(string sdt,string manql,DateTime ngayban,int chietkhau )
        {

                con.Open();
                string sql = "Insert into hoadonban values('" + sdt + "','" + manql + "','" + ngayban + "','" + chietkhau + "')    ";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
           
            
           
        }
        public void themchitiethoadon(int sohd,int masp,string size,int soluongban,int giaban,int thanhtien)
        {
            // THÊM CHI TIẾT MỘT HÓA ĐƠN VÀO BẢNG CHÍNH
            con.Open();
            string sql = "Insert into chitiethoadon values('" + sohd + "','" + masp + "','"+size+"','" + soluongban + "','"+giaban+"','" + thanhtien + "')    ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable xemthongtinmathang(int sohd)
        {
            // XEM THÔNG TIN MẶT HÀNG
            con.Open();
            DataTable dt = new DataTable();
            string sql = "exec xemdanhsachsanpham '"+sohd+"'  ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }
        public void xoasanphamrakhoihang(int masp,string size)
        {
            // XÓA SẢN PHẨM RA KHỎI BẢNG BẢNG PHỤ
            con.Open();
            string sql = " delete from chitiethoadonbannhap where   masp='"+masp+"' and size='"+size+"' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void xoahd(int mahd)
        {
            // XÓA HÓA ĐƠN
            con.Open();
            string sql = " exec  xoahoadonban '" + mahd + "'  ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void update (int sohd,int ck)
        {
            // CẬP NHẬT MẶT HÀNG
            con.Open();
            string sql = " update  hoadonban set chietkhau ='" + ck + "' where sohd='"+sohd+"' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable xemhoadondabantheonhanvien(String manql)
        {
            // XEM THÔNG TIN MÃ HÓA ĐƠN THEO NHÂN VIÊN
            con.Open();
            String sql="Select SOHD,Ngayban,chietkhau from hoadonban where manql='"+manql+"'";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable xemhoadondabantheokhachhang(String sdt)
        {
            // XEM HÓA ĐƠN BÁN THEO KHÁCH HÀNG
            con.Open();
            String sql = "Select SOHD,Ngayban,chietkhau from hoadonban where sdt_kh='" + sdt + "'";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable layRaSoHDBanvuaNhap()
        {
            // LẤY RA HD VỪA NHẬP
            con.Open();
            String sql = "EXEC layRaSoHDBanvuaNhap";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            con.Close();
            return dt;
        }
        public int kiemtratrunghang=0;
        public void themchitiethoadonvaobannhap(int masp,string tensp, string size, int soluongban, int giaban, int thanhtien)
        {
            // THÊM CHI TIẾT MỘT HÓA ĐƠN VÀO BẢNG PHỤ
            try
            {
                con.Open();
                string sql = "Insert into chitiethoadonbannhap values('" + masp + "',N'"+tensp+"','" + size + "','" + soluongban + "','" + giaban + "','" + thanhtien + "')    ";
                SqlCommand cmd = new SqlCommand(sql, con);
                kiemtratrunghang = 0;
                cmd.ExecuteNonQuery();
                con.Close();
                
            }
            catch (SqlException ex)
            {
                if(ex.Number==2627)
                {
                    kiemtratrunghang = 1;
                    MessageBox.Show("Trùng hàng !!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }    
            }
        }
        public DataTable loadsanphambanvuanhap()
        {
            con.Open();
            String sql = "Select * from chitiethoadonbannhap ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            con.Close();
            return dt;
        }
        public void xoabang()
        {
            //XÓA THÔNG TIN
            con.Open();
            string sql = "delete from ChiTietHoaDonBanNhap";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void xoaDuLieuOBang(int masp)
        {
            //XÓA THÔNG TIN
            con.Open();
            string sql = "delete from ChiTietHoaDonBanNhap where masp ='"+masp+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

       

        // XEM SỐ LƯỢNG SẢN PHẨM ĐANG BÁN
        public int xemsoluongsanphamcondangban(int masp)
        {
            con.Open();
            string sql = "exec xemsoluongsanphamcondangban '" + masp + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }



        public DataTable xemSizeCotrongkho(int masp)
        {
            // XEM MẶT HÀNG CÓ NHỮNG SIZE NÀO
             
            con.Open();
            string sql = "Select size from Slcon where [MaSP] ='" + masp + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable Layrasoluongcon(int masp,string size)
        {

            con.Open();
            string sql = "Select slcon from Slcon where [MaSP] ='" + masp + "' and size ='"+size+"'";
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }


        // Cập nhật số lượng bán
        public void CapNhatSoLuongHangThemVao(int masp,string size,int soluongban)
        {
            con.Open();
            string sql = "exec CapNhatSoLuongHangThemVao '"+masp+"','"+size+"','"+soluongban+"' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void CapNhatSoLuongHangHangXoa(int masp, string size, int soluongban)
        {
            con.Open();
            string sql = "exec CapNhatSoLuongHangXoa '" + masp + "','" + size + "','" + soluongban + "' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable sotiencoc(string sdt)
        {
            con.Open();
            string sql = " select [Sotiendatcoc] from [KhachHang] where [SDT_KH]='"+sdt+"'";
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
