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
        //private string tenFileRieng; // Biến lưu tên file: "Categories_admin.csv"
        private string duongDanFileRieng;
        public QuanLyDanhMucThuChi(string username)
        {
            InitializeComponent();
            cboLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            txtMaDanhMuc.ReadOnly = true;

            // Đổi màu nền để người dùng biết là ô này tự động
            txtMaDanhMuc.BackColor = System.Drawing.Color.LightGray;
            // 1. Tạo đường dẫn tới thư mục "DuLieu"
            string folderPath = Path.Combine(Application.StartupPath, "DuLieu");

            // 2. Nếu thư mục chưa có thì tạo mới (Đáp ứng yêu cầu tạo thư mục)
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // 3.DanhMuc_TenUser.csv
            // Kết hợp thư mục và tên file
            this.duongDanFileRieng = Path.Combine(folderPath, "DanhMuc_" + username + ".csv");
        }
        
        private void QuanLyDanhMucThuChi_Load(object sender, EventArgs e)
        {
            //string filePath = Path.Combine(Application.StartupPath, this.tenFileRieng);
            if (File.Exists(this.duongDanFileRieng))
            {
                try
                {
                    
                    string[] lines = File.ReadAllLines(this.duongDanFileRieng, Encoding.UTF8);
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
            txtMaDanhMuc.Enabled = false; // Không cho người dùng tự nhập mã         
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
            
            string tenMoi = txtTenDanhMuc.Text.Trim();
            
            // 1. Kiểm tra rỗng
            if (string.IsNullOrEmpty(tenMoi))
            {
                MessageBox.Show("Vui lòng nhập tên danh mục!", "Thiếu thông tin");
                return;
            }

            // Sinh chuỗi ngẫu nhiên, lấy 8 ký tự, in hoa -> Ví dụ: "1A2B3C4D"
            string maNgauNhien = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
            string maDayDu = "DM" + maNgauNhien; // Kết quả: DM1A2B3C4D
            // (Tùy chọn) Đề phòng trường hợp cực hiếm hoi bị trùng mã thì sinh lại   
            while (KiemTraTrungMa(maDayDu))
            {
                maNgauNhien = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
                maDayDu = "DM" + maNgauNhien;
            }

            // 4. Thêm dòng mới vào bảng (dùng mã vừa tạo)
            dgvDanhMuc.Rows.Add(maDayDu, tenMoi,cboLoai.Text);

            // 5. Lưu dữ liệu xuống file
            TuDongLuuFile();

            // 6. Dọn dẹp ô nhập liệu để nhập tiếp
            txtTenDanhMuc.Clear();
            txtTenDanhMuc.Focus();
        }
        private void btnXoaDM_Click(object sender, EventArgs e)
        {
            // Kiểm tra có dòng nào đang được chọn không
            if (dgvDanhMuc.SelectedRows.Count > 0)
            {
                // Xóa dòng được chọn khỏi bảng
                dgvDanhMuc.Rows.RemoveAt(dgvDanhMuc.SelectedRows[0].Index);
            }
            // Tự động lưu file sau khi xóa
            TuDongLuuFile();
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
            // Tự động lưu file sau khi sửa
            TuDongLuuFile();

        }
        private void TuDongLuuFile()
        {
            try
            {
                // Ghi đè (false) vào đường dẫn file đã định sẵn
                using (StreamWriter sw = new StreamWriter(this.duongDanFileRieng, false, Encoding.UTF8))
                {
                    foreach (DataGridViewRow row in dgvDanhMuc.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            // Lấy dữ liệu các ô
                            string line = string.Join(",", row.Cells.Cast<DataGridViewCell>().Select(c => c.Value?.ToString()));
                            sw.WriteLine(line);
                        }
                    }
                }           
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu tự động: " + ex.Message);
            }
        }
        private void txtMaDanhMuc_Click(object sender, EventArgs e)
        {
            // Chỉ tạo mã mới nếu ô mã danh mục đang trống
            if (string.IsNullOrEmpty(txtMaDanhMuc.Text.Trim()))
            {
                // 1. Tạo GUID (là chuỗi duy nhất trên toàn cầu)
                Guid newGuid = Guid.NewGuid();

                // 2. Rút gọn mã: Lấy 8 ký tự đầu tiên của GUID
                // Ví dụ: 2c19e7a8-1234-5678-abcd-ef0123456789 -> 2C19E7A8
                string shortCode = newGuid.ToString("N").Substring(0, 8).ToUpper();

                // 3. Đặt mã đã rút gọn vào ô nhập liệu
                txtMaDanhMuc.Text = "DM" + shortCode;
            }
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            bool coDuLieu = false;

            foreach (DataGridViewRow row in dgvDanhMuc.Rows)
            {
                // IsNewRow là dòng trống cuối cùng (nếu Grid cho phép thêm dòng), ta không tính dòng đó
                if (!row.IsNewRow)
                {
                    coDuLieu = true;
                    break; 
                }
            }
            // 2. Nếu chưa có dữ liệu thì báo lỗi
            if (!coDuLieu)
            {
                MessageBox.Show("Chưa có danh mục, vui lòng tạo danh mục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng lại, không đóng form
            }
            // 3. Nếu đã có dữ liệu thì đóng form
            this.Close();
        }
    }
}
