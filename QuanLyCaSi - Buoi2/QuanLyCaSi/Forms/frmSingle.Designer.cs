namespace QuanLyCaSi.Forms
{
    partial class frmSingle
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
            dgvBaiHat = new DataGridView();
            dtpNgPhat = new DateTimePicker();
            cboCSHoTro = new ComboBox();
            txtTG = new TextBox();
            txtCS = new TextBox();
            txtTen = new TextBox();
            CSHoTro = new Label();
            label5 = new Label();
            NgPhat = new Label();
            CaSi = new Label();
            TG = new Label();
            Ten = new Label();
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            Ma = new Label();
            txtMa = new TextBox();
            BaiHat = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvBaiHat).BeginInit();
            groupBox1.SuspendLayout();
            BaiHat.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBaiHat
            // 
            dgvBaiHat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBaiHat.Location = new Point(6, 26);
            dgvBaiHat.Name = "dgvBaiHat";
            dgvBaiHat.RowHeadersWidth = 51;
            dgvBaiHat.Size = new Size(796, 220);
            dgvBaiHat.TabIndex = 0;
            // 
            // dtpNgPhat
            // 
            dtpNgPhat.Location = new Point(475, 18);
            dtpNgPhat.Name = "dtpNgPhat";
            dtpNgPhat.Size = new Size(241, 27);
            dtpNgPhat.TabIndex = 81;
            // 
            // cboCSHoTro
            // 
            cboCSHoTro.FormattingEnabled = true;
            cboCSHoTro.Location = new Point(475, 52);
            cboCSHoTro.Name = "cboCSHoTro";
            cboCSHoTro.Size = new Size(241, 28);
            cboCSHoTro.TabIndex = 80;
            // 
            // txtTG
            // 
            txtTG.Location = new Point(475, 88);
            txtTG.Name = "txtTG";
            txtTG.Size = new Size(241, 27);
            txtTG.TabIndex = 79;
            // 
            // txtCS
            // 
            txtCS.Location = new Point(109, 88);
            txtCS.Name = "txtCS";
            txtCS.Size = new Size(226, 27);
            txtCS.TabIndex = 78;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(109, 20);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(226, 27);
            txtTen.TabIndex = 77;
            // 
            // CSHoTro
            // 
            CSHoTro.AutoSize = true;
            CSHoTro.Location = new Point(355, 60);
            CSHoTro.Name = "CSHoTro";
            CSHoTro.Size = new Size(84, 20);
            CSHoTro.TabIndex = 76;
            CSHoTro.Text = "Ca sĩ hỗ trợ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(338, 51);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 75;
            // 
            // NgPhat
            // 
            NgPhat.AutoSize = true;
            NgPhat.Location = new Point(355, 25);
            NgPhat.Name = "NgPhat";
            NgPhat.Size = new Size(114, 20);
            NgPhat.TabIndex = 74;
            NgPhat.Text = "Ngày phát hành";
            // 
            // CaSi
            // 
            CaSi.AutoSize = true;
            CaSi.Location = new Point(20, 95);
            CaSi.Name = "CaSi";
            CaSi.Size = new Size(40, 20);
            CaSi.TabIndex = 73;
            CaSi.Text = "Ca sĩ";
            // 
            // TG
            // 
            TG.AutoSize = true;
            TG.Location = new Point(355, 95);
            TG.Name = "TG";
            TG.Size = new Size(55, 20);
            TG.TabIndex = 72;
            TG.Text = "Tác giả";
            // 
            // Ten
            // 
            Ten.AutoSize = true;
            Ten.Location = new Point(20, 25);
            Ten.Name = "Ten";
            Ten.Size = new Size(82, 20);
            Ten.TabIndex = 71;
            Ten.Text = "Tên bài hát";
            Ten.Click += label1_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(570, 125);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 69;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(459, 125);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 68;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(349, 125);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 67;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(239, 125);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 66;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(129, 125);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 65;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(20, 125);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 64;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvBaiHat);
            groupBox1.Location = new Point(12, 182);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(808, 252);
            groupBox1.TabIndex = 63;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bài hát";
            // 
            // Ma
            // 
            Ma.AutoSize = true;
            Ma.Location = new Point(20, 60);
            Ma.Name = "Ma";
            Ma.Size = new Size(80, 20);
            Ma.TabIndex = 82;
            Ma.Text = "Mã bài hát";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(109, 53);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(226, 27);
            txtMa.TabIndex = 83;
            // 
            // BaiHat
            // 
            BaiHat.Controls.Add(txtMa);
            BaiHat.Controls.Add(txtTG);
            BaiHat.Controls.Add(Ma);
            BaiHat.Controls.Add(btnThem);
            BaiHat.Controls.Add(dtpNgPhat);
            BaiHat.Controls.Add(btnXoa);
            BaiHat.Controls.Add(cboCSHoTro);
            BaiHat.Controls.Add(btnSua);
            BaiHat.Controls.Add(btnLuu);
            BaiHat.Controls.Add(txtCS);
            BaiHat.Controls.Add(btnHuy);
            BaiHat.Controls.Add(txtTen);
            BaiHat.Controls.Add(btnThoat);
            BaiHat.Controls.Add(CSHoTro);
            BaiHat.Controls.Add(Ten);
            BaiHat.Controls.Add(TG);
            BaiHat.Controls.Add(NgPhat);
            BaiHat.Controls.Add(CaSi);
            BaiHat.Location = new Point(12, 12);
            BaiHat.Name = "BaiHat";
            BaiHat.Size = new Size(808, 164);
            BaiHat.TabIndex = 84;
            BaiHat.TabStop = false;
            BaiHat.Text = "Thông tin bài hát";
            // 
            // frmSingle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 453);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(BaiHat);
            Name = "frmSingle";
            Text = "Bài Hát";
            ((System.ComponentModel.ISupportInitialize)dgvBaiHat).EndInit();
            groupBox1.ResumeLayout(false);
            BaiHat.ResumeLayout(false);
            BaiHat.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBaiHat;
        private DateTimePicker dtpNgPhat;
        private ComboBox cboCSHoTro;
        private TextBox txtTG;
        private TextBox txtCS;
        private TextBox txtTen;
        private Label CSHoTro;
        private Label label5;
        private Label NgPhat;
        private Label CaSi;
        private Label TG;
        private Label Ten;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox1;
        private Label Ma;
        private TextBox txtMa;
        private GroupBox BaiHat;
    }
}