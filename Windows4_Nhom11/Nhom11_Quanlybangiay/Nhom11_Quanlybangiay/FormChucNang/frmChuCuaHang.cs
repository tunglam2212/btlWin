using Nhom11_Quanlybangiay.Người_quản_lí;
using System;
using System.Windows.Forms;
using Nhom11_Quanlybangiay.HoaDonBanHang;
using Nhom11_Quanlybangiay.ThemSanPham;
using Nhom11_Quanlybangiay.Khachhang;
using Nhom11_Quanlybangiay.DanhSachCacNhaCungCap;
using Nhom11_Quanlybangiay.NhapHang;
using Nhom11_Quanlybangiay.ThongKe;
using Nhom11_Quanlybangiay.SanPham;
using Nhom11_Quanlybangiay.FrmLogin;
namespace Nhom11_Quanlybangiay.FormChucNang
{
    public partial class frmChuCuaHang : Form
    {
        public frmChuCuaHang(string tk,string mk)
        {
            InitializeComponent();
            this.tk = tk;// TẠO TK , MK TRUYỀN THAM TRỊ SANG FORM ĐỔI MẬT KHẨU
            this.mk = mk;
        }
        dataformChucNang data = new dataformChucNang();
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string tk;
        string mk;
        private void frmChuCuaHang_Load(object sender, EventArgs e)
        {
            lblChao.Text = "Welcome Admin " + data.layraten(tk);
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void hóaĐơnĐãNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCacHoaDonDaNhap f = new frmCacHoaDonDaNhap();
            f.Show();
        }

        private void hóaĐơnĐãBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thốngKêHóaĐơnTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xemSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void danhSáchNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void thốngKêSảnPhẩmBánChạyNhấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thốngKêHóaĐơnBánTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thốngKêHóaĐơnXuấtTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // THỐNG KÊ
            
        }

