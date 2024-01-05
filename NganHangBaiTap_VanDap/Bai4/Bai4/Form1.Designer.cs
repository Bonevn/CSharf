namespace Bai4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_den = new System.Windows.Forms.RadioButton();
            this.rbtn_xanh = new System.Windows.Forms.RadioButton();
            this.rbtn_do = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gachduoi = new System.Windows.Forms.CheckBox();
            this.nghieng = new System.Windows.Forms.CheckBox();
            this.indam = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_den);
            this.groupBox1.Controls.Add(this.rbtn_xanh);
            this.groupBox1.Controls.Add(this.rbtn_do);
            this.groupBox1.Location = new System.Drawing.Point(28, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Màu sắc";
            // 
            // rbtn_den
            // 
            this.rbtn_den.AutoSize = true;
            this.rbtn_den.Location = new System.Drawing.Point(18, 127);
            this.rbtn_den.Name = "rbtn_den";
            this.rbtn_den.Size = new System.Drawing.Size(45, 17);
            this.rbtn_den.TabIndex = 2;
            this.rbtn_den.Text = "Đen";
            this.rbtn_den.UseVisualStyleBackColor = true;
            // 
            // rbtn_xanh
            // 
            this.rbtn_xanh.AutoSize = true;
            this.rbtn_xanh.Location = new System.Drawing.Point(18, 78);
            this.rbtn_xanh.Name = "rbtn_xanh";
            this.rbtn_xanh.Size = new System.Drawing.Size(82, 17);
            this.rbtn_xanh.TabIndex = 1;
            this.rbtn_xanh.Text = "Xanh da trời";
            this.rbtn_xanh.UseVisualStyleBackColor = true;
            // 
            // rbtn_do
            // 
            this.rbtn_do.AutoSize = true;
            this.rbtn_do.Location = new System.Drawing.Point(18, 32);
            this.rbtn_do.Name = "rbtn_do";
            this.rbtn_do.Size = new System.Drawing.Size(39, 17);
            this.rbtn_do.TabIndex = 0;
            this.rbtn_do.Text = "Đỏ";
            this.rbtn_do.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gachduoi);
            this.groupBox2.Controls.Add(this.nghieng);
            this.groupBox2.Controls.Add(this.indam);
            this.groupBox2.Location = new System.Drawing.Point(209, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kiểu chữ";
            // 
            // gachduoi
            // 
            this.gachduoi.AutoSize = true;
            this.gachduoi.Location = new System.Drawing.Point(22, 127);
            this.gachduoi.Name = "gachduoi";
            this.gachduoi.Size = new System.Drawing.Size(75, 17);
            this.gachduoi.TabIndex = 2;
            this.gachduoi.Text = "Gạch dưới";
            this.gachduoi.UseVisualStyleBackColor = true;
            // 
            // nghieng
            // 
            this.nghieng.AutoSize = true;
            this.nghieng.Location = new System.Drawing.Point(22, 78);
            this.nghieng.Name = "nghieng";
            this.nghieng.Size = new System.Drawing.Size(66, 17);
            this.nghieng.TabIndex = 1;
            this.nghieng.Text = "Nghiêng";
            this.nghieng.UseVisualStyleBackColor = true;
            // 
            // indam
            // 
            this.indam.AutoSize = true;
            this.indam.Location = new System.Drawing.Point(22, 32);
            this.indam.Name = "indam";
            this.indam.Size = new System.Drawing.Size(48, 17);
            this.indam.TabIndex = 0;
            this.indam.Text = "Đậm";
            this.indam.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Hiện";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 24);
            this.button2.TabIndex = 4;
            this.button2.Text = "Xoá";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(267, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 24);
            this.button3.TabIndex = 5;
            this.button3.Text = "Kết thúc";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "CHƯƠNG TRÌNH OPTIONBOX VÀ CHECKBOX";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(28, 234);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(337, 88);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 370);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Bài 6";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtn_den;
        private System.Windows.Forms.RadioButton rbtn_xanh;
        private System.Windows.Forms.RadioButton rbtn_do;
        private System.Windows.Forms.CheckBox gachduoi;
        private System.Windows.Forms.CheckBox nghieng;
        private System.Windows.Forms.CheckBox indam;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

