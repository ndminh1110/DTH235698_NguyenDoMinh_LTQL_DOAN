using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCaSi.Forms
{
    public partial class frmDangKi : Form
    {
        string connStr = @"Data Source=.;
                        Initial Catalog=QLCaSi;
                        Integrated Security=True;
                        TrustServerCertificate=True";
        public frmDangKi()
        {
            InitializeComponent();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            SqlConnection conn = new SqlConnection(connStr);

            string query = @"INSERT INTO TaiKhoan
                         VALUES(@user,@pass,'Staff','0')";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@user", txtTenDangNhap.Text);
            cmd.Parameters.AddWithValue("@pass", txtMatKhau.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Đăng ký thành công! Chờ Admin duyệt.");

            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                txtMatKhau.PasswordChar = '\0';
            else
                txtMatKhau.PasswordChar = '*';
        }

        private void frmDangKi_Load(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
        }
    }
}


