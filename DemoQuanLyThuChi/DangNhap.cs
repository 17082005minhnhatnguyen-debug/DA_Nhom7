using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoQuanLyThuChi
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void txtMauKhau_TextChanged(object sender, EventArgs e)
        {
        }
        bool KiemTraTaiKhoan(string username, string password)
        {
            // Ví dụ hardcode 1 vài tài khoản mẫu
            if ((username == "user1" && password == "12345") ||
                (username == "admin" && password == "admin123"))
            {
                return true;
            }
            return false;
        }
        private void btnTạoTK_Click(object sender, EventArgs e)
        {
            // Tạo form đăng ký
            DangKy dangKyForm = new DangKy();
            // Ẩn form hiện tại (form đăng nhập)
            this.Hide();
            // Hiển thị form đăng ký
            dangKyForm.ShowDialog();
            // Khi đóng form đăng ký, hiện lại form đăng nhập
            this.Show();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTen.Text.Trim();
            string password = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            // Giả sử bạn có hàm kiểm tra tài khoản:
            if (KiemTraTaiKhoan(username, password))  // Hàm bạn tự viết để check DB hoặc bộ nhớ
            {
                MessageBox.Show("Đăng nhập thành công!");
                // Mở form chính (MainForm) hoặc form quản lý sau đăng nhập
                QuanLyThuChi mainForm = new QuanLyThuChi();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
            }
        }

        private void btnTat_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Bạn có chắc muốn thoát khỏi ứng dụng", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
