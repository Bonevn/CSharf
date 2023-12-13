namespace Bai28
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnThemGoc = new System.Windows.Forms.Button();
            this.btnThemcon = new System.Windows.Forms.Button();
            this.btnxoatatca = new System.Windows.Forms.Button();
            this.btnxoadangchon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(34, 63);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(202, 253);
            this.treeView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TreeView";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TreeView";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(355, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btnThemGoc
            // 
            this.btnThemGoc.Location = new System.Drawing.Point(356, 80);
            this.btnThemGoc.Name = "btnThemGoc";
            this.btnThemGoc.Size = new System.Drawing.Size(131, 24);
            this.btnThemGoc.TabIndex = 4;
            this.btnThemGoc.Text = "Thêm node gốc";
            this.btnThemGoc.UseVisualStyleBackColor = true;
            this.btnThemGoc.Click += new System.EventHandler(this.btnThemGoc_Click);
            // 
            // btnThemcon
            // 
            this.btnThemcon.Location = new System.Drawing.Point(356, 125);
            this.btnThemcon.Name = "btnThemcon";
            this.btnThemcon.Size = new System.Drawing.Size(131, 24);
            this.btnThemcon.TabIndex = 5;
            this.btnThemcon.Text = "Thêm node con tại vị trí chọn";
            this.btnThemcon.UseVisualStyleBackColor = true;
            this.btnThemcon.Click += new System.EventHandler(this.btnThemcon_Click);
            // 
            // btnxoatatca
            // 
            this.btnxoatatca.Location = new System.Drawing.Point(356, 170);
            this.btnxoatatca.Name = "btnxoatatca";
            this.btnxoatatca.Size = new System.Drawing.Size(131, 24);
            this.btnxoatatca.TabIndex = 6;
            this.btnxoatatca.Text = "Xoá tất cả các node";
            this.btnxoatatca.UseVisualStyleBackColor = true;
            this.btnxoatatca.Click += new System.EventHandler(this.btnxoatatca_Click);
            // 
            // btnxoadangchon
            // 
            this.btnxoadangchon.Location = new System.Drawing.Point(356, 215);
            this.btnxoadangchon.Name = "btnxoadangchon";
            this.btnxoadangchon.Size = new System.Drawing.Size(131, 24);
            this.btnxoadangchon.TabIndex = 7;
            this.btnxoadangchon.Text = "Xoá node đang chọn";
            this.btnxoadangchon.UseVisualStyleBackColor = true;
            this.btnxoadangchon.Click += new System.EventHandler(this.btnxoadangchon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(356, 260);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(131, 24);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 344);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnxoadangchon);
            this.Controls.Add(this.btnxoatatca);
            this.Controls.Add(this.btnThemcon);
            this.Controls.Add(this.btnThemGoc);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnThemGoc;
        private System.Windows.Forms.Button btnThemcon;
        private System.Windows.Forms.Button btnxoatatca;
        private System.Windows.Forms.Button btnxoadangchon;
        private System.Windows.Forms.Button btnThoat;
    }
}

