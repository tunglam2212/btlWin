using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom11_Quanlybangiay.NhapHang;
namespace Nhom11_Quanlybangiay.ThongKe
{
    public partial class frmThongKeHoaDonNhapTheoNgay : Form
    {
        public frmThongKeHoaDonNhapTheoNgay()
        {
            InitializeComponent();
        }
        dataThongKe data = new dataThongKe();
        private void getheader()
        {
            //LẤY RA HEADER
            dgvdanhsach.Columns[0].HeaderText = "Số hóa đơn nhập";
            dgvdanhsach.Columns[1].HeaderText = "Tên người nhập";
            dgvdanhsach.Columns[1].Width = 200;
            dgvdanhsach.Columns[2].HeaderText = "Ngày nhập";
            dgvdanhsach.Columns[2].Width = 200;
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {   // KIỂM TRA XEM NGÀY SAU CÓ NHỎ HƠN NGÀY TRƯỚC HAY KHÔNG
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
                dgvdanhsach.DataSource = data.ThongKeHoaDonNhapTheoNgay(dtp1.Value, dtp2.Value);
                getheader();
                lblTK.Text = "Số lượng hóa đơn nhập: " + dgvdanhsach.Rows.Count;// ĐẾM SỐ LƯỢNG HÓA ĐƠN
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongKeHoaDonNhapTheoNgay_Load(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //BTN XÓA DỮ LIỆU
            if(txtmahd.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa chọn một bản ghi nào !!!");
            }    
            else
            {
                DialogResult kq = MessageBox.Show("Bạn có chắc chắn xóa không, sau khi xóa dữ liệu không thể khôi phục lại được ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (kq.Equals(DialogResult.Yes))
                {
                    data.xoahoadonnhap(txtmahd.Text);
                    dgvdanhsach.DataSource = data.ThongKeHoaDonNhapTheoNgay(dtp1.Value, dtp2.Value);
                }
            }    
        }

        private void dgvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int d = e.RowIndex;
                txtmahd.Text = dgvdanhsach.Rows[d].Cells[0].Value.ToString();
                dtpngayban.Value = Convert.ToDateTime(dgvdanhsach.Rows[d].Cells[2].Value.ToString());
            }
            catch (Exception)
            {
                //TRƯỜNG HỢP MÀ D=-1
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if(txtmahd.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa chọn một bản ghi nào !!!");
            }
            else
            {
                //XEM CHI TIẾT HÓA ĐƠN
                frmChitietnhaphang f = new frmChitietnhaphang(Convert.ToInt32(txtmahd.Text));
                f.Show();
            }
        }

        private void dgvdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dtp2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblTK_Click(object sender, EventArgs e)
        {

        }
    }
}
