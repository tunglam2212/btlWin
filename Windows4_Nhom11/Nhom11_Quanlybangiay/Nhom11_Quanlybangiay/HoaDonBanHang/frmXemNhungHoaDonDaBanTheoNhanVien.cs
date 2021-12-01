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
    public partial class frmXemNhungHoaDonDaBanTheoNhanVien : Form
    {
        dataChiTietHoaDonBan data = new dataChiTietHoaDonBan();
        private string manql;// TRUYỀN THAM CHIẾU GIỮA NHIỀU FORM
        public frmXemNhungHoaDonDaBanTheoNhanVien(string manql)
        {
            InitializeComponent();
            this.manql = manql;//TRUYỀN THAM CHIẾU
        }

        private void frmXemNhungHoaDonDaBanTheoNhanVien_Load(object sender, EventArgs e)
        {
            dgvHoadondaban.DataSource = data.xemhoadondabantheonhanvien(manql); // TRUYỀN MÃ QUẢN LÍ ĐỂ XEM
            getheader();//TẠO HEADER
            lblTK.Text = "Số lượng hóa đơn xuất: " + dgvHoadondaban.Rows.Count;
        }
        private void getheader()
        {// TẠO HEADER TIẾNG VIỆT
            dgvHoadondaban.Columns[0].HeaderText = "Số hóa đơn";
            dgvHoadondaban.Columns[0].Width = 120;
            dgvHoadondaban.Columns[1].HeaderText = "Ngày bán";
            dgvHoadondaban.Columns[1].Width = 250;
            dgvHoadondaban.Columns[2].HeaderText = "Chiết khấu";
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

                // Nếu click sai
            }
        }

        private void a_Click(object sender, EventArgs e)
        {
            if(txtsohd.Text.Equals("")) // NẾU MÃ HÓA ĐƠN KHÔNG TỒN TẠI
            { 
                MessageBox.Show("Bạn chưa chọn bản ghi nào để xem chi tiết");
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
