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
    public partial class FrmTimKiemPhim : Form
    {
        ProcessDB db = new ProcessDB();
        public FrmTimKiemPhim()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
 
        private void FrmTimKiemPhim_Load(object sender, EventArgs e)
        {
            Load_comboBox();
            ResetValues();

        }
        private void ResetValues()
        {
            cboTheLoai.Text = ""; cboHangSX.Text = "";
        }
        private void Load_comboBox()
        {
            ProcessDB.OpenConnection();
            //Load cboTheLoai tìm kiếm 
            cboTheLoai.DataSource = ProcessDB.DocBangsql("SELECT MaTheLoai, TenTheLoai FROM tblTheLoai");
            cboTheLoai.ValueMember = "MaTheLoai"; cboTheLoai.DisplayMember = "TenTheLoai"; cboTheLoai.SelectedIndex = -1;

            //Load cboMaHangSX tìm kiếm 
            cboHangSX.DataSource = ProcessDB.DocBangsql("SELECT MaHangSX, TenHangSX FROM tblHangSX");
            cboHangSX.ValueMember = "MaHangSX"; cboHangSX.DisplayMember = "TenHangSX"; cboHangSX.SelectedIndex = -1;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (txtTenphim.Text == "")
            {
                MessageBox.Show("Hãy chọn tên Phim cần tìm!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboTheLoai.Text == "")
            {
                MessageBox.Show("Hãy chọn tên thể loại cần tìm!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboHangSX.Text == "")
            {
                MessageBox.Show("Hãy chọn tên hãng sản xuất cần tìm!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DataTable tbl;
                string sql = "SELECT * FROM tblPhim WHERE TenPhim LIKE '%" + txtTenphim.Text.Trim() + "%' AND MaTheLoai= N'" + cboTheLoai.SelectedValue + "' AND MaHangSX = N'" + cboHangSX.SelectedValue + "'";

                tbl = ProcessDB.DocBangsql(sql);
                GridViewTimKiemPhim.DataSource = tbl;
                GridViewTimKiemPhim.AllowUserToAddRows = false;
                GridViewTimKiemPhim.EditMode = DataGridViewEditMode.EditProgrammatically;
            }

        }

        private void btnTimkiemphim_Click(object sender, EventArgs e)
        {
            if (txtTenphim.Text == "")
            {
                MessageBox.Show("Hãy chọn tên Phim cần tìm!", "Thông Báo",
MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            else
            {
                DataTable tbl;
                string sql = "SELECT * FROM tblPhim WHERE TenPhim LIKE '%" + txtTenphim.Text.Trim() + "%'";
                tbl = ProcessDB.DocBangsql(sql); GridViewTimKiemPhim.DataSource = tbl;
                GridViewTimKiemPhim.AllowUserToAddRows = false;
                GridViewTimKiemPhim.EditMode = DataGridViewEditMode.EditProgrammatically;
            }

        }

        private void btnTimkiemtheloai_Click(object sender, EventArgs e)
        {
            if (cboTheLoai.Text == "")
            {
                MessageBox.Show("Hãy chọn tên thể loại cần tìm!", "Thông Báo",
MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            else
            {
                DataTable tbl;
                string sql = "SELECT * FROM tblPhim WHERE (MaTheLoai =N'" + cboTheLoai.SelectedValue + "')";
                tbl = ProcessDB.DocBangsql(sql); GridViewTimKiemPhim.DataSource = tbl;
                GridViewTimKiemPhim.AllowUserToAddRows = false;
                GridViewTimKiemPhim.EditMode = DataGridViewEditMode.EditProgrammatically;
            }

        }

        private void btnTimkiemhsx_Click(object sender, EventArgs e)
        {
            if (cboHangSX.Text == "")
            {
                MessageBox.Show("Hãy chọn tên hãng sản xuất cần tìm!", "Thông Báo",
MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            else
            {
                DataTable tbl;
                string sql = "SELECT * FROM tblPhim WHERE (MaHangSX =N'" + cboHangSX.SelectedValue + "')";
                tbl = ProcessDB.DocBangsql(sql); GridViewTimKiemPhim.DataSource = tbl;
                GridViewTimKiemPhim.AllowUserToAddRows = false;
                GridViewTimKiemPhim.EditMode = DataGridViewEditMode.EditProgrammatically;
            }

        }
    }
}
