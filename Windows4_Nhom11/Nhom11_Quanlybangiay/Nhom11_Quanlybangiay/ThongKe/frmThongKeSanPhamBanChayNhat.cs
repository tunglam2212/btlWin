using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom11_Quanlybangiay.ThongKe
{
    public partial class frmThongKeSanPhamBanChayNhat : Form
    {
        public frmThongKeSanPhamBanChayNhat()
        {
            InitializeComponent();
        }
        dataThongKe data = new dataThongKe();
        private void getheader() // THAY ĐỔI TÊN CỘT
        {
            dgvTopSanPham.Columns[0].HeaderText = "Mã sản phẩm";
            dgvTopSanPham.Columns[1].HeaderText = "Tên sản phẩm";
            dgvTopSanPham.Columns[1].Width = 200;
            dgvTopSanPham.Columns[2].HeaderText = "Số lượng đã bán";
        }
        private void frmThongKeSanPhamBanChayNhat_Load(object sender, EventArgs e)
        {
            dgvTopSanPham.DataSource = data.sanPhamBanChay();
            getheader();
            try
            {
                if(dgvTopSanPham.Rows[0].Cells[1].Value==null)
                {
                    txtsanpham.Text = "NULL";
                }    
                else
                {
                    txtsanpham.Text = dgvTopSanPham.Rows[0].Cells[1].Value.ToString();
                }    
                
            }
            catch (Exception)
            {

                txtsanpham.Text = "NULL";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
