namespace QuanLyCaSi
{
    partial class frmDuyetStaff
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
            btnDuyet = new Button();
            btnTaiLai = new Button();
            btnThoat = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnDuyet
            // 
            btnDuyet.Location = new Point(477, 333);
            btnDuyet.Name = "btnDuyet";
            btnDuyet.Size = new Size(94, 29);
            btnDuyet.TabIndex = 0;
            btnDuyet.Text = "Duyệt";
            btnDuyet.UseVisualStyleBackColor = true;
            btnDuyet.Click += btnDuyet_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Location = new Point(591, 333);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(94, 29);
            btnTaiLai.TabIndex = 1;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = true;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(703, 333);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(785, 302);
            dataGridView1.TabIndex = 3;
            // 
            // frmDuyetStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 516);
            Controls.Add(dataGridView1);
            Controls.Add(btnThoat);
            Controls.Add(btnTaiLai);
            Controls.Add(btnDuyet);
            Name = "frmDuyetStaff";
            Text = "frmDuyetStaff";
            Load += frmDuyetStaff_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDuyet;
        private Button btnTaiLai;
        private Button btnThoat;
        private DataGridView dataGridView1;
    }
}