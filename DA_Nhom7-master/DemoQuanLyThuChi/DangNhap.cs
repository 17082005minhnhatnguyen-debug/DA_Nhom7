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
using System.Security.Cryptography;


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
            // Mã hoá mật khẩu người dùng vừa nhập để so sánh
            string passwordHash = MaHoaMD5(password);
            // Ví dụ: MD5 của "12345" là "827CCB0EEA8A706C4C34A16891F84E7B"
            if ((username == "user1" && passwordHash == "MD5_CUA_12345") ||
                (username == "admin" && passwordHash == "MD5_CUA_ADMIN123"))
            {
                return true;
            }           
            string filePath = Path.Combine(Application.StartupPath, "users.txt");
            if (File.Exists(filePath)) 
            {
                string[] lines = File.ReadAllLines(filePath); // Dùng biến filePath
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');                   
                    if (parts.Length >= 3)
                    {
                        // Giả sử đăng nhập bằng Email (index 0)
                        bool checkUser = parts[0].Equals(username, StringComparison.OrdinalIgnoreCase);
                        if (checkUser && parts[2] == passwordHash)
                        {
                            return true;
                        }
                    }
                }
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
            if (KiemTraTaiKhoan(username, password))  
            {
                MessageBox.Show("Đăng nhập thành công!");

                HomeWindow home = new HomeWindow(username);
                // 1. Ẩn form đăng nhập đi
                this.Hide();
                // 2. Mở HomeWindow và "treo" code tại đây chờ cho đến khi HomeWindow đóng lại
                home.ShowDialog();
                // 3. Khi HomeWindow đóng (do bấm Đăng xuất hoặc tắt), dòng này sẽ chạy để hiện lại form Đăng nhập
                this.Show();
                // (Tùy chọn) Xóa mật khẩu để người dùng nhập lại cho an toàn
                txtMatKhau.Text = "";
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
        // Hàm mã hoá
        public string MaHoaMD5(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(str);
            byte[] hashBytes = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
