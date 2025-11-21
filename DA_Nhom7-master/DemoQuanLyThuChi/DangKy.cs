using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace DemoQuanLyThuChi
{
    public partial class DangKy: Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        // Hàm kiểm tra xem Email hoặc Username đã có trong file users.txt chưa
        private bool KiemTraTonTai(string checkEmail, string checkUsername)
        {
            if (!File.Exists("users.txt"))
            {
                return false; // File chưa có thì chắc chắn chưa trùng
            }

            // Đọc toàn bộ các dòng trong file
            string[] lines = File.ReadAllLines("users.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                // Cấu trúc lưu: email,username,password
                // parts[0] là Email, parts[1] là Username
                if (parts.Length >= 2)
                {
                  
                    if (parts[0].Trim().Equals(checkEmail, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Email này đã được sử dụng!", "Trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return true;
                    }
                    if (parts[1].Trim().Equals(checkUsername, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Tên đăng nhập này đã tồn tại!", "Trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return true;
                    }
                }
            }
            return false; 
        }
        private void btnTạoTK_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // 1. Kiểm tra dữ liệu rỗng
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra dấu phẩy 
            if (email.Contains(",") || username.Contains(",") || password.Contains(","))
            {
                MessageBox.Show("Thông tin không được chứa dấu phẩy (,)", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Kiểm tra trùng lặp 
            if (KiemTraTonTai(email, username))
            {
                return; // Nếu trùng thì dừng lại, không lưu nữa
            }

            try
            {
                // Tạo một dòng chứa thông tin người dùng
                string line = $"{email},{username},{password}";

                // Ghi dòng đó vào file "users.txt"
                File.AppendAllText("users.txt", line + Environment.NewLine);

                MessageBox.Show("Tạo tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // (Tùy chọn) Xóa trắng các ô nhập sau khi đăng ký xong
                txtEmail.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        


        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Bạn có chắc muốn thoát khỏi ứng dụng", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Tạo form đăng nhập và hiển thị nó
            DangNhap formDN = new DangNhap();
            formDN.Show();

            // Ẩn form đăng ký hiện tại
            this.Hide();

        }
    }
}
