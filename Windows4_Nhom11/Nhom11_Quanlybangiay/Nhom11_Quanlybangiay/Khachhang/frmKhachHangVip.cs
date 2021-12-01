using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom11_Quanlybangiay.Khachhang
{
    public partial class frmKhachHangVip : Form
    {
        public frmKhachHangVip()
        {
            InitializeComponent();
        }
        dataKhachHang data = new dataKhachHang(); // khai báo data khách hàng
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void getheader()// LẤY RA HEADER
        {
            dgvVip.Columns[0].HeaderText = "Số điện thoại";
            dgvVip.Columns[0].Width = 100;
            dgvVip.Columns[1].HeaderText = "Tên khách hàng";
            dgvVip.Columns[1].Width = 250;
            dgvVip.Columns[2].HeaderText = "Tổng tiền chi";
        }
        private void frmKhachHangVip_Load(object sender, EventArgs e)
        {
            try
            {
                dgvVip.DataSource = data.xemkhVip();// LẤY RA THÔNG TIN CỦA KH VIP
                if(data.xemkhVip().Rows.Count==0)
                {
                    MessageBox.Show("Chưa có ai mua hàng!!!");
                }    
                else
                {
                    txtSdt.Text = data.xemkhVip().Rows[0][0].ToString();// LẤY RA SĐT
                    txtTen.Text = data.xemkhVip().Rows[0][1].ToString();  //LẤY RA TÊN
                    getheader();
                }    
                  
                
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa có khách hàng nào");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
