namespace QuanLyCaSi.Forms
{
    partial class frmCaSi
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
            dataGridView1 = new DataGridView();
            dtpNgSinh = new DateTimePicker();
            txtDChi = new TextBox();
            txtSDT = new TextBox();
            txtTenCS = new TextBox();
            radNu = new RadioButton();
            radNam = new RadioButton();
            Ma = new Label();
            Gtinh = new Label();
            NgSinh = new Label();
            DT = new Label();
            DChi = new Label();
            Ten = new Label();
            groupBox1 = new GroupBox();
            txtMaCS = new TextBox();
            groupBox2 = new GroupBox();
            txtCatXe = new TextBox();
            label1 = new Label();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            label2 = new Label();
            txtTacGia = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
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
            // dtpNgSinh
            // 
            dtpNgSinh.Location = new Point(406, 56);
            dtpNgSinh.Name = "dtpNgSinh";
            dtpNgSinh.Size = new Size(252, 27);
            dtpNgSinh.TabIndex = 41;
            // 
            // txtDChi
            // 
            txtDChi.Location = new Point(406, 91);
            txtDChi.Name = "txtDChi";
            txtDChi.Size = new Size(252, 27);
            txtDChi.TabIndex = 39;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(111, 87);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(194, 27);
            txtSDT.TabIndex = 38;
            // 
            // txtTenCS
            // 
            txtTenCS.Location = new Point(111, 22);
            txtTenCS.Name = "txtTenCS";
            txtTenCS.Size = new Size(194, 27);
            txtTenCS.TabIndex = 37;
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
            // Ma
            // 
            Ma.AutoSize = true;
            Ma.Location = new Point(27, 61);
            Ma.Name = "Ma";
            Ma.Size = new Size(63, 20);
            Ma.TabIndex = 34;
            Ma.Text = "Mã ca sĩ";
            Ma.Click += label6_Click;
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
            // NgSinh
            // 
            NgSinh.AutoSize = true;
            NgSinh.Location = new Point(326, 61);
            NgSinh.Name = "NgSinh";
            NgSinh.Size = new Size(74, 20);
            NgSinh.TabIndex = 32;
            NgSinh.Text = "Ngày sinh";
            // 
            // DT
            // 
            DT.AutoSize = true;
            DT.Location = new Point(27, 94);
            DT.Name = "DT";
            DT.Size = new Size(78, 20);
            DT.TabIndex = 31;
            DT.Text = "Điện thoại";
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
            // Ten
            // 
            Ten.AutoSize = true;
            Ten.Location = new Point(25, 29);
            Ten.Name = "Ten";
            Ten.Size = new Size(65, 20);
            Ten.TabIndex = 29;
            Ten.Text = "Tên ca sĩ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 272);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(808, 252);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ca sĩ";
            // 
            // txtMaCS
            // 
            txtMaCS.Location = new Point(111, 54);
            txtMaCS.Name = "txtMaCS";
            txtMaCS.Size = new Size(194, 27);
            txtMaCS.TabIndex = 42;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTacGia);
            groupBox2.Controls.Add(label2);
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
            groupBox2.Location = new Point(12, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(808, 223);
            groupBox2.TabIndex = 43;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin ca sĩ";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // txtCatXe
            // 
            txtCatXe.Location = new Point(111, 123);
            txtCatXe.Name = "txtCatXe";
            txtCatXe.Size = new Size(194, 27);
            txtCatXe.TabIndex = 83;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 126);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 82;
            label1.Text = "Catxe";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(24, 172);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 76;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(133, 172);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 77;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(326, 126);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 84;
            label2.Text = "Tác giả";
            // 
            // txtTacGia
            // 
            txtTacGia.Location = new Point(406, 126);
            txtTacGia.Name = "txtTacGia";
            txtTacGia.Size = new Size(252, 27);
            txtTacGia.TabIndex = 85;
            // 
            // frmCaSi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 556);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "frmCaSi";
            Text = "Ca Sĩ";
            Load += frmCaSi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DateTimePicker dtpNgSinh;
        private TextBox txtDChi;
        private TextBox txtSDT;
        private TextBox txtTenCS;
        private RadioButton radNu;
        private RadioButton radNam;
        private Label Ma;
        private Label Gtinh;
        private Label NgSinh;
        private Label DT;
        private Label DChi;
        private Label Ten;
        private GroupBox groupBox1;
        private TextBox txtMaCS;
        private GroupBox groupBox2;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Button btnHuy;
        private Button btnThoat;
        private TextBox txtCatXe;
        private Label label1;
        private TextBox txtTacGia;
        private Label label2;
    }
}