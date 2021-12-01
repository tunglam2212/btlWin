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
using Nhom11_Quanlybangiay.ThemSanPham;

namespace Nhom11_Quanlybangiay.SanPham
{
    public partial class frmSanPhamVoiNhanVien : Form
    {
        public frmSanPhamVoiNhanVien()
        {
            InitializeComponent();
        }
        dataSanPham data = new dataSanPham();
        private void dgvsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int d = e.RowIndex;
                txtMaSP.Text = dgvsanpham.Rows[d].Cells[0].Value.ToString(); ;
                txtTenSP.Text = dgvsanpham.Rows[d].Cells[1].Value.ToString();
                txtGiaBan.Text = dgvsanpham.Rows[d].Cells[2].Value.ToString();
                txtMaSP.Enabled = false;
                

                dgvSoLuong.DataSource = data.LayRaSizeVaSoLuong(Convert.ToInt32(dgvsanpham.Rows[d].Cells[0].Value.ToString()));
                getheadersize();
            }
            catch (Exception)
            {
                //TRƯỜNG HỢP D=-1;

            }
        }
        private void getheader()
        {
            //LẤY RA HEADER
            dgvsanpham.Columns[0].HeaderText = "Mã sản phẩm";
            dgvsanpham.Columns[1].HeaderText = "Tên sản phẩm";
            dgvsanpham.Columns[1].Width = 250;
            dgvsanpham.Columns[2].HeaderText = "Giá bán";
            dgvsanpham.Columns[3].HeaderText = "Nhập";

        }
        private void getheadersize()
        {
            dgvSoLuong.Columns[0].HeaderText = "Tên sản phẩm";
            dgvSoLuong.Columns[0].Width = 150;
            dgvSoLuong.Columns[1].HeaderText = "Size"; ;
            dgvSoLuong.Columns[2].HeaderText = "Số lượng còn";
            
        }
        private void frmSanPhamVoiNhanVien_Load(object sender, EventArgs e)
        {
            dgvsanpham.DataSource = data.Xemtatsanpham();
            getheader();
            lblTK.Text = "Số lượng sản phẩm: " + dgvsanpham.Rows.Count;
        }
        private void clear()
        {
            //BTN CLEAR
            txtMaSP.Enabled = true;
            txtTimmaSP.Enabled = true;
            txtTimTenSP.Enabled = true;
            txtMaSP.Clear();
            txtTenSP.Clear();

            txtTimmaSP.Clear();
            txtTimTenSP.Clear();
            txtGiaBan.Clear();

        }
        private void btnTim_Click(object sender, EventArgs e)
        {

            //BTN TIM
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-0560TPMD\SQLEXPRESS;Initial Catalog=qlgiay;Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            string masp = txtTimmaSP.Text;
            string tensp = txtTimTenSP.Text;
            string sql = "Select * from Sanpham where masp='" + masp + "'  ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            dgvsanpham.DataSource = dt;
            con.Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvsanpham.DataSource = data.Xemtatsanpham();
            clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimmaSP_Click(object sender, EventArgs e)
        {
            txtTimTenSP.Enabled = false;
        }

        private void txtTimTenSP_Click(object sender, EventArgs e)
        {
            txtTimmaSP.Enabled = false;
        }

        private void dgvsanpham_Click(object sender, EventArgs e)
        {
          
        }

        private void dgvSoLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-0560TPMD\SQLEXPRESS;Initial Catalog=qlgiay;Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            string masp = txtTimmaSP.Text;
            string tensp = txtTimTenSP.Text;
            string sql = "Select * from Sanpham where  tensp like '%'+N'" + tensp + "'+'%'  ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            dgvsanpham.DataSource = dt;
            con.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtTimTenSP_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-0560TPMD\SQLEXPRESS;Initial Catalog=qlgiay;Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            string masp = txtTimmaSP.Text;
            string tensp = txtTimTenSP.Text;
            string sql = "Select * from Sanpham where  tensp like '%'+N'" + tensp + "'+'%'  ";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            dgvsanpham.DataSource = dt;
            con.Close();
        }
    }
}
