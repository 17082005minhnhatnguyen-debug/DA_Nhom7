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
using System.Security.Cryptography;
namespace DemoQuanLyThuChi
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        // Hàm kiểm tra xem Email hoặc Username đã có trong file users.txt
        private bool KiemTraTonTai(string checkEmail, string checkUsername)
        {          
            string filePath = Path.Combine(Application.StartupPath, "users.txt");

            // Thay thế "users.txt" bằng biến filePath
            if (!File.Exists(filePath))
            {
                return false;
            }
            // Thay thế "users.txt" bằng biến filePath
            string[] lines = File.ReadAllLines(filePath);

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
            string password = txtPassword.Text; // Không Trim() mật khẩu ngay nếu muốn kiểm tra chính xác input người dùng
            // 1. Kiểm tra dữ liệu rỗng
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (password.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!", "Mật khẩu quá ngắn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra dấu cách (khoảng trắng)
            if (password.Contains(" "))
            {
                MessageBox.Show("Mật khẩu không được chứa khoảng trắng (dấu cách)!", "Quy định mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra: Có ít nhất 1 chữ cái, 1 số và 1 ký tự đặc biệt
            // Sử dụng LINQ để kiểm tra từng ký tự trong chuỗi
            bool coChuCai = password.Any(char.IsLetter);          // Kiểm tra có a-z hoặc A-Z
            bool coSo = password.Any(char.IsDigit);               // Kiểm tra có 0-9
            bool coKyTuDacBiet = password.Any(c => !char.IsLetterOrDigit(c)); // Ký tự không phải chữ và số

            if (!coChuCai || !coSo || !coKyTuDacBiet)
            {
                MessageBox.Show("Mật khẩu cần đảm bảo độ mạnh:\n- Phải có ít nhất 1 chữ cái.\n- Phải có ít nhất 1 số.\n- Phải có ít nhất 1 ký tự đặc biệt (ví dụ: @, #, !).",
                                "Mật khẩu yếu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 2. Kiểm tra dấu phẩy (Để tránh lỗi file CSV/TXT)
            if (email.Contains(",") || username.Contains(",") || password.Contains(","))
            {
                MessageBox.Show("Thông tin không được chứa dấu phẩy (,)", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 3. Kiểm tra định dạng Email
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                if (addr.Address != email)
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Email không đúng định dạng! Vui lòng nhập lại (ví dụ: abc@gmail.com).",
                                "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Kiểm tra trùng lặp 
            if (KiemTraTonTai(email, username))
            {
                return;
            }
            try
            {

                string passwordHash = MaHoaMD5(password);
                string line = $"{email},{username},{passwordHash}";


                // Tạo đường dẫn tuyệt đối
                string filePath = Path.Combine(Application.StartupPath, "users.txt");

                // Lưu vào đường dẫn đó
                File.AppendAllText(filePath, line + Environment.NewLine);

                MessageBox.Show("Tạo tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            
            this.Close();

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

        private void cBPass_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = cBPass.Checked;

            if (isChecked)
            {
                // Nếu CheckBox được chọn (true) => Hiện mật khẩu
                // Đặt ký tự ẩn về ký tự null (char rỗng) để hiện nội dung
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                // Nếu CheckBox không được chọn (false) => Ẩn mật khẩu
                // Đặt ký tự ẩn về '*'
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
