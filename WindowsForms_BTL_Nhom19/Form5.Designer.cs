namespace WindowsForms_BTL_Nhom19
{
    partial class InDoanhThuRap
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
            this.cboRap = new System.Windows.Forms.ComboBox();
            this.btnInDTR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn rạp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Báo cáo doanh thu rạp";
            // 
            // cboRap
            // 
            this.cboRap.FormattingEnabled = true;
            this.cboRap.Location = new System.Drawing.Point(324, 142);
            this.cboRap.Name = "cboRap";
            this.cboRap.Size = new System.Drawing.Size(121, 21);
            this.cboRap.TabIndex = 1;
            // 
            // btnInDTR
            // 
            this.btnInDTR.Location = new System.Drawing.Point(519, 142);
            this.btnInDTR.Name = "btnInDTR";
            this.btnInDTR.Size = new System.Drawing.Size(75, 23);
            this.btnInDTR.TabIndex = 2;
            this.btnInDTR.Text = "in báo cáo";
            this.btnInDTR.UseVisualStyleBackColor = true;
            this.btnInDTR.Click += new System.EventHandler(this.btnInDTR_Click);
            // 
            // InDoanhThuRap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInDTR);
            this.Controls.Add(this.cboRap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InDoanhThuRap";
            this.Text = "In doanh thu rạp";
            this.Load += new System.EventHandler(this.InDoanhThuRap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboRap;
        private System.Windows.Forms.Button btnInDTR;
    }
}