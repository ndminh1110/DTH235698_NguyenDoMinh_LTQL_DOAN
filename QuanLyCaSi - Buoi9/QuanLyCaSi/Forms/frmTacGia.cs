using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QuanLyCaSi.Forms
{
    public partial class frmTacGia : Form
    {
        DataTable dtTG = new DataTable();

        string connectionString = @"Data Source=.;Initial Catalog=QlCaSi;Integrated Security=True;TrustServerCertificate=True";

        List<string> danhSachMaXoa = new List<string>();

        public frmTacGia()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dtTG.Clear();
            dtTG.Columns.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"SELECT MaTG, TenTG,
                                      GTinh  AS GioiTinh,
                                      NgSinh AS NgaySinh,
                                      SDT    AS DienThoai,
                                      DChi   AS DiaChi
                               FROM dbo.TacGia
                               ORDER BY MaTG";
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    da.Fill(dtTG);
                }
            }
        }

        private string TaoMaTuDong()
        {
            HashSet<int> danhSachMa = new HashSet<int>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT MaTG FROM dbo.TacGia";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string ma = reader["MaTG"].ToString();
                        if (ma.StartsWith("TG") && int.TryParse(ma.Substring(2), out int num))
                            danhSachMa.Add(num);
                    }
                }
            }

            foreach (DataRow row in dtTG.Rows)
            {
                string ma = row["MaTG"].ToString();
                if (ma.StartsWith("TG") && int.TryParse(ma.Substring(2), out int num))
                    danhSachMa.Add(num);
            }

            int next = 1;
            while (danhSachMa.Contains(next)) next++;

            return "TG" + next.ToString("0000");
        }

        private void ClearForm()
        {
            txtMaTG.Text    = TaoMaTuDong();
            txtTenTG.Clear();
            txtSDT.Clear();
            txtDChi.Clear();
            radNam.Checked  = true;
            radNu.Checked   = false;
            dtpNgSinh.Value = DateTime.Now;
        }

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

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dtTG;
            txtMaTG.Enabled = false;
            dataGridView1.AutoGenerateColumns = true;

            LoadData();
            txtMaTG.Text = TaoMaTuDong();
           // dataGridView1.CellClick += dataGridView1_CellClick;
        }

         private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenTG.Text) && string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên tác giả và Số điện thoại!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTG.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenTG.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên tác giả!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTG.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            if (!KiemTraSDT(txtSDT.Text)) return;

            DataRow row = dtTG.NewRow();
            string ma = TaoMaTuDong();
            row["MaTG"]      = ma;
            row["TenTG"]     = txtTenTG.Text.Trim();
            row["GioiTinh"]  = radNam.Checked ? "Nam" : "Nữ";
            row["NgaySinh"]  = dtpNgSinh.Value;
            row["DienThoai"] = txtSDT.Text.Trim();
            row["DiaChi"]    = txtDChi.Text.Trim();
            dtTG.Rows.Add(row);

            ClearForm();
        }

         private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0) return;

            if (string.IsNullOrWhiteSpace(txtTenTG.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên tác giả!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTG.Focus();
                return;
            }
            if (!KiemTraSDT(txtSDT.Text)) return;

            int i = dataGridView1.CurrentRow.Index;
            dtTG.Rows[i]["TenTG"]     = txtTenTG.Text.Trim();
            dtTG.Rows[i]["GioiTinh"]  = radNam.Checked ? "Nam" : "Nữ";
            dtTG.Rows[i]["NgaySinh"]  = dtpNgSinh.Value;
            dtTG.Rows[i]["DienThoai"] = txtSDT.Text.Trim();
            dtTG.Rows[i]["DiaChi"]    = txtDChi.Text.Trim();

            ClearForm();
        }

         private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0) return;

            string maXoa = dtTG.Rows[dataGridView1.CurrentRow.Index]["MaTG"].ToString();

            var confirm = MessageBox.Show($"Bạn có chắc muốn xóa tác giả '{maXoa}' không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            if (!string.IsNullOrEmpty(maXoa))
                danhSachMaXoa.Add(maXoa);

            dtTG.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            ClearForm();
        }

         private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra SDT trùng với DB
            using (SqlConnection connCheck = new SqlConnection(connectionString))
            {
                connCheck.Open();
                foreach (DataRow row in dtTG.Rows)
                {
                    string sdt = row["DienThoai"]?.ToString();
                    string maTG = row["MaTG"]?.ToString();

                    string checkSql = "SELECT COUNT(*) FROM dbo.TacGia WHERE SDT = @SDT AND MaTG != @MaTG";
                    using (SqlCommand cmd = new SqlCommand(checkSql, connCheck))
                    {
                        cmd.Parameters.AddWithValue("@SDT", sdt);
                        cmd.Parameters.AddWithValue("@MaTG", maTG);
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
                         foreach (string maXoa in danhSachMaXoa)
                        {
                            string deleteSql = "DELETE FROM dbo.TacGia WHERE MaTG = @MaTG";
                            using (var del = new SqlCommand(deleteSql, conn, tran))
                            {
                                del.Parameters.AddWithValue("@MaTG", maXoa);
                                del.ExecuteNonQuery();
                            }
                        }
                        danhSachMaXoa.Clear();

                         foreach (DataRow row in dtTG.Rows)
                        {
                            string maTG = row["MaTG"]?.ToString();
                            string tenTG = row["TenTG"]?.ToString();
                            string gioiTinh = row["GioiTinh"]?.ToString();
                            string dienThoai = row["DienThoai"]?.ToString();
                            string diaChi = row["DiaChi"]?.ToString();

                            DateTime? ngaySinh = null;
                            if (row["NgaySinh"] != null && row["NgaySinh"] != DBNull.Value)
                            {
                                if (row["NgaySinh"] is DateTime dt) ngaySinh = dt;
                                else if (DateTime.TryParse(row["NgaySinh"].ToString(), out var parsed)) ngaySinh = parsed;
                            }

                            string updateSql = @"UPDATE dbo.TacGia
                                                 SET TenTG  = @TenTG,
                                                     GTinh  = @GioiTinh,
                                                     NgSinh = @NgaySinh,
                                                     SDT    = @DienThoai,
                                                     DChi   = @DiaChi
                                                 WHERE MaTG = @MaTG";

                            using (var cmd = new SqlCommand(updateSql, conn, tran))
                            {
                                cmd.Parameters.Add("@MaTG", SqlDbType.NVarChar, 50).Value  = (object)maTG      ?? DBNull.Value;
                                cmd.Parameters.Add("@TenTG", SqlDbType.NVarChar, 200).Value = (object)tenTG     ?? DBNull.Value;
                                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 10).Value  = (object)gioiTinh  ?? DBNull.Value;
                                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value          = ngaySinh.HasValue ? (object)ngaySinh.Value : DBNull.Value;
                                cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar, 50).Value  = (object)dienThoai ?? DBNull.Value;
                                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 200).Value = (object)diaChi   ?? DBNull.Value;

                                int affected = cmd.ExecuteNonQuery();

                                if (affected == 0)
                                {
                                    string insertSql = @"INSERT INTO dbo.TacGia (MaTG, TenTG, GTinh, NgSinh, SDT, DChi)
                                                         VALUES (@MaTG, @TenTG, @GioiTinh, @NgaySinh, @DienThoai, @DiaChi)";

                                    using (var ins = new SqlCommand(insertSql, conn, tran))
                                    {
                                        ins.Parameters.Add("@MaTG", SqlDbType.NVarChar, 50).Value  = (object)maTG      ?? DBNull.Value;
                                        ins.Parameters.Add("@TenTG", SqlDbType.NVarChar, 200).Value = (object)tenTG     ?? DBNull.Value;
                                        ins.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 10).Value  = (object)gioiTinh  ?? DBNull.Value;
                                        ins.Parameters.Add("@NgaySinh", SqlDbType.Date).Value          = ngaySinh.HasValue ? (object)ngaySinh.Value : DBNull.Value;
                                        ins.Parameters.Add("@DienThoai", SqlDbType.NVarChar, 50).Value  = (object)dienThoai ?? DBNull.Value;
                                        ins.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 200).Value = (object)diaChi   ?? DBNull.Value;
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

         private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

         private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dtTG.Rows.Count) return;

            DataRow row = dtTG.Rows[e.RowIndex];

            txtMaTG.Text  = row["MaTG"]?.ToString();
            txtTenTG.Text = row["TenTG"]?.ToString();
            txtSDT.Text   = row["DienThoai"]?.ToString();
            txtDChi.Text  = row["DiaChi"]?.ToString();

            string gt = row["GioiTinh"]?.ToString()?.ToLower();
            radNam.Checked = (gt == "nam");
            radNu.Checked  = (gt == "nữ");

            if (row["NgaySinh"] != null && row["NgaySinh"] != DBNull.Value)
                dtpNgSinh.Value = Convert.ToDateTime(row["NgaySinh"]);
        }
    }
}