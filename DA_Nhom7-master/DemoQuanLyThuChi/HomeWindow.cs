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
        public HomeWindow()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnTrangChinh_Click(object sender, EventArgs e)
        {
            // Mở lại form chính hoặc làm mới giao diện
            MessageBox.Show("Bạn đang ở Trang Chính!");

        }

        private void btnQLChiTieu_Click(object sender, EventArgs e)
        {
            // Mở form Quản Lý Thu Chi
            QuanLyThuChi frmQLChiTieu = new QuanLyThuChi();
            
            string fileDanhMuc = "Categories.csv"; // Quy định tên file danh mục cố định

            //  Nếu file chưa tồn tại HOẶC file không có dòng nào
            if (!File.Exists(fileDanhMuc) || File.ReadAllLines(fileDanhMuc).Length == 0)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn chưa có danh mục thu/chi nào (hoặc chưa tạo file dữ liệu).\n" +
                    "Bạn có muốn tạo danh mục ngay bây giờ không?",
                    "Cảnh báo thiếu dữ liệu",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Nếu bấm Yes -> Chuyển hướng sang trang tạo danh mục
                    btnQLDanhMuc_Click(sender, e);
                }
                // Nếu bấm No -> Thì thôi, đứng yên tại chỗ, không mở trang Thu Chi để tránh lỗi
                return;
                
            }
            frmQLChiTieu.ShowDialog();
        }

        private void btnQLDanhMuc_Click(object sender, EventArgs e)
        {
            // Mở form Danh Mục Thu Chi
            QuanLyDanhMucThuChi frmDanhMuc = new QuanLyDanhMucThuChi();
            frmDanhMuc.ShowDialog();
            

        }
        private void btnDangXuat_Click(object sender, EventArgs e) 
        {
            DangNhap frmLogin = new DangNhap();
            frmLogin.Show();
            this.Close();
        }
    }
}
