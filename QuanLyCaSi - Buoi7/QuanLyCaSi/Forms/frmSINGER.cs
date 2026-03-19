using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QuanLyCaSi.Forms
{
    public partial class frmSINGER : Form
    {
        DataTable dtCS = new DataTable();
        
        string connectionString = @"Data Source=.;Initial Catalog=QlCaSi;Integrated Security=True;TrustServerCertificate=True";

        List<string> danhSachMaXoa = new List<string>();
        public frmSINGER()
        {
            InitializeComponent();
        }

        // ===================== LOAD DỮ LIỆU =====================
        private void LoadData()
        {
            dtCS.Clear();
            dtCS.Columns.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"SELECT MaCS, TenCS,
                                      GTinh  AS GioiTinh,
                                      NgSinh AS NgaySinh,
                                      SDT    AS DienThoai,
                                      DChi   AS DiaChi,
                                      CatXe
                               FROM dbo.CaSi
                               ORDER BY MaCS";
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    da.Fill(dtCS);
                }
            }
        }

        // ===================== SINH MÃ TỰ ĐỘNG =====================
        private string TaoMaTuDong()
        {
            HashSet<int> danhSachMa = new HashSet<int>();

            // Lấy mã từ DB
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT MaCS FROM dbo.CaSi";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string ma = reader["MaCS"].ToString();
                        if (ma.StartsWith("CS") && int.TryParse(ma.Substring(2), out int num))
                            danhSachMa.Add(num);
                    }
                }
            }

            // Lấy mã từ dtCS (các dòng chưa lưu)
            foreach (DataRow row in dtCS.Rows)
            {
                string ma = row["MaCS"].ToString();
                if (ma.StartsWith("CS") && int.TryParse(ma.Substring(2), out int num))
                    danhSachMa.Add(num);
            }

            // Tìm số nhỏ nhất chưa dùng bắt đầu từ 1
            int next = 1;
            while (danhSachMa.Contains(next)) next++;

            return "CS" + next.ToString("0000");
        }

        // ===================== XÓA FORM =====================
        private void ClearForm()
        {
            txtMaCS.Text = TaoMaTuDong();
            txtTenCS.Clear();
            txtSDT.Clear();
            txtDChi.Clear();
            txtCatXe.Clear();
            radNam.Checked = true;
            dtpNgSinh.Value = DateTime.Now;
        }

        // ===================== VALIDATE SỐ ĐIỆN THOẠI =====================
        private bool KiemTraSDT(string sdt)
        {
            if (string.IsNullOrWhiteSpace(sdt) || !sdt.StartsWith("0") || sdt.Length != 10 || !sdt.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!\nPhải bắt đầu bằng số 0, đủ 10 chữ số và không chứa ký tự đặc biệt.",
                    "Số điện thoại không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                txtSDT.SelectAll();
                return false;
            }
            return true;
        }

        // ===================== FORM LOAD =====================
        private void frmSINGER_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dtCS;
            txtMaCS.Enabled = false;
            dataGridView1.AutoGenerateColumns = true;

            LoadData();
            txtMaCS.Text = TaoMaTuDong();
        }

        // ===================== THÊM =====================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenCS.Text) && string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên ca sĩ và Số điện thoại!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenCS.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenCS.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên ca sĩ!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenCS.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            if (!KiemTraSDT(txtSDT.Text)) return;

            DataRow row = dtCS.NewRow();
            string ma = TaoMaTuDong();
            row["MaCS"]      = ma;
            row["TenCS"]     = txtTenCS.Text.Trim();
            row["GioiTinh"]  = radNam.Checked ? "Nam" : "Nữ";
            row["NgaySinh"]  = dtpNgSinh.Value;
            row["DienThoai"] = txtSDT.Text.Trim();
            row["DiaChi"]    = txtDChi.Text.Trim();
            row["CatXe"]     = txtCatXe.Text.Trim();
            dtCS.Rows.Add(row);

            ClearForm();
        }

        // ===================== SỬA =====================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0) return;

            if (string.IsNullOrWhiteSpace(txtTenCS.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên ca sĩ!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenCS.Focus();
                return;
            }
            if (!KiemTraSDT(txtSDT.Text)) return;

            int i = dataGridView1.CurrentRow.Index;
            dtCS.Rows[i]["TenCS"]     = txtTenCS.Text.Trim();
            dtCS.Rows[i]["GioiTinh"]  = radNam.Checked ? "Nam" : "Nữ";
            dtCS.Rows[i]["NgaySinh"]  = dtpNgSinh.Value;
            dtCS.Rows[i]["DienThoai"] = txtSDT.Text.Trim();
            dtCS.Rows[i]["DiaChi"]    = txtDChi.Text.Trim();
            dtCS.Rows[i]["CatXe"]     = txtCatXe.Text.Trim();

            ClearForm();
        }

        // ===================== XÓA =====================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0) return;

            string maXoa = dtCS.Rows[dataGridView1.CurrentRow.Index]["MaCS"].ToString();

            var confirm = MessageBox.Show($"Bạn có chắc muốn xóa ca sĩ '{maXoa}' không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            // Chỉ thêm vào danh sách xóa nếu mã đã tồn tại trong DB
            if (!string.IsNullOrEmpty(maXoa))
                danhSachMaXoa.Add(maXoa);

            dtCS.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            ClearForm();
        }

        // ===================== LƯU =====================
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra SDT trùng với DB (chỉ các dòng mới)
            using (SqlConnection connCheck = new SqlConnection(connectionString))
            {
                connCheck.Open();
                foreach (DataRow row in dtCS.Rows)
                {
                    string sdt = row["DienThoai"]?.ToString();
                    string maCS = row["MaCS"]?.ToString();

                    string checkSql = "SELECT COUNT(*) FROM dbo.CaSi WHERE SDT = @SDT AND MaCS != @MaCS";
                    using (SqlCommand cmd = new SqlCommand(checkSql, connCheck))
                    {
                        cmd.Parameters.AddWithValue("@SDT", sdt);
                        cmd.Parameters.AddWithValue("@MaCS", maCS);
                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show($"Số điện thoại '{sdt}' đã tồn tại trong hệ thống!",
                                "Trùng số điện thoại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        // 1. XÓA các dòng đã bị xóa khỏi DataTable
                        foreach (string maXoa in danhSachMaXoa)
                        {
                            string deleteSql = "DELETE FROM dbo.CaSi WHERE MaCS = @MaCS";
                            using (var del = new SqlCommand(deleteSql, conn, tran))
                            {
                                del.Parameters.AddWithValue("@MaCS", maXoa);
                                del.ExecuteNonQuery();
                            }
                        }
                        danhSachMaXoa.Clear();

                        // 2. INSERT / UPDATE các dòng còn lại
                        foreach (DataRow row in dtCS.Rows)
                        {
                            string maCS = row["MaCS"]?.ToString();
                            string tenCS = row["TenCS"]?.ToString();
                            string gioiTinh = row["GioiTinh"]?.ToString();
                            string dienThoai = row["DienThoai"]?.ToString();
                            string diaChi = row["DiaChi"]?.ToString();
                            string catXe = row["CatXe"]?.ToString();

                            DateTime? ngaySinh = null;
                            if (row["NgaySinh"] != null && row["NgaySinh"] != DBNull.Value)
                            {
                                if (row["NgaySinh"] is DateTime dt) ngaySinh = dt;
                                else if (DateTime.TryParse(row["NgaySinh"].ToString(), out var parsed)) ngaySinh = parsed;
                            }

                            // Thử UPDATE trước
                            string updateSql = @"UPDATE dbo.CaSi
                                                 SET TenCS  = @TenCS,
                                                     GTinh  = @GioiTinh,
                                                     NgSinh = @NgaySinh,
                                                     SDT    = @DienThoai,
                                                     DChi   = @DiaChi,
                                                     CatXe  = @CatXe
                                                 WHERE MaCS = @MaCS";

                            using (var cmd = new SqlCommand(updateSql, conn, tran))
                            {
                                cmd.Parameters.Add("@MaCS", SqlDbType.NVarChar, 50).Value  = (object)maCS      ?? DBNull.Value;
                                cmd.Parameters.Add("@TenCS", SqlDbType.NVarChar, 200).Value = (object)tenCS     ?? DBNull.Value;
                                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 10).Value  = (object)gioiTinh  ?? DBNull.Value;
                                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value          = ngaySinh.HasValue ? (object)ngaySinh.Value : DBNull.Value;
                                cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar, 50).Value  = (object)dienThoai ?? DBNull.Value;
                                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 200).Value = (object)diaChi   ?? DBNull.Value;
                                cmd.Parameters.Add("@CatXe", SqlDbType.NVarChar, 100).Value = (object)catXe    ?? DBNull.Value;

                                int affected = cmd.ExecuteNonQuery();

                                // Nếu UPDATE không có dòng nào → INSERT mới
                                if (affected == 0)
                                {
                                    string insertSql = @"INSERT INTO dbo.CaSi (MaCS, TenCS, GTinh, NgSinh, SDT, DChi, CatXe)
                                                         VALUES (@MaCS, @TenCS, @GioiTinh, @NgaySinh, @DienThoai, @DiaChi, @CatXe)";

                                    using (var ins = new SqlCommand(insertSql, conn, tran))
                                    {
                                        ins.Parameters.Add("@MaCS", SqlDbType.NVarChar, 50).Value  = (object)maCS      ?? DBNull.Value;
                                        ins.Parameters.Add("@TenCS", SqlDbType.NVarChar, 200).Value = (object)tenCS     ?? DBNull.Value;
                                        ins.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 10).Value  = (object)gioiTinh  ?? DBNull.Value;
                                        ins.Parameters.Add("@NgaySinh", SqlDbType.Date).Value          = ngaySinh.HasValue ? (object)ngaySinh.Value : DBNull.Value;
                                        ins.Parameters.Add("@DienThoai", SqlDbType.NVarChar, 50).Value  = (object)dienThoai ?? DBNull.Value;
                                        ins.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 200).Value = (object)diaChi   ?? DBNull.Value;
                                        ins.Parameters.Add("@CatXe", SqlDbType.NVarChar, 100).Value = (object)catXe    ?? DBNull.Value;
                                        ins.ExecuteNonQuery();
                                    }
                                }
                            }
                        }

                        tran.Commit();
                    }

                    MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearForm();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL error: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===================== HỦY =====================
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // ===================== THOÁT =====================
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ===================== CLICK DÒNG TRÊN GRID =====================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            txtMaCS.Text  = row.Cells["MaCS"].Value?.ToString();
            txtTenCS.Text = row.Cells["TenCS"].Value?.ToString();
            txtSDT.Text   = row.Cells["DienThoai"].Value?.ToString();
            txtDChi.Text  = row.Cells["DiaChi"].Value?.ToString();
            txtCatXe.Text = row.Cells["CatXe"].Value?.ToString();

            string gt = row.Cells["GioiTinh"].Value?.ToString();
            radNam.Checked = (gt == "Nam");
            radNu.Checked  = (gt == "Nữ");

            if (row.Cells["NgaySinh"].Value != null && row.Cells["NgaySinh"].Value != DBNull.Value)
                dtpNgSinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
        }
    }
}