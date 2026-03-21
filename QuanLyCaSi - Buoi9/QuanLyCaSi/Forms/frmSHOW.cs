#nullable disable
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QuanLyCaSi.Forms
{
    public partial class frmSHOW : Form
    {
        DataTable dtShow = new DataTable();

        string connectionString = @"Data Source=.;Initial Catalog=QlCaSi;Integrated Security=True;TrustServerCertificate=True";

        List<string> danhSachMaXoa = new List<string>();

        // Lưu danh sách ca sĩ để tra cứu MaCS theo index
        List<(string MaCS, string TenCS, int CatXe)> dsCaSi = new List<(string, string, int)>();

        public frmSHOW()
        {
            InitializeComponent();
        }

        // ===================== LOAD DỮ LIỆU =====================
        private void LoadData()
        {
            dtShow.Clear();
            dtShow.Columns.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"SELECT s.MaShow,
                                      s.TenShow,
                                      s.NgDien,
                                      s.GiaVe,
                                      s.SoLuong,
                                      STRING_AGG(cs.TenCS, ', ') AS DanhSachCaSi
                               FROM dbo.Show s
                               LEFT JOIN dbo.ShowCaSi sc ON s.MaShow = sc.MaShow
                               LEFT JOIN dbo.CaSi cs     ON sc.MaCS  = cs.MaCS
                               GROUP BY s.MaShow, s.TenShow, s.NgDien, s.GiaVe, s.SoLuong
                               ORDER BY s.MaShow";
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    da.Fill(dtShow);
            }
        }

        // ===================== LOAD LISTBOX CA SĨ =====================
        private void LoadListCaSi()
        {
            dsCaSi.Clear();
            lCS.Items.Clear();
            lCS.SelectionMode = SelectionMode.MultiSimple;
            lCS.ScrollAlwaysVisible = true;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT MaCS, TenCS, Catxe FROM dbo.CaSi ORDER BY TenCS", conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string maCS = reader["MaCS"]  != DBNull.Value ? reader["MaCS"].ToString() : "";
                        string tenCS = reader["TenCS"] != DBNull.Value ? reader["TenCS"].ToString() : "";
                        int catXe = reader["Catxe"] != DBNull.Value ? Convert.ToInt32(reader["Catxe"]) : 0;
                        dsCaSi.Add((maCS, tenCS, catXe));
                        lCS.Items.Add(tenCS);
                    }
                }
            }
        }

        // ===================== SINH MÃ TỰ ĐỘNG =====================
        private string TaoMaTuDong()
        {
            HashSet<int> danhSachMa = new HashSet<int>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT MaShow FROM dbo.Show", conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string ma = reader["MaShow"] != DBNull.Value ? reader["MaShow"].ToString() : "";
                        if (ma.StartsWith("Show") && int.TryParse(ma.Substring(4), out int num))
                            danhSachMa.Add(num);
                    }
                }
            }

            int next = 1;
            while (danhSachMa.Contains(next)) next++;
            return "Show" + next.ToString("0000");
        }

        // ===================== LẤY MaCS ĐÃ CHỌN =====================
        private string LayMaCSList()
        {
            return string.Join(",", lCS.SelectedIndices.Cast<int>().Select(i => dsCaSi[i].MaCS));
        }

        private string LayTenCSList()
        {
            return string.Join(", ", lCS.SelectedIndices.Cast<int>().Select(i => dsCaSi[i].TenCS));
        }

        // ===================== XÓA FORM =====================
        private void ClearForm()
        {
            txtMaShow.Text  = TaoMaTuDong();
            txtTenShow.Text = "";
            dtpNgLap.Value  = DateTime.Now;
            txtGiaVe.Text   = "";
            txtSoLuong.Text = "";
            lCS.ClearSelected();
        }

        // ===================== ẨN CỘT KHÔNG CẦN THIẾT =====================
        private void AnCotGrid()
        {
            string[] anCot = { "_MaCSList" };
            foreach (string col in anCot)
                if (dataGridView1.Columns.Contains(col))
                    dataGridView1.Columns[col].Visible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            if (dataGridView1.Columns.Contains("MaShow")) dataGridView1.Columns["MaShow"].Width       = 90;
            if (dataGridView1.Columns.Contains("TenShow")) dataGridView1.Columns["TenShow"].Width      = 180;
            if (dataGridView1.Columns.Contains("NgDien")) dataGridView1.Columns["NgDien"].Width       = 100;
            if (dataGridView1.Columns.Contains("GiaVe")) dataGridView1.Columns["GiaVe"].Width        = 90;
            if (dataGridView1.Columns.Contains("SoLuong")) dataGridView1.Columns["SoLuong"].Width      = 80;
            if (dataGridView1.Columns.Contains("DanhSachCaSi")) dataGridView1.Columns["DanhSachCaSi"].Width = 350;
        }

        // ===================== FORM LOAD =====================
        private void SHOW_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource          = dtShow;
            txtMaShow.Enabled                 = false;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.ScrollBars          = ScrollBars.Both;

            dataGridView1.DataBindingComplete += (s, ev) => AnCotGrid();

            LoadListCaSi();
            LoadData();
            txtMaShow.Text = TaoMaTuDong();

            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        // ===================== THÊM =====================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenShow.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Show!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenShow.Focus();
                return;
            }
            if (lCS.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 Ca sĩ!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listCS.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtGiaVe.Text) || !int.TryParse(txtGiaVe.Text, out _))
            {
                MessageBox.Show("Vui lòng nhập Giá vé hợp lệ!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaVe.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text) || !int.TryParse(txtSoLuong.Text, out _))
            {
                MessageBox.Show("Vui lòng nhập Số lượng hợp lệ!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }

            if (!dtShow.Columns.Contains("_MaCSList"))
                dtShow.Columns.Add("_MaCSList", typeof(string));

            DataRow row = dtShow.NewRow();
            row["MaShow"]       = txtMaShow.Text;
            row["TenShow"]      = txtTenShow.Text.Trim();
            row["NgDien"]       = dtpNgLap.Value;
            row["GiaVe"]        = int.Parse(txtGiaVe.Text);
            row["SoLuong"]      = int.Parse(txtSoLuong.Text);
            row["DanhSachCaSi"] = LayTenCSList();
            row["_MaCSList"]    = LayMaCSList();
            dtShow.Rows.Add(row);

            ClearForm();
        }

        // ===================== SỬA (lưu thẳng vào DB) =====================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0) return;

            if (string.IsNullOrWhiteSpace(txtTenShow.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Show!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenShow.Focus();
                return;
            }
            if (lCS.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 Ca sĩ!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listCS.Focus();
                return;
            }

            string maShow = txtMaShow.Text;
            string tenShow = txtTenShow.Text.Trim();
            DateTime ngay = dtpNgLap.Value;
            string maCSList = LayMaCSList();
            string tenCSList = LayTenCSList();
            int giaVe = int.TryParse(txtGiaVe.Text, out int gv) ? gv : 0;
            int soLuong = int.TryParse(txtSoLuong.Text, out int sl) ? sl : 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        // Cập nhật Show
                        using (var cmd = new SqlCommand(@"UPDATE dbo.Show SET TenShow=@Ten, NgDien=@Ngay, GiaVe=@GiaVe, SoLuong=@SoLuong WHERE MaShow=@Ma", conn, tran))
                        {
                            cmd.Parameters.Add("@Ma", SqlDbType.VarChar, 8).Value   = maShow;
                            cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 200).Value = tenShow;
                            cmd.Parameters.Add("@Ngay", SqlDbType.Date).Value          = ngay;
                            cmd.Parameters.Add("@GiaVe", SqlDbType.Int).Value           = giaVe;
                            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value           = soLuong;
                            cmd.ExecuteNonQuery();
                        }

                        // Cập nhật ShowCaSi
                        if (!string.IsNullOrEmpty(maCSList))
                        {
                            using (var del = new SqlCommand("DELETE FROM dbo.ShowCaSi WHERE MaShow=@Ma", conn, tran))
                            {
                                del.Parameters.AddWithValue("@Ma", maShow);
                                del.ExecuteNonQuery();
                            }
                            foreach (var maCS in maCSList.Split(',', StringSplitOptions.RemoveEmptyEntries))
                            {
                                // Lấy CatXe của ca sĩ này
                                int catXe = dsCaSi.FirstOrDefault(x => x.MaCS == maCS.Trim()).CatXe;
                                using (var ins = new SqlCommand("INSERT INTO dbo.ShowCaSi (MaShow,MaCS,CatXe) VALUES (@Ma,@MaCS,@CatXe)", conn, tran))
                                {
                                    ins.Parameters.Add("@Ma", SqlDbType.VarChar, 8).Value = maShow;
                                    ins.Parameters.Add("@MaCS", SqlDbType.VarChar, 6).Value = maCS.Trim();
                                    ins.Parameters.Add("@CatXe", SqlDbType.Int).Value        = catXe;
                                    ins.ExecuteNonQuery();
                                }
                            }
                        }

                        tran.Commit();
                    }
                }

                int i = dataGridView1.CurrentRow.Index;
                dtShow.Rows[i]["TenShow"]      = tenShow;
                dtShow.Rows[i]["NgDien"]       = ngay;
                dtShow.Rows[i]["GiaVe"]        = giaVe;
                dtShow.Rows[i]["SoLuong"]      = soLuong;
                if (!string.IsNullOrEmpty(tenCSList))
                    dtShow.Rows[i]["DanhSachCaSi"] = tenCSList;

                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===================== XÓA =====================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0) return;

            string maXoa = dtShow.Rows[dataGridView1.CurrentRow.Index]["MaShow"].ToString();

            var confirm = MessageBox.Show($"Bạn có chắc muốn xóa Show '{maXoa}' không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            if (!string.IsNullOrEmpty(maXoa))
                danhSachMaXoa.Add(maXoa);

            dtShow.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            ClearForm();
        }

        // ===================== LƯU =====================
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
                            using (var del = new SqlCommand("DELETE FROM dbo.ShowCaSi WHERE MaShow=@Ma", conn, tran))
                            {
                                del.Parameters.AddWithValue("@Ma", maXoa);
                                del.ExecuteNonQuery();
                            }
                            using (var del = new SqlCommand("DELETE FROM dbo.Show WHERE MaShow=@Ma", conn, tran))
                            {
                                del.Parameters.AddWithValue("@Ma", maXoa);
                                del.ExecuteNonQuery();
                            }
                        }
                        danhSachMaXoa.Clear();

                        foreach (DataRow row in dtShow.Rows)
                        {
                            string maShow = row["MaShow"].ToString();
                            string tenShow = row["TenShow"].ToString();
                            string maCSList = dtShow.Columns.Contains("_MaCSList") && row["_MaCSList"] != DBNull.Value
                                              ? row["_MaCSList"].ToString() : "";

                            if (string.IsNullOrEmpty(maCSList)) continue;

                            int giaVe = row["GiaVe"]   != DBNull.Value ? Convert.ToInt32(row["GiaVe"]) : 0;
                            int soLuong = row["SoLuong"] != DBNull.Value ? Convert.ToInt32(row["SoLuong"]) : 0;

                            DateTime? ngayDien = null;
                            if (row["NgDien"] != null && row["NgDien"] != DBNull.Value)
                            {
                                if (row["NgDien"] is DateTime dt) ngayDien = dt;
                                else if (DateTime.TryParse(row["NgDien"].ToString(), out var parsed)) ngayDien = parsed;
                            }

                            using (var ins = new SqlCommand(@"INSERT INTO dbo.Show (MaShow, TenShow, NgDien, GiaVe, SoLuong)
                                                              VALUES (@Ma, @Ten, @Ngay, @GiaVe, @SoLuong)", conn, tran))
                            {
                                ins.Parameters.Add("@Ma", SqlDbType.VarChar, 8).Value   = maShow;
                                ins.Parameters.Add("@Ten", SqlDbType.NVarChar, 200).Value = tenShow;
                                ins.Parameters.Add("@Ngay", SqlDbType.Date).Value = ngayDien.HasValue ? (object)ngayDien.Value : DBNull.Value;
                                ins.Parameters.Add("@GiaVe", SqlDbType.Int).Value = giaVe;
                                ins.Parameters.Add("@SoLuong", SqlDbType.Int).Value = soLuong;
                                ins.ExecuteNonQuery();
                            }

                            foreach (var maCS in maCSList.Split(',', StringSplitOptions.RemoveEmptyEntries))
                            {
                                int catXe = dsCaSi.FirstOrDefault(x => x.MaCS == maCS.Trim()).CatXe;
                                using (var ins2 = new SqlCommand("INSERT INTO dbo.ShowCaSi (MaShow,MaCS,CatXe) VALUES (@Ma,@MaCS,@CatXe)", conn, tran))
                                {
                                    ins2.Parameters.Add("@Ma", SqlDbType.VarChar, 8).Value = maShow;
                                    ins2.Parameters.Add("@MaCS", SqlDbType.VarChar, 6).Value = maCS.Trim();
                                    ins2.Parameters.Add("@CatXe", SqlDbType.Int).Value = catXe;
                                    ins2.ExecuteNonQuery();
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
            if (e.RowIndex < 0 || e.RowIndex >= dtShow.Rows.Count) return;

            DataRow row = dtShow.Rows[e.RowIndex];

            txtMaShow.Text  = row["MaShow"].ToString();
            txtTenShow.Text = row["TenShow"].ToString();
            txtGiaVe.Text   = row["GiaVe"]   != DBNull.Value ? row["GiaVe"].ToString() : "";
            txtSoLuong.Text = row["SoLuong"] != DBNull.Value ? row["SoLuong"].ToString() : "";

            if (row["NgDien"] != DBNull.Value)
                dtpNgLap.Value = Convert.ToDateTime(row["NgDien"]);

            // Tích chọn lại ca sĩ trong ListBox
            string maShow = row["MaShow"].ToString();
            lCS.ClearSelected();
            if (string.IsNullOrEmpty(maShow)) return;

            List<string> danhSachMaCS = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT MaCS FROM dbo.ShowCaSi WHERE MaShow=@Ma", conn))
                {
                    cmd.Parameters.AddWithValue("@Ma", maShow);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                        while (reader.Read())
                            danhSachMaCS.Add(reader["MaCS"].ToString());
                }
            }

            for (int i = 0; i < dsCaSi.Count; i++)
                if (danhSachMaCS.Contains(dsCaSi[i].MaCS))
                    lCS.SetSelected(i, true);
        }
    }
}