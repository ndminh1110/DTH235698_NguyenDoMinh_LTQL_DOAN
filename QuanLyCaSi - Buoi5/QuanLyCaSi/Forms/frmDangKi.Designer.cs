namespace QuanLyCaSi.Forms
{
    partial class frmDangKi
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
            label1 = new Label();
            label2 = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            checkBox1 = new CheckBox();
            btnDangKi = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 69);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 109);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(152, 66);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(125, 27);
            txtTenDangNhap.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(152, 109);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(125, 27);
            txtMatKhau.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(150, 142);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(127, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Hiện mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnDangKi
            // 
            btnDangKi.Location = new Point(75, 228);
            btnDangKi.Name = "btnDangKi";
            btnDangKi.Size = new Size(94, 29);
            btnDangKi.TabIndex = 5;
            btnDangKi.Text = "Đăng kí";
            btnDangKi.UseVisualStyleBackColor = true;
            btnDangKi.Click += btnDangKi_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(183, 228);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // frmDangKi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 429);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKi);
            Controls.Add(checkBox1);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDangKi";
            Text = "frmDangKi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private CheckBox checkBox1;
        private Button btnDangKi;
        private Button btnHuy;
    }
}