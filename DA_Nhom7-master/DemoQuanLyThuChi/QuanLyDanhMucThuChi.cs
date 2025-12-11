using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DemoQuanLyThuChi
{
    public partial class QuanLyDanhMucThuChi : Form
    {
        public QuanLyDanhMucThuChi()
        {
            InitializeComponent();
        }
        // 1. Tự động đọc file khi mở Form lên
        private void QuanLyDanhMucThuChi_Load(object sender, EventArgs e)
        {
            string filePath = "Categories.csv";
            if (File.Exists(filePath))
            {
                try
                {
                    
                    string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);
                    dgvDanhMuc.Rows.Clear();
                    foreach (string line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            string[] data = line.Split(',');
                            if (data.Length >= 2) dgvDanhMuc.Rows.Add(data);
                        }
                    }
                }
                catch { /* Bỏ qua lỗi nếu file lỗi nhẹ */ }
            }
        }
        private bool KiemTraTrungMa(string maCheck)
        {
            // Duyệt qua từng dòng trong DataGridView
            foreach (DataGridViewRow row in dgvDanhMuc.Rows)
            {
                // Bỏ qua dòng mới (dòng trống cuối cùng trong grid nếu có)
                if (row.IsNewRow) continue;

                // Lấy giá trị ô mã danh mục (Cột 0)
                if (row.Cells[0].Value != null)
                {
                    string maDaCo = row.Cells[0].Value.ToString();
                    // So sánh không phân biệt hoa thường
                    if (maDaCo.Trim().Equals(maCheck.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        return true; 
                    }
                }
            }
            return false; 
        }
        private void btnThemDM_Click(object sender, EventArgs e)
        {
            string maMoi = txtMaDanhMuc.Text.Trim();
            string tenMoi = txtTenDanhMuc.Text.Trim();

            // 1. Kiểm tra rỗng
            if (string.IsNullOrEmpty(maMoi) || string.IsNullOrEmpty(tenMoi))
            {
                MessageBox.Show("Vui lòng nhập mã và tên danh mục!", "Thiếu thông tin");
                return;
            }

            // 2. Kiểm tra trùng mã
            if (KiemTraTrungMa(maMoi))
            {
                MessageBox.Show($"Mã danh mục '{maMoi}' đã tồn tại. Vui lòng chọn mã khác.", "Trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 3. Nếu hợp lệ thì thêm vào bảng
            dgvDanhMuc.Rows.Add(
                maMoi,
                tenMoi,
                cboLoai.Text
            );

            // (Tuỳ chọn) Xoá ô nhập sau khi thêm
            txtMaDanhMuc.Clear();
            txtTenDanhMuc.Clear();
            txtMaDanhMuc.Focus();
            


        }

        private void btnXoaDM_Click(object sender, EventArgs e)
        {
            // Kiểm tra có dòng nào đang được chọn không
            if (dgvDanhMuc.SelectedRows.Count > 0)
            {
                // Xóa dòng được chọn khỏi bảng
                dgvDanhMuc.Rows.RemoveAt(dgvDanhMuc.SelectedRows[0].Index);
            }

        }

        private void btnSuaDM_Click(object sender, EventArgs e)
        {
            // Kiểm tra có dòng nào đang được chọn không
            if (dgvDanhMuc.SelectedRows.Count > 0)
            {
                // Gán lại giá trị mới từ các ô nhập liệu vào dòng được chọn
                DataGridViewRow row = dgvDanhMuc.SelectedRows[0];
                row.Cells[0].Value = txtMaDanhMuc.Text;     // Mã danh mục
                row.Cells[1].Value = txtTenDanhMuc.Text;    // Tên danh mục
                row.Cells[2].Value = cboLoai.Text;          // Loại
            }

        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại chọn file CSV
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV Files|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Đọc toàn bộ dòng từ file
                string[] lines = File.ReadAllLines(ofd.FileName);
                dgvDanhMuc.Rows.Clear(); // Xóa dữ liệu cũ

                // Thêm từng dòng vào bảng
                foreach (string line in lines)
                {
                    string[] data = line.Split(','); // Tách dữ liệu theo dấu phẩy
                    dgvDanhMuc.Rows.Add(data);       // Thêm dòng vào bảng
                }
            }


        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            //// Mở hộp thoại lưu file
            //SaveFileDialog sfd = new SaveFileDialog();
            //sfd.Filter = "CSV Files|*.csv";

            //if (sfd.ShowDialog() == DialogResult.OK)
            //{
            //    // Ghi từng dòng dữ liệu từ bảng vào file CSV
            //    using (StreamWriter sw = new StreamWriter(sfd.FileName))
            //    {
            //        foreach (DataGridViewRow row in dgvDanhMuc.Rows)
            //        {
            //            if (!row.IsNewRow) // Bỏ qua dòng trống cuối bảng
            //            {
            //                // Lấy dữ liệu từng ô và nối bằng dấu phẩy
            //                string line = string.Join(",", row.Cells.Cast<DataGridViewCell>().Select(c => c.Value?.ToString()));
            //                sw.WriteLine(line); // Ghi dòng vào file
            //            }
            //        }
            //    }
            //}
            try
            {
                using (StreamWriter sw = new StreamWriter("Categories.csv", false, Encoding.UTF8))
                {
                    foreach (DataGridViewRow row in dgvDanhMuc.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            
                            string line = string.Join(",", row.Cells.Cast<DataGridViewCell>().Select(c => c.Value?.ToString()));
                            sw.WriteLine(line);
                        }
                    }
                }
                MessageBox.Show("Đã lưu danh mục thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu file: " + ex.Message);
            }
        }
    }
}
