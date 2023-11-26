namespace WindowsForms_BTL_Nhom19
{
    partial class FrmTimKiemLich
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimKiemLich));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboRap = new System.Windows.Forms.ComboBox();
            this.cboPhim = new System.Windows.Forms.ComboBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnTimkiemrap = new System.Windows.Forms.Button();
            this.btnTimkiemphim = new System.Windows.Forms.Button();
            this.GridViewTimKiemLich = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTimKiemLich)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(177, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm lịch chiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(38, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rạp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(38, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phim";
            // 
            // cboRap
            // 
            this.cboRap.FormattingEnabled = true;
            this.cboRap.Location = new System.Drawing.Point(148, 84);
            this.cboRap.Name = "cboRap";
            this.cboRap.Size = new System.Drawing.Size(147, 21);
            this.cboRap.TabIndex = 1;
            // 
            // cboPhim
            // 
            this.cboPhim.FormattingEnabled = true;
            this.cboPhim.Location = new System.Drawing.Point(148, 124);
            this.cboPhim.Name = "cboPhim";
            this.cboPhim.Size = new System.Drawing.Size(147, 21);
            this.cboPhim.TabIndex = 2;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(461, 88);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(116, 40);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnTimkiemrap
            // 
            this.btnTimkiemrap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimkiemrap.BackgroundImage")));
            this.btnTimkiemrap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimkiemrap.Location = new System.Drawing.Point(337, 84);
            this.btnTimkiemrap.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimkiemrap.Name = "btnTimkiemrap";
            this.btnTimkiemrap.Size = new System.Drawing.Size(28, 18);
            this.btnTimkiemrap.TabIndex = 8;
            this.btnTimkiemrap.UseVisualStyleBackColor = true;
            this.btnTimkiemrap.Click += new System.EventHandler(this.btnTimkiemrap_Click);
            // 
            // btnTimkiemphim
            // 
            this.btnTimkiemphim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimkiemphim.BackgroundImage")));
            this.btnTimkiemphim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimkiemphim.Location = new System.Drawing.Point(337, 124);
            this.btnTimkiemphim.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimkiemphim.Name = "btnTimkiemphim";
            this.btnTimkiemphim.Size = new System.Drawing.Size(28, 18);
            this.btnTimkiemphim.TabIndex = 9;
            this.btnTimkiemphim.UseVisualStyleBackColor = true;
            this.btnTimkiemphim.Click += new System.EventHandler(this.btnTimkiemphim_Click);
            // 
            // GridViewTimKiemLich
            // 
            this.GridViewTimKiemLich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewTimKiemLich.Location = new System.Drawing.Point(30, 201);
            this.GridViewTimKiemLich.Name = "GridViewTimKiemLich";
            this.GridViewTimKiemLich.Size = new System.Drawing.Size(547, 190);
            this.GridViewTimKiemLich.TabIndex = 10;
            // 
            // FrmTimKiemLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(707, 426);
            this.Controls.Add(this.GridViewTimKiemLich);
            this.Controls.Add(this.btnTimkiemphim);
            this.Controls.Add(this.btnTimkiemrap);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.cboPhim);
            this.Controls.Add(this.cboRap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmTimKiemLich";
            this.Text = "Tìm kiếm lịch";
            this.Load += new System.EventHandler(this.FrmTimKiemLich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTimKiemLich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboRap;
        private System.Windows.Forms.ComboBox cboPhim;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnTimkiemrap;
        private System.Windows.Forms.Button btnTimkiemphim;
        private System.Windows.Forms.DataGridView GridViewTimKiemLich;
    }
}