namespace QuanLyCaSi.Forms
{
    partial class frmLOGIN
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
            linkDangKi = new LinkLabel();
            cboChucVu = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            btnHuy = new Button();
            btnOK = new Button();
            chkHienMK = new CheckBox();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // linkDangKi
            // 
            linkDangKi.AutoSize = true;
            linkDangKi.Location = new Point(210, 318);
            linkDangKi.Name = "linkDangKi";
            linkDangKi.Size = new Size(54, 20);
            linkDangKi.TabIndex = 31;
            linkDangKi.TabStop = true;
            linkDangKi.Text = "tại đây";
            linkDangKi.LinkClicked += linkDangKi_LinkClicked;
            // 
            // cboChucVu
            // 
            cboChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Location = new Point(111, 19);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(184, 28);
            cboChucVu.TabIndex = 30;
            cboChucVu.SelectedIndexChanged += cboChucVu_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 318);
            label4.Name = "label4";
            label4.Size = new Size(156, 20);
            label4.TabIndex = 32;
            label4.Text = "đăng kí tài khoản staff";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 69);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 29;
            label3.Text = "Tên";
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(171, 196);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(99, 37);
            btnHuy.TabIndex = 28;
            btnHuy.Text = "huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(48, 196);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(104, 37);
            btnOK.TabIndex = 27;
            btnOK.Text = "đăng nhập";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click_1;
            // 
            // chkHienMK
            // 
            chkHienMK.AutoSize = true;
            chkHienMK.Location = new Point(171, 139);
            chkHienMK.Name = "chkHienMK";
            chkHienMK.Size = new Size(124, 24);
            chkHienMK.TabIndex = 26;
            chkHienMK.Text = "hiện mật khẩu";
            chkHienMK.UseVisualStyleBackColor = true;
            chkHienMK.CheckedChanged += chkHienMK_CheckedChanged;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(111, 106);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(184, 27);
            txtMatKhau.TabIndex = 25;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(111, 62);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(184, 27);
            txtTenDangNhap.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 113);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 23;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 19);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 22;
            label1.Text = "Chức vụ";
            // 
            // frmLOGIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 344);
            Controls.Add(linkDangKi);
            Controls.Add(cboChucVu);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnHuy);
            Controls.Add(btnOK);
            Controls.Add(chkHienMK);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLOGIN";
            Text = "Đăng nhập";
            Load += FormDangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkDangKi;
        private ComboBox cboChucVu;
        private Label label4;
        private Label label3;
        private Button btnHuy;
        private Button btnOK;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private Label label2;
        private Label label1;
        public CheckBox chkHienMK;
    }
}