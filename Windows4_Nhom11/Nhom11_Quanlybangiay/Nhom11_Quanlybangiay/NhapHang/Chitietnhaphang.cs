using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Nhom11_Quanlybangiay.NhapHang
{
    public partial class frmChitietnhaphang : Form
    {
        private int sohdn;//SỬ DỤNG BIẾN ĐỂ LƯU DỮ LIỆU VÀ MỞ FORM KHÁC
        public frmChitietnhaphang(int sohdn)
        {
            InitializeComponent();
            this.sohdn = sohdn;
        }
        datanhaphang data = new datanhaphang();
        private void getheader()
        {
            //GET HEADER
            dgvdanhsach.Columns[0].HeaderText = "Mã sản phẩm";
            dgvdanhsach.Columns[1].HeaderText = "Tên sản phẩm";
            dgvdanhsach.Columns[2].HeaderText = "Size";
            dgvdanhsach.Columns[3].HeaderText = "Đơn giá nhập";
            dgvdanhsach.Columns[4].HeaderText = "Số lượng nhập";
            dgvdanhsach.Columns[5].HeaderText = "Thành tiền";
            dgvdanhsach.Columns[1].Width = 200;
            dgvdanhsach.Columns[2].Width = 130;
            dgvdanhsach.Columns[3].Width = 130;
            dgvdanhsach.Columns[4].Width = 130;
            dgvdanhsach.Columns[5].Width = 130;
        }
        private void frmChitietnhaphang_Load(object sender, EventArgs e)
        {

            txtSohdn.Text = sohdn + "";
            DataTable dt = data.xemchitietmothoadonhap(Convert.ToInt32(sohdn));
            //LƯU DỮ LIỆU VÀO BẢNG PROCEDURE

            DataTable dttt = data.xemtongtien(Convert.ToInt32(sohdn));
            dtpNgayNhap.Value = Convert.ToDateTime(dt.Rows[0][1].ToString());
            txtNguoilap.Text = dt.Rows[0][2].ToString();
            txtTenncc.Text = dt.Rows[0][3].ToString();
            txtdiachi.Text = dt.Rows[0][4].ToString();
            txtsdt.Text = dt.Rows[0][5].ToString();


            lblthanhtien.Text = dttt.Rows[0][0].ToString();//LẤY RA THÀNH TIỀN Ở PROCEDURE
            dgvdanhsach.DataSource = data.xemthongtinsanphamdanhap(Convert.ToInt32(sohdn));
            lblTK.Text = "Số lượng hàng đã nhập: " + dgvdanhsach.Rows.Count;
            getheader();
            int number = int.Parse(lblthanhtien.Text);

            lblthanhtien.Text = string.Format("{0:0,0}", number);

        }

        private void dgvdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String filename = "HDN" + txtSohdn.Text;
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

                // TẠO CHI TIẾT NHẬP HÀNG BAN ĐẦU
                Phrase phrase2 = new Phrase("Chi tiết nhập hàng", fontHearder);
                PdfPCell pdfPCell2 = new PdfPCell(phrase2);
                pdfPCell2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell2.Colspan = 3;
                pdfPCell2.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfPCell2.PaddingBottom = 25;
                pdfPCell2.PaddingLeft = 20;
                table.AddCell(pdfPCell2);


                // số hóa đơn
                Phrase phrase1 = new Phrase("Số HD: " + txtSohdn.Text, font);
                PdfPCell pdfPCell1 = new PdfPCell(phrase1);
                pdfPCell1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell1.Colspan = 1;
                pdfPCell1.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfPCell1.Padding = 10;
                table.AddCell(pdfPCell1);
                //tên
                Phrase phrase3 = new Phrase("Tên nhà cung cấp: " + txtTenncc.Text, font);
                PdfPCell pdfPCell3 = new PdfPCell(phrase3);
                pdfPCell3.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell3.Colspan = 2;
                pdfPCell3.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfPCell3.Padding = 10;
                table.AddCell(pdfPCell3);


                //Ngày lập
                Phrase phrase4 = new Phrase("Ngày lập: " + dtpNgayNhap.Text, font);
                PdfPCell pdfPCell4 = new PdfPCell(phrase4);
                pdfPCell4.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell4.Colspan = 1;
                pdfPCell4.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfPCell4.Padding = 10;
                table.AddCell(pdfPCell4);

                // địa chỉ
                Phrase phrase5 = new Phrase("Địa chỉ: " + txtdiachi.Text, font);
                PdfPCell pdfPCell5 = new PdfPCell(phrase5);
                pdfPCell5.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell5.Colspan = 2;
                pdfPCell5.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfPCell5.Padding = 10;
                table.AddCell(pdfPCell5);
                //người lập
                Phrase phrase6 = new Phrase("Người lập: " + txtNguoilap.Text, font);
                PdfPCell pdfPCell6 = new PdfPCell(phrase6);
                pdfPCell6.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell6.Colspan = 1;
                pdfPCell6.Padding = 10;
                pdfPCell6.HorizontalAlignment = Element.ALIGN_LEFT;
                table.AddCell(pdfPCell6);
                //SĐT

                Phrase phrase7 = new Phrase("Số điện thoại: " + txtsdt.Text, font);
                PdfPCell pdfPCell7 = new PdfPCell(phrase7);
                pdfPCell7.Border = iTextSharp.text.Rectangle.NO_BORDER;
                pdfPCell7.Colspan = 2;
                pdfPCell7.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfPCell7.Padding = 10;
                table.AddCell(pdfPCell7);


                //table Sản phẩm
                PdfPTable tableProduct = new PdfPTable(dgvdanhsach.ColumnCount);
                tableProduct.DefaultCell.PaddingBottom = 10;
                tableProduct.DefaultCell.PaddingTop = 10;
                tableProduct.WidthPercentage = 90;
                tableProduct.HorizontalAlignment = Element.ALIGN_LEFT;
                tableProduct.DefaultCell.BorderWidth = 1;

                //add headertext
                foreach (DataGridViewColumn column in dgvdanhsach.Columns)
                {
                    PdfPCell pdfPCell = new PdfPCell(new Phrase(column.HeaderText, fontBold));
                    pdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfPCell.PaddingBottom = 2;
                    tableProduct.AddCell(pdfPCell);
                }

                // add cell
                foreach (DataGridViewRow row in dgvdanhsach.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        PdfPCell pdfPCell = new PdfPCell(new Phrase(cell.Value.ToString(), font));
                        pdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfPCell.PaddingBottom = 2;
                        tableProduct.AddCell(pdfPCell);
                    }
                }


                //Paragraph parablank = new Paragraph(" ", font);
                //tổng tiền aaaaaa
                //Phrase phrase8 = new Phrase("Tổng tiền: " + lblthanhtien.Text, font);
                //PdfPCell pdfPCell8 = new PdfPCell(phrase8);
                //pdfPCell8.Border = iTextSharp.text.Rectangle.NO_BORDER;
                //pdfPCell8.Colspan = 3;
                //pdfPCell8.HorizontalAlignment = Element.ALIGN_LEFT;
                //pdfPCell8.Padding = 10;

                Paragraph para = new Paragraph("Tổng tiền: " + lblthanhtien.Text, font);
                para.Alignment = Element.ALIGN_LEFT;
                //Blank
                Paragraph parablank = new Paragraph(" ", font);





                document.Add(table);
                document.Add(parablank);
                document.Add(tableProduct);
                document.Add(parablank);
                document.Add(para);

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

        private void dgvdanhsach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}
