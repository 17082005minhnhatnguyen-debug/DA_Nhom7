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
            
                
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Bạn có chắc muốn thoát khỏi ứng dụng", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
