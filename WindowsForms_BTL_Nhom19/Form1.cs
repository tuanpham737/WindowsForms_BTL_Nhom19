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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void phimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTimKiemPhim frmTim = new FrmTimKiemPhim();
            frmTim.ShowDialog();
        }

        private void lichChieuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTimKiemLich frmTim = new FrmTimKiemLich();
            frmTim.ShowDialog();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void phimĐangChieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InPhimDangChieu inDoanh =new InPhimDangChieu();
            inDoanh.ShowDialog();
        }

        private void phimToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            InDoanhThuPhim inDoanh = new InDoanhThuPhim();
            inDoanh.ShowDialog();
        }

        private void rapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InDoanhThuRap inDoanh = new InDoanhThuRap();
            inDoanh.ShowDialog();
        }

        private void rapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQlRap frmQlRap = new FrmQlRap();
            frmQlRap.ShowDialog();
        }

        private void PhongChieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPhongChieu frmPhongChieu = new FrmPhongChieu();
            frmPhongChieu.ShowDialog();
        }

        private void LichChieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLichChieu frmLichChieu = new FrmLichChieu(); frmLichChieu.ShowDialog();
        }

        private void phimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQlPhim frmQlPhim = new FrmQlPhim(); frmQlPhim.ShowDialog();
        }

        private void VeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVe frmVe = new FrmVe(); frmVe.ShowDialog();
        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
