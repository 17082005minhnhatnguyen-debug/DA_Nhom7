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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1092, 471);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtMaGD
            // 
            this.txtMaGD.BackColor = System.Drawing.SystemColors.Window;
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
            this.dgvGiaoDich.ReadOnly = true;
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
            this.MaGD.ReadOnly = true;
            this.MaGD.Width = 150;
            // 
            // NgayGD
            // 
            this.NgayGD.DataPropertyName = "NgayGD";
            this.NgayGD.HeaderText = "Ngày Giao Dịch";
            this.NgayGD.MinimumWidth = 8;
            this.NgayGD.Name = "NgayGD";
            this.NgayGD.ReadOnly = true;
            this.NgayGD.Width = 150;
            // 
            // Loai
            // 
            this.Loai.DataPropertyName = "Loai";
            this.Loai.HeaderText = "Loai";
            this.Loai.MinimumWidth = 8;
            this.Loai.Name = "Loai";
            this.Loai.ReadOnly = true;
            this.Loai.Width = 150;
            // 
            // DanhMuc
            // 
            this.DanhMuc.DataPropertyName = "DanhMuc";
            this.DanhMuc.HeaderText = "Danh Mục";
            this.DanhMuc.MinimumWidth = 8;
            this.DanhMuc.Name = "DanhMuc";
            this.DanhMuc.ReadOnly = true;
            this.DanhMuc.Width = 150;
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "NoiDung";
            this.NoiDung.HeaderText = "Nội Dung";
            this.NoiDung.MinimumWidth = 8;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.ReadOnly = true;
            this.NoiDung.Width = 150;
            // 
            // SoTien
            // 
            this.SoTien.DataPropertyName = "SoTien";
            this.SoTien.HeaderText = "Số Tiền";
            this.SoTien.MinimumWidth = 8;
            this.SoTien.Name = "SoTien";
            this.SoTien.ReadOnly = true;
            this.SoTien.Width = 150;
            // 
            // btnThemGD
            // 
            this.btnThemGD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemGD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemGD.BackgroundImage")));
            this.btnThemGD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemGD.Location = new System.Drawing.Point(770, 103);
            this.btnThemGD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemGD.Name = "btnThemGD";
            this.btnThemGD.Size = new System.Drawing.Size(67, 34);
            this.btnThemGD.TabIndex = 30;
            this.btnThemGD.Text = "Thêm";
            this.btnThemGD.UseVisualStyleBackColor = true;
            this.btnThemGD.Click += new System.EventHandler(this.btnThemGD_Click);
            // 
            // btnXoaDM
            // 
            this.btnXoaDM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaDM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaDM.BackgroundImage")));
            this.btnXoaDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDM.Location = new System.Drawing.Point(770, 156);
            this.btnXoaDM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaDM.Name = "btnXoaDM";
            this.btnXoaDM.Size = new System.Drawing.Size(67, 30);
            this.btnXoaDM.TabIndex = 30;
            this.btnXoaDM.Text = "Xóa";
            this.btnXoaDM.UseVisualStyleBackColor = true;
            this.btnXoaDM.Click += new System.EventHandler(this.btnXoaDM_Click);
            // 
            // btnSuaDM
            // 
            this.btnSuaDM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaDM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuaDM.BackgroundImage")));
            this.btnSuaDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnTongThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongThu.Location = new System.Drawing.Point(880, 106);
            this.btnTongThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTongThu.Name = "btnTongThu";
            this.btnTongThu.Size = new System.Drawing.Size(105, 31);
            this.btnTongThu.TabIndex = 34;
            this.btnTongThu.Text = "Tổng Thu";
            this.btnTongThu.UseVisualStyleBackColor = true;
            this.btnTongThu.Click += new System.EventHandler(this.btnTongThu_Click);
            // 
            // btnTongChi
            // 
            this.btnTongChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTongChi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTongChi.BackgroundImage")));
            this.btnTongChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongChi.Location = new System.Drawing.Point(880, 156);
            this.btnTongChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTongChi.Name = "btnTongChi";
            this.btnTongChi.Size = new System.Drawing.Size(105, 30);
            this.btnTongChi.TabIndex = 35;
            this.btnTongChi.Text = "Tổng Chi";
            this.btnTongChi.UseVisualStyleBackColor = true;
            this.btnTongChi.Click += new System.EventHandler(this.btnTongChi_Click);
            // 
            // btnSoDu
            // 
            this.btnSoDu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSoDu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSoDu.BackgroundImage")));
            this.btnSoDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoDu.Location = new System.Drawing.Point(880, 210);
            this.btnSoDu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSoDu.Name = "btnSoDu";
            this.btnSoDu.Size = new System.Drawing.Size(105, 28);
            this.btnSoDu.TabIndex = 36;
            this.btnSoDu.Text = "Số Dư";
            this.btnSoDu.UseVisualStyleBackColor = true;
            this.btnSoDu.Click += new System.EventHandler(this.btnSoDu_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(-1, -2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1090, 46);
            this.label4.TabIndex = 37;
            this.label4.Text = "QUẢN LÝ THU / CHI";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Mã Giao Dịch";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "Ngày Giao Dịch";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "Loại Giao Dịch";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(166, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 21);
            this.label5.TabIndex = 41;
            this.label5.Text = "Nhóm Danh Mục";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(166, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 21);
            this.label6.TabIndex = 42;
            this.label6.Text = "Nội Dung";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(166, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 21);
            this.label7.TabIndex = 43;
            this.label7.Text = "Số Tiền";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QuanLyThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 467);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}