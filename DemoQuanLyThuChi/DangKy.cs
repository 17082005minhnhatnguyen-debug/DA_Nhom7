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
<<<<<<< HEAD
using System.IO;
=======
<<<<<<< HEAD
using System.IO;
=======

>>>>>>> 798e8a9f334982c33736b203d52b74438e164729
>>>>>>> 6c1d7c4ef02174d5f7abd43df847e177a126e1b4
namespace DemoQuanLyThuChi
{
    public partial class DangKy: Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        private void btnTạoTK_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 6c1d7c4ef02174d5f7abd43df847e177a126e1b4
            string email = txtEmail.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            //Kiểm tra nếu có ô nào bị trống thì báo lỗi
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;//Dừng xử lý nếu thiếu thông tin
            }

            try
            {
                //Tạo một dòng chứa thông tin người dùng
                string line = $"{email},{username},{password}";
                //Ghi dòng đó vào file"user.txt",mỗi tài khoản một dòng
                File.AppendAllText("users.txt", line + Environment.NewLine);
                //Hiển thị thông báo thành công
                MessageBox.Show("Tạo tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                //Nếu có lỗi khi ghi file , hiển thị thông báo lỗi
                MessageBox.Show("Lỗi khi lưu tài khoản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
               
<<<<<<< HEAD
=======
=======
            
                
        }
>>>>>>> 798e8a9f334982c33736b203d52b74438e164729
>>>>>>> 6c1d7c4ef02174d5f7abd43df847e177a126e1b4

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Bạn có chắc muốn thoát khỏi ứng dụng", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 6c1d7c4ef02174d5f7abd43df847e177a126e1b4

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Tạo form đăng nhập và hiển thị nó
            DangNhap formDN = new DangNhap();
            formDN.Show();

            // Ẩn form đăng ký hiện tại
            this.Hide();

        }
<<<<<<< HEAD
=======
=======
>>>>>>> 798e8a9f334982c33736b203d52b74438e164729
>>>>>>> 6c1d7c4ef02174d5f7abd43df847e177a126e1b4
    }
}
