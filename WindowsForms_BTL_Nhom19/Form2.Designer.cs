namespace WindowsForms_BTL_Nhom19
{
    partial class FrmTimKiemPhim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimKiemPhim));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.cboHangSX = new System.Windows.Forms.ComboBox();
            this.txtTenphim = new System.Windows.Forms.TextBox();
            this.btnTimkiemphim = new System.Windows.Forms.Button();
            this.GridViewTimKiemPhim = new System.Windows.Forms.DataGridView();
            this.btnTimkiemtheloai = new System.Windows.Forms.Button();
            this.btnTimkiemhsx = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTimKiemPhim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(190, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM PHIM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(77, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên phim";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(82, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thể loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(56, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hãng sản xuất";
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.FormattingEnabled = true;
            this.cboTheLoai.Location = new System.Drawing.Point(176, 113);
            this.cboTheLoai.Margin = new System.Windows.Forms.Padding(2);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(147, 21);
            this.cboTheLoai.TabIndex = 4;
            // 
            // cboHangSX
            // 
            this.cboHangSX.FormattingEnabled = true;
            this.cboHangSX.Location = new System.Drawing.Point(176, 157);
            this.cboHangSX.Margin = new System.Windows.Forms.Padding(2);
            this.cboHangSX.Name = "cboHangSX";
            this.cboHangSX.Size = new System.Drawing.Size(147, 21);
            this.cboHangSX.TabIndex = 5;
            // 
            // txtTenphim
            // 
            this.txtTenphim.Location = new System.Drawing.Point(176, 75);
            this.txtTenphim.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenphim.Name = "txtTenphim";
            this.txtTenphim.Size = new System.Drawing.Size(147, 20);
            this.txtTenphim.TabIndex = 6;
            // 
            // btnTimkiemphim
            // 
            this.btnTimkiemphim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimkiemphim.BackgroundImage")));
            this.btnTimkiemphim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimkiemphim.Location = new System.Drawing.Point(355, 75);
            this.btnTimkiemphim.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimkiemphim.Name = "btnTimkiemphim";
            this.btnTimkiemphim.Size = new System.Drawing.Size(28, 18);
            this.btnTimkiemphim.TabIndex = 7;
            this.btnTimkiemphim.UseVisualStyleBackColor = true;
            this.btnTimkiemphim.Click += new System.EventHandler(this.btnTimkiemphim_Click);
            // 
            // GridViewTimKiemPhim
            // 
            this.GridViewTimKiemPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewTimKiemPhim.Location = new System.Drawing.Point(9, 201);
            this.GridViewTimKiemPhim.Margin = new System.Windows.Forms.Padding(2);
            this.GridViewTimKiemPhim.Name = "GridViewTimKiemPhim";
            this.GridViewTimKiemPhim.RowHeadersWidth = 51;
            this.GridViewTimKiemPhim.RowTemplate.Height = 24;
            this.GridViewTimKiemPhim.Size = new System.Drawing.Size(543, 162);
            this.GridViewTimKiemPhim.TabIndex = 8;
            // 
            // btnTimkiemtheloai
            // 
            this.btnTimkiemtheloai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimkiemtheloai.BackgroundImage")));
            this.btnTimkiemtheloai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimkiemtheloai.Location = new System.Drawing.Point(355, 113);
            this.btnTimkiemtheloai.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimkiemtheloai.Name = "btnTimkiemtheloai";
            this.btnTimkiemtheloai.Size = new System.Drawing.Size(28, 18);
            this.btnTimkiemtheloai.TabIndex = 7;
            this.btnTimkiemtheloai.UseVisualStyleBackColor = true;
            this.btnTimkiemtheloai.Click += new System.EventHandler(this.btnTimkiemtheloai_Click);
            // 
            // btnTimkiemhsx
            // 
            this.btnTimkiemhsx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimkiemhsx.BackgroundImage")));
            this.btnTimkiemhsx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimkiemhsx.Location = new System.Drawing.Point(355, 157);
            this.btnTimkiemhsx.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimkiemhsx.Name = "btnTimkiemhsx";
            this.btnTimkiemhsx.Size = new System.Drawing.Size(28, 18);
            this.btnTimkiemhsx.TabIndex = 7;
            this.btnTimkiemhsx.UseVisualStyleBackColor = true;
            this.btnTimkiemhsx.Click += new System.EventHandler(this.btnTimkiemhsx_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(419, 95);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(133, 55);
            this.btnTimkiem.TabIndex = 9;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // FrmTimKiemPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(619, 366);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.GridViewTimKiemPhim);
            this.Controls.Add(this.btnTimkiemhsx);
            this.Controls.Add(this.btnTimkiemtheloai);
            this.Controls.Add(this.btnTimkiemphim);
            this.Controls.Add(this.txtTenphim);
            this.Controls.Add(this.cboHangSX);
            this.Controls.Add(this.cboTheLoai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmTimKiemPhim";
            this.Text = "Tìm kiếm phim";
            this.Load += new System.EventHandler(this.FrmTimKiemPhim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTimKiemPhim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.ComboBox cboHangSX;
        private System.Windows.Forms.TextBox txtTenphim;
        private System.Windows.Forms.Button btnTimkiemphim;
        private System.Windows.Forms.DataGridView GridViewTimKiemPhim;
        private System.Windows.Forms.Button btnTimkiemtheloai;
        private System.Windows.Forms.Button btnTimkiemhsx;
        private System.Windows.Forms.Button btnTimkiem;
    }
}