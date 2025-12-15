using DemoQuanLiChiTieu;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DemoQuanLyThuChi
{
    public partial class HomeWindow : Form
    {
        //Thêm biến để lưu tên người dùng hiện tại
        private string tenDangNhap;
        public HomeWindow(string username)
        {
            InitializeComponent();
            this.tenDangNhap = username; // Lưu lại để dùng sau
        }

        private void btnQLChiTieu_Click(object sender, EventArgs e)
        {
            // Tạo tên file dựa theo tên người dùng: Ví dụ "Categories_admin.csv"
            string folderPath = Path.Combine(Application.StartupPath, "DuLieu");

            // 2. Sửa tên file thành "DanhMuc_..." thay vì "Categories_..."
            string tenFileRieng = "DanhMuc_" + tenDangNhap + ".csv";

            // 3. Đường dẫn đầy đủ
            string filePath = Path.Combine(folderPath, tenFileRieng);

            // -- Logic kiểm tra file  --
            bool chuaCoDuLieu = !File.Exists(filePath);
            if (!chuaCoDuLieu)
            {
                // Kiểm tra nếu file rỗng
                if (File.ReadAllLines(filePath).All(string.IsNullOrWhiteSpace)) chuaCoDuLieu = true;
            }

            if (chuaCoDuLieu)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn chưa có danh mục thu/chi nào.\n" +
                    "Bạn có muốn tạo danh mục ngay bây giờ không?",
                    "Cảnh báo thiếu dữ liệu",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Chuyển hướng sang trang tạo danh mục
                    btnQLDanhMuc_Click(sender, e);
                }
                // Dừng lại, không mở form Thu Chi
                return;
            }

            // Nếu đã có dữ liệu thì mới mở form
            QuanLyThuChi frmQLChiTieu = new QuanLyThuChi(tenDangNhap);
            frmQLChiTieu.ShowDialog();
        }

        private void btnQLDanhMuc_Click(object sender, EventArgs e)
        {
            // Truyền username sang QuanLyDanhMucThuChi
            QuanLyDanhMucThuChi frmDanhMuc = new QuanLyDanhMucThuChi(tenDangNhap);
            frmDanhMuc.ShowDialog();


        }
        private void btnDangXuat_Click(object sender, EventArgs e) 
        {
            //DangNhap frmLogin = new DangNhap();
            //frmLogin.Show();
            this.Close();
        }
    }
}
