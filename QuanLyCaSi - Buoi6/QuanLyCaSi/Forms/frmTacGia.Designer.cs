namespace QuanLyCaSi.Forms
{
    partial class frmTacGia
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
            radNu = new RadioButton();
            dtpNgSinh = new DateTimePicker();
            btnThem = new Button();
            txtDChi = new TextBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            DChi = new Label();
            NgSinh = new Label();
            btnHuy = new Button();
            btnThoat = new Button();
            txtTenTG = new TextBox();
            Ten = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            txtSDT = new TextBox();
            Ma = new Label();
            DT = new Label();
            txtMaTG = new TextBox();
            groupBox2 = new GroupBox();
            radNam = new RadioButton();
            Gtinh = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
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
            // btnThem
            // 
            btnThem.Location = new Point(24, 172);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 76;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
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
            // 
            // btnSua
            // 
            btnSua.Location = new Point(242, 172);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 78;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(351, 172);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 79;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
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
            // btnHuy
            // 
            btnHuy.Location = new Point(461, 172);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 80;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(571, 172);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 81;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // txtTenTG
            // 
            txtTenTG.Location = new Point(111, 54);
            txtTenTG.Name = "txtTenTG";
            txtTenTG.Size = new Size(194, 27);
            txtTenTG.TabIndex = 42;
            // 
            // Ten
            // 
            Ten.AutoSize = true;
            Ten.Location = new Point(25, 29);
            Ten.Name = "Ten";
            Ten.Size = new Size(79, 20);
            Ten.TabIndex = 29;
            Ten.Text = "Mã tác giả";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(-4, 225);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(808, 252);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tác giả";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(796, 220);
            dataGridView1.TabIndex = 0;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(111, 87);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(194, 27);
            txtSDT.TabIndex = 38;
            // 
            // Ma
            // 
            Ma.AutoSize = true;
            Ma.Location = new Point(27, 61);
            Ma.Name = "Ma";
            Ma.Size = new Size(81, 20);
            Ma.TabIndex = 34;
            Ma.Text = "Tên tác giả";
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
            // txtMaTG
            // 
            txtMaTG.Location = new Point(111, 22);
            txtMaTG.Name = "txtMaTG";
            txtMaTG.Size = new Size(194, 27);
            txtMaTG.TabIndex = 37;
            // 
            // groupBox2
            // 
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
            groupBox2.Controls.Add(txtTenTG);
            groupBox2.Controls.Add(Ten);
            groupBox2.Controls.Add(txtSDT);
            groupBox2.Controls.Add(Ma);
            groupBox2.Controls.Add(DT);
            groupBox2.Controls.Add(txtMaTG);
            groupBox2.Location = new Point(2, -2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(774, 221);
            groupBox2.TabIndex = 45;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin tác giả";
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
            // Gtinh
            // 
            Gtinh.AutoSize = true;
            Gtinh.Location = new Point(326, 29);
            Gtinh.Name = "Gtinh";
            Gtinh.Size = new Size(65, 20);
            Gtinh.TabIndex = 33;
            Gtinh.Text = "Giới tính";
            // 
            // frmTacGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "frmTacGia";
            Text = "Tác giả";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton radNu;
        private DateTimePicker dtpNgSinh;
        private Button btnThem;
        private TextBox txtDChi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Label DChi;
        private Label NgSinh;
        private Button btnHuy;
        private Button btnThoat;
        private TextBox txtTenTG;
        private Label Ten;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private TextBox txtSDT;
        private Label Ma;
        private Label DT;
        private TextBox txtMaTG;
        private GroupBox groupBox2;
        private RadioButton radNam;
        private Label Gtinh;
    }
}