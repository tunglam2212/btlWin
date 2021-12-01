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
    public partial class frmNguoiThuTien : Form
    {
        dataThongKe data = new dataThongKe();
        public frmNguoiThuTien()
        {
            InitializeComponent();
        }
        private void getheader()
        {
            
            dgvTK.Columns[0].HeaderText = "Mã ";


            dgvTK.Columns[1].HeaderText = "Tên người bán";
            dgvTK.Columns[1].Width = 250;

            dgvTK.Columns[2].HeaderText = "Tình trạng";
            dgvTK.Columns[0].Width = 80;

            dgvTK.Columns[3].HeaderText = "Tiền bán được";
            dgvTK.Columns[3].Width = 150;

            
        }
        private void frmNguoiThuDuocTienNhieuNhat_Load(object sender, EventArgs e)
        {
            
            

            if(dgvTK.Rows.Count==0)
            {

            }    
            else
            {
                dgvTK.Columns[0].HeaderText = "Mã ";


                dgvTK.Columns[1].HeaderText = "Tên người bán";
                dgvTK.Columns[1].Width = 250;

                dgvTK.Columns[2].HeaderText = "Tình trạng";
                dgvTK.Columns[0].Width = 80;

                dgvTK.Columns[3].HeaderText = "Tiền bán được";
                dgvTK.Columns[3].Width = 150;

                
            }    
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(dtp1.Value);
            string b = Convert.ToString(dtp2.Value);
            if (a == b)
            {
                MessageBox.Show("Không được trùng ngày, ngày sau phải lớn hơn ngày trước ít nhất một ngày!!!");
            }
            else if (dtp1.Value >= dtp2.Value)
            {
                MessageBox.Show("Ngày sau phải lớn hơn ngày trước ít nhất một ngày!!!");
            }
            else
            {
                dgvTK.DataSource = data.NguoiThuTienNhieuNhat(dtp1.Value, dtp2.Value);
                getheader();
                if(dgvTK.Rows.Count!=0)
                {
                    txtMa.Text = dgvTK.Rows[0].Cells[0].Value.ToString();
                    txtTen.Text = dgvTK.Rows[0].Cells[1].Value.ToString();
                }    
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();//THOÁT
        }

        private void dgvTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
