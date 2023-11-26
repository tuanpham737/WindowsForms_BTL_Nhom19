using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace WindowsForms_BTL_Nhom19
{
    public partial class InPhimDangChieu : Form
    {
        public InPhimDangChieu()
        {
            InitializeComponent();
        }

        private void InPhimDangChieu_Load(object sender, EventArgs e)
        {
            ProcessDB.OpenConnection();
            LoadDataToGridView();
            ProcessDB.CloseConnection();

        }
        private void LoadDataToGridView()
        {
            string sql = "select MaPhim, TenPhim, DaoDien, TenTheLoai, NgayKhoiChieu, NgayKetThuc from tblPhim inner join tblTheLoai on tblPhim.MaTheLoai = tblTheLoai.MaTheLoai where NgayKetThuc > getdate() and NgayKhoiChieu < getdate()";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, ProcessDB.conn);
            DataTable tblPhimDC = new DataTable(); adapter.Fill(tblPhimDC);
            dataGridView1.DataSource = tblPhimDC;
        }

        private void btnInDTR_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook 
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet 
            COMExcel.Range exRange; int hang = 0, cot = 0;
            string sql = "select * from tblPhim where NgayKetThuc > getdate() and NgayKhoiChieu < getdate()"; 
            SqlDataAdapter adapter = new SqlDataAdapter(sql, ProcessDB.conn); DataTable tblPhimDC = new DataTable();
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet); exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];             
            exRange.Range["A1:B3"].Font.Size = 10; 
            exRange.Range["A1:B3"].Font.Name = "Times new roman"; exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời 
            exRange.Range["A1:A1"].ColumnWidth = 7; exRange.Range["B1:B1"].ColumnWidth = 15; exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter; exRange.Range["A1:B1"].Value = "Tập đoàn Nguyễn Thắng"; exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter; exRange.Range["A2:B2"].Value = "Hệ thống Rạp chiếu toàn quốc"; exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter; exRange.Range["A3:B3"].Value = "Hotline: 19008668"; exRange.Range["C2:H2"].Font.Size = 16;
            exRange.Range["C2:H2"].Font.Name = "Times new roman"; exRange.Range["C2:H2"].Font.Bold = true; exRange.Range["C2:H2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:H2"].MergeCells = true; 
            exRange.Range["C2:H2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter; exRange.Range["C2:H2"].Value = "DANH SÁCH PHIM ĐANG CHIẾU";

            tblPhimDC = ProcessDB.DocBangsql(sql); exRange.Range["A6:G6"].Font.Bold = true;
            exRange.Range["A6:G6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter; exRange.Range["C6:G6"].ColumnWidth = 15; exRange.Range["A6:A6"].Value = "STT"; exRange.Range["B6:B6"].Value = "Mã phim"; exRange.Range["C6:C6"].Value = "Tên phim"; exRange.Range["D6:D6"].Value = "Đạo diễn"; exRange.Range["E6:E6"].Value = "Tên thể loại"; exRange.Range["F6:F6"].Value = "Ngày khởi chiếu"; exRange.Range["G6:G6"].Value = "Ngày kết thúc";

            for (hang = 0; hang <= tblPhimDC.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 7
                exSheet.Cells[1][hang + 7] = hang + 1; 
                for (cot = 0; cot <= tblPhimDC.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 7 
                    exSheet.Cells[cot + 2][hang + 7] = tblPhimDC.Rows[hang][cot].ToString();
            }
            exApp.Visible = true;
        }
    }
}
