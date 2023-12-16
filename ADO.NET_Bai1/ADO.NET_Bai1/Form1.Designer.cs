namespace ADO.NET_Bai1
{
    partial class frmtaomoitk
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Manv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hoten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Diachi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tendangnhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quyenhan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbquyenhan = new System.Windows.Forms.ComboBox();
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butdau = new System.Windows.Forms.Button();
            this.butlui = new System.Windows.Forms.Button();
            this.buttien = new System.Windows.Forms.Button();
            this.butcuoi = new System.Windows.Forms.Button();
            this.butthoat = new System.Windows.Forms.Button();
            this.butxoabo = new System.Windows.Forms.Button();
            this.buttimkiem = new System.Windows.Forms.Button();
            this.buttaomoi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Manv,
            this.Hoten,
            this.Diachi,
            this.Tendangnhap,
            this.quyenhan});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(9, 8);
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(708, 126);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Manv
            // 
            this.Manv.Text = "Manv";
            this.Manv.Width = 80;
            // 
            // Hoten
            // 
            this.Hoten.Text = "Họ tên";
            this.Hoten.Width = 180;
            // 
            // Diachi
            // 
            this.Diachi.Text = "Địa chỉ";
            this.Diachi.Width = 200;
            // 
            // Tendangnhap
            // 
            this.Tendangnhap.Text = "Tendangnhap";
            this.Tendangnhap.Width = 150;
            // 
            // quyenhan
            // 
            this.quyenhan.Text = "Quyền hạn";
            this.quyenhan.Width = 90;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbquyenhan);
            this.groupBox1.Controls.Add(this.txttendangnhap);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.txtmanv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 165);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cơ bản";
            // 
            // cbquyenhan
            // 
            this.cbquyenhan.FormattingEnabled = true;
            this.cbquyenhan.Location = new System.Drawing.Point(130, 129);
            this.cbquyenhan.Name = "cbquyenhan";
            this.cbquyenhan.Size = new System.Drawing.Size(123, 21);
            this.cbquyenhan.TabIndex = 9;
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.Location = new System.Drawing.Point(130, 103);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(275, 20);
            this.txttendangnhap.TabIndex = 8;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(130, 77);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(275, 20);
            this.txtdiachi.TabIndex = 7;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(130, 51);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(275, 20);
            this.txthoten.TabIndex = 6;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(130, 25);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(275, 20);
            this.txtmanv.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quyền hạn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // butdau
            // 
            this.butdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdau.ForeColor = System.Drawing.Color.Black;
            this.butdau.Location = new System.Drawing.Point(507, 151);
            this.butdau.Name = "butdau";
            this.butdau.Size = new System.Drawing.Size(77, 36);
            this.butdau.TabIndex = 2;
            this.butdau.Text = "|<";
            this.butdau.UseVisualStyleBackColor = true;
            this.butdau.Click += new System.EventHandler(this.butdau_Click);
            // 
            // butlui
            // 
            this.butlui.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butlui.ForeColor = System.Drawing.Color.Black;
            this.butlui.Location = new System.Drawing.Point(507, 193);
            this.butlui.Name = "butlui";
            this.butlui.Size = new System.Drawing.Size(77, 36);
            this.butlui.TabIndex = 3;
            this.butlui.Text = "<";
            this.butlui.UseVisualStyleBackColor = true;
            this.butlui.Click += new System.EventHandler(this.butlui_Click);
            // 
            // buttien
            // 
            this.buttien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttien.ForeColor = System.Drawing.Color.Black;
            this.buttien.Location = new System.Drawing.Point(507, 237);
            this.buttien.Name = "buttien";
            this.buttien.Size = new System.Drawing.Size(77, 36);
            this.buttien.TabIndex = 4;
            this.buttien.Text = ">";
            this.buttien.UseVisualStyleBackColor = true;
            this.buttien.Click += new System.EventHandler(this.buttien_Click);
            // 
            // butcuoi
            // 
            this.butcuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butcuoi.ForeColor = System.Drawing.Color.Black;
            this.butcuoi.Location = new System.Drawing.Point(507, 279);
            this.butcuoi.Name = "butcuoi";
            this.butcuoi.Size = new System.Drawing.Size(77, 36);
            this.butcuoi.TabIndex = 5;
            this.butcuoi.Text = ">|";
            this.butcuoi.UseVisualStyleBackColor = true;
            this.butcuoi.Click += new System.EventHandler(this.butcuoi_Click);
            // 
            // butthoat
            // 
            this.butthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butthoat.ForeColor = System.Drawing.Color.Black;
            this.butthoat.Location = new System.Drawing.Point(620, 279);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(77, 36);
            this.butthoat.TabIndex = 9;
            this.butthoat.Text = "Thoát";
            this.butthoat.UseVisualStyleBackColor = true;
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // butxoabo
            // 
            this.butxoabo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butxoabo.ForeColor = System.Drawing.Color.Black;
            this.butxoabo.Location = new System.Drawing.Point(620, 237);
            this.butxoabo.Name = "butxoabo";
            this.butxoabo.Size = new System.Drawing.Size(77, 36);
            this.butxoabo.TabIndex = 8;
            this.butxoabo.Text = "Xoá bỏ";
            this.butxoabo.UseVisualStyleBackColor = true;
            this.butxoabo.Click += new System.EventHandler(this.butxoabo_Click);
            // 
            // buttimkiem
            // 
            this.buttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttimkiem.ForeColor = System.Drawing.Color.Black;
            this.buttimkiem.Location = new System.Drawing.Point(620, 193);
            this.buttimkiem.Name = "buttimkiem";
            this.buttimkiem.Size = new System.Drawing.Size(77, 36);
            this.buttimkiem.TabIndex = 7;
            this.buttimkiem.Text = "Tìm kiếm";
            this.buttimkiem.UseVisualStyleBackColor = true;
            this.buttimkiem.Click += new System.EventHandler(this.buttimkiem_Click);
            // 
            // buttaomoi
            // 
            this.buttaomoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttaomoi.ForeColor = System.Drawing.Color.Black;
            this.buttaomoi.Location = new System.Drawing.Point(620, 151);
            this.buttaomoi.Name = "buttaomoi";
            this.buttaomoi.Size = new System.Drawing.Size(77, 36);
            this.buttaomoi.TabIndex = 6;
            this.buttaomoi.Text = "Tạo mới";
            this.buttaomoi.UseVisualStyleBackColor = true;
            this.buttaomoi.Click += new System.EventHandler(this.buttaomoi_Click);
            // 
            // frmtaomoitk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.butxoabo);
            this.Controls.Add(this.buttimkiem);
            this.Controls.Add(this.buttaomoi);
            this.Controls.Add(this.butcuoi);
            this.Controls.Add(this.buttien);
            this.Controls.Add(this.butlui);
            this.Controls.Add(this.butdau);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Name = "frmtaomoitk";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmtaomoitk_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Manv;
        private System.Windows.Forms.ColumnHeader Hoten;
        private System.Windows.Forms.ColumnHeader Diachi;
        private System.Windows.Forms.ColumnHeader Tendangnhap;
        private System.Windows.Forms.ColumnHeader quyenhan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbquyenhan;
        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Button butdau;
        private System.Windows.Forms.Button butlui;
        private System.Windows.Forms.Button buttien;
        private System.Windows.Forms.Button butcuoi;
        private System.Windows.Forms.Button butthoat;
        private System.Windows.Forms.Button butxoabo;
        private System.Windows.Forms.Button buttimkiem;
        private System.Windows.Forms.Button buttaomoi;
    }
}

