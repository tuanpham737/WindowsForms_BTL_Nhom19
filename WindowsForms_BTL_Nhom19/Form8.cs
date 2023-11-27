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

namespace WindowsForms_BTL_Nhom19
{
    public partial class FrmPhongChieu : Form
    {
        SqlConnection conn;
        DataTable tblPhongChieu;
        //Test github
        public void Connect() //Kết nối
        {
            conn = new SqlConnection(); //Khởi tạo đối tượng
            conn.ConnectionString = @"Data Source=DESKTOP-P283H3V\TESTDB;Initial Catalog=BTL;Integrated Security=True";
            conn.Open(); //Mở kết nối
        }
        public void Disconnect() //Ngắt kết nối
        {
            if (conn.State == ConnectionState.Open) //nếu đang mở
            {
                conn.Close(); //đóng
                conn.Dispose(); //huỷ
            }
        }
        public void LoaddataGridViewPhongChieu()
        {
            Connect();
            string sql;
            sql = "SELECT * from tblPhongChieu";
            SqlDataAdapter MyData = new SqlDataAdapter(sql, conn); //Đối tượng DataAdapter 
            tblPhongChieu = new DataTable(); //Khởi tạo bảng
            MyData.Fill(tblPhongChieu); //Đổ dữ liệu từ DataAdapter vào bảng
            dataGridViewPhongChieu.DataSource = tblPhongChieu;
            Disconnect();
        }

        public void RunSQL(string sql,string message) //Thực hiện một câu lệnh SQL
        {
            SqlCommand cmd = new SqlCommand(); //Đối tượng để thực hiện lệnh
            cmd.CommandText = sql;
            cmd.Connection = conn;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show($"{message} Phòng Chiếu thành công");//Thực hiện câu lệnh
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{message} Phòng Chiếu thất bại");
                //MessageBox.Show(ex.ToString());
            }
        }

        public FrmPhongChieu()
        {
            InitializeComponent();
        }

        private void FrmPhongChieu_Load(object sender, EventArgs e)
        {
            LoaddataGridViewPhongChieu();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Connect();
            string sql;
            sql = "SELECT MaPhong FROM tblPhongChieu WHERE MaRap=N'" + txtMaPhong.Text + "'";
            SqlDataAdapter MyData = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            MyData.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Mã phòng này đã tồn tại");
                return;
            }
            //Thực hiện chèn thêm mới
            sql = "INSERT INTO tblPhongChieu VALUES ('" + txtMaPhong.Text + "',N'" + txtTenPhong.Text + "','" +
            txtTongSoGhe.Text + "','" + txtMaRap.Text + "')";
            RunSQL(sql, "Thêm");
            LoaddataGridViewPhongChieu();
            Disconnect();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Connect();
            string sql;
            sql = "UPDATE tblPhongChieu SET TenPhong='" + txtTenPhong.Text + "',TongSoGhe='" + txtTongSoGhe.Text + "',MaRap='" + txtMaRap.Text + "' WHERE MaPhong='" + txtMaPhong.Text + "'";
            RunSQL(sql, "Sửa"); //thực hiện lệnh sql
            LoaddataGridViewPhongChieu(); //hiển thị lại thông tin lên DataGridView
            Disconnect();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Connect();
            string sql;
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblPhongChieu WHERE MaPhong='" + txtMaPhong.Text + "'";
                RunSQL(sql, "Xoá");
                LoaddataGridViewPhongChieu();
                ResetValue();
            }
            Disconnect();
        }
        public void ResetValue()
        {
            txtMaPhong.Clear();
            txtTenPhong.Clear();
            txtTongSoGhe.Clear();
            txtMaRap.Clear();
        }
        private void dataGridViewPhongChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng đang được chọn
                DataGridViewRow selectedRow = this.dataGridViewPhongChieu.Rows[e.RowIndex];

                // Lấy giá trị từ cột cần hiển thị lên TextBox (giả sử là cột đầu tiên)
                txtMaPhong.Text = selectedRow.Cells[0].Value.ToString();
                txtTenPhong.Text = selectedRow.Cells[1].Value.ToString();
                txtTongSoGhe.Text = selectedRow.Cells[2].Value.ToString();
                txtMaRap.Text = selectedRow.Cells[3].Value.ToString();
                

                // Gán giá trị lên TextBox

            }
        }

        private void dataGridViewPhongChieu_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPhongChieu.SelectedRows != null)
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }
    }
}