        private void thốngKêTiềnNhậpXuấtDoanhThuTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LOẠI HÀNG
           
        }

        private void xemLoạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kháchHàngVIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // KHÁCH HÀNG
            frmKhachHangVip f = new frmKhachHangVip();
            f.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm đổi mật khẩu
            
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void soSánhGiáSảnPhẩmNhậpGiữaCácNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void xemSảnPhẩmBánChậmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tổngSốLượngSảnPhẩmĐangTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (btnxem1.Visible == true)
            {
                // CÁC NÚT VỚI CÁC SỰ KIỆN
               
                btnxem6.Visible = false;
                btnxem5.Visible = false;
                btnxem4.Visible = false;
                btnxem3.Visible = false;
                btnxem2.Visible = false;
                btnxem1.Visible = false;
            }
            else
            {
                btnxem6.Visible = true;
                btnxem5.Visible = true;
                btnxem4.Visible = true;
                btnxem3.Visible = true;
                btnxem2.Visible = true;
                btnxem1.Visible = true;
            }    
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(btnTK1.Visible==true)
            {
                
             
                btnTK8.Visible = false;
                btnTK7.Visible = false;
                btnTK6.Visible = false;
                btnTK5.Visible = false;
                btnTK4.Visible = false;
                btnTK3.Visible = false;
                btnTK2.Visible = false;
                btnTK1.Visible = false;
            }    
            else
            {
               
                btnTK8.Visible = true;
                btnTK7.Visible = true;
                btnTK6.Visible = true;
                btnTK5.Visible = true;
                btnTK4.Visible = true;
                btnTK3.Visible = true;
                btnTK2.Visible = true;
                btnTK1.Visible = true;
            }    
        }

        private void btnxem1_Click(object sender, EventArgs e)
        {// THÔNG TIN TÀI KHOẢN
            this.panelDisplay.Controls.Clear();
            frmNguoiquanli f = new frmNguoiquanli();
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill; 
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            this.panelDisplay.Controls.Add(f);
            f.Show();
        }

        private void btnxem2_Click(object sender, EventArgs e)
        {
            this.panelDisplay.Controls.Clear();
            frmCacHoaDonDaNhap f = new frmCacHoaDonDaNhap();
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            this.panelDisplay.Controls.Add(f);
            f.Show();

            
            
        }

        private void btnxem3_Click(object sender, EventArgs e)
        {
            this.panelDisplay.Controls.Clear();
            frmTongHopHoaDonDaBan f = new frmTongHopHoaDonDaBan();
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            this.panelDisplay.Controls.Add(f);
            f.Show();
        }

        private void btnxem4_Click(object sender, EventArgs e)
        {
            this.panelDisplay.Controls.Clear();
            frmKhachHangVoiNQL f = new frmKhachHangVoiNQL();
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            this.panelDisplay.Controls.Add(f);
            f.Show();
        }

        private void btnxem5_Click(object sender, EventArgs e)
        {
            this.panelDisplay.Controls.Clear();
            frmNhaCungCap f = new frmNhaCungCap();
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            this.panelDisplay.Controls.Add(f);
            f.Show();
        }

        private void btnxem6_Click(object sender, EventArgs e)
        {
            this.panelDisplay.Controls.Clear();
            frmSanPham f = new frmSanPham();
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            this.panelDisplay.Controls.Add(f);
            f.Show();
        }

        private void pnl_hienthi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTK1_Click(object sender, EventArgs e)
        {
            this.panelDisplay.Controls.Clear();
            frmKhachHangVip f = new frmKhachHangVip();
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            this.panelDisplay.Controls.Add(f);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnChucNang_Click(object sender, EventArgs e)
        {
            if(btnCN1.Visible==true)
            {
                btnCN2.Visible = false;
                btnCN1.Visible = false;
            }    
            else
            {
                btnCN2.Visible = true;
                btnCN1.Visible = true;
            }    
        }

        private void btnTK2_Click(object sender, EventArgs e)
        {
            this.panelDisplay.Controls.Clear();
            frmThongKeHoaDonBanTheoNgay f = new frmThongKeHoaDonBanTheoNgay();
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            this.panelDisplay.Controls.Add(f);
            f.Show();
        }

        private void btnTK3_Click(object sender, EventArgs e)
        {
            this.panelDisplay.Controls.Clear();
            frmThongKeHoaDonNhapTheoNgay f = new frmThongKeHoaDonNhapTheoNgay();
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            this.panelDisplay.Controls.Add(f);
            f.Show();
        }

        private void btnTK4_Click(object sender, EventArgs e)
        {
            this.panelDisplay.Controls.Clear();
            frmThongKeSanPhamBanChayNhat f = new frmThongKeSanPhamBanChayNhat();
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            this.panelDisplay.Controls.Add(f);
            f.Show();
        }

        private void btnTK5_Click(object sender, EventArgs e)
        {
            this.panelDisplay.Controls.Clear();
            frmThongKeDoanhThuTheoNgay f = new frmThongKeDoanhThuTheoNgay();
            f.Show();
        }

        private void btnTK6_Click(object sender, EventArgs e)
        {
            this.panelDisplay.Controls.Clear();
            frmThongKeTienNhapGiuaCacNhaCungCap f = new frmThongKeTienNhapGiuaCacNhaCungCap();
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            this.panelDisplay.Controls.Add(f);
            f.Show();
        }

        private void btnTK7_Click(object sender, EventArgs e)
        {
            this.panelDisplay.Controls.Clear();
            frmTongSoLuongTonKho f = new frmTongSoLuongTonKho();
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            this.panelDisplay.Controls.Add(f);
            f.Show();
        }

        private void btnCN2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.panelDisplay.Controls.Clear();
            formdoimatkhau f = new formdoimatkhau(tk, mk); // ĐỔI MẬT KHẨU
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            this.panelDisplay.Controls.Add(f);
            f.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Nhom11_Quanlybangiay.FrmLogin.FrmLogin f = new Nhom11_Quanlybangiay.FrmLogin.FrmLogin();
            f.ShowDialog();
            this.Close();

        }

        private void pnl_hienthi_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnCN2_Click_1(object sender, EventArgs e)
        {
            this.panelDisplay.Controls.Clear();
            frmNhapHang f = new frmNhapHang();
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            f.manql = tk; // NHẬP HÀNG
            this.panelDisplay.Controls.Add(f);
            f.Show();
        }

        private void btnCN1_Click(object sender, EventArgs e)
        {
            //Bán hàng
            this.panelDisplay.Controls.Clear();
            frmkhachhang f = new frmkhachhang();
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;

            f.manql = tk; // TRUYỀN DỮ LIỆU GIỮA CÁC FORM
            this.panelDisplay.Controls.Add(f);
            f.Show();
        }

        private void btnChucNang_Click_1(object sender, EventArgs e)
        {
            if (btnCN1.Visible == true)
            {
                btnCN2.Visible = false;
                btnCN1.Visible = false;
            }
            else
            {
                btnCN2.Visible = true;
                btnCN1.Visible = true;
            }
        }

        private void frmChuCuaHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Hide();
            //Nhom11_Quanlybangiay.FrmLogin.FrmLogin f = new Nhom11_Quanlybangiay.FrmLogin.FrmLogin();
            //f.ShowDialog();
            //this.Close();
        }

        private void btnTK8_Click(object sender, EventArgs e)
        {// THỐNG KÊ NGƯỜI BÁN ĐƯỢC NHIEUF NHẤT
            this.panelDisplay.Controls.Clear();
            frmNguoiThuTien f = new frmNguoiThuTien();
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = (FormBorderStyle)FormBorderStyle.None;
            this.panelDisplay.Controls.Add(f);
            f.Show();
        }
    }
}
