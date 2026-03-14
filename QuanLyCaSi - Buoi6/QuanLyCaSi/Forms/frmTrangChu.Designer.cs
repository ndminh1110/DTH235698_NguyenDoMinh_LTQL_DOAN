namespace QuanLyCaSi.Forms
{
    partial class frmTrangChu
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
            btnShow = new Button();
            btnSingle = new Button();
            btnAbum = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnDuyet
            // 
            btnDuyet.Location = new Point(634, 212);
            btnDuyet.Name = "btnDuyet";
            btnDuyet.Size = new Size(94, 29);
            btnDuyet.TabIndex = 9;
            btnDuyet.Text = "Duyệt";
            btnDuyet.UseVisualStyleBackColor = true;
            btnDuyet.Click += btnDuyet_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(479, 212);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 29);
            btnShow.TabIndex = 8;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnSingle
            // 
            btnSingle.Location = new Point(340, 212);
            btnSingle.Name = "btnSingle";
            btnSingle.Size = new Size(94, 29);
            btnSingle.TabIndex = 7;
            btnSingle.Text = "Single";
            btnSingle.UseVisualStyleBackColor = true;
            btnSingle.Click += btnSingle_Click;
            // 
            // btnAbum
            // 
            btnAbum.Location = new Point(191, 212);
            btnAbum.Name = "btnAbum";
            btnAbum.Size = new Size(94, 29);
            btnAbum.TabIndex = 6;
            btnAbum.Text = "Album";
            btnAbum.UseVisualStyleBackColor = true;
            btnAbum.Click += btnAbum_Click;
            // 
            // button1
            // 
            button1.Location = new Point(59, 212);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Ca sĩ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmTrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(btnDuyet);
            Controls.Add(btnShow);
            Controls.Add(btnSingle);
            Controls.Add(btnAbum);
            Controls.Add(button1);
            Name = "frmTrangChu";
            Text = "frmStaff";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDuyet;
        private Button btnShow;
        private Button btnSingle;
        private Button btnAbum;
        private Button button1;
    }
}