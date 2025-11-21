<<<<<<< HEAD
﻿using DemoQuanLiChiTieu;
using System;
=======
<<<<<<< HEAD
﻿using DemoQuanLiChiTieu;
using System;
=======
﻿using System;
>>>>>>> 798e8a9f334982c33736b203d52b74438e164729
>>>>>>> 6c1d7c4ef02174d5f7abd43df847e177a126e1b4
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
=======
<<<<<<< HEAD
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
=======
>>>>>>> 798e8a9f334982c33736b203d52b74438e164729
>>>>>>> 6c1d7c4ef02174d5f7abd43df847e177a126e1b4

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
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 6c1d7c4ef02174d5f7abd43df847e177a126e1b4

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
<<<<<<< HEAD
=======
=======
>>>>>>> 798e8a9f334982c33736b203d52b74438e164729
>>>>>>> 6c1d7c4ef02174d5f7abd43df847e177a126e1b4
    }
}
