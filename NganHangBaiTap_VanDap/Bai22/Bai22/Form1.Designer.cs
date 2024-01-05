namespace Bai22
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
            this.myTabControl = new System.Windows.Forms.TabControl();
            this.tabQuanLyNhanVien = new System.Windows.Forms.TabPage();
            this.txtChucVuNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listNhanVien = new System.Windows.Forms.ListView();
            this.clHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colChucVu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLuongCoBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnCapNhatNV = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.txtHeSoLuongNV = new System.Windows.Forms.TextBox();
            this.txtLuongCBNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabQuanLyGiaoVien = new System.Windows.Forms.TabPage();
            this.txtHocVi = new System.Windows.Forms.TextBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listViewGV = new System.Windows.Forms.ListView();
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHocVi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTienDayMotTiet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoTietDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoaGiaoVien = new System.Windows.Forms.Button();
            this.btnCapNhatGV = new System.Windows.Forms.Button();
            this.btnThemGV = new System.Windows.Forms.Button();
            this.txtSoTietDay = new System.Windows.Forms.TextBox();
            this.txtTienDayMotTiet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.myTabControl.SuspendLayout();
            this.tabQuanLyNhanVien.SuspendLayout();
            this.tabQuanLyGiaoVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // myTabControl
            // 
            this.myTabControl.Controls.Add(this.tabQuanLyNhanVien);
            this.myTabControl.Controls.Add(this.tabQuanLyGiaoVien);
            this.myTabControl.Location = new System.Drawing.Point(44, 77);
            this.myTabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myTabControl.Name = "myTabControl";
            this.myTabControl.SelectedIndex = 0;
            this.myTabControl.Size = new System.Drawing.Size(798, 456);
            this.myTabControl.TabIndex = 0;
            // 
            // tabQuanLyNhanVien
            // 
            this.tabQuanLyNhanVien.Controls.Add(this.txtChucVuNV);
            this.tabQuanLyNhanVien.Controls.Add(this.txtTenNV);
            this.tabQuanLyNhanVien.Controls.Add(this.label2);
            this.tabQuanLyNhanVien.Controls.Add(this.label5);
            this.tabQuanLyNhanVien.Controls.Add(this.listNhanVien);
            this.tabQuanLyNhanVien.Controls.Add(this.btnXoaNV);
            this.tabQuanLyNhanVien.Controls.Add(this.btnCapNhatNV);
            this.tabQuanLyNhanVien.Controls.Add(this.btnThemNV);
            this.tabQuanLyNhanVien.Controls.Add(this.txtHeSoLuongNV);
            this.tabQuanLyNhanVien.Controls.Add(this.txtLuongCBNV);
            this.tabQuanLyNhanVien.Controls.Add(this.label4);
            this.tabQuanLyNhanVien.Controls.Add(this.label3);
            this.tabQuanLyNhanVien.Location = new System.Drawing.Point(4, 29);
            this.tabQuanLyNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabQuanLyNhanVien.Name = "tabQuanLyNhanVien";
            this.tabQuanLyNhanVien.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabQuanLyNhanVien.Size = new System.Drawing.Size(790, 423);
            this.tabQuanLyNhanVien.TabIndex = 0;
            this.tabQuanLyNhanVien.Text = "Quản lý nhân viên";
            this.tabQuanLyNhanVien.UseVisualStyleBackColor = true;
            // 
            // txtChucVuNV
            // 
            this.txtChucVuNV.Location = new System.Drawing.Point(558, 42);
            this.txtChucVuNV.Name = "txtChucVuNV";
            this.txtChucVuNV.Size = new System.Drawing.Size(180, 26);
            this.txtChucVuNV.TabIndex = 2;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(139, 36);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(269, 26);
            this.txtTenNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Chức vụ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Họ tên :";
            // 
            // listNhanVien
            // 
            this.listNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clHoTen,
            this.colChucVu,
            this.colHeSoLuong,
            this.colLuongCoBan});
            this.listNhanVien.FullRowSelect = true;
            this.listNhanVien.HideSelection = false;
            this.listNhanVien.Location = new System.Drawing.Point(58, 203);
            this.listNhanVien.MultiSelect = false;
            this.listNhanVien.Name = "listNhanVien";
            this.listNhanVien.Size = new System.Drawing.Size(680, 199);
            this.listNhanVien.TabIndex = 8;
            this.listNhanVien.UseCompatibleStateImageBehavior = false;
            this.listNhanVien.View = System.Windows.Forms.View.Details;
            this.listNhanVien.SelectedIndexChanged += new System.EventHandler(this.listNhanVien_SelectedIndexChanged);
            // 
            // clHoTen
            // 
            this.clHoTen.Text = "Họ Tên";
            this.clHoTen.Width = 150;
            // 
            // colChucVu
            // 
            this.colChucVu.Text = "Chức vụ";
            this.colChucVu.Width = 150;
            // 
            // colHeSoLuong
            // 
            this.colHeSoLuong.Text = "Hệ số lương";
            this.colHeSoLuong.Width = 150;
            // 
            // colLuongCoBan
            // 
            this.colLuongCoBan.Text = "Lương cơ bản";
            this.colLuongCoBan.Width = 150;
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Location = new System.Drawing.Point(589, 136);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(149, 34);
            this.btnXoaNV.TabIndex = 7;
            this.btnXoaNV.Text = "Xóa nhân viên";
            this.btnXoaNV.UseVisualStyleBackColor = true;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnCapNhatNV
            // 
            this.btnCapNhatNV.Location = new System.Drawing.Point(358, 138);
            this.btnCapNhatNV.Name = "btnCapNhatNV";
            this.btnCapNhatNV.Size = new System.Drawing.Size(119, 34);
            this.btnCapNhatNV.TabIndex = 6;
            this.btnCapNhatNV.Text = "Cập nhật";
            this.btnCapNhatNV.UseVisualStyleBackColor = true;
            this.btnCapNhatNV.Click += new System.EventHandler(this.btnCapNhatNV_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(58, 136);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(149, 34);
            this.btnThemNV.TabIndex = 5;
            this.btnThemNV.Text = "Thêm nhân viên";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // txtHeSoLuongNV
            // 
            this.txtHeSoLuongNV.Location = new System.Drawing.Point(558, 82);
            this.txtHeSoLuongNV.Name = "txtHeSoLuongNV";
            this.txtHeSoLuongNV.Size = new System.Drawing.Size(180, 26);
            this.txtHeSoLuongNV.TabIndex = 4;
            // 
            // txtLuongCBNV
            // 
            this.txtLuongCBNV.Location = new System.Drawing.Point(171, 76);
            this.txtLuongCBNV.Name = "txtLuongCBNV";
            this.txtLuongCBNV.Size = new System.Drawing.Size(237, 26);
            this.txtLuongCBNV.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hệ số lương:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lương cơ bản :";
            // 
            // tabQuanLyGiaoVien
            // 
            this.tabQuanLyGiaoVien.Controls.Add(this.txtHocVi);
            this.tabQuanLyGiaoVien.Controls.Add(this.txtTenGV);
            this.tabQuanLyGiaoVien.Controls.Add(this.label6);
            this.tabQuanLyGiaoVien.Controls.Add(this.label7);
            this.tabQuanLyGiaoVien.Controls.Add(this.listViewGV);
            this.tabQuanLyGiaoVien.Controls.Add(this.btnXoaGiaoVien);
            this.tabQuanLyGiaoVien.Controls.Add(this.btnCapNhatGV);
            this.tabQuanLyGiaoVien.Controls.Add(this.btnThemGV);
            this.tabQuanLyGiaoVien.Controls.Add(this.txtSoTietDay);
            this.tabQuanLyGiaoVien.Controls.Add(this.txtTienDayMotTiet);
            this.tabQuanLyGiaoVien.Controls.Add(this.label8);
            this.tabQuanLyGiaoVien.Controls.Add(this.label9);
            this.tabQuanLyGiaoVien.Location = new System.Drawing.Point(4, 29);
            this.tabQuanLyGiaoVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabQuanLyGiaoVien.Name = "tabQuanLyGiaoVien";
            this.tabQuanLyGiaoVien.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabQuanLyGiaoVien.Size = new System.Drawing.Size(790, 423);
            this.tabQuanLyGiaoVien.TabIndex = 1;
            this.tabQuanLyGiaoVien.Text = "Quản lý giáo viên";
            this.tabQuanLyGiaoVien.UseVisualStyleBackColor = true;
            // 
            // txtHocVi
            // 
            this.txtHocVi.Location = new System.Drawing.Point(535, 31);
            this.txtHocVi.Name = "txtHocVi";
            this.txtHocVi.Size = new System.Drawing.Size(202, 26);
            this.txtHocVi.TabIndex = 12;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(138, 28);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(269, 26);
            this.txtTenGV.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Học vị:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Họ tên :";
            // 
            // listViewGV
            // 
            this.listViewGV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHoTen,
            this.colHocVi,
            this.colTienDayMotTiet,
            this.colSoTietDay});
            this.listViewGV.FullRowSelect = true;
            this.listViewGV.HideSelection = false;
            this.listViewGV.Location = new System.Drawing.Point(57, 194);
            this.listViewGV.Margin = new System.Windows.Forms.Padding(10);
            this.listViewGV.MultiSelect = false;
            this.listViewGV.Name = "listViewGV";
            this.listViewGV.Size = new System.Drawing.Size(680, 199);
            this.listViewGV.TabIndex = 18;
            this.listViewGV.UseCompatibleStateImageBehavior = false;
            this.listViewGV.View = System.Windows.Forms.View.Details;
            this.listViewGV.SelectedIndexChanged += new System.EventHandler(this.listViewGV_SelectedIndexChanged);
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ Tên";
            this.colHoTen.Width = 160;
            // 
            // colHocVi
            // 
            this.colHocVi.Text = "Học vị";
            this.colHocVi.Width = 160;
            // 
            // colTienDayMotTiet
            // 
            this.colTienDayMotTiet.Text = "Tiền dạy một tiết";
            this.colTienDayMotTiet.Width = 160;
            // 
            // colSoTietDay
            // 
            this.colSoTietDay.Text = "Số tiết dạy";
            this.colSoTietDay.Width = 160;
            // 
            // btnXoaGiaoVien
            // 
            this.btnXoaGiaoVien.Location = new System.Drawing.Point(588, 128);
            this.btnXoaGiaoVien.Name = "btnXoaGiaoVien";
            this.btnXoaGiaoVien.Size = new System.Drawing.Size(149, 34);
            this.btnXoaGiaoVien.TabIndex = 17;
            this.btnXoaGiaoVien.Text = "Xóa giáo viên";
            this.btnXoaGiaoVien.UseVisualStyleBackColor = true;
            this.btnXoaGiaoVien.Click += new System.EventHandler(this.btnXoaGiaoVien_Click);
            // 
            // btnCapNhatGV
            // 
            this.btnCapNhatGV.Location = new System.Drawing.Point(357, 130);
            this.btnCapNhatGV.Name = "btnCapNhatGV";
            this.btnCapNhatGV.Size = new System.Drawing.Size(119, 34);
            this.btnCapNhatGV.TabIndex = 16;
            this.btnCapNhatGV.Text = "Cập nhật";
            this.btnCapNhatGV.UseVisualStyleBackColor = true;
            this.btnCapNhatGV.Click += new System.EventHandler(this.btnCapNhatGV_Click);
            // 
            // btnThemGV
            // 
            this.btnThemGV.Location = new System.Drawing.Point(57, 128);
            this.btnThemGV.Name = "btnThemGV";
            this.btnThemGV.Size = new System.Drawing.Size(149, 34);
            this.btnThemGV.TabIndex = 15;
            this.btnThemGV.Text = "Thêm giáo viên";
            this.btnThemGV.UseVisualStyleBackColor = true;
            this.btnThemGV.Click += new System.EventHandler(this.btnThemGV_Click);
            // 
            // txtSoTietDay
            // 
            this.txtSoTietDay.Location = new System.Drawing.Point(535, 71);
            this.txtSoTietDay.Name = "txtSoTietDay";
            this.txtSoTietDay.Size = new System.Drawing.Size(202, 26);
            this.txtSoTietDay.TabIndex = 14;
            // 
            // txtTienDayMotTiet
            // 
            this.txtTienDayMotTiet.Location = new System.Drawing.Point(189, 68);
            this.txtTienDayMotTiet.Name = "txtTienDayMotTiet";
            this.txtTienDayMotTiet.Size = new System.Drawing.Size(218, 26);
            this.txtTienDayMotTiet.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Số tiết dạy:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 74);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tiền dạy một tiết:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý nhân sự";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(723, 557);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 34);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 603);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "l";
            this.myTabControl.ResumeLayout(false);
            this.tabQuanLyNhanVien.ResumeLayout(false);
            this.tabQuanLyNhanVien.PerformLayout();
            this.tabQuanLyGiaoVien.ResumeLayout(false);
            this.tabQuanLyGiaoVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl myTabControl;
        private System.Windows.Forms.TabPage tabQuanLyNhanVien;
        private System.Windows.Forms.TabPage tabQuanLyGiaoVien;
        private System.Windows.Forms.ListView listNhanVien;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnCapNhatNV;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.TextBox txtHeSoLuongNV;
        private System.Windows.Forms.TextBox txtLuongCBNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ColumnHeader clHoTen;
        private System.Windows.Forms.ColumnHeader colChucVu;
        private System.Windows.Forms.ColumnHeader colHeSoLuong;
        private System.Windows.Forms.ColumnHeader colLuongCoBan;
        private System.Windows.Forms.TextBox txtChucVuNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHocVi;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listViewGV;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colHocVi;
        private System.Windows.Forms.ColumnHeader colTienDayMotTiet;
        private System.Windows.Forms.ColumnHeader colSoTietDay;
        private System.Windows.Forms.Button btnXoaGiaoVien;
        private System.Windows.Forms.Button btnCapNhatGV;
        private System.Windows.Forms.Button btnThemGV;
        private System.Windows.Forms.TextBox txtSoTietDay;
        private System.Windows.Forms.TextBox txtTienDayMotTiet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

