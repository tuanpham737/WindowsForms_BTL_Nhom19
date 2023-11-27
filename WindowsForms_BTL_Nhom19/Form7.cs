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
    public partial class FrmQlRap : Form
    {
        SqlConnection conn;
        DataTable tblRap;
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
        public void LoaddataGridViewQlRap()
        {
            Connect();
            string sql;
            sql = "SELECT * from tblRap";
            SqlDataAdapter MyData = new SqlDataAdapter(sql, conn); //Đối tượng DataAdapter 
            tblRap = new DataTable(); //Khởi tạo bảng
            MyData.Fill(tblRap); //Đổ dữ liệu từ DataAdapter vào bảng
            dataGridViewQlRap.DataSource = tblRap;
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
                MessageBox.Show($"{message} rạp thành công");//Thực hiện câu lệnh
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{message} rạp thất bại");
                //MessageBox.Show(ex.ToString());
            }
        }



        public FrmQlRap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmQlRap_Load(object sender, EventArgs e)
        {
            LoaddataGridViewQlRap();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Connect();
            string sql;
            sql = "SELECT MaRap FROM tblRap WHERE MaRap=N'" + txtMaRap.Text + "'";
            SqlDataAdapter MyData = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            MyData.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Mã rạp này đã tồn tại");
                return;
            }
            //Thực hiện chèn thêm mới
            sql = "INSERT INTO tblRap VALUES ('" + txtMaRap.Text + "',N'" + txtTenRap.Text + "','" +
            txtDiaChi.Text + "','" + txtSoDT.Text + "','" + txtSoPhong.Text + "',N'" + txtTongSoGhe.Text + "')";
            RunSQL(sql,"Thêm");
            LoaddataGridViewQlRap();
            Disconnect();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Connect();
            string sql;
            sql = "UPDATE tblRap SET TenRap='" + txtTenRap.Text + "',DiaChi='" + txtDiaChi.Text + "',DienThoai='" + txtSoDT.Text + "',SoPhong='" + txtSoPhong.Text + "',TongSoGhe='" + txtTongSoGhe.Text + "' WHERE MaRap='" + txtMaRap.Text + "'";
            RunSQL(sql,"Sửa"); //thực hiện lệnh sql
            LoaddataGridViewQlRap(); //hiển thị lại thông tin lên DataGridView
            Disconnect();
            
        }

        public void ResetValue()
        {
            txtMaRap.Clear();
            txtTenRap.Clear();
            txtDiaChi.Clear();
            txtSoDT.Clear();
            txtSoPhong.Clear();
            txtTongSoGhe.Clear();
        }

        private void dataGridViewQlRap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng đang được chọn
                DataGridViewRow selectedRow = this.dataGridViewQlRap.Rows[e.RowIndex];

                // Lấy giá trị từ cột cần hiển thị lên TextBox (giả sử là cột đầu tiên)
                txtMaRap.Text = selectedRow.Cells[0].Value.ToString();
                txtTenRap.Text = selectedRow.Cells[1].Value.ToString();
                txtDiaChi.Text = selectedRow.Cells[2].Value.ToString();
                txtSoDT.Text = selectedRow.Cells[3].Value.ToString();
                txtSoPhong.Text = selectedRow.Cells[4].Value.ToString();
                txtTongSoGhe.Text = selectedRow.Cells[5].Value.ToString();


                // Gán giá trị lên TextBox

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Connect();
            string sql;
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblRap WHERE MaRap='" + txtMaRap.Text + "'";
                RunSQL(sql,"Xoá");
                LoaddataGridViewQlRap();
                ResetValue();
            }
            Disconnect();
        }

        private void dataGridViewQlRap_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewQlRap.SelectedRows != null)
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
