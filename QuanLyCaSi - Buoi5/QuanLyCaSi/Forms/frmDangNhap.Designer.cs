namespace QuanLyCaSi
{
    partial class frmDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            cboChucVu = new ComboBox();
            label3 = new Label();
            btnHuy = new Button();
            btnOK = new Button();
            chkHienMK = new CheckBox();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            label2 = new Label();
            label1 = new Label();
            linkDangKi = new LinkLabel();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkDangKi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cboChucVu);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnOK);
            groupBox1.Controls.Add(chkHienMK);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(37, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(452, 280);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Talent Management";
            // 
            // cboChucVu
            // 
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Location = new Point(130, 36);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(254, 28);
            cboChucVu.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 79);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 7;
            label3.Text = "Tên";
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(249, 178);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(99, 37);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(130, 178);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(104, 37);
            btnOK.TabIndex = 5;
            btnOK.Text = "ok";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click_1;
            // 
            // chkHienMK
            // 
            chkHienMK.AutoSize = true;
            chkHienMK.Location = new Point(260, 148);
            chkHienMK.Name = "chkHienMK";
            chkHienMK.Size = new Size(124, 24);
            chkHienMK.TabIndex = 4;
            chkHienMK.Text = "hiện mật khẩu";
            chkHienMK.UseVisualStyleBackColor = true;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(130, 115);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(254, 27);
            txtMatKhau.TabIndex = 3;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(130, 76);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(254, 27);
            txtTenDangNhap.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 120);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 38);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Chức vụ";
            // 
            // linkDangKi
            // 
            linkDangKi.AutoSize = true;
            linkDangKi.Location = new Point(249, 227);
            linkDangKi.Name = "linkDangKi";
            linkDangKi.Size = new Size(54, 20);
            linkDangKi.TabIndex = 9;
            linkDangKi.TabStop = true;
            linkDangKi.Text = "tại đây";
            linkDangKi.LinkClicked += linkDangKi_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 227);
            label4.Name = "label4";
            label4.Size = new Size(156, 20);
            label4.TabIndex = 10;
            label4.Text = "đăng kí tài khoản staff";
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 353);
            Controls.Add(groupBox1);
            Name = "frmDangNhap";
            Text = "Đăng Nhập";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private Label label2;
        private Label label1;
        private Button btnHuy;
        private Button btnOK;
        private CheckBox chkHienMK;
        private Label label3;
        private ComboBox cboChucVu;
        private LinkLabel linkDangKi;
        private Label label4;
    }
}
