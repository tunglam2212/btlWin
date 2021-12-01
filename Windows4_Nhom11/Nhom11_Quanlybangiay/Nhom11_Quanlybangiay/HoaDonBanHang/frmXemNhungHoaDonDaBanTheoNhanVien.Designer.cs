
namespace Nhom11_Quanlybangiay.HoaDonBanHang
{
    partial class frmXemNhungHoaDonDaBanTheoNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtngayban = new System.Windows.Forms.TextBox();
            this.txtsohd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvHoadondaban = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Button();
            this.lblTK = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadondaban)).BeginInit();
            this.SuspendLayout();
            // 
            // txtngayban
            // 
            this.txtngayban.Enabled = false;
            this.txtngayban.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngayban.Location = new System.Drawing.Point(707, 181);
            this.txtngayban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtngayban.Name = "txtngayban";
            this.txtngayban.Size = new System.Drawing.Size(120, 30);
            this.txtngayban.TabIndex = 13;
            // 
            // txtsohd
            // 
            this.txtsohd.Enabled = false;
            this.txtsohd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsohd.Location = new System.Drawing.Point(707, 144);
            this.txtsohd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsohd.Name = "txtsohd";
            this.txtsohd.Size = new System.Drawing.Size(120, 30);
            this.txtsohd.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Nhom11_Quanlybangiay.Properties.Resources.Exit_ForMat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(604, 293);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 55);
            this.button1.TabIndex = 11;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(600, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ngày bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(600, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Số hóa đơn";
            // 
            // dgvHoadondaban
            // 
            this.dgvHoadondaban.AllowUserToAddRows = false;
            this.dgvHoadondaban.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvHoadondaban.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoadondaban.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoadondaban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoadondaban.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoadondaban.GridColor = System.Drawing.SystemColors.MenuBar;
            this.dgvHoadondaban.Location = new System.Drawing.Point(19, 145);
            this.dgvHoadondaban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHoadondaban.Name = "dgvHoadondaban";
            this.dgvHoadondaban.ReadOnly = true;
            this.dgvHoadondaban.RowHeadersWidth = 51;
            this.dgvHoadondaban.RowTemplate.Height = 24;
            this.dgvHoadondaban.Size = new System.Drawing.Size(551, 204);
            this.dgvHoadondaban.TabIndex = 8;
            this.dgvHoadondaban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoadondaban_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(17, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Những hóa đơn đã bán:";
            // 
            // a
            // 
            this.a.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.Image = global::Nhom11_Quanlybangiay.Properties.Resources.XemChiTiet_Format;
            this.a.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.a.Location = new System.Drawing.Point(604, 234);
            this.a.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(223, 53);
            this.a.TabIndex = 12;
            this.a.Text = "Xem chi tiết";
            this.a.UseVisualStyleBackColor = true;
            this.a.Click += new System.EventHandler(this.a_Click);
            // 
            // lblTK
            // 
            this.lblTK.AutoSize = true;
            this.lblTK.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTK.Location = new System.Drawing.Point(16, 367);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(127, 32);
            this.lblTK.TabIndex = 15;
            this.lblTK.Text = "Thống kê";
            // 
            // frmXemNhungHoaDonDaBanTheoNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1067, 519);
            this.Controls.Add(this.lblTK);
            this.Controls.Add(this.txtngayban);
            this.Controls.Add(this.txtsohd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvHoadondaban);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmXemNhungHoaDonDaBanTheoNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tổng hợp những hóa đơn đã bán";
            this.Load += new System.EventHandler(this.frmXemNhungHoaDonDaBanTheoNhanVien_Load);
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