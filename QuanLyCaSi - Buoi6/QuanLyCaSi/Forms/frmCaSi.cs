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
    public partial class frmCaSi : Form
    {
        string connStr = @"Data Source=.;Initial Catalog=QLCaSi;Integrated Security=True;TrustServerCertificate=True";

        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        public frmCaSi()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        void LoadCaSi()
        {
            conn = new SqlConnection(connStr);

            string sql = "SELECT * FROM CaSi";

            da = new SqlDataAdapter(sql, conn);

            dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void frmCaSi_Load(object sender, EventArgs e)
        {
            LoadCaSi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaCS.Text = dataGridView1.Rows[e.RowIndex].Cells["MaCS"].Value.ToString();
                txtTenCS.Text = dataGridView1.Rows[e.RowIndex].Cells["TenCS"].Value.ToString();
                txtSDT.Text = dataGridView1.Rows[e.RowIndex].Cells["DienThoai"].Value.ToString();
                txtDChi.Text = dataGridView1.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                txtCatXe.Text = dataGridView1.Rows[e.RowIndex].Cells["CatXe"].Value.ToString();

                dtpNgSinh.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["NgaySinh"].Value);

                string gt = dataGridView1.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();

                if (gt == "Nam")
                    radNam.Checked = true;
                else
                    radNu.Checked = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaCS.Clear();
            txtTenCS.Clear();
            txtSDT.Clear();
            txtDChi.Clear();
            txtCatXe.Clear();

            radNam.Checked = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);

            string gt = radNam.Checked ? "Nam" : "Nữ";

            string sql = @"INSERT INTO CaSi
                           VALUES(@Ma,@Ten,@GT,@NS,@SDT,@DC,@CatXe)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Ma", txtMaCS.Text);
            cmd.Parameters.AddWithValue("@Ten", txtTenCS.Text);
            cmd.Parameters.AddWithValue("@GT", gt);
            cmd.Parameters.AddWithValue("@NS", dtpNgSinh.Value);
            cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
            cmd.Parameters.AddWithValue("@DC", txtDChi.Text);
            cmd.Parameters.AddWithValue("@CatXe", txtCatXe.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Thêm ca sĩ thành công");

            LoadCaSi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);

            string gt = radNam.Checked ? "Nam" : "Nữ";

            string sql = @"UPDATE CaSi
                           SET TenCS=@Ten,
                               GioiTinh=@GT,
                               NgaySinh=@NS,
                               DienThoai=@SDT,
                               DiaChi=@DC,
                               CatXe=@CatXe
                           WHERE MaCS=@Ma";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Ma", txtMaCS.Text);
            cmd.Parameters.AddWithValue("@Ten", txtTenCS.Text);
            cmd.Parameters.AddWithValue("@GT", gt);
            cmd.Parameters.AddWithValue("@NS", dtpNgSinh.Value);
            cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
            cmd.Parameters.AddWithValue("@DC", txtDChi.Text);
            cmd.Parameters.AddWithValue("@CatXe", txtCatXe.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Sửa thành công");

            LoadCaSi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);

            string sql = "DELETE FROM CaSi WHERE MaCS=@Ma";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Ma", txtMaCS.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Xóa thành công");

            LoadCaSi();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaCS.Clear();
            txtTenCS.Clear();
            txtSDT.Clear();
            txtDChi.Clear();
            txtCatXe.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
