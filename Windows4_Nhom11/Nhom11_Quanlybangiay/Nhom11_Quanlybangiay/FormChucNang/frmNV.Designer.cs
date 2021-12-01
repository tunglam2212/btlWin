
namespace Nhom11_Quanlybangiay.FormChucNang
{
    partial class frmNV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtwelcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.btnXemSanPhamTonKho = new System.Windows.Forms.Button();
            this.btnHoaDonNhapDaTao = new System.Windows.Forms.Button();
            this.btnHoaDonBanDaTao = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnChucNang = new System.Windows.Forms.Button();
            this.pnl_hienthi = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtwelcome
            // 
            this.txtwelcome.AutoSize = true;
            this.txtwelcome.Font = new System.Drawing.Font("Times New Roman", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwelcome.ForeColor = System.Drawing.Color.Tomato;
            this.txtwelcome.Location = new System.Drawing.Point(311, 18);
            this.txtwelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtwelcome.Name = "txtwelcome";
            this.txtwelcome.Size = new System.Drawing.Size(175, 90);
            this.txtwelcome.TabIndex = 0;
            this.txtwelcome.Text = "hỎI";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtwelcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 127);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Nhom11_Quanlybangiay.Properties.Resources.logokvo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.btnDangXuat);
            this.panel2.Controls.Add(this.btnDoiMatKhau);
            this.panel2.Controls.Add(this.btnXemSanPhamTonKho);
            this.panel2.Controls.Add(this.btnHoaDonNhapDaTao);
            this.panel2.Controls.Add(this.btnHoaDonBanDaTao);
            this.panel2.Controls.Add(this.btnXem);
            this.panel2.Controls.Add(this.btnNhapHang);
            this.panel2.Controls.Add(this.btnBanHang);
            this.panel2.Controls.Add(this.btnChucNang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 622);
            this.panel2.TabIndex = 3;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDangXuat.Image = global::Nhom11_Quanlybangiay.Properties.Resources.Logout1;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 549);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(272, 88);
            this.btnDangXuat.TabIndex = 8;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDoiMatKhau.Image = global::Nhom11_Quanlybangiay.Properties.Resources.changepassword;
            this.btnDoiMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(0, 461);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(272, 88);
            this.btnDoiMatKhau.TabIndex = 7;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnXemSanPhamTonKho
            // 
            this.btnXemSanPhamTonKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXemSanPhamTonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemSanPhamTonKho.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemSanPhamTonKho.ForeColor = System.Drawing.Color.Red;
            this.btnXemSanPhamTonKho.Location = new System.Drawing.Point(0, 404);
            this.btnXemSanPhamTonKho.Name = "btnXemSanPhamTonKho";
            this.btnXemSanPhamTonKho.Size = new System.Drawing.Size(272, 57);
            this.btnXemSanPhamTonKho.TabIndex = 6;
            this.btnXemSanPhamTonKho.Text = "* Sản phẩm tồn kho";
            this.btnXemSanPhamTonKho.UseVisualStyleBackColor = true;
            this.btnXemSanPhamTonKho.Visible = false;
            this.btnXemSanPhamTonKho.Click += new System.EventHandler(this.btnXemSanPhamTonKho_Click);
            // 
            // btnHoaDonNhapDaTao
            // 
            this.btnHoaDonNhapDaTao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDonNhapDaTao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDonNhapDaTao.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDonNhapDaTao.ForeColor = System.Drawing.Color.Red;
            this.btnHoaDonNhapDaTao.Location = new System.Drawing.Point(0, 347);
            this.btnHoaDonNhapDaTao.Name = "btnHoaDonNhapDaTao";
            this.btnHoaDonNhapDaTao.Size = new System.Drawing.Size(272, 57);
            this.btnHoaDonNhapDaTao.TabIndex = 5;
            this.btnHoaDonNhapDaTao.Text = "* Hóa đơn nhập đã tạo";
            this.btnHoaDonNhapDaTao.UseVisualStyleBackColor = true;
            this.btnHoaDonNhapDaTao.Visible = false;
            this.btnHoaDonNhapDaTao.Click += new System.EventHandler(this.btnHoaDonNhapDaTao_Click);
            // 
            // btnHoaDonBanDaTao
            // 
            this.btnHoaDonBanDaTao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDonBanDaTao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDonBanDaTao.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDonBanDaTao.ForeColor = System.Drawing.Color.Red;
            this.btnHoaDonBanDaTao.Location = new System.Drawing.Point(0, 290);
            this.btnHoaDonBanDaTao.Name = "btnHoaDonBanDaTao";
            this.btnHoaDonBanDaTao.Size = new System.Drawing.Size(272, 57);
            this.btnHoaDonBanDaTao.TabIndex = 4;
            this.btnHoaDonBanDaTao.Text = "* Hóa đơn bán đã tạo";
            this.btnHoaDonBanDaTao.UseVisualStyleBackColor = true;
            this.btnHoaDonBanDaTao.Visible = false;
            this.btnHoaDonBanDaTao.Click += new System.EventHandler(this.btnHoaDonBanDaTao_Click);
            // 
            // btnXem
            // 
            this.btnXem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnXem.Image = global::Nhom11_Quanlybangiay.Properties.Resources.report__1_1;
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(0, 202);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(272, 88);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.ForeColor = System.Drawing.Color.Red;
            this.btnNhapHang.Location = new System.Drawing.Point(0, 145);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(272, 57);
            this.btnNhapHang.TabIndex = 2;
            this.btnNhapHang.Text = "* Nhập hàng";
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Visible = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanHang.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanHang.ForeColor = System.Drawing.Color.Red;
            this.btnBanHang.Location = new System.Drawing.Point(0, 88);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(272, 57);
            this.btnBanHang.TabIndex = 1;
            this.btnBanHang.Text = "* Bán hàng";
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Visible = false;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnChucNang
            // 
            this.btnChucNang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChucNang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChucNang.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChucNang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnChucNang.Image = global::Nhom11_Quanlybangiay.Properties.Resources.Chức_năng;
            this.btnChucNang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChucNang.Location = new System.Drawing.Point(0, 0);
            this.btnChucNang.Name = "btnChucNang";
            this.btnChucNang.Size = new System.Drawing.Size(272, 88);
            this.btnChucNang.TabIndex = 0;
            this.btnChucNang.Text = "Chức năng";
            this.btnChucNang.UseVisualStyleBackColor = true;
            this.btnChucNang.Click += new System.EventHandler(this.btnChucNang_Click);
            // 
            // pnl_hienthi
            // 
            this.pnl_hienthi.AutoScroll = true;
            this.pnl_hienthi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_hienthi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_hienthi.Location = new System.Drawing.Point(289, 127);
            this.pnl_hienthi.Name = "pnl_hienthi";
            this.pnl_hienthi.Size = new System.Drawing.Size(807, 622);
            this.pnl_hienthi.TabIndex = 4;
            // 
            // frmNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1096, 749);
            this.Controls.Add(this.pnl_hienthi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNV_FormClosed);
            this.Load += new System.EventHandler(this.frmNV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtwelcome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_hienthi;
        private System.Windows.Forms.Button btnChucNang;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnXemSanPhamTonKho;
        private System.Windows.Forms.Button btnHoaDonNhapDaTao;
        private System.Windows.Forms.Button btnHoaDonBanDaTao;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnDoiMatKhau;
    }
}