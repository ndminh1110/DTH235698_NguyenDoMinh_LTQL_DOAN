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
            txtTenBH = new TextBox();
            dtpNgLap = new DateTimePicker();
            ListBH = new Label();
            lBH = new TextBox();
            Ma = new Label();
            txtMaBH = new TextBox();
            groupBox2 = new GroupBox();
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
            groupBox1.Location = new Point(12, 189);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(808, 252);
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
            dataGridView1.Size = new Size(796, 234);
            dataGridView1.TabIndex = 0;
            // 
            // Ten
            // 
            Ten.AutoSize = true;
            Ten.Location = new Point(16, 33);
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
            // txtTenBH
            // 
            txtTenBH.Location = new Point(103, 27);
            txtTenBH.Name = "txtTenBH";
            txtTenBH.Size = new Size(225, 27);
            txtTenBH.TabIndex = 16;
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
            // lBH
            // 
            lBH.Location = new Point(411, 27);
            lBH.Multiline = true;
            lBH.Name = "lBH";
            lBH.Size = new Size(379, 92);
            lBH.TabIndex = 22;
            // 
            // Ma
            // 
            Ma.AutoSize = true;
            Ma.Location = new Point(18, 63);
            Ma.Name = "Ma";
            Ma.Size = new Size(78, 20);
            Ma.TabIndex = 23;
            Ma.Text = "Mã Album";
            // 
            // txtMaBH
            // 
            txtMaBH.Location = new Point(103, 60);
            txtMaBH.Name = "txtMaBH";
            txtMaBH.Size = new Size(225, 27);
            txtMaBH.TabIndex = 24;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnLuu);
            groupBox2.Controls.Add(btnHuy);
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(lBH);
            groupBox2.Controls.Add(txtMaBH);
            groupBox2.Controls.Add(ListBH);
            groupBox2.Controls.Add(Ten);
            groupBox2.Controls.Add(txtTenBH);
            groupBox2.Controls.Add(Ma);
            groupBox2.Controls.Add(NgLap);
            groupBox2.Controls.Add(dtpNgLap);
            groupBox2.Location = new Point(12, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(808, 168);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin Album";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(30, 127);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 70;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(139, 127);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 71;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(248, 127);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 72;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(357, 127);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 73;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(467, 127);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 74;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(577, 127);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 75;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // frmAlbum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 453);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "frmAlbum";
            Text = "Album";
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
        private TextBox txtTenBH;
        private DateTimePicker dtpNgLap;
        private Label ListBH;
        private TextBox lBH;
        private Label Ma;
        private TextBox txtMaBH;
        private GroupBox groupBox2;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Button btnHuy;
        private Button btnThoat;
    }
}