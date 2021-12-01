using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom11_Quanlybangiay.HoaDonBanHang
{
    public partial class frmHoaDonBanHangCuaMotKhachHang : Form
    {
        string sdt;
        public frmHoaDonBanHangCuaMotKhachHang(string sdt)
        {
            InitializeComponent();
            this.sdt = sdt; // TRUYỀN DỮ LIỆU GIỮA CÁC FORM
        }
        dataChiTietHoaDonBan data = new dataChiTietHoaDonBan();
        private void HoaDonBanChoMotKhachHang_Load(object sender, EventArgs e)
        {
            dgvHoadondaban.DataSource = data.xemhoadondabantheokhachhang(sdt);
            getheader();
            lblTK.Text = "Tổng số hóa đơn đã mua: " + dgvHoadondaban.Rows.Count;
        }
        private void getheader()
        {// TẠO HEADDER
            dgvHoadondaban.Columns[0].HeaderText = "Số hóa đơn";
            dgvHoadondaban.Columns[1].HeaderText = "Ngày bán";
            dgvHoadondaban.Columns[1].Width = 250;
            dgvHoadondaban.Columns[2].HeaderText = "Chiết khấu";
        }
        private void dgvHoadondaban_CellClick(object sender, DataGridViewCellEventArgs e) // CELL CLICK GET THÔNG TIN KHÁCH HÀNG
        {
            try
            {
                int d = e.RowIndex;
                txtsohd.Text = dgvHoadondaban.Rows[d].Cells[0].Value.ToString();
                txtngayban.Text = dgvHoadondaban.Rows[d].Cells[1].Value.ToString();
            }
            catch (Exception)
            {

               // TRƯỜNG HỢP D =-1;
            }
        }

        private void a_Click(object sender, EventArgs e)
        {
            if(txtsohd.Text.Equals("")) // XỬ LÝ NGOẠI LỆ HÓA ĐƠN RỖNG
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn nào để xem chi tiết!!!");

            }   
            else
            {
                frmXemChiTietHoaDon f = new frmXemChiTietHoaDon(Convert.ToInt32(txtsohd.Text));
                f.Show();
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
