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
namespace Nhom11_Quanlybangiay.DanhSachCacNhaCungCap
{
    public partial class frmXemNhungHoaDonTheoNhaCC : Form
    {
        string mancc;
        string sohd; //TẠO BIẾN ẢO ĐỂ TRUYỀN THAM TRỊ
        public frmXemNhungHoaDonTheoNhaCC(string mancc)
        {
            InitializeComponent();
            this.mancc = mancc; // TRUYỀN THAM TRỊ
        }
        dataNCC data = new dataNCC();
        private void dgvhoadonnhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvhoadonnhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                int d = e.RowIndex;
                txtSoHDN.Text = dgvTK.Rows[d].Cells[0].Value.ToString();
                txtMancc.Text = dgvTK.Rows[d].Cells[1].Value.ToString();
                dtpNgayNhap.Value = Convert.ToDateTime(dgvTK.Rows[d].Cells[3].Value.ToString());
                sohd = txtSoHDN.Text;
            }
            catch (Exception)
            {

                // XỬ LÝ NGOẠI LỆ D =-1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void getheader()
        {
            dgvTK.Columns[0].HeaderText = "Số HĐN";
            dgvTK.Columns[1].HeaderText = "Mã nhà cung cấp";
            dgvTK.Columns[2].HeaderText = "Tên nhà cung cấp";
            dgvTK.Columns[2].Width = 250;
            dgvTK.Columns[3].HeaderText = "Ngày nhập";
            dgvTK.Columns[3].Width = 250;
        }
        private void frmXemNhungHoaDonTheoNhaCC_Load(object sender, EventArgs e)
        {
            dgvTK.DataSource = data.layrahoadoncuancc(Convert.ToInt32(mancc));
            getheader();
            lblTK.Text = "Số lượng hóa đơn: " + dgvTK.Rows.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtSoHDN.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa chọn một bản ghi nào!!!");
            }    
            else
            {
                frmChitietnhaphang f = new frmChitietnhaphang(Convert.ToInt32(txtSoHDN.Text));
                f.Show();
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // BTN THỐNG KÊ NHỮNG HÓA ĐƠN NHẬP THEO NGÀY
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
                dgvTK.DataSource = data.layrahoadoncuanccTheoNgay(Convert.ToInt32(mancc),dtp1.Value,dtp2.Value);
                getheader();
                lblTK.Text = "Số lượng hóa đơn: " + dgvTK.Rows.Count;
            }    
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvTK.DataSource = data.layrahoadoncuancc(Convert.ToInt32(mancc));
            getheader();
            lblTK.Text = "Số lượng hóa đơn: " + dgvTK.Rows.Count;
        }
    }
}
