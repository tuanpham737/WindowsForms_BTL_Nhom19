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

        public void RunSQL(string sql) //Thực hiện một câu lệnh SQL
        {
            SqlCommand cmd = new SqlCommand(); //Đối tượng để thực hiện lệnh
            cmd.CommandText = sql;
            cmd.Connection = conn;
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
            RunSQL(sql);
            LoaddataGridViewQlRap();
            Disconnect();
        }
    }
}
