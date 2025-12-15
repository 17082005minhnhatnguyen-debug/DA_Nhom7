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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            DangNhap formDangNhap = new DangNhap();

            // Ẩn form Welcome hiện tại đi
            this.Hide();

            // Hiển thị form Đăng nhập dưới dạng hộp thoại (khi đóng form này code mới chạy tiếp)
            formDangNhap.ShowDialog();

            // Sau khi form Đăng nhập (và các form sau đó) đóng lại, thì đóng luôn form Welcome để kết thúc chương trình
            this.Close();
        }
    }
}
