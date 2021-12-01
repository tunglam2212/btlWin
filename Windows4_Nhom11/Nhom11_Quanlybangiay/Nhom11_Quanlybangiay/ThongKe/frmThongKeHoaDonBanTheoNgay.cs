using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Nhom11_Quanlybangiay.HoaDonBanHang;
namespace Nhom11_Quanlybangiay.ThongKe
{
    public partial class frmThongKeHoaDonBanTheoNgay : Form
    {
        public frmThongKeHoaDonBanTheoNgay()
        {
            InitializeComponent();
        }
        dataThongKe data = new dataThongKe();
        private void getheader()
        {
            // LẤY RA HEADER
            dgvHoaDon.Columns[0].HeaderText = "Số hóa đơn";
            dgvHoaDon.Columns[1].HeaderText = "Ngày bán";
            dgvHoaDon.Columns[1].Width = 250;
            dgvHoaDon.Columns[2].HeaderText = "Chiết khấu";
            dgvHoaDon.Columns[3].HeaderText = "Người bán";
            dgvHoaDon.Columns[3].Width = 250;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // KIỂM TRA NGÀY SAU CÓ NHỎ HƠN NGÀY TRƯỚC HAY KHÔNG
            string a = Convert.ToString(dtp1.Value);
            string b = Convert.ToString(dtp2.Value);
            if(a==b)
            {
                MessageBox.Show("Không được trùng ngày, ngày sau phải lớn hơn ngày trước ít nhất một ngày!!!");
            }    
            else if(dtp1.Value >= dtp2.Value)
            {
                MessageBox.Show("Ngày sau phải lớn hơn ngày trước ít nhất một ngày!!!");
            }    
            else
            {
                dgvHoaDon.DataSource = data.ThongKeHoaDonBanTheoNgay(dtp1.Value, dtp2.Value);
                getheader();
                lblTK.Text = "Số lượng hóa đơn bán: " + dgvHoaDon.Rows.Count;
            }    
        }

        private void frmThongKeHoaDonBanTheoNgay_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = null;
        }

        private void dgvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int d = e.RowIndex;
                txtck.Text = dgvHoaDon.Rows[d].Cells[2].Value.ToString();
                dtpngayban.Value = Convert.ToDateTime(dgvHoaDon.Rows[d].Cells[1].Value.ToString());
                txtmahd.Text = dgvHoaDon.Rows[d].Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                //TRƯỜNG HỢP D=-1
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtmahd.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa chọn một bản ghi nào!!!");
            }    
            else
            {
                frmXemChiTietHoaDon f = new frmXemChiTietHoaDon(Convert.ToInt32(txtmahd.Text));
                f.Show();
            }    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txtmahd.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa chọn một hóa đơn nào!!!");
            }    
            else
            {
                DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này, dữ liệu không thể khôi phục", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (kq.Equals(DialogResult.Yes))
                {
                    data.xoahoadon(txtmahd.Text);
                    dgvHoaDon.DataSource = data.ThongKeHoaDonBanTheoNgay(dtp1.Value, dtp2.Value);
                }
            }    
        }

        private void dtpngayban_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lblTK_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
