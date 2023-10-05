namespace Bai1
{
    partial class Bai1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.so_a = new System.Windows.Forms.Label();
            this.so_b = new System.Windows.Forms.Label();
            this.so_c = new System.Windows.Forms.Label();
            this.nhap_a = new System.Windows.Forms.TextBox();
            this.nhap_b = new System.Windows.Forms.TextBox();
            this.nhap_c = new System.Windows.Forms.TextBox();
            this.tim = new System.Windows.Forms.Button();
            this.ketqua = new System.Windows.Forms.GroupBox();
            this.max = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.so_max = new System.Windows.Forms.TextBox();
            this.so_min = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.ketqua.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nhap_c);
            this.groupBox1.Controls.Add(this.nhap_b);
            this.groupBox1.Controls.Add(this.nhap_a);
            this.groupBox1.Controls.Add(this.so_c);
            this.groupBox1.Controls.Add(this.so_b);
            this.groupBox1.Controls.Add(this.so_a);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox1.Location = new System.Drawing.Point(54, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Số nhập vào";
            // 
            // so_a
            // 
            this.so_a.AutoSize = true;
            this.so_a.Location = new System.Drawing.Point(25, 44);
            this.so_a.Name = "so_a";
            this.so_a.Size = new System.Drawing.Size(26, 25);
            this.so_a.TabIndex = 0;
            this.so_a.Text = "A";
            // 
            // so_b
            // 
            this.so_b.AutoSize = true;
            this.so_b.Location = new System.Drawing.Point(242, 44);
            this.so_b.Name = "so_b";
            this.so_b.Size = new System.Drawing.Size(25, 25);
            this.so_b.TabIndex = 1;
            this.so_b.Text = "B";
            this.so_b.Click += new System.EventHandler(this.label1_Click);
            // 
            // so_c
            // 
            this.so_c.AutoSize = true;
            this.so_c.Location = new System.Drawing.Point(458, 44);
            this.so_c.Name = "so_c";
            this.so_c.Size = new System.Drawing.Size(27, 25);
            this.so_c.TabIndex = 2;
            this.so_c.Text = "C";
            // 
            // nhap_a
            // 
            this.nhap_a.Location = new System.Drawing.Point(57, 41);
            this.nhap_a.Name = "nhap_a";
            this.nhap_a.Size = new System.Drawing.Size(130, 30);
            this.nhap_a.TabIndex = 3;
            this.nhap_a.TextChanged += new System.EventHandler(this.nhap_a_TextChanged);
            // 
            // nhap_b
            // 
            this.nhap_b.Location = new System.Drawing.Point(273, 41);
            this.nhap_b.Name = "nhap_b";
            this.nhap_b.Size = new System.Drawing.Size(130, 30);
            this.nhap_b.TabIndex = 4;
            this.nhap_b.TextChanged += new System.EventHandler(this.nhap_b_TextChanged);
            // 
            // nhap_c
            // 
            this.nhap_c.Location = new System.Drawing.Point(491, 41);
            this.nhap_c.Name = "nhap_c";
            this.nhap_c.Size = new System.Drawing.Size(130, 30);
            this.nhap_c.TabIndex = 5;
            this.nhap_c.TextChanged += new System.EventHandler(this.nhap_c_TextChanged);
            // 
            // tim
            // 
            this.tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tim.Location = new System.Drawing.Point(264, 181);
            this.tim.Name = "tim";
            this.tim.Size = new System.Drawing.Size(193, 55);
            this.tim.TabIndex = 1;
            this.tim.Text = "Tìm";
            this.tim.UseVisualStyleBackColor = true;
            this.tim.Click += new System.EventHandler(this.tim_Click);
            // 
            // ketqua
            // 
            this.ketqua.Controls.Add(this.so_max);
            this.ketqua.Controls.Add(this.so_min);
            this.ketqua.Controls.Add(this.max);
            this.ketqua.Controls.Add(this.min);
            this.ketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ketqua.Location = new System.Drawing.Point(68, 302);
            this.ketqua.Name = "ketqua";
            this.ketqua.Size = new System.Drawing.Size(659, 98);
            this.ketqua.TabIndex = 2;
            this.ketqua.TabStop = false;
            this.ketqua.Text = "Kết quả";
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Location = new System.Drawing.Point(26, 40);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(111, 25);
            this.max.TabIndex = 6;
            this.max.Text = "Số lớn nhất";
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Location = new System.Drawing.Point(363, 40);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(118, 25);
            this.min.TabIndex = 7;
            this.min.Text = "Số nhỏ nhất";
            // 
            // so_max
            // 
            this.so_max.Location = new System.Drawing.Point(143, 37);
            this.so_max.Name = "so_max";
            this.so_max.ReadOnly = true;
            this.so_max.Size = new System.Drawing.Size(130, 30);
            this.so_max.TabIndex = 6;
            this.so_max.TextChanged += new System.EventHandler(this.so_max_TextChanged);
            // 
            // so_min
            // 
            this.so_min.Location = new System.Drawing.Point(487, 37);
            this.so_min.Name = "so_min";
            this.so_min.ReadOnly = true;
            this.so_min.Size = new System.Drawing.Size(130, 30);
            this.so_min.TabIndex = 7;
            this.so_min.TextChanged += new System.EventHandler(this.so_min_TextChanged);
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.tim);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bai1";
            this.Text = "Bài 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ketqua.ResumeLayout(false);
            this.ketqua.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label so_c;
        private System.Windows.Forms.Label so_b;
        private System.Windows.Forms.Label so_a;
        private System.Windows.Forms.TextBox nhap_c;
        private System.Windows.Forms.TextBox nhap_b;
        private System.Windows.Forms.TextBox nhap_a;
        private System.Windows.Forms.Button tim;
        private System.Windows.Forms.GroupBox ketqua;
        private System.Windows.Forms.TextBox so_max;
        private System.Windows.Forms.TextBox so_min;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.Label min;
    }
}

