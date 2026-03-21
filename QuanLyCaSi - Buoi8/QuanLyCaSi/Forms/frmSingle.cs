using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QuanLyCaSi.Forms
{
    public partial class frmSingle : Form
    {
        DataTable dtBH = new DataTable();

        string connectionString = @"Data Source=.;Initial Catalog=QlCaSi;Integrated Security=True;TrustServerCertificate=True";

        List<string> danhSachMaXoa = new List<string>();

        public frmSingle()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dtBH.Clear();
            dtBH.Columns.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"SELECT bh.MaBH,
                                      bh.TenBH,
                                      bh.NgPhatHanh  AS NgayPhat,
                                      cs.MaCS        AS MaCaSi,
                                      cs.TenCS       AS CaSi,
                                      tg.MaTG        AS MaTacGia,
                                      tg.TenTG       AS TacGia,
                                      cst.MaCS       AS MaCaSiHoTro,
                                      cst.TenCS      AS CaSiHoTro
                               FROM dbo.Single bh
                               LEFT JOIN dbo.CaSi   cs  ON bh.MaCS   = cs.MaCS
                               LEFT JOIN dbo.TacGia  tg  ON bh.MaTG   = tg.MaTG
                               LEFT JOIN dbo.CaSi   cst ON bh.MaCSHT = cst.MaCS
                               ORDER BY bh.MaBH";
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    da.Fill(dtBH);
                }
            }
        }

        private void LoadComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Load Ca sĩ
                DataTable dtCS = new DataTable();
                string sqlCS = "SELECT MaCS, TenCS FROM dbo.CaSi ORDER BY TenCS";
                using (SqlDataAdapter da = new SqlDataAdapter(sqlCS, conn))
                    da.Fill(dtCS);

                cboCS.DataSource    = dtCS;
                cboCS.DisplayMember = "TenCS";
                cboCS.ValueMember   = "MaCS";
                cboCS.SelectedIndex = -1;

                cboCSHoTro.DataSource    = dtCS.Copy();
                cboCSHoTro.DisplayMember = "TenCS";
                cboCSHoTro.ValueMember   = "MaCS";
                cboCSHoTro.SelectedIndex = -1;

                DataTable dtTG = new DataTable();
                string sqlTG = "SELECT MaTG, TenTG FROM dbo.TacGia ORDER BY TenTG";
                using (SqlDataAdapter da = new SqlDataAdapter(sqlTG, conn))
                    da.Fill(dtTG);

                cboTG.DataSource    = dtTG;
                cboTG.DisplayMember = "TenTG";
                cboTG.ValueMember   = "MaTG";
                cboTG.SelectedIndex = -1;
            }
        }

        private string TaoMaTuDong()
        {
            HashSet<int> danhSachMa = new HashSet<int>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT MaBH FROM dbo.Single";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string ma = reader["MaBH"].ToString();
                        if (ma.StartsWith("BH") && int.TryParse(ma.Substring(2), out int num))
                            danhSachMa.Add(num);
                    }
                }
            }

            foreach (DataRow row in dtBH.Rows)
            {
                string ma = row["MaBH"].ToString();
                if (ma.StartsWith("BH") && int.TryParse(ma.Substring(2), out int num))
                    danhSachMa.Add(num);
            }

            int next = 1;
            while (danhSachMa.Contains(next)) next++;

            return "BH" + next.ToString("0000");
        }

        private void ClearForm()
        {
            txtMaBH.Text           = TaoMaTuDong();
            txtTenBH.Clear();
            dtpNgPhat.Value        = DateTime.Now;
            cboCS.SelectedIndex    = -1;
            cboTG.SelectedIndex    = -1;
            cboCSHoTro.SelectedIndex = -1;
        }

        private void frmSingle_Load(object sender, EventArgs e)
        {
            dgvBaiHat.DataSource          = dtBH;
            txtMaBH.Enabled               = false;
            dgvBaiHat.AutoGenerateColumns = true;

            LoadComboBox();
            LoadData();
            txtMaBH.Text = TaoMaTuDong();

            dgvBaiHat.CellClick += dgvBaiHat_CellClick;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenBH.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên bài hát!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenBH.Focus();
                return;
            }
            if (cboCS.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Ca sĩ!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCS.Focus();
                return;
            }
            if (cboTG.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Tác giả!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTG.Focus();
                return;
            }

            DataRow row = dtBH.NewRow();
            row["MaBH"]        = TaoMaTuDong();
            row["TenBH"]       = txtTenBH.Text.Trim();
            row["NgayPhat"]    = dtpNgPhat.Value;
            row["MaCaSi"]      = cboCS.SelectedValue.ToString();
            row["CaSi"]        = cboCS.Text.Trim();
            row["MaTacGia"]    = cboTG.SelectedValue.ToString();
            row["TacGia"]      = cboTG.Text.Trim();
            row["MaCaSiHoTro"] = cboCSHoTro.SelectedIndex >= 0 ? cboCSHoTro.SelectedValue.ToString() : (object)DBNull.Value;
            row["CaSiHoTro"]   = cboCSHoTro.SelectedIndex >= 0 ? cboCSHoTro.Text.Trim() : (object)DBNull.Value;
            dtBH.Rows.Add(row);

            ClearForm();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvBaiHat.CurrentRow == null || dgvBaiHat.CurrentRow.Index < 0) return;

            if (string.IsNullOrWhiteSpace(txtTenBH.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên bài hát!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenBH.Focus();
                return;
            }
            if (cboCS.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Ca sĩ!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCS.Focus();
                return;
            }
            if (cboTG.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Tác giả!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTG.Focus();
                return;
            }

            int i = dgvBaiHat.CurrentRow.Index;
            dtBH.Rows[i]["TenBH"]       = txtTenBH.Text.Trim();
            dtBH.Rows[i]["NgayPhat"]    = dtpNgPhat.Value;
            dtBH.Rows[i]["MaCaSi"]      = cboCS.SelectedValue.ToString();
            dtBH.Rows[i]["CaSi"]        = cboCS.Text.Trim();
            dtBH.Rows[i]["MaTacGia"]    = cboTG.SelectedValue.ToString();
            dtBH.Rows[i]["TacGia"]      = cboTG.Text.Trim();
            dtBH.Rows[i]["MaCaSiHoTro"] = cboCSHoTro.SelectedIndex >= 0 ? cboCSHoTro.SelectedValue.ToString() : (object)DBNull.Value;
            dtBH.Rows[i]["CaSiHoTro"]   = cboCSHoTro.SelectedIndex >= 0 ? cboCSHoTro.Text.Trim() : (object)DBNull.Value;

            ClearForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvBaiHat.CurrentRow == null || dgvBaiHat.CurrentRow.Index < 0) return;

            string maXoa = dtBH.Rows[dgvBaiHat.CurrentRow.Index]["MaBH"].ToString();

            var confirm = MessageBox.Show($"Bạn có chắc muốn xóa bài hát '{maXoa}' không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            if (!string.IsNullOrEmpty(maXoa))
                danhSachMaXoa.Add(maXoa);

            dtBH.Rows.RemoveAt(dgvBaiHat.CurrentRow.Index);
            ClearForm();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        foreach (string maXoa in danhSachMaXoa)
                        {
                            string deleteSql = "DELETE FROM dbo.Single WHERE MaBH = @MaBH";
                            using (var del = new SqlCommand(deleteSql, conn, tran))
                            {
                                del.Parameters.AddWithValue("@MaBH", maXoa);
                                del.ExecuteNonQuery();
                            }
                        }
                        danhSachMaXoa.Clear();

                        foreach (DataRow row in dtBH.Rows)
                        {
                            string maBH = row["MaBH"]?.ToString();
                            string tenBH = row["TenBH"]?.ToString();
                            string maCaSi = row["MaCaSi"]?.ToString();
                            string maTG = row["MaTacGia"]?.ToString();
                            string maCSHT = row["MaCaSiHoTro"] != DBNull.Value
                                             ? row["MaCaSiHoTro"]?.ToString()
                                             : null;

                            DateTime? ngayPhat = null;
                            if (row["NgayPhat"] != null && row["NgayPhat"] != DBNull.Value)
                            {
                                if (row["NgayPhat"] is DateTime dt) ngayPhat = dt;
                                else if (DateTime.TryParse(row["NgayPhat"].ToString(), out var parsed)) ngayPhat = parsed;
                            }

                            string updateSql = @"UPDATE dbo.Single
                                                 SET TenBH      = @TenBH,
                                                     NgPhatHanh = @NgayPhat,
                                                     MaCS       = @MaCS,
                                                     MaTG       = @MaTG,
                                                     MaCSHT     = @MaCSHT
                                                 WHERE MaBH = @MaBH";

                            using (var cmd = new SqlCommand(updateSql, conn, tran))
                            {
                                cmd.Parameters.Add("@MaBH", SqlDbType.NVarChar, 50).Value  = (object)maBH   ?? DBNull.Value;
                                cmd.Parameters.Add("@TenBH", SqlDbType.NVarChar, 200).Value = (object)tenBH  ?? DBNull.Value;
                                cmd.Parameters.Add("@NgayPhat", SqlDbType.Date).Value           = ngayPhat.HasValue ? (object)ngayPhat.Value : DBNull.Value;
                                cmd.Parameters.Add("@MaCS", SqlDbType.NVarChar, 50).Value  = (object)maCaSi ?? DBNull.Value;
                                cmd.Parameters.Add("@MaTG", SqlDbType.NVarChar, 50).Value  = (object)maTG   ?? DBNull.Value;
                                cmd.Parameters.Add("@MaCSHT", SqlDbType.NVarChar, 50).Value  = (object)maCSHT ?? DBNull.Value;

                                int affected = cmd.ExecuteNonQuery();

                                if (affected == 0)
                                {
                                    string insertSql = @"INSERT INTO dbo.Single (MaBH, TenBH, NgPhatHanh, MaCS, MaTG, MaCSHT)
                                                         VALUES (@MaBH, @TenBH, @NgayPhat, @MaCS, @MaTG, @MaCSHT)";
                                    using (var ins = new SqlCommand(insertSql, conn, tran))
                                    {
                                        ins.Parameters.Add("@MaBH", SqlDbType.NVarChar, 50).Value  = (object)maBH   ?? DBNull.Value;
                                        ins.Parameters.Add("@TenBH", SqlDbType.NVarChar, 200).Value = (object)tenBH  ?? DBNull.Value;
                                        ins.Parameters.Add("@NgayPhat", SqlDbType.Date).Value           = ngayPhat.HasValue ? (object)ngayPhat.Value : DBNull.Value;
                                        ins.Parameters.Add("@MaCS", SqlDbType.NVarChar, 50).Value  = (object)maCaSi ?? DBNull.Value;
                                        ins.Parameters.Add("@MaTG", SqlDbType.NVarChar, 50).Value  = (object)maTG   ?? DBNull.Value;
                                        ins.Parameters.Add("@MaCSHT", SqlDbType.NVarChar, 50).Value  = (object)maCSHT ?? DBNull.Value;
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

        private void dgvBaiHat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dtBH.Rows.Count) return;

            DataRow row = dtBH.Rows[e.RowIndex];

            txtMaBH.Text  = row["MaBH"]?.ToString();
            txtTenBH.Text = row["TenBH"]?.ToString();

            if (row["NgayPhat"] != null && row["NgayPhat"] != DBNull.Value)
                dtpNgPhat.Value = Convert.ToDateTime(row["NgayPhat"]);

            cboCS.SelectedValue = row["MaCaSi"]?.ToString() ?? "";
            cboTG.SelectedValue = row["MaTacGia"]?.ToString() ?? "";

            if (row["MaCaSiHoTro"] != DBNull.Value && row["MaCaSiHoTro"] != null)
                cboCSHoTro.SelectedValue = row["MaCaSiHoTro"].ToString();
            else
                cboCSHoTro.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}