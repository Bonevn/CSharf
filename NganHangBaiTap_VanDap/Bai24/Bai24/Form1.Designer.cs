namespace Bai24
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnChonMau = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radMauNen = new System.Windows.Forms.RadioButton();
            this.radMauChu = new System.Windows.Forms.RadioButton();
            this.lblHienThi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnChonMau);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 176);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 184);
            this.panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(414, 114);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(159, 47);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnChonMau
            // 
            this.btnChonMau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonMau.Location = new System.Drawing.Point(414, 46);
            this.btnChonMau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChonMau.Name = "btnChonMau";
            this.btnChonMau.Size = new System.Drawing.Size(159, 47);
            this.btnChonMau.TabIndex = 2;
            this.btnChonMau.Text = "Chọn màu ";
            this.btnChonMau.UseVisualStyleBackColor = true;
            this.btnChonMau.Click += new System.EventHandler(this.btnChonMau_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radMauNen);
            this.groupBox1.Controls.Add(this.radMauChu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(264, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn màu chũ hoặc màu nền";
            // 
            // radMauNen
            // 
            this.radMauNen.AutoSize = true;
            this.radMauNen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMauNen.Location = new System.Drawing.Point(33, 86);
            this.radMauNen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radMauNen.Name = "radMauNen";
            this.radMauNen.Size = new System.Drawing.Size(93, 24);
            this.radMauNen.TabIndex = 1;
            this.radMauNen.TabStop = true;
            this.radMauNen.Text = "Màu nền ";
            this.radMauNen.UseVisualStyleBackColor = true;
            // 
            // radMauChu
            // 
            this.radMauChu.AutoSize = true;
            this.radMauChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMauChu.Location = new System.Drawing.Point(33, 41);
            this.radMauChu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radMauChu.Name = "radMauChu";
            this.radMauChu.Size = new System.Drawing.Size(88, 24);
            this.radMauChu.TabIndex = 0;
            this.radMauChu.TabStop = true;
            this.radMauChu.Text = "Màu chữ";
            this.radMauChu.UseVisualStyleBackColor = true;
            // 
            // lblHienThi
            // 
            this.lblHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThi.Location = new System.Drawing.Point(13, 9);
            this.lblHienThi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(670, 162);
            this.lblHienThi.TabIndex = 4;
            this.lblHienThi.Text = "Khoa Công nghê thông tin";
            this.lblHienThi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 361);
            this.Controls.Add(this.lblHienThi);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnChonMau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radMauNen;
        private System.Windows.Forms.RadioButton radMauChu;
        private System.Windows.Forms.Label lblHienThi;
    }
}

