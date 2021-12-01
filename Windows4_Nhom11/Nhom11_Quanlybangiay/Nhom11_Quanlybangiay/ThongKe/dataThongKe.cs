using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
namespace Nhom11_Quanlybangiay.ThongKe
{
    class dataThongKe
    {
        public SqlConnection con = new SqlConnection();
        public dataThongKe()
        {
            string connnect = @"Data Source=LAPTOP-0560TPMD\SQLEXPRESS;Initial Catalog=qlgiay;Integrated Security=True";
            con = new SqlConnection(connnect);

        }
        public DataTable ThongKeHoaDonBanTheoNgay(DateTime a,DateTime b)
        {
            //BTN THỐNG KÊ HÓA ĐƠN BÁN THEO NGÀY
            con.Open();
            DataTable dt = new DataTable();
            String sql = "Exec thongkehoadonbantheongay '" + a + "','" + b + "'       ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }
        public void xoahoadon(string mahd)
        {
            //BTN XÓA HÓA ĐƠN
            con.Open();
            string sql = "Exec xoahoadonban '" + mahd + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable ThongKeHoaDonNhapTheoNgay(DateTime a, DateTime b)
        {
            //BTN THỐNG KÊ TỔNG TIỀN NHẬP XUẤT
            con.Open();
            DataTable dt = new DataTable();
            String sql = "Exec thongkehoadonnhaptheongay '" + a + "','" + b + "'       ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }
        public void xoahoadonnhap(string mahd)
        {
            //BTN XÓA HÓA ĐƠN NHẬP
            con.Open();
            string sql = "Exec xoahoadonnhap '" + mahd + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable sanPhamBanChay()
        {
            //XEM THỐNG TIN SẢN PHẨM BÁN CHẠY
            con.Open();
            DataTable dt = new DataTable();
            String sql = "Exec thongkesanphambanchaynhat";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable thongketienbantheongay(DateTime x,DateTime y)
        {
            // THỐNG KÊ TIỀN BÁN THEO NGÀY
            con.Open();
            DataTable dt = new DataTable();
            String sql = "Exec thongketiennhap '" + x + "','"+y+"' ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable thongketiennhaptheongay(DateTime x, DateTime y)
        {
            //THỐNG KÊ TIỀN NHẬP THEO NGÀY
            con.Open();
            DataTable dt = new DataTable();
            String sql = "Exec thongketiennhap2 '" + x + "','" + y + "' ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable NguoiThuTienNhieuNhat( DateTime x, DateTime y)
        {
            //THỐNG KÊ TIỀN NHẬP THEO NGÀY
            con.Open();
            DataTable dt = new DataTable();
            String sql = "Exec ThongkeNguoiBanNhieuNhat '"+x+"','"+y+"'";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
