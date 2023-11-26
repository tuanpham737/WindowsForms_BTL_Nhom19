using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_BTL_Nhom19
{
    public partial class FrmTimKiemLich : Form
    {
        public FrmTimKiemLich()
        {
            InitializeComponent();
        }

        private void FrmTimKiemLich_Load(object sender, EventArgs e)
        {
            Load_comboBox();
            ResetValues();
        }
        private void ResetValues()
        {
            cboRap.Text = ""; cboPhim.Text = "";
        }
        private void Load_comboBox()
        {
            ProcessDB.OpenConnection();             //Load cboMaRap tìm kiếm 
            cboRap.DataSource = ProcessDB.DocBangsql("SELECT MaRap, TenRap FROM tblRap"); 
            cboRap.ValueMember = "MaRap"; 
            cboRap.DisplayMember = "TenRap"; 
            cboRap.SelectedIndex = -1;

            //Load cboMaPhim tìm kiếm 
            cboPhim.DataSource = ProcessDB.DocBangsql("SELECT MaPhim, TenPhim FROM tblPhim"); 
            cboPhim.ValueMember = "MaPhim"; 
            cboPhim.DisplayMember = "TenPhim"; 
            cboPhim.SelectedIndex = -1;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (cboRap.Text == "")
            {
                MessageBox.Show("Chưa chọn mã rạp!", "Thông Báo", MessageBoxButtons.OK,
MessageBoxIcon.Information); return;
            }
            if (cboPhim.Text == "")
            {
                MessageBox.Show("Chưa chọn mã phim!", "Thông Báo", MessageBoxButtons.OK,
MessageBoxIcon.Information); return;
            }

            DataTable tbl;
            string sql = "SELECT * FROM tblLichChieu WHERE (MaRap =N'"
            + cboRap.SelectedValue + "' AND MaPhim= N'" + cboPhim.SelectedValue + "')"; tbl = ProcessDB.DocBangsql(sql); GridViewTimKiemLich.DataSource = tbl;
            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới 
            GridViewTimKiemLich.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới 
            GridViewTimKiemLich.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTimkiemrap_Click(object sender, EventArgs e)
        {
            if (cboRap.Text == "")
            {
                MessageBox.Show("Chưa chọn rạp!", "Thông Báo", MessageBoxButtons.OK,
MessageBoxIcon.Information); return;
            }
            DataTable tbl;
            string sql = "SELECT * FROM tblLichChieu WHERE (MaRap =N'" + cboRap.SelectedValue + "')";
            tbl = ProcessDB.DocBangsql(sql); GridViewTimKiemLich.DataSource = tbl;
            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới 
            GridViewTimKiemLich.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới 
            GridViewTimKiemLich.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void btnTimkiemphim_Click(object sender, EventArgs e)
        {
            if (cboPhim.Text == "")
            {
                MessageBox.Show("Chưa chọn tên phim!", "Thông Báo", MessageBoxButtons.OK,
MessageBoxIcon.Information); return;
            }

            DataTable tbl;
            string sql = "SELECT * FROM tblLichChieu WHERE (MaPhim= N'" + cboPhim.SelectedValue + "')";
            tbl = ProcessDB.DocBangsql(sql); GridViewTimKiemLich.DataSource = tbl;
            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới 
            GridViewTimKiemLich.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới 
            GridViewTimKiemLich.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
    }
}
