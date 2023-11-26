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
    public partial class InDoanhThuRap : Form
    {
        public InDoanhThuRap()
        {
            InitializeComponent();
        }

        private void InDoanhThuRap_Load(object sender, EventArgs e)
        {
            ProcessDB.OpenConnection();
            DataTable tb= ProcessDB.DocBangsql("SELECT MaRap, TenRap FROM tblRap");
            cboRap.DataSource = tb;
            cboRap.DisplayMember = "TenRap";
            cboRap.ValueMember = "MaRap";
            ProcessDB.CloseConnection();

        }

        private void btnInDTR_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook 
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet 
            COMExcel.Range exRange; string sql;
            DataTable tblRap, sove;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet); exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];             
            exRange.Range["A1:B3"].Font.Size = 10; 
            exRange.Range["A1:B3"].Font.Name = "Times new roman"; exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời 
            exRange.Range["A1:A1"].ColumnWidth = 7; exRange.Range["B1:B1"].ColumnWidth = 15; exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter; exRange.Range["A1:B1"].Value = "Tập đoàn Nguyễn Thắng";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter; exRange.Range["A2:B2"].Value = "Hệ thống Rạp chiếu toàn quốc";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter; exRange.Range["A3:B3"].Value = "Hotline: 19008668"; exRange.Range["C2:H2"].Font.Size = 16;
            exRange.Range["C2:H2"].Font.Name = "Times new roman"; 
            exRange.Range["C2:H2"].Font.Bold = true; 
            exRange.Range["C2:H2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:H2"].MergeCells = true; 
            exRange.Range["C2:H2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter; 
            exRange.Range["C2:H2"].Value = "BÁO CÁO DOANH THU RẠP";
            sql = "SELECT MaRap, TenRap, DiaChi, DienThoai FROM tblRap  WHERE MaRap = N'" + cboRap.SelectedValue.ToString() + "'";

            tblRap = ProcessDB.DocBangsql(sql); exRange.Range["B6:C11"].Font.Size = 12;
            exRange.Range["B6:C11"].Font.Name = "Times new roman"; exRange.Range["B6:B6"].Value = "Mã rạp:"; exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblRap.Rows[0][0].ToString(); exRange.Range["B7:B7"].Value = "Tên rạp:"; exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblRap.Rows[0][1].ToString(); exRange.Range["B8:B8"].Value = "Địa chỉ:"; exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblRap.Rows[0][2].ToString(); exRange.Range["B9:B9"].Value = "Điện thoại:"; exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblRap.Rows[0][3].ToString(); sql = "SELECT SUM(TongTien) from tblLichChieu where MaRap = N'" + cboRap.SelectedValue.ToString() + "'"; sove = ProcessDB.DocBangsql(sql);
            exRange.Range["B10:B10"].Value = "Doanh thu:"; exRange.Range["C10:E10"].MergeCells = true;
            exRange.Range["C10:E10"].Value = sove.Rows[0][0].ToString(); exApp.Visible = true;
        }
    }
}
