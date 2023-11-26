using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace WindowsForms_BTL_Nhom19
{
    public partial class InDoanhThuPhim : Form
    {
        public InDoanhThuPhim()
        {
            InitializeComponent();
        }

        private void InDoanhThuPhim_Load(object sender, EventArgs e)
        {
            ProcessDB.OpenConnection();
            DataTable tb = ProcessDB.DocBangsql("SELECT MaPhim, TenPhim FROM tblPhim");
            cboPhim.DataSource = tb;
            cboPhim.DisplayMember = "TenPhim";
            cboPhim.ValueMember = "MaPhim";
            ProcessDB.CloseConnection();

        }

        private void btnInDTP_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook 
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet 
            COMExcel.Range exRange; string sql;
            DataTable tblPhim, sove;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet); exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];            
            exRange.Range["A1:B3"].Font.Size = 10; 
            exRange.Range["A1:B3"].Font.Name = "Times new roman"; exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời 
            exRange.Range["A1:A1"].ColumnWidth = 7; exRange.Range["B1:B1"].ColumnWidth = 15; exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter; exRange.Range["A1:B1"].Value = "Nguyễn Thắng"; exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter; exRange.Range["A2:B2"].Value = "Hệ thống Rạp chiếu toàn quốc"; exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter; exRange.Range["A3:B3"].Value = "Hotline: 19006996"; exRange.Range["C2:H2"].Font.Size = 16;
            exRange.Range["C2:H2"].Font.Name = "Times new roman"; 
            exRange.Range["C2:H2"].Font.Bold = true; 
            exRange.Range["C2:H2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:H2"].MergeCells = true; 
            exRange.Range["C2:H2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter; exRange.Range["C2:H2"].Value = "BÁO CÁO DOANH THU PHIM";
            sql = "SELECT MaPhim, TenPhim, NgayKhoiChieu, NgayKetThuc, TongThu FROM tblPhim  WHERE MaPhim = N'" + cboPhim.SelectedValue.ToString() + "'"; 


            tblPhim = ProcessDB.DocBangsql(sql); exRange.Range["B6:C11"].Font.Size = 12;
            exRange.Range["B6:C11"].Font.Name = "Times new roman"; exRange.Range["B6:B6"].Value = "Mã phim:"; exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblPhim.Rows[0][0].ToString(); exRange.Range["B7:B7"].Value = "Tên phim:"; exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblPhim.Rows[0][1].ToString(); exRange.Range["B8:B8"].Value = "Ngày khởi chiếu:"; exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblPhim.Rows[0][2].ToString(); exRange.Range["B9:B9"].Value = "Ngày kết thúc:"; exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblPhim.Rows[0][3].ToString(); exRange.Range["B11:B11"].Value = "Doanh thu:"; exRange.Range["C11:E11"].MergeCells = true;
            exRange.Range["C11:E11"].Value = tblPhim.Rows[0][4].ToString();
            sql = "SELECT SUM(SoVeDaBan) from tblLichChieu where MaPhim = N'" + cboPhim.SelectedValue.ToString() + "'"; sove = ProcessDB.DocBangsql(sql);
            exRange.Range["B10:B10"].Value = "Số vé đã bán:"; exRange.Range["C10:E10"].MergeCells = true;
            exRange.Range["C10:E10"].Value = sove.Rows[0][0].ToString(); exApp.Visible = true;

        }
    }
}
