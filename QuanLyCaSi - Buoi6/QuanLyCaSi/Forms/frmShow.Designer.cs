
namespace QuanLyCaSi.Forms
{
    partial class frmShow
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
            lBH = new TextBox();
            BH = new Label();
            dtpNgDien = new DateTimePicker();
            label4 = new Label();
            txtMaShow = new TextBox();
            this.Ma = new Label();
            txtTenShow = new TextBox();
            Ten = new Label();
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
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Show";
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
            // lBH
            // 
            lBH.Location = new Point(432, 26);
            lBH.Multiline = true;
            lBH.Name = "lBH";
            lBH.Size = new Size(340, 88);
            lBH.TabIndex = 36;
            // 
            // BH
            // 
            BH.AutoSize = true;
            BH.Location = new Point(371, 29);
            BH.Name = "BH";
            BH.Size = new Size(55, 20);
            BH.TabIndex = 35;
            BH.Text = "Bài hát";
            // 
            // dtpNgDien
            // 
            dtpNgDien.Location = new Point(116, 93);
            dtpNgDien.Name = "dtpNgDien";
            dtpNgDien.Size = new Size(243, 27);
            dtpNgDien.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 98);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 32;
            label4.Text = "Ngày diễn ra";
            // 
            // txtMaShow
            // 
            txtMaShow.Location = new Point(102, 60);
            txtMaShow.Name = "txtMaShow";
            txtMaShow.Size = new Size(243, 27);
            txtMaShow.TabIndex = 38;
            // 
            // Ma
            // 
            this.Ma.AutoSize = true;
            this.Ma.Location = new Point(20, 63);
            this.Ma.Name = "Ma";
            this.Ma.Size = new Size(70, 20);
            this.Ma.TabIndex = 37;
            this.Ma.Text = "Mã Show";
            // 
            // txtTenShow
            // 
            txtTenShow.Location = new Point(102, 26);
            txtTenShow.Name = "txtTenShow";
            txtTenShow.Size = new Size(243, 27);
            txtTenShow.TabIndex = 40;
            // 
            // Ten
            // 
            Ten.AutoSize = true;
            Ten.Location = new Point(20, 29);
            Ten.Name = "Ten";
            Ten.Size = new Size(72, 20);
            Ten.TabIndex = 39;
            Ten.Text = "Tên Show";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnLuu);
            groupBox2.Controls.Add(btnHuy);
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(txtMaShow);
            groupBox2.Controls.Add(txtTenShow);
            groupBox2.Controls.Add(this.Ma);
            groupBox2.Controls.Add(BH);
            groupBox2.Controls.Add(lBH);
            groupBox2.Controls.Add(Ten);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(dtpNgDien);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(808, 177);
            groupBox2.TabIndex = 41;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin Show";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(34, 131);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 76;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(143, 131);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 77;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(252, 131);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 78;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(361, 131);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 79;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(471, 131);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 80;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(581, 131);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 81;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // frmShow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 453);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "frmShow";
            Text = "Show";
            Load += this.frmShow_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private TextBox lBH;
        private Label BH;
        private DateTimePicker dtpNgDien;
        private Label label4;
        private Button button7;
        private TextBox txtMaShow;
        private Label label1;
        private TextBox txtTenShow;
        private Label Ten;
        private GroupBox groupBox2;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private Button btnHuy;
        private Button btnThoat;
        private EventHandler frmShow_Load;
        private Control Ma;
    }
}