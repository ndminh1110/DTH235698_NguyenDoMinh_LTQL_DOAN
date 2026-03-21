using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QuanLyCaSi
{
    public partial class frmDuyetStaff : Form
    {
        string connStr = @"Data Source=.;
                           Initial Catalog=QLCaSi;
                           Integrated Security=True;
                           TrustServerCertificate=True";

        public frmDuyetStaff()
        {
            InitializeComponent();
        }

        private void frmDuyetStaff_Load(object sender, EventArgs e)
        {
            LoadStaff();
        }

        void LoadStaff()
        {
            SqlConnection conn = new SqlConnection(connStr);

            string query = @"SELECT TenDangNhap, VaiTro, TrangThai
                             FROM TaiKhoan
                             WHERE VaiTro='Staff' AND TrangThai='0'";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadStaff();
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần duyệt");
                return;
            }

            string username = dataGridView1.CurrentRow.Cells["TenDangNhap"].Value.ToString();

            SqlConnection conn = new SqlConnection(connStr);

            string query = @"UPDATE TaiKhoan
                             SET TrangThai = '1'
                             WHERE TenDangNhap = @user";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@user", username);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Duyệt tài khoản thành công");

            LoadStaff();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}