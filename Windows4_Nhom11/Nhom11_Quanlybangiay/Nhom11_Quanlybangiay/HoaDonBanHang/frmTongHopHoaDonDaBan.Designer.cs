
namespace Nhom11_Quanlybangiay.HoaDonBanHang
{
    partial class frmTongHopHoaDonDaBan
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHoadondaban = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Button();
            this.txtsohd = new System.Windows.Forms.TextBox();
            this.txtngayban = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbltongsohoadondanhap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadondaban)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(135, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Những hóa đơn đã bán:";
            // 
            // dgvHoadondaban
            // 
            this.dgvHoadondaban.AllowUserToAddRows = false;
            this.dgvHoadondaban.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvHoadondaban.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoadondaban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoadondaban.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvHoadondaban.Location = new System.Drawing.Point(139, 100);
            this.dgvHoadondaban.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvHoadondaban.Name = "dgvHoadondaban";
            this.dgvHoadondaban.ReadOnly = true;
            this.dgvHoadondaban.RowHeadersWidth = 51;
            this.dgvHoadondaban.RowTemplate.Height = 24;
            this.dgvHoadondaban.Size = new System.Drawing.Size(514, 193);
            this.dgvHoadondaban.TabIndex = 1;
            this.dgvHoadondaban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoadondaban_CellClick);
            this.dgvHoadondaban.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoadondaban_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(725, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(725, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày bán";
            // 
            // a
            // 
            this.a.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.Image = global::Nhom11_Quanlybangiay.Properties.Resources.XemChiTiet_Format;
            this.a.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.a.Location = new System.Drawing.Point(729, 235);
            this.a.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(277, 58);
            this.a.TabIndex = 5;
            this.a.Text = "Xem chi tiết";
            this.a.UseVisualStyleBackColor = true;
            this.a.Click += new System.EventHandler(this.a_Click);
            // 
            // txtsohd
            // 
            this.txtsohd.Enabled = false;
            this.txtsohd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsohd.Location = new System.Drawing.Point(858, 110);
            this.txtsohd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsohd.Name = "txtsohd";
            this.txtsohd.Size = new System.Drawing.Size(148, 26);
            this.txtsohd.TabIndex = 6;
            // 
            // txtngayban
            // 
            this.txtngayban.Enabled = false;
            this.txtngayban.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngayban.Location = new System.Drawing.Point(858, 154);
            this.txtngayban.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtngayban.Name = "txtngayban";
            this.txtngayban.Size = new System.Drawing.Size(148, 26);
            this.txtngayban.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Nhom11_Quanlybangiay.Properties.Resources.Exit_ForMat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(729, 314);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbltongsohoadondanhap
            // 
            this.lbltongsohoadondanhap.AutoSize = true;
            this.lbltongsohoadondanhap.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltongsohoadondanhap.ForeColor = System.Drawing.SystemColors.Info;
            this.lbltongsohoadondanhap.Location = new System.Drawing.Point(147, 342);
            this.lbltongsohoadondanhap.Name = "lbltongsohoadondanhap";
            this.lbltongsohoadondanhap.Size = new System.Drawing.Size(101, 25);
            this.lbltongsohoadondanhap.TabIndex = 8;
            this.lbltongsohoadondanhap.Text = "Thống kê";
            this.lbltongsohoadondanhap.Click += new System.EventHandler(this.lbltongsohoadondanhap_Click);
            // 
            // frmTongHopHoaDonDaBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1083, 438);
            this.Controls.Add(this.lbltongsohoadondanhap);
            this.Controls.Add(this.txtngayban);
            this.Controls.Add(this.txtsohd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvHoadondaban);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTongHopHoaDonDaBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê hóa đơn đã bán";
            this.Load += new System.EventHandler(this.frmTongHopHoaDonDaBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadondaban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHoadondaban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button a;
        private System.Windows.Forms.TextBox txtsohd;
        private System.Windows.Forms.TextBox txtngayban;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbltongsohoadondanhap;
    }
}