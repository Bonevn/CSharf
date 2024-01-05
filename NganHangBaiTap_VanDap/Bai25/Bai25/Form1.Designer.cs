namespace Bai25
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
            this.btnMoTapTin = new System.Windows.Forms.Button();
            this.btnLuuTapTin = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnMoTapTin
            // 
            this.btnMoTapTin.Location = new System.Drawing.Point(44, 128);
            this.btnMoTapTin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMoTapTin.Name = "btnMoTapTin";
            this.btnMoTapTin.Size = new System.Drawing.Size(112, 35);
            this.btnMoTapTin.TabIndex = 0;
            this.btnMoTapTin.Text = "Mở tập tin";
            this.btnMoTapTin.UseVisualStyleBackColor = true;
            this.btnMoTapTin.Click += new System.EventHandler(this.btnMoTapTin_Click);
            // 
            // btnLuuTapTin
            // 
            this.btnLuuTapTin.Location = new System.Drawing.Point(44, 173);
            this.btnLuuTapTin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuuTapTin.Name = "btnLuuTapTin";
            this.btnLuuTapTin.Size = new System.Drawing.Size(112, 35);
            this.btnLuuTapTin.TabIndex = 1;
            this.btnLuuTapTin.Text = "Lưu tập tin";
            this.btnLuuTapTin.UseVisualStyleBackColor = true;
            this.btnLuuTapTin.Click += new System.EventHandler(this.btnLuuTapTin_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(44, 227);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 35);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Soạn thảo văn bản";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(197, 74);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNoiDung.Size = new System.Drawing.Size(492, 244);
            this.txtNoiDung.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "File Text|*.txt";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "Mở tập tin Text để soạn thảo ";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "File Text|*.txt";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Lưu tập tin Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuuTapTin);
            this.Controls.Add(this.btnMoTapTin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMoTapTin;
        private System.Windows.Forms.Button btnLuuTapTin;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

