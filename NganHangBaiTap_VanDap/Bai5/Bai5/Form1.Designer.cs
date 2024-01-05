namespace Bai5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_n = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ketqua = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.rbtn_cong = new System.Windows.Forms.RadioButton();
            this.rbtn_binhphuong = new System.Windows.Forms.RadioButton();
            this.rbtn_chia = new System.Windows.Forms.RadioButton();
            this.rbtn_chiagiathua = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH TÍNH TỔNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(27, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số N: ";
            // 
            // txt_n
            // 
            this.txt_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_n.Location = new System.Drawing.Point(116, 74);
            this.txt_n.Name = "txt_n";
            this.txt_n.Size = new System.Drawing.Size(58, 21);
            this.txt_n.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_chiagiathua);
            this.groupBox1.Controls.Add(this.rbtn_chia);
            this.groupBox1.Controls.Add(this.rbtn_binhphuong);
            this.groupBox1.Controls.Add(this.rbtn_cong);
            this.groupBox1.Location = new System.Drawing.Point(21, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 148);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // ketqua
            // 
            this.ketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ketqua.Location = new System.Drawing.Point(240, 186);
            this.ketqua.Name = "ketqua";
            this.ketqua.ReadOnly = true;
            this.ketqua.Size = new System.Drawing.Size(93, 21);
            this.ketqua.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tính";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Tính tiếp";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 30);
            this.button3.TabIndex = 7;
            this.button3.Text = "Kết thúc";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rbtn_cong
            // 
            this.rbtn_cong.AutoSize = true;
            this.rbtn_cong.Location = new System.Drawing.Point(9, 25);
            this.rbtn_cong.Name = "rbtn_cong";
            this.rbtn_cong.Size = new System.Drawing.Size(148, 17);
            this.rbtn_cong.TabIndex = 0;
            this.rbtn_cong.TabStop = true;
            this.rbtn_cong.Text = "S = 1 + 3 + 5 + ... + (2N-1)";
            this.rbtn_cong.UseVisualStyleBackColor = true;
            // 
            // rbtn_binhphuong
            // 
            this.rbtn_binhphuong.AutoSize = true;
            this.rbtn_binhphuong.Location = new System.Drawing.Point(9, 57);
            this.rbtn_binhphuong.Name = "rbtn_binhphuong";
            this.rbtn_binhphuong.Size = new System.Drawing.Size(139, 17);
            this.rbtn_binhphuong.TabIndex = 1;
            this.rbtn_binhphuong.TabStop = true;
            this.rbtn_binhphuong.Text = "S = 1 + 4 + 9 + ... + N^2";
            this.rbtn_binhphuong.UseVisualStyleBackColor = true;
            // 
            // rbtn_chia
            // 
            this.rbtn_chia.AutoSize = true;
            this.rbtn_chia.Location = new System.Drawing.Point(9, 89);
            this.rbtn_chia.Name = "rbtn_chia";
            this.rbtn_chia.Size = new System.Drawing.Size(160, 17);
            this.rbtn_chia.TabIndex = 2;
            this.rbtn_chia.TabStop = true;
            this.rbtn_chia.Text = "S = 1 + 1/2 + 1/3 + ... + 1/N";
            this.rbtn_chia.UseVisualStyleBackColor = true;
            // 
            // rbtn_chiagiathua
            // 
            this.rbtn_chiagiathua.AutoSize = true;
            this.rbtn_chiagiathua.Location = new System.Drawing.Point(9, 121);
            this.rbtn_chiagiathua.Name = "rbtn_chiagiathua";
            this.rbtn_chiagiathua.Size = new System.Drawing.Size(169, 17);
            this.rbtn_chiagiathua.TabIndex = 3;
            this.rbtn_chiagiathua.TabStop = true;
            this.rbtn_chiagiathua.Text = "S = 1 + 1/2! + 1/3! + ... + 1/N!";
            this.rbtn_chiagiathua.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 281);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_n);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bài 7";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_n;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ketqua;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton rbtn_chiagiathua;
        private System.Windows.Forms.RadioButton rbtn_chia;
        private System.Windows.Forms.RadioButton rbtn_binhphuong;
        private System.Windows.Forms.RadioButton rbtn_cong;
    }
}

