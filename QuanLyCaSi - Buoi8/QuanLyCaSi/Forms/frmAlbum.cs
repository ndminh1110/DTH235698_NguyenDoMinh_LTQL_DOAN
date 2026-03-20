#nullable disable
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QuanLyCaSi.Forms
{
    public partial class frmAlbum : Form
    {
        DataTable dtAlbum = new DataTable();

        string connectionString = @"Data Source=.;Initial Catalog=QlCaSi;Integrated Security=True;TrustServerCertificate=True";

        List<string> danhSachMaXoa = new List<string>();

        // Lưu danh sách bài hát để tra cứu MaBH theo index
        List<(string MaBH, string TenBH)> dsBaiHat = new List<(string, string)>();

        public frmAlbum()
        {
            InitializeComponent();
        }

        // ===================== LOAD DỮ LIỆU =====================
        private void LoadData()
        {
            dtAlbum.Clear();
            dtAlbum.Columns.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"SELECT a.MaAlbum,
                                      a.TenAlbum,
                                      a.NgPhatHanh,
                                      cs.MaCS,
                                      cs.TenCS AS CaSi,
                                      STRING_AGG(s.TenBH, ', ') AS DanhSachBaiHat
                               FROM dbo.Album a
                               LEFT JOIN dbo.CaSi cs         ON a.MaCS     = cs.MaCS
                               LEFT JOIN dbo.AlbumSingle als  ON a.MaAlbum = als.MaAlbum
                               LEFT JOIN dbo.Single s         ON als.MaBH  = s.MaBH
                               GROUP BY a.MaAlbum, a.TenAlbum, a.NgPhatHanh, cs.MaCS, cs.TenCS
                               ORDER BY a.MaAlbum";
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    da.Fill(dtAlbum);
            }
        }

        // ===================== LOAD COMBOBOX CA SĨ =====================
        private void LoadComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                DataTable dtCS = new DataTable();
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT MaCS, TenCS FROM dbo.CaSi ORDER BY TenCS", conn))
                    da.Fill(dtCS);

                cboCS.DataSource    = dtCS;
                cboCS.DisplayMember = "TenCS";
                cboCS.ValueMember   = "MaCS";
                cboCS.SelectedIndex = -1;
            }
        }

        // ===================== LOAD LISTBOX BÀI HÁT =====================
        private void LoadListBaiHat()
        {
            dsBaiHat.Clear();
            lBH.Items.Clear();
            lBH.SelectionMode       = SelectionMode.MultiSimple;
            lBH.ScrollAlwaysVisible = true;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT MaBH, TenBH FROM dbo.Single ORDER BY TenBH", conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string maBH = reader["MaBH"]  != DBNull.Value ? reader["MaBH"].ToString() : "";
                        string tenBH = reader["TenBH"] != DBNull.Value ? reader["TenBH"].ToString() : "";
                        dsBaiHat.Add((maBH, tenBH));
                        lBH.Items.Add(tenBH);
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
                using (SqlCommand cmd = new SqlCommand("SELECT MaAlbum FROM dbo.Album", conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string ma = reader["MaAlbum"] != DBNull.Value ? reader["MaAlbum"].ToString() : "";
                        if (ma.StartsWith("Album") && int.TryParse(ma.Substring(5), out int num))
                            danhSachMa.Add(num);
                    }
                }
            }

            int next = 1;
            while (danhSachMa.Contains(next)) next++;
            return "Album" + next.ToString("0000");
        }

        // ===================== LẤY TÊN & MÃ BÀI HÁT ĐÃ CHỌN =====================
        private string LayMaBHList()
        {
            return string.Join(",", lBH.SelectedIndices.Cast<int>().Select(i => dsBaiHat[i].MaBH));
        }

        private string LayTenBHList()
        {
            return string.Join(", ", lBH.SelectedIndices.Cast<int>().Select(i => dsBaiHat[i].TenBH));
        }

        // ===================== XÓA FORM =====================
        private void ClearForm()
        {
            txtMaAlbum.Text     = TaoMaTuDong();
            txtTenAlbum.Clear();
            dtpNgLap.Value      = DateTime.Now;
            cboCS.SelectedIndex = -1;
            lBH.ClearSelected();
        }

        // ===================== ẨN CỘT KHÔNG CẦN THIẾT =====================
        private void AnCotGrid()
        {
            string[] anCot = { "_MaBHList", "MaCS" };
            foreach (string col in anCot)
                if (dataGridView1.Columns.Contains(col))
                    dataGridView1.Columns[col].Visible = false;
        }

        // ===================== FORM LOAD =====================
        private void frmAlbum_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource          = dtAlbum;
            txtMaAlbum.Enabled                = false;
            dataGridView1.AutoGenerateColumns = true;

            // Ẩn cột sau mỗi lần grid render xong
            dataGridView1.DataBindingComplete += (s, ev) => AnCotGrid();

            LoadComboBox();
            LoadListBaiHat();
            LoadData();
            txtMaAlbum.Text = TaoMaTuDong();

            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        // ===================== THÊM =====================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenAlbum.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Album!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenAlbum.Focus();
                return;
            }
            if (cboCS.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Ca sĩ!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCS.Focus();
                return;
            }
            if (lBH.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 Bài hát!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lBH.Focus();
                return;
            }

            if (!dtAlbum.Columns.Contains("_MaBHList"))
                dtAlbum.Columns.Add("_MaBHList", typeof(string));

            DataRow row = dtAlbum.NewRow();
            row["MaAlbum"]        = txtMaAlbum.Text;
            row["TenAlbum"]       = txtTenAlbum.Text.Trim();
            row["NgPhatHanh"]     = dtpNgLap.Value;
            row["MaCS"]           = cboCS.SelectedValue.ToString();
            row["CaSi"]           = cboCS.Text.Trim();
            row["DanhSachBaiHat"] = LayTenBHList();
            row["_MaBHList"]      = LayMaBHList();
            dtAlbum.Rows.Add(row);

            ClearForm();
        }

        // ===================== SỬA (lưu thẳng vào DB ngay lập tức) =====================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0) return;

            if (string.IsNullOrWhiteSpace(txtTenAlbum.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Album!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenAlbum.Focus();
                return;
            }
            if (cboCS.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Ca sĩ!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCS.Focus();
                return;
            }

            string maAlbum = txtMaAlbum.Text;
            string tenAlbum = txtTenAlbum.Text.Trim();
            string maCS = cboCS.SelectedValue.ToString();
            DateTime ngay = dtpNgLap.Value;
            string maBHList = LayMaBHList();
            string tenBHList = LayTenBHList();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        // Cập nhật Album
                        using (var cmd = new SqlCommand(@"UPDATE dbo.Album SET TenAlbum=@Ten, NgPhatHanh=@Ngay, MaCS=@MaCS WHERE MaAlbum=@Ma", conn, tran))
                        {
                            cmd.Parameters.Add("@Ma", SqlDbType.VarChar, 9).Value   = maAlbum;
                            cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 200).Value = tenAlbum;
                            cmd.Parameters.Add("@Ngay", SqlDbType.Date).Value          = ngay;
                            cmd.Parameters.Add("@MaCS", SqlDbType.VarChar, 6).Value   = maCS;
                            cmd.ExecuteNonQuery();
                        }

                        // Cập nhật AlbumSingle: xóa cũ rồi insert lại
                        if (!string.IsNullOrEmpty(maBHList))
                        {
                            using (var del = new SqlCommand("DELETE FROM dbo.AlbumSingle WHERE MaAlbum=@Ma", conn, tran))
                            {
                                del.Parameters.AddWithValue("@Ma", maAlbum);
                                del.ExecuteNonQuery();
                            }
                            foreach (var maBH in maBHList.Split(',', StringSplitOptions.RemoveEmptyEntries))
                            {
                                using (var ins = new SqlCommand("INSERT INTO dbo.AlbumSingle (MaAlbum,MaBH) VALUES (@Ma,@MaBH)", conn, tran))
                                {
                                    ins.Parameters.Add("@Ma", SqlDbType.VarChar, 9).Value = maAlbum;
                                    ins.Parameters.Add("@MaBH", SqlDbType.VarChar, 6).Value = maBH.Trim();
                                    ins.ExecuteNonQuery();
                                }
                            }
                        }

                        tran.Commit();
                    }
                }

                // Cập nhật DataTable để grid hiện đúng ngay
                int i = dataGridView1.CurrentRow.Index;
                dtAlbum.Rows[i]["TenAlbum"]       = tenAlbum;
                dtAlbum.Rows[i]["NgPhatHanh"]     = ngay;
                dtAlbum.Rows[i]["MaCS"]           = maCS;
                dtAlbum.Rows[i]["CaSi"]           = cboCS.Text.Trim();
                if (!string.IsNullOrEmpty(tenBHList))
                    dtAlbum.Rows[i]["DanhSachBaiHat"] = tenBHList;

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

            string maXoa = dtAlbum.Rows[dataGridView1.CurrentRow.Index]["MaAlbum"].ToString();

            var confirm = MessageBox.Show($"Bạn có chắc muốn xóa Album '{maXoa}' không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            if (!string.IsNullOrEmpty(maXoa))
                danhSachMaXoa.Add(maXoa);

            dtAlbum.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            ClearForm();
        }

        // ===================== LƯU (chỉ xử lý album MỚI từ btnThem và xóa) =====================
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        // 1. XÓA (AlbumSingle trước, rồi Album)
                        foreach (string maXoa in danhSachMaXoa)
                        {
                            using (var del = new SqlCommand("DELETE FROM dbo.AlbumSingle WHERE MaAlbum=@Ma", conn, tran))
                            {
                                del.Parameters.AddWithValue("@Ma", maXoa);
                                del.ExecuteNonQuery();
                            }
                            using (var del = new SqlCommand("DELETE FROM dbo.Album WHERE MaAlbum=@Ma", conn, tran))
                            {
                                del.Parameters.AddWithValue("@Ma", maXoa);
                                del.ExecuteNonQuery();
                            }
                        }
                        danhSachMaXoa.Clear();

                        // 2. Chỉ INSERT album MỚI (có _MaBHList, chưa tồn tại trong DB)
                        foreach (DataRow row in dtAlbum.Rows)
                        {
                            string maAlbum = row["MaAlbum"].ToString();
                            string tenAlbum = row["TenAlbum"].ToString();
                            string maCS = row["MaCS"].ToString();
                            string maBHList = dtAlbum.Columns.Contains("_MaBHList") && row["_MaBHList"] != DBNull.Value
                                              ? row["_MaBHList"].ToString() : "";

                            // Bỏ qua nếu không có _MaBHList (album cũ đã Sửa xong rồi)
                            if (string.IsNullOrEmpty(maBHList)) continue;

                            DateTime? ngayPhat = null;
                            if (row["NgPhatHanh"] != null && row["NgPhatHanh"] != DBNull.Value)
                            {
                                if (row["NgPhatHanh"] is DateTime dt) ngayPhat = dt;
                                else if (DateTime.TryParse(row["NgPhatHanh"].ToString(), out var parsed)) ngayPhat = parsed;
                            }

                            // INSERT Album mới
                            using (var ins = new SqlCommand(@"INSERT INTO dbo.Album (MaAlbum, TenAlbum, NgPhatHanh, MaCS)
                                                              VALUES (@Ma, @Ten, @Ngay, @MaCS)", conn, tran))
                            {
                                ins.Parameters.Add("@Ma", SqlDbType.VarChar, 9).Value   = maAlbum;
                                ins.Parameters.Add("@Ten", SqlDbType.NVarChar, 200).Value = tenAlbum;
                                ins.Parameters.Add("@Ngay", SqlDbType.Date).Value          = ngayPhat.HasValue ? (object)ngayPhat.Value : DBNull.Value;
                                ins.Parameters.Add("@MaCS", SqlDbType.VarChar, 6).Value   = maCS;
                                ins.ExecuteNonQuery();
                            }

                            // INSERT AlbumSingle cho album mới
                            foreach (var maBH in maBHList.Split(',', StringSplitOptions.RemoveEmptyEntries))
                            {
                                using (var ins2 = new SqlCommand("INSERT INTO dbo.AlbumSingle (MaAlbum,MaBH) VALUES (@Ma,@MaBH)", conn, tran))
                                {
                                    ins2.Parameters.Add("@Ma", SqlDbType.VarChar, 9).Value = maAlbum;
                                    ins2.Parameters.Add("@MaBH", SqlDbType.VarChar, 6).Value = maBH.Trim();
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
            if (e.RowIndex < 0 || e.RowIndex >= dtAlbum.Rows.Count) return;

            DataRow row = dtAlbum.Rows[e.RowIndex];

            txtMaAlbum.Text  = row["MaAlbum"].ToString();
            txtTenAlbum.Text = row["TenAlbum"].ToString();

            if (row["NgPhatHanh"] != DBNull.Value)
                dtpNgLap.Value = Convert.ToDateTime(row["NgPhatHanh"]);

            cboCS.SelectedValue = row["MaCS"].ToString();

            // Tích chọn lại bài hát trong ListBox
            string maAlbum = row["MaAlbum"].ToString();
            lBH.ClearSelected();
            if (string.IsNullOrEmpty(maAlbum)) return;

            List<string> danhSachMaBH = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT MaBH FROM dbo.AlbumSingle WHERE MaAlbum=@Ma", conn))
                {
                    cmd.Parameters.AddWithValue("@Ma", maAlbum);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                        while (reader.Read())
                            danhSachMaBH.Add(reader["MaBH"].ToString());
                }
            }

            for (int i = 0; i < dsBaiHat.Count; i++)
                if (danhSachMaBH.Contains(dsBaiHat[i].MaBH))
                    lBH.SetSelected(i, true);
        }
    }
}