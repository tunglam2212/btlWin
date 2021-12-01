using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom11_Quanlybangiay.ThongKe
{
    public partial class frmThongKeDoanhThuTheoNgay : Form
    {
        public frmThongKeDoanhThuTheoNgay()
        {
            InitializeComponent();
        }
        dataThongKe data = new dataThongKe();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void getheaderNhap() // THAY ĐỔI TÊN CỘT
        {
            dgvNhap.Columns[0].HeaderText = "Số hóa đơn nhập";
            dgvNhap.Columns[1].HeaderText = "Tên sản phẩm";
            dgvNhap.Columns[2].HeaderText = "Size";
            dgvNhap.Columns[3].HeaderText = "Số lượng nhập";
            dgvNhap.Columns[4].HeaderText = "Đơn giá nhập";
            dgvNhap.Columns[5].HeaderText = "Thành tiền";
            dgvNhap.Columns[6].HeaderText = "Ngày nhập";
            dgvNhap.Columns[7].HeaderText = "Người nhập";
        }
        private void getheaderBan() // THAY ĐỔI TÊN CỘT
        {
            dgvXuat.Columns[0].HeaderText = "Số hóa đơn bán";
            dgvXuat.Columns[1].HeaderText = "Tên sản phẩm";
            dgvXuat.Columns[2].HeaderText = "Giá bán";
            dgvXuat.Columns[3].HeaderText = "Size";
            dgvXuat.Columns[4].HeaderText = "Số lượng bán";
            dgvXuat.Columns[5].HeaderText = "Thành tiền";
            dgvXuat.Columns[6].HeaderText = "Chiết khấu";
            dgvXuat.Columns[7].HeaderText = "Tiền trả";
            dgvXuat.Columns[8].HeaderText = "Ngày bán";
            dgvXuat.Columns[9].HeaderText = "Người bán";
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            // KIỂM TRA DỮ LIỆU GIỮA 2 NGÀY
            string a = Convert.ToString(dtp1.Value);
            string b = Convert.ToString(dtp2.Value);
            if (a == b)
            {
                MessageBox.Show("Không được trùng ngày, ngày sau phải lớn hơn ngày trước ít nhất một ngày!!!");
            }
            else if (dtp1.Value >= dtp2.Value)
            {
                MessageBox.Show("Ngày sau phải lớn hơn ngày trước ít nhất một ngày!!!");
            }
            else
            {
               
                dgvXuat.DataSource = data.thongketienbantheongay(dtp1.Value, dtp2.Value);
                //HIỂN THỊ DỮ LIỆU

                //TÍNH TỔNG TIỀN BÁN
                int d = 0;
                for(int i=0;i<dgvXuat.Rows.Count;i++)
                {
                    d = d + Convert.ToInt32(dgvXuat.Rows[i].Cells[7].Value);
                }
                txtXuat.Text = d + "";

                //HIỂN THỊ DỮ LIỆU
                dgvNhap.DataSource = data.thongketiennhaptheongay(dtp1.Value, dtp2.Value);
                int k = 0;

                //TÍNH TỔNG TIỀN NHẬP
                for(int i=0;i<dgvNhap.Rows.Count;i++)
                {
                    k = k + Convert.ToInt32(dgvNhap.Rows[i].Cells[5].Value);
                }
                txtNhap.Text = k + "";
                txtDoanhThu.Text = d - k + "";
                getheaderBan();
                getheaderNhap();
            }
        }

        private void frmThongKeDoanhThuTheoNgay_Load(object sender, EventArgs e)
        {

        }

        private void dgvNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
