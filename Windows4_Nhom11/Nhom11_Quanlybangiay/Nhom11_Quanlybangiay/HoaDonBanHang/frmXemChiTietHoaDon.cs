using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text;// THƯ VIỆN LƯU FILE PDF
using iTextSharp.text.pdf;// THƯ VIỆN LƯU FILE PDF
using System.IO;// THƯ VIỆN LƯU FILE PDF

namespace Nhom11_Quanlybangiay.HoaDonBanHang
{
    public partial class frmXemChiTietHoaDon : Form
    {
        int sohdd;
        public frmXemChiTietHoaDon(int sohd)
        {
            InitializeComponent();
            this.sohdd = sohd; // TRUYỀN DỮ LIỆU ĐỂ XEM CHI TIẾT
        }
        dataChiTietHoaDonBan data = new dataChiTietHoaDonBan();
        private void Xemchitiethoadon_Load(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-0560TPMD\SQLEXPRESS;Initial Catalog=qlgiay;Integrated Security=True");
            con.Open(); // MỞ KẾT NỐI
            DataTable dt = new DataTable();
            String sql = "exec xemchitietdanhsachdonhang'" + sohdd + "'";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            dgvChiTietHoaDonBan.DataSource = data.xemthongtinmathang(Convert.ToInt32(sohdd));

            adap.Fill(dt);
            // LƯU THÔNG TIN VÀO BẢNG DỰA VÀO TRIIGER


            // LẤY THÔNG TIN Ở BẢNG RA ĐỂ XEM
            txthd.Text = sohdd + "";
            try
            {
                dtpngay.Value = Convert.ToDateTime(dt.Rows[0][1].ToString());
                txtnl.Text = dt.Rows[0][2].ToString();
                txtTen.Text = dt.Rows[0][3].ToString();
                txtdiachi.Text = dt.Rows[0][4].ToString();
                txtsdt.Text = dt.Rows[0][5].ToString();
                txtCk.Text = dt.Rows[0][6].ToString();
                txtTongTien.Text = dt.Rows[0][7].ToString();



                lbltongtien.Text = Convert.ToInt32(txtTongTien.Text) - (int)(Convert.ToInt32(txtTongTien.Text) * Convert.ToInt32(txtCk.Text) / 100) + "";
                lblTK.Text = "Số lượng hàng đã mua: " + dgvChiTietHoaDonBan.Rows.Count;

                int number = int.Parse(txtTongTien.Text);
                txtTongTien.Text = string.Format("{0:0,0}", number);
                number = int.Parse(lbltongtien.Text);
                lbltongtien.Text = string.Format("{0:0,0}", number);
            }
            catch (Exception)
            {


                txtnl.Text = "NULL";
                txtTen.Text = "NULL";
                txtdiachi.Text = "NULL";
                txtsdt.Text = "NULL";
                txtCk.Text = "NULL";
                txtTongTien.Text = "NULL";
            }


            con.Close();
            getheader();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void getheader() // lấy ra thông tin header
        {
            dgvChiTietHoaDonBan.Columns[0].HeaderText = "Mã";
            dgvChiTietHoaDonBan.Columns[1].HeaderText = "Tên";
            dgvChiTietHoaDonBan.Columns[1].Width = 200;
            dgvChiTietHoaDonBan.Columns[2].HeaderText = "Size";
            dgvChiTietHoaDonBan.Columns[3].HeaderText = "Số lượng";
            dgvChiTietHoaDonBan.Columns[3].Width = 120;

            dgvChiTietHoaDonBan.Columns[4].HeaderText = "Giá";
            dgvChiTietHoaDonBan.Columns[4].Width = 120;
            dgvChiTietHoaDonBan.Columns[5].HeaderText = "Thành tiền";
            dgvChiTietHoaDonBan.Columns[5].Width = 120;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            String filename = "HD" + txthd.Text;
            var savefile = new SaveFileDialog();
            savefile.FileName = filename;
            savefile.DefaultExt = ".pdf";
            if (savefile.ShowDialog() == DialogResult.OK)
            { // set up để thêm dữ liệu
                Document document = new Document(PageSize.A4, 10f, 20f, 20f, 20f);
                Stream stream = new FileStream(savefile.FileName, FileMode.Create);
                PdfWriter.GetInstance(document, stream);
                document.Open();

                PdfPTable table = new PdfPTable(3);
                float[] columnsWidth = { 1, 1, 1 };
                table.SetWidths(columnsWidth);
                table.DefaultCell.BorderWidth = 0;
                table.DefaultCell.Padding = 10;
                table.WidthPercentage = 100;
                table.HorizontalAlignment = Element.ALIGN_CENTER;
                // font chữ
                string path = Path.Combine(Path.GetFullPath(@"..\..\"), "Resources") + @"\font.ttf";
                BaseFont baseFont = BaseFont.CreateFont(path, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                //  Font font = new Font("Times New Roman", 12.0f);
                //BaseFont baseFont = BaseFont.CreateFont(BaseFont.TIMES_BOLD, BaseFont.CP1252, BaseFont.EMBEDDED);

                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font fontHearder = new iTextSharp.text.Font(baseFont, 15, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font fontBold = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font font8 = new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.NORMAL);


                Phrase phrase2 = new Phrase("Chi tiết hóa đơn", fontHearder);
                PdfPCell pdfPCell2 = new PdfPCell(phrase2);
                pdfPCell2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell2.Colspan = 3;
                pdfPCell2.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfPCell2.PaddingBottom = 25;
                pdfPCell2.PaddingLeft = 20;
                table.AddCell(pdfPCell2);


                // số hóa đơn
                Phrase phrase1 = new Phrase("Số HD: " + txthd.Text, font);
                PdfPCell pdfPCell1 = new PdfPCell(phrase1);
                pdfPCell1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell1.Colspan = 1;
                pdfPCell1.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfPCell1.Padding = 10;
                table.AddCell(pdfPCell1);
                //tên
                Phrase phrase3 = new Phrase("Tên khách hàng: " + txtTen.Text, font);
                PdfPCell pdfPCell3 = new PdfPCell(phrase3);
                pdfPCell3.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell3.Colspan = 1;
                pdfPCell3.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfPCell3.Padding = 10;
                table.AddCell(pdfPCell3);


                //Tổng tiền
                Phrase phrase4 = new Phrase("Tổng tiền: " + txtTongTien.Text, font);
                PdfPCell pdfPCell4 = new PdfPCell(phrase4);
                pdfPCell4.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell4.Colspan = 1;
                pdfPCell4.HorizontalAlignment = Element.ALIGN_RIGHT;
                pdfPCell4.Padding = 10;
                table.AddCell(pdfPCell4);

                // ngày lập
                Phrase phrase5 = new Phrase("\nNgày lập: " + dtpngay.Text, font);
                PdfPCell pdfPCell5 = new PdfPCell(phrase5);
                pdfPCell5.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell5.Colspan = 1;
                pdfPCell5.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfPCell5.Padding = 10;
                table.AddCell(pdfPCell5);
                //địa chỉ
                Phrase phrase6 = new Phrase("Địa chỉ: " + txtdiachi.Text, font);
                PdfPCell pdfPCell6 = new PdfPCell(phrase6);
                pdfPCell6.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell6.Colspan = 1;
                pdfPCell6.Padding = 10;
                pdfPCell6.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(pdfPCell6);
                //chiết khấu

                Phrase phrase7 = new Phrase("Chiết khấu: " + txtCk.Text, font);
                PdfPCell pdfPCell7 = new PdfPCell(phrase7);
                pdfPCell7.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell7.Colspan = 1;
                pdfPCell7.HorizontalAlignment = Element.ALIGN_RIGHT;
                pdfPCell7.Padding = 10;
                table.AddCell(pdfPCell7);
                //người lập

                Phrase phrase8 = new Phrase("Người lập: " + txtnl.Text, font);
                PdfPCell pdfPCell8 = new PdfPCell(phrase8);
                pdfPCell8.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell8.Colspan = 1;
                pdfPCell8.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfPCell8.Padding = 10;
                table.AddCell(pdfPCell8);
                //sđt

                Phrase phrase9 = new Phrase("SĐT: " + txtsdt.Text, font);
                PdfPCell pdfPCell9 = new PdfPCell(phrase9);
                pdfPCell9.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell9.Colspan = 1;
                pdfPCell9.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfPCell9.Padding = 10;
                table.AddCell(pdfPCell9);
                //thành tiền

                Phrase phrase10 = new Phrase("Thành tiền" +
                    ": " + lbltongtien.Text, font);
                PdfPCell pdfPCell10 = new PdfPCell(phrase10);
                pdfPCell10.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell10.Colspan = 1;
                pdfPCell10.HorizontalAlignment = Element.ALIGN_RIGHT;
                pdfPCell10.Padding = 10;
                table.AddCell(pdfPCell10);
                //table Sản phẩm
                PdfPTable tableProduct = new PdfPTable(dgvChiTietHoaDonBan.ColumnCount);
                tableProduct.DefaultCell.PaddingBottom = 10;
                tableProduct.DefaultCell.PaddingTop = 10;
                tableProduct.WidthPercentage = 90;
                tableProduct.HorizontalAlignment = Element.ALIGN_CENTER;
                tableProduct.DefaultCell.BorderWidth = 1;

                //add headertext
                foreach (DataGridViewColumn column in dgvChiTietHoaDonBan.Columns)
                {
                    PdfPCell pdfPCell = new PdfPCell(new Phrase(column.HeaderText, fontBold));
                    pdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfPCell.PaddingBottom = 2;
                    tableProduct.AddCell(pdfPCell);
                }

                // add cell
                foreach (DataGridViewRow row in dgvChiTietHoaDonBan.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        PdfPCell pdfPCell = new PdfPCell(new Phrase(cell.Value.ToString(), font));
                        pdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfPCell.PaddingBottom = 2;
                        tableProduct.AddCell(pdfPCell);
                    }
                }

                Paragraph parablank = new Paragraph(" ", font);

                document.Add(table);
                document.Add(parablank);
                document.Add(tableProduct);
                document.Add(parablank);

                document.Close();
                stream.Close();
                MessageBox.Show("In hóa đơn thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                try
                {
                    System.Diagnostics.Process.Start("explorer.exe", savefile.FileName); // XML NHẬP
                }
                catch (Exception)
                {
                    System.Diagnostics.Process.Start("msedge.exe", savefile.FileName);

                }


            }
        }

        private void lblTK_Click(object sender, EventArgs e)
        {

        }
    }
}
