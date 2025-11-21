using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using System.IO;
=======
>>>>>>> 798e8a9f334982c33736b203d52b74438e164729

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
<<<<<<< HEAD
            // Kiểm tra tài khoản mẫu
=======
            // Ví dụ hardcode 1 vài tài khoản mẫu
>>>>>>> 798e8a9f334982c33736b203d52b74438e164729
            if ((username == "user1" && password == "12345") ||
                (username == "admin" && password == "admin123"))
            {
                return true;
            }
<<<<<<< HEAD

            // Kiểm tra tài khoản từ file
            if (File.Exists("users.txt"))
            {
                string[] lines = File.ReadAllLines("users.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3 && parts[1] == username && parts[2] == password)
                    {
                        return true;
                    }
                }
            }

=======
>>>>>>> 798e8a9f334982c33736b203d52b74438e164729
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
