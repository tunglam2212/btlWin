using System;
using System.Windows.Forms;
using Nhom11_Quanlybangiay.Khachhang;
using Nhom11_Quanlybangiay.NhapHang;
using Nhom11_Quanlybangiay.HoaDonBanHang;
using Nhom11_Quanlybangiay.SanPham;
namespace Nhom11_Quanlybangiay.FormChucNang
{
    public partial class frmNV : Form
    {
        public string manql { get; set; }
        public string matkhau { get; set; }
        public frmNV(string manql, string matkhau)
        {
            InitializeComponent();
            this.manql = manql; // TRUYỀN THAM TRỊ SANG FORM ĐỔI MẬT KHẨU , BÁN HÀNG, NHẬP HÀNG
            this.matkhau = matkhau;
        }


        dataformChucNang data = new dataformChucNang();









        private void frmNV_Load(object sender, EventArgs e)
        {
            txtwelcome.Text = "Welcome " + data.layraten(manql); // TẠO LỜI CHÀO

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); // ĐÓNG FORM
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nhữngHóaĐơnBánĐãTạoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhữngHóaĐơnNhậpĐãTạoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xemSảnPhẩmTrongKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnChucNang_Click(object sender, EventArgs e)
        {
            if (btnBanHang.Visible == true)
            {
                btnNhapHang.Visible = false;
                btnBanHang.Visible = false;
            }
            else
            {
                btnNhapHang.Visible = true;
                btnBanHang.Visible = true;
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (btnXemSanPhamTonKho.Visible == true)
            {
                btnHoaDonNhapDaTao.Visible = false;
                btnHoaDonBanDaTao.Visible = false;
                btnXemSanPhamTonKho.Visible = false;
            }
            else
            {
                btnHoaDonNhapDaTao.Visible = true;
                btnHoaDonBanDaTao.Visible = true;
                btnXemSanPhamTonKho.Visible = true;
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nhom11_Quanlybangiay.FrmLogin.FrmLogin f = new Nhom11_Quanlybangiay.FrmLogin.FrmLogin();
            f.ShowDialog();
            this.Close();
            
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            this.pnl_hienthi.Controls.Clear();
            frmkhachhang f = new frmkhachhang();
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            f.manql = manql; // TRUYỀN DỮ LIỆU GIỮA CÁC FORM
            this.pnl_hienthi.Controls.Add(f);
            f.Show();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            this.pnl_hienthi.Controls.Clear();
            frmNhapHang f = new frmNhapHang();
            f.manql = manql;
            f.Show();
        }

        private void btnHoaDonBanDaTao_Click(object sender, EventArgs e)
        {
            this.pnl_hienthi.Controls.Clear();
            frmXemNhungHoaDonDaBanTheoNhanVien f = new frmXemNhungHoaDonDaBanTheoNhanVien(manql);
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            this.pnl_hienthi.Controls.Add(f);
            f.Show(); // SHOW
        }

        private void btnHoaDonNhapDaTao_Click(object sender, EventArgs e)
        {
            this.pnl_hienthi.Controls.Clear();
            frmNhungHangDaNhapTheoTuNhanVien f = new frmNhungHangDaNhapTheoTuNhanVien(manql); // FRM NHỮNG HÀNG ĐÃ NHẬP THEO NHÂN VIÊN
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            this.pnl_hienthi.Controls.Add(f);
            f.Show();
        }

        private void btnXemSanPhamTonKho_Click(object sender, EventArgs e)
        {

            this.pnl_hienthi.Controls.Clear();
            frmSanPhamVoiNhanVien f = new frmSanPhamVoiNhanVien(); // FRM SẢN PHẨM
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            this.pnl_hienthi.Controls.Add(f);
            f.Show(); ;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            this.pnl_hienthi.Controls.Clear();
            formdoimatkhau f = new formdoimatkhau(manql, matkhau); // TRUYỀN THAM TRỊ ĐỔI MẬT KHẨU
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            this.pnl_hienthi.Controls.Add(f);
            f.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmNV_FormClosed(object sender, FormClosedEventArgs e)
        {

            //this.Hide();
            //Nhom11_Quanlybangiay.FrmLogin.FrmLogin f = new Nhom11_Quanlybangiay.FrmLogin.FrmLogin();
            //f.ShowDialog();
            //this.Close();
        }
    }
}
