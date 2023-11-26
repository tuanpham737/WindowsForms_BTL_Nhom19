namespace WindowsForms_BTL_Nhom19
{
    partial class InDoanhThuPhim
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPhim = new System.Windows.Forms.ComboBox();
            this.btnInDTP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(203, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Báo cáo doanh thu phim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn phim";
            // 
            // cboPhim
            // 
            this.cboPhim.FormattingEnabled = true;
            this.cboPhim.Location = new System.Drawing.Point(293, 157);
            this.cboPhim.Name = "cboPhim";
            this.cboPhim.Size = new System.Drawing.Size(181, 21);
            this.cboPhim.TabIndex = 3;
            // 
            // btnInDTP
            // 
            this.btnInDTP.Location = new System.Drawing.Point(566, 155);
            this.btnInDTP.Name = "btnInDTP";
            this.btnInDTP.Size = new System.Drawing.Size(75, 23);
            this.btnInDTP.TabIndex = 4;
            this.btnInDTP.Text = "in báo cáo";
            this.btnInDTP.UseVisualStyleBackColor = true;
            this.btnInDTP.Click += new System.EventHandler(this.btnInDTP_Click);
            // 
            // InDoanhThuPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInDTP);
            this.Controls.Add(this.cboPhim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "InDoanhThuPhim";
            this.Text = "Doanh thu phim";
            this.Load += new System.EventHandler(this.InDoanhThuPhim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPhim;
        private System.Windows.Forms.Button btnInDTP;
    }
}