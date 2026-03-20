namespace QuanLyCaSi.Forms
{
    partial class frmSINGER
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
            txtCatXe = new TextBox();
            label1 = new Label();
            radNu = new RadioButton();
            dtpNgSinh = new DateTimePicker();
            radNam = new RadioButton();
            btnThem = new Button();
            txtDChi = new TextBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            DChi = new Label();
            NgSinh = new Label();
            Gtinh = new Label();
            btnHuy = new Button();
            btnThoat = new Button();
            txtMaCS = new TextBox();
            Ten = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            txtSDT = new TextBox();
            Ma = new Label();
            txtTenCS = new TextBox();
            groupBox2 = new GroupBox();
            DT = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtCatXe
            // 
            txtCatXe.Location = new Point(111, 127);
            txtCatXe.Name = "txtCatXe";
            txtCatXe.Size = new Size(194, 27);
            txtCatXe.TabIndex = 83;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 130);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 82;
            label1.Text = "Catxe";
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(490, 22);
            radNu.Name = "radNu";
            radNu.Size = new Size(47, 24);
            radNu.TabIndex = 36;
            radNu.TabStop = true;
            radNu.Text = "nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // dtpNgSinh
            // 
            dtpNgSinh.Location = new Point(406, 56);
            dtpNgSinh.Name = "dtpNgSinh";
            dtpNgSinh.Size = new Size(252, 27);
            dtpNgSinh.TabIndex = 41;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(406, 23);
            radNam.Name = "radNam";
            radNam.Size = new Size(59, 24);
            radNam.TabIndex = 35;
            radNam.TabStop = true;
            radNam.Text = "nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(24, 172);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 76;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtDChi
            // 
            txtDChi.Location = new Point(406, 91);
            txtDChi.Name = "txtDChi";
            txtDChi.Size = new Size(252, 27);
            txtDChi.TabIndex = 39;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(133, 172);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 77;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(242, 172);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 78;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(351, 172);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 79;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // DChi
            // 
            DChi.AutoSize = true;
            DChi.Location = new Point(326, 94);
            DChi.Name = "DChi";
            DChi.Size = new Size(55, 20);
            DChi.TabIndex = 30;
            DChi.Text = "Địa chỉ";
            // 
            // NgSinh
            // 
            NgSinh.AutoSize = true;
            NgSinh.Location = new Point(326, 61);
            NgSinh.Name = "NgSinh";
            NgSinh.Size = new Size(74, 20);
            NgSinh.TabIndex = 32;
            NgSinh.Text = "Ngày sinh";
            // 
            // Gtinh
            // 
            Gtinh.AutoSize = true;
            Gtinh.Location = new Point(326, 29);
            Gtinh.Name = "Gtinh";
            Gtinh.Size = new Size(65, 20);
            Gtinh.TabIndex = 33;
            Gtinh.Text = "Giới tính";
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(461, 172);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 80;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(571, 172);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 81;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtMaCS
            // 
            txtMaCS.Location = new Point(111, 23);
            txtMaCS.Name = "txtMaCS";
            txtMaCS.Size = new Size(194, 27);
            txtMaCS.TabIndex = 42;
            // 
            // Ten
            // 
            Ten.AutoSize = true;
            Ten.Location = new Point(27, 56);
            Ten.Name = "Ten";
            Ten.Size = new Size(65, 20);
            Ten.TabIndex = 29;
            Ten.Text = "Tên ca sĩ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(41, 254);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(808, 252);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ca sĩ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(796, 220);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(111, 94);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(194, 27);
            txtSDT.TabIndex = 38;
            // 
            // Ma
            // 
            Ma.AutoSize = true;
            Ma.Location = new Point(27, 29);
            Ma.Name = "Ma";
            Ma.Size = new Size(63, 20);
            Ma.TabIndex = 34;
            Ma.Text = "Mã ca sĩ";
            // 
            // txtTenCS
            // 
            txtTenCS.Location = new Point(111, 61);
            txtTenCS.Name = "txtTenCS";
            txtTenCS.Size = new Size(194, 27);
            txtTenCS.TabIndex = 37;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCatXe);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(radNu);
            groupBox2.Controls.Add(dtpNgSinh);
            groupBox2.Controls.Add(radNam);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(txtDChi);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnLuu);
            groupBox2.Controls.Add(DChi);
            groupBox2.Controls.Add(NgSinh);
            groupBox2.Controls.Add(Gtinh);
            groupBox2.Controls.Add(btnHuy);
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(txtMaCS);
            groupBox2.Controls.Add(Ten);
            groupBox2.Controls.Add(txtSDT);
            groupBox2.Controls.Add(Ma);
            groupBox2.Controls.Add(DT);
            groupBox2.Controls.Add(txtTenCS);
            groupBox2.Location = new Point(41, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(808, 223);
            groupBox2.TabIndex = 45;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin ca sĩ";
            // 
            // DT
            // 
            DT.AutoSize = true;
            DT.Location = new Point(24, 94);
            DT.Name = "DT";
            DT.Size = new Size(78, 20);
            DT.TabIndex = 31;
            DT.Text = "Điện thoại";
            // 
            // frmSINGER
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 502);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "frmSINGER";
            Text = "SINGER";
            Load += frmSINGER_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtCatXe;
        private Label label1;
        private RadioButton radNu;
        private DateTimePicker dtpNgSinh;
        private RadioButton radNam;
        private Button btnThem;
        private TextBox txtDChi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Label DChi;
        private Label NgSinh;
        private Label Gtinh;
        private Button btnHuy;
        private Button btnThoat;
        private TextBox txtMaCS;
        private Label Ten;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private TextBox txtSDT;
        private Label Ma;
        private TextBox txtTenCS;
        private GroupBox groupBox2;
        private Label DT;
    }
}