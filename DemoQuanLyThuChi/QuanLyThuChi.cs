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

namespace DemoQuanLyThuChi
{
    public partial class QuanLyThuChi : Form
    {
        public QuanLyThuChi()
        {
            InitializeComponent();
        }
        private void dtpNgayGD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThemGD_Click(object sender, EventArgs e)
        {
            // Thêm một dòng mới vào bảng giao dịch

            int rowIndex = dgvGiaoDich.Rows.Add();
            // Gán giá trị từ các ô nhập liệu vào từng cột của dòng mới

            dgvGiaoDich.Rows[rowIndex].Cells["MaGD"].Value = txtMaGD.Text;
            dgvGiaoDich.Rows[rowIndex].Cells["NgayGD"].Value = dtpNgayGD.Value.ToShortDateString();
            dgvGiaoDich.Rows[rowIndex].Cells["Loai"].Value = cboLoaiGD.Text;
            dgvGiaoDich.Rows[rowIndex].Cells["DanhMuc"].Value = cboDanhMuc.Text;
            dgvGiaoDich.Rows[rowIndex].Cells["NoiDung"].Value = txtNoiDung.Text;
            dgvGiaoDich.Rows[rowIndex].Cells["SoTien"].Value = nudSoTien.Value;
        }

        private void btnXoaDM_Click(object sender, EventArgs e)
        {
            // Kiểm tra có dòng nào đang được chọn không

            if (dgvGiaoDich.SelectedRows.Count > 0)
            {
                // Xóa dòng được chọn khỏi bảng

                dgvGiaoDich.Rows.RemoveAt(dgvGiaoDich.SelectedRows[0].Index);
            }

        }

        private void btnSuaDM_Click(object sender, EventArgs e)
        {
            // Kiểm tra có dòng nào đang được chọn không

            if (dgvGiaoDich.SelectedRows.Count > 0)
            {
                // Gán lại giá trị mới từ các ô nhập liệu vào dòng được chọn

                DataGridViewRow row = dgvGiaoDich.SelectedRows[0];
                row.Cells["MaGD"].Value = txtMaGD.Text;
                row.Cells["NgayGD"].Value = dtpNgayGD.Value.ToShortDateString();
                row.Cells["Loai"].Value = cboLoaiGD.Text;
                row.Cells["DanhMuc"].Value = cboDanhMuc.Text;
                row.Cells["NoiDung"].Value = txtNoiDung.Text;
                row.Cells["SoTien"].Value = nudSoTien.Value;
            }

        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại chọn file CSV

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV Files|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Đọc toàn bộ dòng từ file

                string[] lines = File.ReadAllLines(ofd.FileName);
                dgvGiaoDich.Rows.Clear();
                // Thêm từng dòng vào bảng

                foreach (string line in lines)
                {
                    string[] data = line.Split(',');
                    dgvGiaoDich.Rows.Add(data);
                }
            }

        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại lưu file

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV Files|*.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Ghi từng dòng dữ liệu từ bảng vào file CSV

                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    foreach (DataGridViewRow row in dgvGiaoDich.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string line = string.Join(",", row.Cells.Cast<DataGridViewCell>().Select(c => c.Value?.ToString()));
                            sw.WriteLine(line);
                        }
                    }
                }
            }

        }

        private void btnTongThu_Click(object sender, EventArgs e)
        {
            // Tính tổng số tiền của các giao dịch loại "Thu"

            decimal tongThu = 0;
            foreach (DataGridViewRow row in dgvGiaoDich.Rows)
            {
                if (row.Cells["Loai"].Value?.ToString() == "Thu")
                {
                    tongThu += Convert.ToDecimal(row.Cells["SoTien"].Value);
                }
            }
            MessageBox.Show("Tổng Thu: " + tongThu.ToString("N0") + " VND");

        }

        private void btnTongChi_Click(object sender, EventArgs e)
        {
            // Tính tổng số tiền của các giao dịch loại "Chi"

            decimal tongChi = 0;
            foreach (DataGridViewRow row in dgvGiaoDich.Rows)
            {
                if (row.Cells["Loai"].Value?.ToString() == "Chi")
                {
                    tongChi += Convert.ToDecimal(row.Cells["SoTien"].Value);
                }
            }
            MessageBox.Show("Tổng Chi: " + tongChi.ToString("N0") + " VND");

        }

        private void btnSoDu_Click(object sender, EventArgs e)
        {
            decimal tongThu = 0, tongChi = 0;
            foreach (DataGridViewRow row in dgvGiaoDich.Rows)
            {
                string loai = row.Cells["Loai"].Value?.ToString();
                decimal soTien = Convert.ToDecimal(row.Cells["SoTien"].Value);
                if (loai == "Thu") tongThu += soTien;
                else if (loai == "Chi") tongChi += soTien;
            }
            decimal soDu = tongThu - tongChi;
            MessageBox.Show("Số Dư: " + soDu.ToString("N0") + " VND");

        }
    }
}
