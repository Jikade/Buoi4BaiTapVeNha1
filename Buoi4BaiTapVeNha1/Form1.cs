using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Buoi4BaiTapVeNha1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            btnThemSua.Click += BtnThemSua_Click;
            btnXoa.Click += BtnXoa_Click;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbChuyenNghanh.Items.AddRange(new object[] { "QTKD", "CNTT", "NNA" });
            cbbChuyenNghanh.SelectedIndex = 0;
            rdbNu.Checked = true;
            InitDataGridView();
            UpdateBtnThemSuaText();
        }

        private void InitDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("MSSV", "MSSV");
            dataGridView1.Columns.Add("HoTen", "Họ Tên");
            dataGridView1.Columns.Add("GioiTinh", "Giới Tính");
            dataGridView1.Columns.Add("DTB", "Điểm TB");
            dataGridView1.Columns.Add("Khoa", "Chuyên Ngành");
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void BtnThemSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMSSV.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtDTB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mssv = txtMSSV.Text.Trim();
            string hoten = txtHoTen.Text.Trim();
            string gioitinh = rdbNam.Checked ? "Nam" : "Nữ";
            string dtb = txtDTB.Text.Trim();
            string chuyenNghanh = cbbChuyenNghanh.SelectedItem?.ToString() ?? "";

            // Tìm dòng có MSSV trùng
            DataGridViewRow foundRow = null;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["MSSV"].Value?.ToString() == mssv)
                {
                    foundRow = row;
                    break;
                }
            }

            if (foundRow != null)
            {
                // Ghi đè dữ liệu mới
                foundRow.Cells["HoTen"].Value = hoten;
                foundRow.Cells["GioiTinh"].Value = gioitinh;
                foundRow.Cells["DTB"].Value = dtb;
                foundRow.Cells["Khoa"].Value = chuyenNghanh;
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Thêm mới
                dataGridView1.Rows.Add(mssv, hoten, gioitinh, dtb, chuyenNghanh);
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ClearInput();
            UpdateBtnThemSuaText();
            UpdateGenderCount();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text.Trim();
            if (string.IsNullOrEmpty(mssv))
            {
                MessageBox.Show("Vui lòng nhập MSSV hoặc chọn sinh viên cần xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow rowToDelete = null;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["MSSV"].Value?.ToString() == mssv)
                {
                    rowToDelete = row;
                    break;
                }
            }

            if (rowToDelete != null)
            {
                if (MessageBox.Show("Bạn có chắc muốn xoá sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dataGridView1.Rows.Remove(rowToDelete);
                    MessageBox.Show("Xoá dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInput();
                    UpdateBtnThemSuaText();
                    UpdateGenderCount();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên với MSSV này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                ClearInput();
                UpdateBtnThemSuaText();
                return;
            }
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            txtMSSV.Text = row.Cells["MSSV"].Value?.ToString() ?? "";
            txtHoTen.Text = row.Cells["HoTen"].Value?.ToString() ?? "";
            txtDTB.Text = row.Cells["DTB"].Value?.ToString() ?? "";
            string gioitinh = row.Cells["GioiTinh"].Value?.ToString() ?? "Nữ";
            rdbNam.Checked = gioitinh == "Nam";
            rdbNu.Checked = gioitinh == "Nữ";
            cbbChuyenNghanh.SelectedItem = row.Cells["Khoa"].Value?.ToString() ?? "QTKD";
            UpdateBtnThemSuaText();
        }

        private void ClearInput()
        {
            txtMSSV.Clear();
            txtHoTen.Clear();
            txtDTB.Clear();
            rdbNu.Checked = true;
            cbbChuyenNghanh.SelectedIndex = 0;
            dataGridView1.ClearSelection();
        }

        private void UpdateBtnThemSuaText()
        {
            btnThemSua.Text = dataGridView1.SelectedRows.Count == 0 ? "Thêm" : "Sửa";
        }

        private void UpdateGenderCount()
        {
            int countNam = 0;
            int countNu = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                var gioiTinh = row.Cells["GioiTinh"].Value?.ToString();
                if (gioiTinh == "Nam") countNam++;
                else if (gioiTinh == "Nữ") countNu++;
            }
            btnNam.Text = countNam.ToString();
            btnNu.Text = countNu.ToString();
        }

        private void cbbChuyenNghanh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
