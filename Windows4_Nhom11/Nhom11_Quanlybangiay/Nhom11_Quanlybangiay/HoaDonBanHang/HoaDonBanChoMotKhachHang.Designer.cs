
namespace Nhom11_Quanlybangiay.HoaDonBanHang
{
    partial class frmHoaDonBanHangCuaMotKhachHang
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
            this.txtngayban = new System.Windows.Forms.TextBox();
            this.txtsohd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvHoadondaban = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTK = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadondaban)).BeginInit();
            this.SuspendLayout();
            // 
            // txtngayban
            // 
            this.txtngayban.Enabled = false;
            this.txtngayban.Location = new System.Drawing.Point(700, 130);
            this.txtngayban.Margin = new System.Windows.Forms.Padding(4);
            this.txtngayban.Name = "txtngayban";
            this.txtngayban.Size = new System.Drawing.Size(145, 30);
            this.txtngayban.TabIndex = 21;
            // 
            // txtsohd
            // 
            this.txtsohd.Enabled = false;
            this.txtsohd.Location = new System.Drawing.Point(700, 91);
            this.txtsohd.Margin = new System.Windows.Forms.Padding(4);
            this.txtsohd.Name = "txtsohd";
            this.txtsohd.Size = new System.Drawing.Size(145, 30);
            this.txtsohd.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Nhom11_Quanlybangiay.Properties.Resources.Exit_ForMat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(597, 243);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 69);
            this.button1.TabIndex = 19;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // a
            // 
            this.a.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a.Image = global::Nhom11_Quanlybangiay.Properties.Resources.XemChiTiet_Format;
            this.a.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.a.Location = new System.Drawing.Point(597, 168);
            this.a.Margin = new System.Windows.Forms.Padding(4);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(248, 67);
            this.a.TabIndex = 20;
            this.a.Text = "Xem chi tiết";
            this.a.UseVisualStyleBackColor = true;
            this.a.Click += new System.EventHandler(this.a_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(593, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ngày bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Số hóa đơn";
            // 
            // dgvHoadondaban
            // 
            this.dgvHoadondaban.AllowUserToAddRows = false;
            this.dgvHoadondaban.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvHoadondaban.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoadondaban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoadondaban.GridColor = System.Drawing.Color.MintCream;
            this.dgvHoadondaban.Location = new System.Drawing.Point(34, 91);
            this.dgvHoadondaban.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHoadondaban.Name = "dgvHoadondaban";
            this.dgvHoadondaban.ReadOnly = true;
            this.dgvHoadondaban.RowHeadersWidth = 51;
            this.dgvHoadondaban.RowTemplate.Height = 24;
            this.dgvHoadondaban.Size = new System.Drawing.Size(514, 235);
            this.dgvHoadondaban.TabIndex = 16;
            this.dgvHoadondaban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoadondaban_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(34, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Những hóa đơn đã bán:";
            // 
            // lblTK
            // 
            this.lblTK.AutoSize = true;
            this.lblTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTK.Location = new System.Drawing.Point(34, 334);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(88, 23);
            this.lblTK.TabIndex = 23;
            this.lblTK.Text = "Thống kê";
            // 
            // frmHoaDonBanHangCuaMotKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(920, 426);
            this.Controls.Add(this.lblTK);
            this.Controls.Add(this.txtngayban);
            this.Controls.Add(this.txtsohd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvHoadondaban);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHoaDonBanHangCuaMotKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê hóa đơn theo khách hàng";
            this.Load += new System.EventHandler(this.HoaDonBanChoMotKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadondaban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtngayban;
        private System.Windows.Forms.TextBox txtsohd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button a;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvHoadondaban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTK;
    }
}