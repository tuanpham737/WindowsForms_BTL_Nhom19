namespace WindowsForms_BTL_Nhom19
{
    partial class FrmLichChieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaShow = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dataGridViewLichChieu = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMaPhong = new System.Windows.Forms.ComboBox();
            this.cmbMaRap = new System.Windows.Forms.ComboBox();
            this.dtNgayChieu = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLichChieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Show";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày chiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá Vé";
            // 
            // txtMaShow
            // 
            this.txtMaShow.Location = new System.Drawing.Point(278, 59);
            this.txtMaShow.Name = "txtMaShow";
            this.txtMaShow.Size = new System.Drawing.Size(100, 22);
            this.txtMaShow.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(278, 151);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(106, 381);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(250, 381);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(381, 381);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(519, 381);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dataGridViewLichChieu
            // 
            this.dataGridViewLichChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLichChieu.Location = new System.Drawing.Point(78, 204);
            this.dataGridViewLichChieu.Name = "dataGridViewLichChieu";
            this.dataGridViewLichChieu.RowHeadersWidth = 51;
            this.dataGridViewLichChieu.RowTemplate.Height = 24;
            this.dataGridViewLichChieu.Size = new System.Drawing.Size(651, 150);
            this.dataGridViewLichChieu.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Rạp";
            // 
            // cmbMaPhong
            // 
            this.cmbMaPhong.FormattingEnabled = true;
            this.cmbMaPhong.Location = new System.Drawing.Point(587, 59);
            this.cmbMaPhong.Name = "cmbMaPhong";
            this.cmbMaPhong.Size = new System.Drawing.Size(121, 24);
            this.cmbMaPhong.TabIndex = 4;
            // 
            // cmbMaRap
            // 
            this.cmbMaRap.FormattingEnabled = true;
            this.cmbMaRap.Location = new System.Drawing.Point(587, 109);
            this.cmbMaRap.Name = "cmbMaRap";
            this.cmbMaRap.Size = new System.Drawing.Size(121, 24);
            this.cmbMaRap.TabIndex = 4;
            // 
            // dtNgayChieu
            // 
            this.dtNgayChieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayChieu.Location = new System.Drawing.Point(278, 107);
            this.dtNgayChieu.Name = "dtNgayChieu";
            this.dtNgayChieu.Size = new System.Drawing.Size(104, 22);
            this.dtNgayChieu.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(329, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 38);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày Chiếu";
            // 
            // FrmLichChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtNgayChieu);
            this.Controls.Add(this.cmbMaRap);
            this.Controls.Add(this.cmbMaPhong);
            this.Controls.Add(this.dataGridViewLichChieu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtMaShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FrmLichChieu";
            this.Text = "Lịch Chiếu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLichChieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaShow;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dataGridViewLichChieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMaPhong;
        private System.Windows.Forms.ComboBox cmbMaRap;
        private System.Windows.Forms.DateTimePicker dtNgayChieu;
        private System.Windows.Forms.Label label6;
    }
}