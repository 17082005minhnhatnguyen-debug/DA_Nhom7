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

        private void btnThemDM_Click(object sender, EventArgs e)
        {
            // Thêm một dòng mới vào bảng danh mục với dữ liệu từ các ô nhập
            dgvDanhMuc.Rows.Add(
                txtMaDanhMuc.Text,     // Mã danh mục
                txtTenDanhMuc.Text,    // Tên danh mục
                cboLoai.Text           // Loại (Thu hoặc Chi)
            );


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
            // Mở hộp thoại lưu file
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV Files|*.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Ghi từng dòng dữ liệu từ bảng vào file CSV
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    foreach (DataGridViewRow row in dgvDanhMuc.Rows)
                    {
                        if (!row.IsNewRow) // Bỏ qua dòng trống cuối bảng
                        {
                            // Lấy dữ liệu từng ô và nối bằng dấu phẩy
                            string line = string.Join(",", row.Cells.Cast<DataGridViewCell>().Select(c => c.Value?.ToString()));
                            sw.WriteLine(line); // Ghi dòng vào file
                        }
                    }
                }
            }

        }
    }
}
