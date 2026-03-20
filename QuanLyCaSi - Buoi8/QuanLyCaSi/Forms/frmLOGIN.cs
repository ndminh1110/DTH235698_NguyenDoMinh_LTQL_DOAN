using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QuanLyCaSi.Forms
{
    public partial class frmLOGIN : Form
    {
        string connStr = @"Data Source=.;
                        Initial Catalog=QLCaSi;
                        Integrated Security=True;
                        TrustServerCertificate=True";
        public frmLOGIN()
        {
            InitializeComponent();
        }
        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            cboChucVu.Items.Add("Admin");
            cboChucVu.Items.Add("Staff");
            cboChucVu.Items.Add("Guest");

            cboChucVu.SelectedIndex = 0; // chọn mặc định Admin

            txtMatKhau.UseSystemPasswordChar = true;
        }

        bool KiemTraDangNhap(string vaitro, string username, string password)
        {
            SqlConnection conn = new SqlConnection(connStr);

            string query = @"SELECT * FROM TaiKhoan
                             WHERE VaiTro = @vaitro
                             AND TenDangNhap = @user
                             AND (
                                    (VaiTro='Admin' AND MatKhau=@pass)
                                    OR
                                    (VaiTro='Staff' AND MatKhau=@pass AND TrangThai='1')
                                    OR
                                    (VaiTro='Guest')
                                 )";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@vaitro", vaitro);
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pass", password);

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            bool result = reader.HasRows;

            conn.Close();

            return result;
        }

        private void chkHienMK_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkHienMK.Checked;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            string vaitro = cboChucVu.Text;
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text.Trim();

            if (vaitro == "Guest")
            {
                MessageBox.Show("Đăng nhập với quyền Guest");

                this.Hide();
                frmHOME f = new frmHOME();
                f.Show();
                return;
            }

            if (vaitro == "" || username == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            if (KiemTraDangNhap(vaitro, username, password))
            {
                MessageBox.Show("Đăng nhập thành công");

                this.Hide();

                frmHOME f = new frmHOME();
                f.Show();
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập hoặc tài khoản chưa được duyệt");
            }
        }

        private void linkDangKi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKi f = new frmDangKi();
            f.ShowDialog();
        }

        private void cboChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChucVu.Text == "Guest")
            {
                txtTenDangNhap.Enabled = false;
                txtMatKhau.Enabled = false;
            }
            else
            {
                txtTenDangNhap.Enabled = true;
                txtMatKhau.Enabled = true;
            }
        }
    }
}
