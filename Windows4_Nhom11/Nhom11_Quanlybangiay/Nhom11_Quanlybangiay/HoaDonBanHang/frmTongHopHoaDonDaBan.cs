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
using System.Data.Sql;
namespace Nhom11_Quanlybangiay.HoaDonBanHang
{
    public partial class frmTongHopHoaDonDaBan : Form
    {
        public frmTongHopHoaDonDaBan()
        {
            InitializeComponent();
        }
        dataChiTietHoaDonBan data = new dataChiTietHoaDonBan();
        private void getheader()
        {
            dgvHoadondaban.Columns[0].HeaderText = "Số hóa đơn";
            dgvHoadondaban.Columns[1].HeaderText = "Ngày bán"; // THIẾT LẬP THÔNG TIN HEADER
            dgvHoadondaban.Columns[1].Width = 250;
            dgvHoadondaban.Columns[2].HeaderText = "Chiết khấu";
        }
        private void frmTongHopHoaDonDaBan_Load(object sender, EventArgs e)
        {
            // XEM TẤT CẢ HÓA ĐƠN BÁN
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-0560TPMD\SQLEXPRESS;Initial Catalog=qlgiay;Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            String sql= "Select sohd,ngayban,chietkhau from hoadonban     ";
            SqlDataAdapter adap =new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            dgvHoadondaban.DataSource = dt;
            lbltongsohoadondanhap.Text = "Số hóa đơn bán đã tạo: " + dgvHoadondaban.Rows.Count;
            con.Close();
            getheader();
        }

        private void dgvHoadondaban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int d = e.RowIndex;
                txtsohd.Text = dgvHoadondaban.Rows[d].Cells[0].Value.ToString();
                txtngayban.Text = dgvHoadondaban.Rows[d].Cells[1].Value.ToString();
            }
            catch (Exception)
            {

                //TRƯỜNG HỢP D =-1 THÌ CHƯƠNG TRÌNH VẪN CHẠY
            }
        }

        private void a_Click(object sender, EventArgs e)
        {
           if(txtsohd.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa chọn một bản ghi nào!!!");
            }    
           else
            {
                frmXemChiTietHoaDon f = new frmXemChiTietHoaDon(Convert.ToInt32(txtsohd.Text)); // TRUYỀN DỮ LIỆU SỐ HÓA ĐƠN ĐỂ LẤY HÓA ĐƠN ĐÓ RA
                // MỞ FRM CHI TIẾT HÓA ĐƠN
                f.Show();
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa không, dữ liệu không thể khôi phục", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(kq.Equals(DialogResult.Yes)) // NẾU SO SÁNH VỚI YES
            {
                data.xoahd(Convert.ToInt32(txtsohd.Text));
                frmTongHopHoaDonDaBan_Load(sender, e);
            }    
        }

        private void dgvHoadondaban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbltongsohoadondanhap_Click(object sender, EventArgs e)
        {

        }
    }
}
