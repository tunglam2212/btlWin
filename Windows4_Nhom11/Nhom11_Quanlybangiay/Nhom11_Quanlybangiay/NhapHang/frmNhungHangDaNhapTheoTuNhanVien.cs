using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom11_Quanlybangiay.NhapHang
{
    public partial class frmNhungHangDaNhapTheoTuNhanVien : Form
    {
        string manql; // TẠO BIẾN ĐỂ TRUYỀN GIỮA LIỆU GIỮA NHIỀU FORM
        public frmNhungHangDaNhapTheoTuNhanVien(string manql)
        {
            InitializeComponent();
            this.manql = manql;// TRUYỀN DỮ LIỆU
        }
        datanhaphang data = new datanhaphang();
        private void frmNhungHangDaNhapTheoTuNhanVien_Load(object sender, EventArgs e)
        {
            dgvhoadonnhap.DataSource = data.xemnhunghoadondanhaptheomaNQL(manql);// XEM HÓA ĐƠN NHẬP THEO MÃ NQL
            getheader();

            dgvhoadonnhap.Columns[1].Width = 150;
            dgvhoadonnhap.Columns[2].Width = 250;
            lblTK.Text = "Tổng số hóa đơn nhập: " + dgvhoadonnhap.Rows.Count;
        }
        private void getheader()
        {
            dgvhoadonnhap.Columns[0].HeaderText = "Số hóa đơn ";
            dgvhoadonnhap.Columns[1].HeaderText = "Mã nhà cung cấp";
            dgvhoadonnhap.Columns[2].HeaderText = "Ngày nhập";
        }
        private void dgvhoadonnhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int d = e.RowIndex;
                txtSoHDN.Text = dgvhoadonnhap.Rows[d].Cells[0].Value.ToString();
                txtMancc.Text = dgvhoadonnhap.Rows[d].Cells[1].Value.ToString();
                dtpNgayNhap.Value = Convert.ToDateTime(dgvhoadonnhap.Rows[d].Cells[2].Value.ToString());
            }
            catch (Exception)
            {
                //TRƯƠNG HỢP D =-1;
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtSoHDN.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa chọn một bản ghi nào !!!"); // NẾU DỮ LIỆU BỊ LỖI
            }    
            else
            {
                frmChitietnhaphang f = new frmChitietnhaphang(Convert.ToInt32(txtSoHDN.Text));
                f.Show();
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
