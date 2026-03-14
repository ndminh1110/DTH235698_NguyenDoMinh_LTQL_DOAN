namespace QuanLyCaSi.Forms
{
    partial class frmHOME
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
            homeToolStripMenuItem = new ToolStripMenuItem();
            menuCS = new ToolStripMenuItem();
            menuBH = new ToolStripMenuItem();
            menuAb = new ToolStripMenuItem();
            menuS = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            báoCáoThốngKêToolStripMenuItem = new ToolStripMenuItem();
            menuDT = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            menuDangNhap = new ToolStripMenuItem();
            menuDangXuat = new ToolStripMenuItem();
            menuThoat = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuCS, menuBH, menuAb, menuS });
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            // 
            // menuCS
            // 
            menuCS.Name = "menuCS";
            menuCS.Size = new Size(224, 26);
            menuCS.Text = "Quản lí &Ca sĩ";
            // 
            // menuBH
            // 
            menuBH.Name = "menuBH";
            menuBH.Size = new Size(224, 26);
            menuBH.Text = "Quản lí &Bài hát";
            // 
            // menuAb
            // 
            menuAb.Name = "menuAb";
            menuAb.Size = new Size(224, 26);
            menuAb.Text = "Quản lí &Album";
            // 
            // menuS
            // 
            menuS.Name = "menuS";
            menuS.Size = new Size(224, 26);
            menuS.Text = "Quản lí &Show diễn";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, báoCáoThốngKêToolStripMenuItem, trợGiúpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // báoCáoThốngKêToolStripMenuItem
            // 
            báoCáoThốngKêToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuDT });
            báoCáoThốngKêToolStripMenuItem.Name = "báoCáoThốngKêToolStripMenuItem";
            báoCáoThốngKêToolStripMenuItem.Size = new Size(152, 24);
            báoCáoThốngKêToolStripMenuItem.Text = "&Báo cáo - &Thống kê";
            // 
            // menuDT
            // 
            menuDT.Name = "menuDT";
            menuDT.Size = new Size(224, 26);
            menuDT.Text = "&Doanh thu";
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuDangNhap, menuDangXuat, menuThoat });
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(78, 24);
            trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // menuDangNhap
            // 
            menuDangNhap.Name = "menuDangNhap";
            menuDangNhap.Size = new Size(224, 26);
            menuDangNhap.Text = "Đăng &Nhập";
            // 
            // menuDangXuat
            // 
            menuDangXuat.Name = "menuDangXuat";
            menuDangXuat.Size = new Size(224, 26);
            menuDangXuat.Text = "Đăng &Xuất";
            // 
            // menuThoat
            // 
            menuThoat.Name = "menuThoat";
            menuThoat.Size = new Size(224, 26);
            menuThoat.Text = "&Thoát";
            // 
            // frmHOME
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmHOME";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem menuCS;
        private ToolStripMenuItem menuBH;
        private ToolStripMenuItem menuAb;
        private ToolStripMenuItem menuS;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem báoCáoThốngKêToolStripMenuItem;
        private ToolStripMenuItem menuDT;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private ToolStripMenuItem menuDangNhap;
        private ToolStripMenuItem menuDangXuat;
        private ToolStripMenuItem menuThoat;
    }
}