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
            frmQLChiTieu.Show();
            this.Hide(); // Ẩn form hiện tại nếu cần

        }

        private void btnQLDanhMuc_Click(object sender, EventArgs e)
        {
            //// Mở form Danh Mục Thu Chi
            //DanhMucThuChi frmDanhMuc = new DanhMucThuChi();
            //frmDanhMuc.Show();
            //this.Hide();

        }
    }
}
