namespace DemoQuanLyThuChi
{
    partial class QuanLyThuChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyThuChi));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txtMaGD = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.dtpNgayGD = new System.Windows.Forms.DateTimePicker();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.cboLoaiGD = new System.Windows.Forms.ComboBox();
            this.nudSoTien = new System.Windows.Forms.NumericUpDown();
            this.dgvGiaoDich = new System.Windows.Forms.DataGridView();
            this.MaGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemGD = new System.Windows.Forms.Button();
            this.btnXoaDM = new System.Windows.Forms.Button();
            this.btnSuaDM = new System.Windows.Forms.Button();
            this.btnTongThu = new System.Windows.Forms.Button();
            this.btnTongChi = new System.Windows.Forms.Button();
            this.btnSoDu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoDich)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1092, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(-3, -1);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1093, 52);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "QUẢN LÝ THU / CHI";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(171, 178);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 22);
            this.textBox2.TabIndex = 19;
            this.textBox2.Text = "Nhóm Danh Mục";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(171, 144);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(124, 22);
            this.textBox3.TabIndex = 20;
            this.textBox3.Text = "Loại Giao Dịch\r\n";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(171, 109);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(124, 22);
            this.textBox4.TabIndex = 21;
            this.textBox4.Text = "Ngày Giao Dịch\r\n";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(171, 73);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(124, 22);
            this.textBox5.TabIndex = 22;
            this.textBox5.Text = "Mã Giao Dịch\r\n";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(171, 217);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(124, 22);
            this.textBox6.TabIndex = 23;
            this.textBox6.Text = "Nội Dung\r\n";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(171, 253);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(124, 22);
            this.textBox7.TabIndex = 24;
            this.textBox7.Text = "Số Tiền\r\n";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaGD
            // 
            this.txtMaGD.Location = new System.Drawing.Point(368, 73);
            this.txtMaGD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaGD.Name = "txtMaGD";
            this.txtMaGD.ReadOnly = true;
            this.txtMaGD.Size = new System.Drawing.Size(263, 22);
            this.txtMaGD.TabIndex = 25;
            this.txtMaGD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(368, 217);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(263, 22);
            this.txtNoiDung.TabIndex = 26;
            this.txtNoiDung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpNgayGD
            // 
            this.dtpNgayGD.Location = new System.Drawing.Point(368, 106);
            this.dtpNgayGD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayGD.Name = "dtpNgayGD";
            this.dtpNgayGD.Size = new System.Drawing.Size(263, 22);
            this.dtpNgayGD.TabIndex = 27;
            // 
            // cboDanhMuc
            // 
            this.cboDanhMuc.FormattingEnabled = true;
            this.cboDanhMuc.Items.AddRange(new object[] {
            "Ăn Uống",
            "Chi Tiêu",
            "Di Chuyển",
            "Đầu Tư",
            "Nhà Cửa",
            "Lương",
            "Giải Trí",
            "Vay Mượn"});
            this.cboDanhMuc.Location = new System.Drawing.Point(368, 178);
            this.cboDanhMuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(263, 24);
            this.cboDanhMuc.TabIndex = 28;
            // 
            // cboLoaiGD
            // 
            this.cboLoaiGD.FormattingEnabled = true;
            this.cboLoaiGD.Items.AddRange(new object[] {
            "Thu",
            "Chi"});
            this.cboLoaiGD.Location = new System.Drawing.Point(368, 144);
            this.cboLoaiGD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLoaiGD.Name = "cboLoaiGD";
            this.cboLoaiGD.Size = new System.Drawing.Size(263, 24);
            this.cboLoaiGD.TabIndex = 29;
            this.cboLoaiGD.SelectedIndexChanged += new System.EventHandler(this.cboLoaiGD_SelectedIndexChanged);
            // 
            // nudSoTien
            // 
            this.nudSoTien.Location = new System.Drawing.Point(368, 254);
            this.nudSoTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudSoTien.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.nudSoTien.Name = "nudSoTien";
            this.nudSoTien.Size = new System.Drawing.Size(262, 22);
            this.nudSoTien.TabIndex = 30;
            // 
            // dgvGiaoDich
            // 
            this.dgvGiaoDich.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGiaoDich.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvGiaoDich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoDich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGD,
            this.NgayGD,
            this.Loai,
            this.DanhMuc,
            this.NoiDung,
            this.SoTien});
            this.dgvGiaoDich.Location = new System.Drawing.Point(-3, 300);
            this.dgvGiaoDich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGiaoDich.Name = "dgvGiaoDich";
            this.dgvGiaoDich.RowHeadersWidth = 62;
            this.dgvGiaoDich.RowTemplate.Height = 28;
            this.dgvGiaoDich.Size = new System.Drawing.Size(1092, 158);
            this.dgvGiaoDich.TabIndex = 31;
            this.dgvGiaoDich.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoDich_CellClick);
            // 
            // MaGD
            // 
            this.MaGD.DataPropertyName = "MaGD";
            this.MaGD.HeaderText = "Mã Giao Dịch";
            this.MaGD.MinimumWidth = 8;
            this.MaGD.Name = "MaGD";
            this.MaGD.Width = 150;
            // 
            // NgayGD
            // 
            this.NgayGD.DataPropertyName = "NgayGD";
            this.NgayGD.HeaderText = "Ngày Giao Dịch";
            this.NgayGD.MinimumWidth = 8;
            this.NgayGD.Name = "NgayGD";
            this.NgayGD.Width = 150;
            // 
            // Loai
            // 
            this.Loai.DataPropertyName = "Loai";
            this.Loai.HeaderText = "Loai";
            this.Loai.MinimumWidth = 8;
            this.Loai.Name = "Loai";
            this.Loai.Width = 150;
            // 
            // DanhMuc
            // 
            this.DanhMuc.DataPropertyName = "DanhMuc";
            this.DanhMuc.HeaderText = "Danh Mục";
            this.DanhMuc.MinimumWidth = 8;
            this.DanhMuc.Name = "DanhMuc";
            this.DanhMuc.Width = 150;
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "NoiDung";
            this.NoiDung.HeaderText = "Nội Dung";
            this.NoiDung.MinimumWidth = 8;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.Width = 150;
            // 
            // SoTien
            // 
            this.SoTien.DataPropertyName = "SoTien";
            this.SoTien.HeaderText = "Số Tiền";
            this.SoTien.MinimumWidth = 8;
            this.SoTien.Name = "SoTien";
            this.SoTien.Width = 150;
            // 
            // btnThemGD
            // 
            this.btnThemGD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemGD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemGD.BackgroundImage")));
            this.btnThemGD.Location = new System.Drawing.Point(770, 103);
            this.btnThemGD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemGD.Name = "btnThemGD";
            this.btnThemGD.Size = new System.Drawing.Size(67, 27);
            this.btnThemGD.TabIndex = 30;
            this.btnThemGD.Text = "Thêm";
            this.btnThemGD.UseVisualStyleBackColor = true;
            this.btnThemGD.Click += new System.EventHandler(this.btnThemGD_Click);
            // 
            // btnXoaDM
            // 
            this.btnXoaDM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaDM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaDM.BackgroundImage")));
            this.btnXoaDM.Location = new System.Drawing.Point(770, 158);
            this.btnXoaDM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaDM.Name = "btnXoaDM";
            this.btnXoaDM.Size = new System.Drawing.Size(67, 26);
            this.btnXoaDM.TabIndex = 30;
            this.btnXoaDM.Text = "Xóa";
            this.btnXoaDM.UseVisualStyleBackColor = true;
            this.btnXoaDM.Click += new System.EventHandler(this.btnXoaDM_Click);
            // 
            // btnSuaDM
            // 
            this.btnSuaDM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaDM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuaDM.BackgroundImage")));
            this.btnSuaDM.Location = new System.Drawing.Point(770, 210);
            this.btnSuaDM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaDM.Name = "btnSuaDM";
            this.btnSuaDM.Size = new System.Drawing.Size(67, 30);
            this.btnSuaDM.TabIndex = 30;
            this.btnSuaDM.Text = "Sửa";
            this.btnSuaDM.UseVisualStyleBackColor = true;
            this.btnSuaDM.Click += new System.EventHandler(this.btnSuaDM_Click);
            // 
            // btnTongThu
            // 
            this.btnTongThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTongThu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTongThu.BackgroundImage")));
            this.btnTongThu.Location = new System.Drawing.Point(885, 106);
            this.btnTongThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTongThu.Name = "btnTongThu";
            this.btnTongThu.Size = new System.Drawing.Size(89, 31);
            this.btnTongThu.TabIndex = 34;
            this.btnTongThu.Text = "Tổng Thu";
            this.btnTongThu.UseVisualStyleBackColor = true;
            this.btnTongThu.Click += new System.EventHandler(this.btnTongThu_Click);
            // 
            // btnTongChi
            // 
            this.btnTongChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTongChi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTongChi.BackgroundImage")));
            this.btnTongChi.Location = new System.Drawing.Point(885, 156);
            this.btnTongChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTongChi.Name = "btnTongChi";
            this.btnTongChi.Size = new System.Drawing.Size(89, 30);
            this.btnTongChi.TabIndex = 35;
            this.btnTongChi.Text = "Tổng Chi";
            this.btnTongChi.UseVisualStyleBackColor = true;
            this.btnTongChi.Click += new System.EventHandler(this.btnTongChi_Click);
            // 
            // btnSoDu
            // 
            this.btnSoDu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSoDu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSoDu.BackgroundImage")));
            this.btnSoDu.Location = new System.Drawing.Point(885, 210);
            this.btnSoDu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSoDu.Name = "btnSoDu";
            this.btnSoDu.Size = new System.Drawing.Size(94, 28);
            this.btnSoDu.TabIndex = 36;
            this.btnSoDu.Text = "Số Dư";
            this.btnSoDu.UseVisualStyleBackColor = true;
            this.btnSoDu.Click += new System.EventHandler(this.btnSoDu_Click);
            // 
            // QuanLyThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 467);
            this.Controls.Add(this.btnSoDu);
            this.Controls.Add(this.btnTongChi);
            this.Controls.Add(this.btnTongThu);
            this.Controls.Add(this.btnSuaDM);
            this.Controls.Add(this.btnXoaDM);
            this.Controls.Add(this.btnThemGD);
            this.Controls.Add(this.dgvGiaoDich);
            this.Controls.Add(this.nudSoTien);
            this.Controls.Add(this.cboLoaiGD);
            this.Controls.Add(this.cboDanhMuc);
            this.Controls.Add(this.dtpNgayGD);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.txtMaGD);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLyThuChi";
            this.Text = "QuanLyThuChi";
            this.Load += new System.EventHandler(this.QuanLyThuChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoDich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox txtMaGD;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.DateTimePicker dtpNgayGD;
        private System.Windows.Forms.ComboBox cboDanhMuc;
        private System.Windows.Forms.ComboBox cboLoaiGD;
        private System.Windows.Forms.NumericUpDown nudSoTien;
        private System.Windows.Forms.DataGridView dgvGiaoDich;
        private System.Windows.Forms.Button btnThemGD;
        private System.Windows.Forms.Button btnXoaDM;
        private System.Windows.Forms.Button btnSuaDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private System.Windows.Forms.Button btnTongThu;
        private System.Windows.Forms.Button btnTongChi;
        private System.Windows.Forms.Button btnSoDu;
    }
}