namespace QuanLyCaSi.Forms
{
    partial class frmSHOW
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
            lCS = new ListBox();
            label1 = new Label();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            listCS = new Label();
            Ten = new Label();
            txtTenShow = new TextBox();
            Ma = new Label();
            NgLap = new Label();
            dtpNgLap = new DateTimePicker();
            txtMaShow = new TextBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            txtSoLuong = new TextBox();
            txtGiaVe = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lCS
            // 
            lCS.FormattingEnabled = true;
            lCS.Location = new Point(350, 67);
            lCS.Name = "lCS";
            lCS.SelectionMode = SelectionMode.MultiSimple;
            lCS.Size = new Size(378, 104);
            lCS.TabIndex = 78;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 124);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 76;
            label1.Text = "Giá vé";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(16, 182);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 70;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(125, 182);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 71;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(234, 182);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 72;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(343, 182);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 73;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(453, 182);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 74;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(563, 182);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 75;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 252);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(808, 199);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Album";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(796, 167);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // listCS
            // 
            listCS.AutoSize = true;
            listCS.Location = new Point(350, 33);
            listCS.Name = "listCS";
            listCS.Size = new Size(103, 20);
            listCS.TabIndex = 21;
            listCS.Text = "Ca sĩ tham gia";
            // 
            // Ten
            // 
            Ten.AutoSize = true;
            Ten.Location = new Point(16, 65);
            Ten.Name = "Ten";
            Ten.Size = new Size(74, 20);
            Ten.TabIndex = 8;
            Ten.Text = "Tên  show";
            // 
            // txtTenShow
            // 
            txtTenShow.Location = new Point(103, 59);
            txtTenShow.Name = "txtTenShow";
            txtTenShow.Size = new Size(225, 27);
            txtTenShow.TabIndex = 16;
            // 
            // Ma
            // 
            Ma.AutoSize = true;
            Ma.Location = new Point(18, 30);
            Ma.Name = "Ma";
            Ma.Size = new Size(68, 20);
            Ma.TabIndex = 23;
            Ma.Text = "Mã show";
            // 
            // NgLap
            // 
            NgLap.AutoSize = true;
            NgLap.Location = new Point(18, 92);
            NgLap.Name = "NgLap";
            NgLap.Size = new Size(77, 20);
            NgLap.TabIndex = 11;
            NgLap.Text = "Ngày diễn";
            // 
            // dtpNgLap
            // 
            dtpNgLap.Location = new Point(103, 92);
            dtpNgLap.Name = "dtpNgLap";
            dtpNgLap.Size = new Size(240, 27);
            dtpNgLap.TabIndex = 20;
            // 
            // txtMaShow
            // 
            txtMaShow.Location = new Point(103, 27);
            txtMaShow.Name = "txtMaShow";
            txtMaShow.Size = new Size(225, 27);
            txtMaShow.TabIndex = 24;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtSoLuong);
            groupBox2.Controls.Add(txtGiaVe);
            groupBox2.Controls.Add(lCS);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnLuu);
            groupBox2.Controls.Add(btnHuy);
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(txtMaShow);
            groupBox2.Controls.Add(listCS);
            groupBox2.Controls.Add(Ten);
            groupBox2.Controls.Add(txtTenShow);
            groupBox2.Controls.Add(Ma);
            groupBox2.Controls.Add(NgLap);
            groupBox2.Controls.Add(dtpNgLap);
            groupBox2.Location = new Point(12, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(808, 228);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin Album";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 151);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 81;
            label2.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(103, 149);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(225, 27);
            txtSoLuong.TabIndex = 80;
            // 
            // txtGiaVe
            // 
            txtGiaVe.Location = new Point(103, 121);
            txtGiaVe.Name = "txtGiaVe";
            txtGiaVe.Size = new Size(225, 27);
            txtGiaVe.TabIndex = 79;
            // 
            // SHOW
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 487);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "SHOW";
            Text = "SHOW";
            Load += SHOW_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lCS;
        private Label label1;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Button btnHuy;
        private Button btnThoat;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label listCS;
        private Label Ten;
        private TextBox txtTenShow;
        private Label Ma;
        private Label NgLap;
        private DateTimePicker dtpNgLap;
        private TextBox txtMaShow;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox txtSoLuong;
        private TextBox txtGiaVe;
    }
}