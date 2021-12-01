using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Nhom11_Quanlybangiay.HoaDonBanHang
{
    public partial class frmXuatHoaDon : Form
    {
        dataChiTietHoaDonBan data = new dataChiTietHoaDonBan();
        string tenkh, diachi, dienthoai; // TRUYỀN THAM TRỊ
        int m = 0; // Biến cờ để kiểm tra xem đã thay đổi combo box hay chưa
        int kiemtrathanhtoanhoadon = 0; //Biến xem đã thanh toán hóa đơn hay chưa
        public string manql { get; set; } // TRUYỀN THAM TRỊ GIỮA NHIỀU FORM
        
        public frmXuatHoaDon(string dienthoai, string tenkh, string diachi)
        {
            InitializeComponent();
            this.tenkh = tenkh;
            this.diachi = diachi;
            this.dienthoai = dienthoai; // TRUYỀN THAM CHIẾU ĐỂ LƯU THÔNG TIN KHÁCH HÀNG
            
        }
        
        public frmXuatHoaDon()
        {
            InitializeComponent();

        }
        string mahd;
        void getheader() // TẠO HEADER
        {
            dgvdanhsachsp.Columns[0].HeaderText = "Mã sản phẩm";
            dgvdanhsachsp.Columns[0].Width = 100;
            dgvdanhsachsp.Columns[1].HeaderText = "Tên sản phẩm";
            dgvdanhsachsp.Columns[1].Width = 250;
            dgvdanhsachsp.Columns[2].HeaderText = "Size";
            dgvdanhsachsp.Columns[3].HeaderText = "Số lượng ";
            dgvdanhsachsp.Columns[4].HeaderText = "Giá bán";
            dgvdanhsachsp.Columns[5].HeaderText = "Thành tiền";

        }


        private void LoadHang()
        {
            dgvdanhsachsp.DataSource = data.xemthongtinmathang(Convert.ToInt32(txtMahoadon.Text)); // LOAD MẶT HÀNG
            getheader();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data.xoabang();
            cbnguoilap.DataSource = data.Layranguoiquanli();
            cbnguoilap.DisplayMember = "TenNQL";
            cbnguoilap.ValueMember = "MaNQL";  // LẤY RA TÊN NHƯNG GIÁ TRỊ LÀ MÃ 
            cbnguoilap.SelectedValue = manql;
            cbmahang.DataSource = data.Layrasanpham();
            cbmahang.DisplayMember = "tensp";
            cbmahang.ValueMember = "masp"; // LẤY RA TÊN NHƯNG GIÁ TRỊ LÀ MÃ


            // XEM SIZE CÓ TRONG KHO
            cbbsize.DataSource = data.xemSizeCotrongkho(1);
            cbbsize.DisplayMember = "size";

            txtSLcon.Text = data.Layrasoluongcon(Convert.ToInt32(cbmahang.SelectedValue.ToString()), cbbsize.Text).Rows[0][0].ToString();


            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-0560TPMD\SQLEXPRESS;Initial Catalog=qlgiay;Integrated Security=True");
            con.Open(); // TẠO LIÊN KẾT
            DataTable dt = new DataTable();
            string sql = "Select giaban from sanpham where masp='" + cbmahang.SelectedValue + "' "; // CHỌN SẢN PHẨM
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            txttdongia.Text = dt.Rows[0][0].ToString(); // LẤY RA SỐ LƯỢNG CÒN



            txtdiachi.Text = diachi;// GÁN GIÁ TRỊ CỦA KHÁCH HÀNG
            txtsodienthoai.Text = dienthoai;//GÁN GIÁ TRỊ
            txthoten.Text = tenkh;// GÁN GIÁ TRỊ CỦA KHÁCH HÀNG

            stiencoc.Text = data.sotiencoc(dienthoai).Rows[0][0].ToString();

            m = 1;

        }
        private void cbmahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-0560TPMD\SQLEXPRESS;Initial Catalog=qlgiay;Integrated Security=True");
                con.Open();
                DataTable dt = new DataTable(); // Tự động lấy ra đơn giá
                string sql = "Select giaban from sanpham where masp='" + cbmahang.SelectedValue + "' ";
                SqlDataAdapter adap = new SqlDataAdapter(sql, con);
                adap.Fill(dt);
                txttdongia.Text = dt.Rows[0][0].ToString();
                con.Close();
                cbbsize.DataSource = data.xemSizeCotrongkho(Convert.ToInt32(cbmahang.SelectedValue.ToString()));
                txtSLcon.Text = data.Layrasoluongcon(Convert.ToInt32(cbmahang.SelectedValue.ToString()), cbbsize.Text).Rows[0][0].ToString();




                
            }
            catch (Exception)
            {


            }




        }
        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtthanhtien.Text = (int.Parse(txttdongia.Text) * int.Parse(txtsoluong.Text)).ToString(); // MỖI LẦN SẢN PHẨM THAY ĐỔI THÌ GIÁ CŨNG THAY ĐỔI THEO
            }
            catch (Exception)
            {

                txtthanhtien.Text = "Null";
            }
        }
        private void txttdongia_TextChanged(object sender, EventArgs e)
        {
            // TỰ ĐỘNG TÍNH THÀNH TIỀN
            txtthanhtien.Text = (int.Parse(txttdongia.Text) * int.Parse(txtsoluong.Text)).ToString();// MỖI LẦN SẢN PHẨM THAY ĐỔI THÌ GIÁ CŨNG THAY ĐỔI THEO
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void button_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn hủy hóa đơn này không ", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq.Equals(DialogResult.Yes))
            {
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //btn them
            if(string.IsNullOrWhiteSpace(txtsoluong.Text))
            {
                MessageBox.Show("Không được bỏ trống số lượng!!!");
            }    
           else if(Convert.ToInt32(txtsoluong.Text)==0)
            {
                MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0");
            }    
           else if(Convert.ToInt32(txtsoluong.Text) > Convert.ToInt32(txtSLcon.Text))
            {
                MessageBox.Show("Không còn đủ hàng để bán !!!");
            }    
           else
            {
                data.themchitiethoadonvaobannhap(Convert.ToInt32(cbmahang.SelectedValue.ToString()), cbmahang.Text, cbbsize.Text, Convert.ToInt32(txtsoluong.Text), Convert.ToInt32(txttdongia.Text), Convert.ToInt32(txtthanhtien.Text));
                dgvdanhsachsp.DataSource = data.loadsanphambanvuanhap();
                getheader();

                if(data.kiemtratrunghang==0)
                {
                    data.CapNhatSoLuongHangThemVao(Convert.ToInt16(cbmahang.SelectedValue.ToString()), cbbsize.Text, Convert.ToInt16(txtsoluong.Text));
                    txtSLcon.Text = data.Layrasoluongcon(Convert.ToInt32(cbmahang.SelectedValue.ToString()), cbbsize.Text).Rows[0][0].ToString();
                }


                int tongtien = 0;
                for (int i = 0; i < dgvdanhsachsp.Rows.Count; i++)
                {
                    tongtien = tongtien + Convert.ToInt32(dgvdanhsachsp.Rows[i].Cells[5].Value.ToString());
                }
                txtthanhtienn.Text = tongtien + "";
                lbltongtien.Text = tongtien - tongtien * (Convert.ToInt32(txtCk.Text) / 100 )- Convert.ToInt32(stiencoc.Text) +"";
            }    
           


        }
        int cell ; // KIỂM TRA CELL CLICK
        private void dgvdanhsachsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int d = e.RowIndex;
                cbmahang.Text = dgvdanhsachsp.Rows[d].Cells[1].Value.ToString();
                cbbsize.Text = dgvdanhsachsp.Rows[d].Cells[2].Value.ToString();
                txtsoluong.Text=dgvdanhsachsp.Rows[d].Cells[3].Value.ToString();
                cell = 1;

            }
            catch (Exception)
            {


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(cell==1)
            {
                data.xoasanphamrakhoihang(Convert.ToInt32(cbmahang.SelectedValue.ToString()), cbbsize.Text);
                dgvdanhsachsp.DataSource = data.loadsanphambanvuanhap();
                data.CapNhatSoLuongHangHangXoa(Convert.ToInt16(cbmahang.SelectedValue.ToString()), cbbsize.Text, Convert.ToInt16(txtsoluong.Text));
                txtSLcon.Text = data.Layrasoluongcon(Convert.ToInt32(cbmahang.SelectedValue.ToString()), cbbsize.Text).Rows[0][0].ToString();
                txtsoluong.Text = 0 + "";
                int tongtien = 0;
                for (int i = 0; i < dgvdanhsachsp.Rows.Count; i++)
                {
                    tongtien = tongtien+ Convert.ToInt32(dgvdanhsachsp.Rows[i].Cells[5].Value.ToString());
                }
                txtthanhtienn.Text = tongtien + "";
                lbltongtien.Text = tongtien - tongtien * (Convert.ToInt32(txtCk.Text) / 100) - Convert.ToInt32(stiencoc.Text) + "";
                cell = 0;
            }    
        }



        private void txtCk_TextChanged(object sender, EventArgs e)
        {
            int tongtien = 0;
            for (int i = 0; i < dgvdanhsachsp.Rows.Count; i++)
            {
                tongtien = tongtien + Convert.ToInt32(dgvdanhsachsp.Rows[i].Cells[5].Value.ToString());
            }
            txtthanhtienn.Text = tongtien + "";
            try
            {
                if (Convert.ToInt32(txtCk.Text) >= 100)
                {
                    txtCk.Text = "0";
                }
                lbltongtien.Text = tongtien - tongtien * (Convert.ToInt32(txtCk.Text)) / 100 + "";
            }
            catch (Exception)
            {

                txtCk.Text = "0";
            }
        }


        private void txtCk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void cbbsize_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmXuatHoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(kiemtrathanhtoanhoadon==0)
            {
                for (int i = 0; i < dgvdanhsachsp.Rows.Count; i++)
                {
                    int masp = Convert.ToInt32(dgvdanhsachsp.Rows[i].Cells[0].Value.ToString());
                    string size = dgvdanhsachsp.Rows[i].Cells[2].Value.ToString();
                    int slban = Convert.ToInt32(dgvdanhsachsp.Rows[i].Cells[3].Value.ToString());
                    data.CapNhatSoLuongHangHangXoa(masp, size, slban);
                }
            }    
        }

        private void txtthanhtien_TextChanged(object sender, EventArgs e)
        {
            
                
          
        }

        private void txtthanhtienn_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cbbsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m != 0)
            {
                txtSLcon.Text = data.Layrasoluongcon(Convert.ToInt32(cbmahang.SelectedValue.ToString()), cbbsize.Text).Rows[0][0].ToString();
            }
        }


        private void button7_Click(object sender, EventArgs e)

        {
            //thanh toán
            if(dgvdanhsachsp.Rows.Count==0)
            {
                MessageBox.Show("Chưa có sản phẩm nào!!!");
            }    
            else
            {
                DialogResult kq = MessageBox.Show("Vui lòng kiểm tra kĩ hóa đơn mọi thông tin sẽ không thay đổi được !!!", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(kq.Equals(DialogResult.Yes))
                {
                    kiemtrathanhtoanhoadon = 1;
                    data.themhoadonban(txtsodienthoai.Text, manql, dtpngay.Value, Convert.ToInt32(txtCk.Text));
                    txtMahoadon.Text = data.layRaSoHDBanvuaNhap().Rows[0][0].ToString();
                    for (int i = 0; i < dgvdanhsachsp.Rows.Count; i++)
                    {
                        data.themchitiethoadon(Convert.ToInt32(txtMahoadon.Text), Convert.ToInt32(dgvdanhsachsp.Rows[i].Cells[0].Value.ToString()), dgvdanhsachsp.Rows[i].Cells[2].Value.ToString(), Convert.ToInt32(dgvdanhsachsp.Rows[i].Cells[3].Value.ToString()), Convert.ToInt32(dgvdanhsachsp.Rows[i].Cells[4].Value.ToString()), Convert.ToInt32(dgvdanhsachsp.Rows[i].Cells[5].Value.ToString()));
                    }
                    frmXemChiTietHoaDon f = new frmXemChiTietHoaDon(Convert.ToInt32(txtMahoadon.Text));
                    f.Show();
                    this.Close();
                }    
            }    
        }   
    }

}



