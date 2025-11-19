namespace DemoQuanLyThuChi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cmbNhomDM = new System.Windows.Forms.ComboBox();
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.nudSoTien = new System.Windows.Forms.NumericUpDown();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TongChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaGD = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSoDu = new System.Windows.Forms.Button();
            this.btnTongChi = new System.Windows.Forms.Button();
            this.btnTongThu = new System.Windows.Forms.Button();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.MaGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dtpNgayGD = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnDoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DanhMuc
            // 
            this.DanhMuc.DataPropertyName = "DanhMuc";
            this.DanhMuc.HeaderText = "Nhóm danh mục";
            this.DanhMuc.MinimumWidth = 8;
            this.DanhMuc.Name = "DanhMuc";
            this.DanhMuc.Width = 150;
            // 
            // SoTien
            // 
            this.SoTien.DataPropertyName = "SoTien";
            this.SoTien.HeaderText = "Số tiền";
            this.SoTien.MinimumWidth = 8;
            this.SoTien.Name = "SoTien";
            this.SoTien.Width = 150;
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "NoiDung";
            this.NoiDung.HeaderText = "Nội dung";
            this.NoiDung.MinimumWidth = 8;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.Width = 150;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(84, 289);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(176, 30);
            this.textBox9.TabIndex = 145;
            this.textBox9.Text = "Nội dung";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(84, 338);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(178, 30);
            this.textBox8.TabIndex = 144;
            this.textBox8.Text = "Số tiền";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(82, 185);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(178, 30);
            this.textBox7.TabIndex = 143;
            this.textBox7.Text = "Loại giao dịch";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(81, 238);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(178, 30);
            this.textBox6.TabIndex = 142;
            this.textBox6.Text = "Nhóm danh mục";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(899, 255);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 41);
            this.btnXoa.TabIndex = 141;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(899, 168);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 41);
            this.btnSua.TabIndex = 140;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(899, 90);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 41);
            this.btnThem.TabIndex = 139;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // cmbNhomDM
            // 
            this.cmbNhomDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNhomDM.FormattingEnabled = true;
            this.cmbNhomDM.Items.AddRange(new object[] {
            "Ăn Uống",
            "Chi Tiêu",
            "Theo Ngày",
            "Theo Tháng",
            "Lương",
            "Tiền điện",
            "Tiền Nước",
            "Tiền Nhà",
            "Vui Chơi",
            "Vay Mượn"});
            this.cmbNhomDM.Location = new System.Drawing.Point(366, 238);
            this.cmbNhomDM.Name = "cmbNhomDM";
            this.cmbNhomDM.Size = new System.Drawing.Size(337, 33);
            this.cmbNhomDM.TabIndex = 138;
            // 
            // cmbLoai
            // 
            this.cmbLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Items.AddRange(new object[] {
            "Thu",
            "Chi"});
            this.cmbLoai.Location = new System.Drawing.Point(366, 185);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(337, 33);
            this.cmbLoai.TabIndex = 137;
            // 
            // nudSoTien
            // 
            this.nudSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoTien.Location = new System.Drawing.Point(368, 338);
            this.nudSoTien.Name = "nudSoTien";
            this.nudSoTien.Size = new System.Drawing.Size(337, 30);
            this.nudSoTien.TabIndex = 136;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(366, 289);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(337, 30);
            this.txtNoiDung.TabIndex = 135;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(84, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 30);
            this.textBox1.TabIndex = 153;
            this.textBox1.Text = "Ngày giao dịch";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TongChi
            // 
            this.TongChi.DataPropertyName = "TongChi";
            this.TongChi.HeaderText = "Tổng chi";
            this.TongChi.MinimumWidth = 8;
            this.TongChi.Name = "TongChi";
            this.TongChi.Width = 150;
            // 
            // txtMaGD
            // 
            this.txtMaGD.Location = new System.Drawing.Point(366, 94);
            this.txtMaGD.Name = "txtMaGD";
            this.txtMaGD.Size = new System.Drawing.Size(339, 26);
            this.txtMaGD.TabIndex = 151;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(899, 336);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 41);
            this.btnThoat.TabIndex = 150;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnSoDu
            // 
            this.btnSoDu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSoDu.BackgroundImage")));
            this.btnSoDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoDu.Location = new System.Drawing.Point(1066, 306);
            this.btnSoDu.Name = "btnSoDu";
            this.btnSoDu.Size = new System.Drawing.Size(100, 41);
            this.btnSoDu.TabIndex = 149;
            this.btnSoDu.Text = "Số dư ";
            this.btnSoDu.UseVisualStyleBackColor = true;
            // 
            // btnTongChi
            // 
            this.btnTongChi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTongChi.BackgroundImage")));
            this.btnTongChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongChi.Location = new System.Drawing.Point(1066, 216);
            this.btnTongChi.Name = "btnTongChi";
            this.btnTongChi.Size = new System.Drawing.Size(100, 41);
            this.btnTongChi.TabIndex = 148;
            this.btnTongChi.Text = "Tổng chi";
            this.btnTongChi.UseVisualStyleBackColor = true;
            // 
            // btnTongThu
            // 
            this.btnTongThu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTongThu.BackgroundImage")));
            this.btnTongThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongThu.Location = new System.Drawing.Point(1066, 128);
            this.btnTongThu.Name = "btnTongThu";
            this.btnTongThu.Size = new System.Drawing.Size(100, 41);
            this.btnTongThu.TabIndex = 147;
            this.btnTongThu.Text = "Tổng thu";
            this.btnTongThu.UseVisualStyleBackColor = true;
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGD,
            this.NgayGD,
            this.Loai,
            this.DanhMuc,
            this.NoiDung,
            this.SoTien,
            this.TongThu,
            this.TongChi,
            this.SoDu});
            this.dgvDanhSach.Location = new System.Drawing.Point(21, 420);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 62;
            this.dgvDanhSach.RowTemplate.Height = 28;
            this.dgvDanhSach.Size = new System.Drawing.Size(1408, 223);
            this.dgvDanhSach.TabIndex = 146;
            // 
            // MaGD
            // 
            this.MaGD.DataPropertyName = "MaGD";
            this.MaGD.HeaderText = "Mã giao dịch";
            this.MaGD.MinimumWidth = 8;
            this.MaGD.Name = "MaGD";
            this.MaGD.Width = 150;
            // 
            // NgayGD
            // 
            this.NgayGD.DataPropertyName = "NgayGD";
            this.NgayGD.HeaderText = "Ngày giao dịch";
            this.NgayGD.MinimumWidth = 8;
            this.NgayGD.Name = "NgayGD";
            this.NgayGD.Width = 150;
            // 
            // Loai
            // 
            this.Loai.DataPropertyName = "Loai";
            this.Loai.HeaderText = "Loại giao dịch";
            this.Loai.MinimumWidth = 8;
            this.Loai.Name = "Loai";
            this.Loai.Width = 150;
            // 
            // TongThu
            // 
            this.TongThu.DataPropertyName = "TongThu";
            this.TongThu.HeaderText = "Tổng thu";
            this.TongThu.MinimumWidth = 8;
            this.TongThu.Name = "TongThu";
            this.TongThu.Width = 150;
            // 
            // SoDu
            // 
            this.SoDu.DataPropertyName = "SoDu";
            this.SoDu.HeaderText = "Số dư hiện tại";
            this.SoDu.MinimumWidth = 8;
            this.SoDu.Name = "SoDu";
            this.SoDu.Width = 150;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(84, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 30);
            this.textBox2.TabIndex = 152;
            this.textBox2.Text = "Mã giao dịch";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpNgayGD
            // 
            this.dtpNgayGD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayGD.Location = new System.Drawing.Point(366, 139);
            this.dtpNgayGD.Name = "dtpNgayGD";
            this.dtpNgayGD.Size = new System.Drawing.Size(338, 30);
            this.dtpNgayGD.TabIndex = 134;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1458, 632);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 132;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1458, 632);
            this.pictureBox1.TabIndex = 131;
            this.pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Silver;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.DarkBlue;
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1458, 47);
            this.textBox3.TabIndex = 133;
            this.textBox3.Text = "Quản lý chi tiêu cá nhân";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGhi
            // 
            this.btnGhi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGhi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.BackgroundImage")));
            this.btnGhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhi.Location = new System.Drawing.Point(1230, 268);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(100, 41);
            this.btnGhi.TabIndex = 154;
            this.btnGhi.Text = "Ghi File";
            this.btnGhi.UseVisualStyleBackColor = false;
            // 
            // btnDoc
            // 
            this.btnDoc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoc.BackgroundImage")));
            this.btnDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoc.Location = new System.Drawing.Point(1230, 176);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(100, 41);
            this.btnDoc.TabIndex = 155;
            this.btnDoc.Text = "Đọc File";
            this.btnDoc.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 679);
            this.Controls.Add(this.btnDoc);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cmbNhomDM);
            this.Controls.Add(this.cmbLoai);
            this.Controls.Add(this.nudSoTien);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtMaGD);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSoDu);
            this.Controls.Add(this.btnTongChi);
            this.Controls.Add(this.btnTongThu);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dtpNgayGD);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn DanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cmbNhomDM;
        private System.Windows.Forms.ComboBox cmbLoai;
        private System.Windows.Forms.NumericUpDown nudSoTien;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongChi;
        private System.Windows.Forms.TextBox txtMaGD;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSoDu;
        private System.Windows.Forms.Button btnTongChi;
        private System.Windows.Forms.Button btnTongThu;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDu;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dtpNgayGD;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnDoc;
    }
}

