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

    public partial class QuanLyThuChi : Form
    {
        public class DanhMucItem
        {
            public string Ten { get; set; }
            public string Loai { get; set; } // "Thu" hoặc "Chi"
        }
        List<DanhMucItem> listDanhMuc = new List<DanhMucItem>();
        public QuanLyThuChi()
        {
            InitializeComponent();
        }
        private void dtpNgayGD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThemGD_Click(object sender, EventArgs e)
        {
            // 1. Tạo mã tự động: "GD" + NămThángNgàyGiờPhútGiây
            // Ví dụ kết quả: GD20231208093015
            string maTuDong = "GD" + DateTime.Now.ToString("yyyyMMddHHmmss");

            // 2. Thêm một dòng mới vào bảng giao dịch
            int rowIndex = dgvGiaoDich.Rows.Add();

            // 3. Gán giá trị vào dòng mới
            dgvGiaoDich.Rows[rowIndex].Cells["MaGD"].Value = maTuDong; // Dùng mã tự động
            dgvGiaoDich.Rows[rowIndex].Cells["NgayGD"].Value = dtpNgayGD.Value.ToShortDateString();
            dgvGiaoDich.Rows[rowIndex].Cells["Loai"].Value = cboLoaiGD.Text;
            dgvGiaoDich.Rows[rowIndex].Cells["DanhMuc"].Value = cboDanhMuc.Text;
            dgvGiaoDich.Rows[rowIndex].Cells["NoiDung"].Value = txtNoiDung.Text;
            dgvGiaoDich.Rows[rowIndex].Cells["SoTien"].Value = nudSoTien.Value;

            // Hiển thị mã vừa tạo lên ô text để người dùng thấy
            txtMaGD.Text = maTuDong;
        }

        private void btnXoaDM_Click(object sender, EventArgs e)
        {
            // Kiểm tra có dòng nào đang được chọn không

            if (dgvGiaoDich.SelectedRows.Count > 0)
            {
                // Xóa dòng được chọn khỏi bảng

                dgvGiaoDich.Rows.RemoveAt(dgvGiaoDich.SelectedRows[0].Index);
            }

        }

        private void btnSuaDM_Click(object sender, EventArgs e)
        {
            // Kiểm tra có dòng nào đang được chọn không

            if (dgvGiaoDich.SelectedRows.Count > 0)
            {
                // Gán lại giá trị mới từ các ô nhập liệu vào dòng được chọn

                DataGridViewRow row = dgvGiaoDich.SelectedRows[0];
                row.Cells["MaGD"].Value = txtMaGD.Text;
                row.Cells["NgayGD"].Value = dtpNgayGD.Value.ToShortDateString();
                row.Cells["Loai"].Value = cboLoaiGD.Text;
                row.Cells["DanhMuc"].Value = cboDanhMuc.Text;
                row.Cells["NoiDung"].Value = txtNoiDung.Text;
                row.Cells["SoTien"].Value = nudSoTien.Value;
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
                dgvGiaoDich.Rows.Clear();
                // Thêm từng dòng vào bảng

                foreach (string line in lines)
                {
                    string[] data = line.Split(',');
                    dgvGiaoDich.Rows.Add(data);
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
                    foreach (DataGridViewRow row in dgvGiaoDich.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string line = string.Join(",", row.Cells.Cast<DataGridViewCell>().Select(c => c.Value?.ToString()));
                            sw.WriteLine(line);
                        }
                    }
                }
            }

        }

        private void btnTongThu_Click(object sender, EventArgs e)
        {
            // Tính tổng số tiền của các giao dịch loại "Thu"

            decimal tongThu = 0;
            foreach (DataGridViewRow row in dgvGiaoDich.Rows)
            {
                if (row.Cells["Loai"].Value?.ToString() == "Thu")
                {
                    tongThu += Convert.ToDecimal(row.Cells["SoTien"].Value);
                }
            }
            MessageBox.Show("Tổng Thu: " + tongThu.ToString("N0") + " VND");

        }

        private void btnTongChi_Click(object sender, EventArgs e)
        {
            // Tính tổng số tiền của các giao dịch loại "Chi"

            decimal tongChi = 0;
            foreach (DataGridViewRow row in dgvGiaoDich.Rows)
            {
                if (row.Cells["Loai"].Value?.ToString() == "Chi")
                {
                    tongChi += Convert.ToDecimal(row.Cells["SoTien"].Value);
                }
            }
            MessageBox.Show("Tổng Chi: " + tongChi.ToString("N0") + " VND");

        }

        private void btnSoDu_Click(object sender, EventArgs e)
        {
            decimal tongThu = 0, tongChi = 0;
            foreach (DataGridViewRow row in dgvGiaoDich.Rows)
            {
                string loai = row.Cells["Loai"].Value?.ToString();
                decimal soTien = Convert.ToDecimal(row.Cells["SoTien"].Value);
                if (loai == "Thu") tongThu += soTien;
                else if (loai == "Chi") tongChi += soTien;
            }
            decimal soDu = tongThu - tongChi;
            MessageBox.Show("Số Dư: " + soDu.ToString("N0") + " VND");

        }

        private void dgvGiaoDich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGiaoDich.Rows[e.RowIndex];
                // Hiển thị lại mã cũ lên ô text (dù không sửa được nhưng cần để nhìn)
                txtMaGD.Text = row.Cells["MaGD"].Value?.ToString();
                // ... code load các ô khác ...
            }
        }

        private void QuanLyThuChi_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "Categories.csv");

            // Kiểm tra xem file có tồn tại không trước khi đọc
            if (File.Exists(filePath))
            {
                try
                {
                    // Đọc file với bảng mã UTF8 để không lỗi font tiếng Việt
                    var lines = File.ReadAllLines(filePath, Encoding.UTF8);

                    listDanhMuc.Clear(); // Xóa sạch list cũ để tránh bị nhân đôi dữ liệu

                    foreach (string line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        string[] parts = line.Split(',');
                        // Cấu trúc file CSV là: Mã, Tên, Loại
                        // parts[0] = Mã
                        // parts[1] = Tên danh mục
                        // parts[2] = Loại (Thu/Chi)
                        if (parts.Length >= 3)
                        {
                            listDanhMuc.Add(new DanhMucItem()
                            {
                                Ten = parts[1].Trim(),
                                Loai = parts[2].Trim()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc file danh mục: " + ex.Message);
                }
            }

            // Mặc định chọn loại "Thu" (hoặc cái đầu tiên) để kích hoạt sự kiện lọc ngay khi mở form
            if (cboLoaiGD.Items.Count > 0)
            {
                cboLoaiGD.SelectedIndex = 0;
               
            }
        
         }

        private void cboLoaiGD_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. Lấy giá trị Thu hoặc Chi đang chọn
            string loaiDuocChon = cboLoaiGD.Text.Trim();

            // 2. Xóa dữ liệu cũ trong combobox Danh Mục
            cboDanhMuc.Items.Clear();

            // 3. Lọc danh sách: Chỉ lấy những mục có Loai khớp với loaiDuocChon
            foreach (var item in listDanhMuc)
            {
                // So sánh không phân biệt hoa thường
                if (item.Loai.Equals(loaiDuocChon, StringComparison.OrdinalIgnoreCase))
                {
                    cboDanhMuc.Items.Add(item.Ten);
                }
            }

            // 4. (Tuỳ chọn) Chọn mục đầu tiên nếu có dữ liệu để đẹp giao diện
            if (cboDanhMuc.Items.Count > 0)
            {
                cboDanhMuc.SelectedIndex = 0;
            }
            else
            {
                cboDanhMuc.Text = ""; // Xóa trắng nếu không có danh mục nào
            }
        }
    }
}
