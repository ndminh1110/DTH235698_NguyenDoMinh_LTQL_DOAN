namespace QuanLyCaSi.Forms
{
    partial class frmAlbum
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
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            Ten = new Label();
            NgLap = new Label();
            txtTenAlbum = new TextBox();
            dtpNgLap = new DateTimePicker();
            ListBH = new Label();
            Ma = new Label();
            txtMaAlbum = new TextBox();
            groupBox2 = new GroupBox();
            lBH = new ListBox();
            cboCS = new ComboBox();
            label1 = new Label();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 242);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(808, 199);
            groupBox1.TabIndex = 0;
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
            // Ten
            // 
            Ten.AutoSize = true;
            Ten.Location = new Point(16, 65);
            Ten.Name = "Ten";
            Ten.Size = new Size(80, 20);
            Ten.TabIndex = 8;
            Ten.Text = "Tên Album";
            // 
            // NgLap
            // 
            NgLap.AutoSize = true;
            NgLap.Location = new Point(18, 92);
            NgLap.Name = "NgLap";
            NgLap.Size = new Size(69, 20);
            NgLap.TabIndex = 11;
            NgLap.Text = "Ngày lập";
            // 
            // txtTenAlbum
            // 
            txtTenAlbum.Location = new Point(103, 59);
            txtTenAlbum.Name = "txtTenAlbum";
            txtTenAlbum.Size = new Size(225, 27);
            txtTenAlbum.TabIndex = 16;
            // 
            // dtpNgLap
            // 
            dtpNgLap.Location = new Point(103, 92);
            dtpNgLap.Name = "dtpNgLap";
            dtpNgLap.Size = new Size(240, 27);
            dtpNgLap.TabIndex = 20;
            // 
            // ListBH
            // 
            ListBH.AutoSize = true;
            ListBH.Location = new Point(350, 33);
            ListBH.Name = "ListBH";
            ListBH.Size = new Size(55, 20);
            ListBH.TabIndex = 21;
            ListBH.Text = "Bài hát";
            // 
            // Ma
            // 
            Ma.AutoSize = true;
            Ma.Location = new Point(18, 30);
            Ma.Name = "Ma";
            Ma.Size = new Size(78, 20);
            Ma.TabIndex = 23;
            Ma.Text = "Mã Album";
            // 
            // txtMaAlbum
            // 
            txtMaAlbum.Location = new Point(103, 27);
            txtMaAlbum.Name = "txtMaAlbum";
            txtMaAlbum.Size = new Size(225, 27);
            txtMaAlbum.TabIndex = 24;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lBH);
            groupBox2.Controls.Add(cboCS);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnLuu);
            groupBox2.Controls.Add(btnHuy);
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(txtMaAlbum);
            groupBox2.Controls.Add(ListBH);
            groupBox2.Controls.Add(Ten);
            groupBox2.Controls.Add(txtTenAlbum);
            groupBox2.Controls.Add(Ma);
            groupBox2.Controls.Add(NgLap);
            groupBox2.Controls.Add(dtpNgLap);
            groupBox2.Location = new Point(12, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(808, 228);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin Album";
            // 
            // lBH
            // 
            lBH.FormattingEnabled = true;
            lBH.Location = new Point(411, 27);
            lBH.Name = "lBH";
            lBH.SelectionMode = SelectionMode.MultiSimple;
            lBH.Size = new Size(317, 144);
            lBH.TabIndex = 78;
            // 
            // cboCS
            // 
            cboCS.FormattingEnabled = true;
            cboCS.Location = new Point(103, 134);
            cboCS.Name = "cboCS";
            cboCS.Size = new Size(151, 28);
            cboCS.TabIndex = 77;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 134);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 76;
            label1.Text = "Ca six";
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
            // frmAlbum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 523);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "frmAlbum";
            Text = "Album";
            Load += frmAlbum_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label Ten;
        private Label NgLap;
        private TextBox txtTenAlbum;
        private DateTimePicker dtpNgLap;
        private Label ListBH;
        private Label Ma;
        private TextBox txtMaAlbum;
        private GroupBox groupBox2;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Button btnHuy;
        private Button btnThoat;
        private ComboBox cboCS;
        private Label label1;
        private ListBox lBH;
    }
}