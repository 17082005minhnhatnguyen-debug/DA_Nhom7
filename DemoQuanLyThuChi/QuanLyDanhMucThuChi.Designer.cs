namespace DemoQuanLyThuChi
{
    partial class QuanLyDanhMucThuChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyDanhMucThuChi));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.MaDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
<<<<<<< HEAD
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtTenDanhMuc = new System.Windows.Forms.TextBox();
            this.txtMaDanhMuc = new System.Windows.Forms.TextBox();
=======
            this.cmbLoaiDM = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtTenDM = new System.Windows.Forms.TextBox();
            this.txtMaDM = new System.Windows.Forms.TextBox();
>>>>>>> 798e8a9f334982c33736b203d52b74438e164729
            this.btnThemDM = new System.Windows.Forms.Button();
            this.btnXoaDM = new System.Windows.Forms.Button();
            this.btnSuaDM = new System.Windows.Forms.Button();
            this.btnDocFile = new System.Windows.Forms.Button();
            this.btnGhiFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1250, 640);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(-2, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1250, 61);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "QUẢN LÝ DANH MỤC THU / CHI";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDM,
            this.TenDM,
            this.Loai});
            this.dgvDanhMuc.Location = new System.Drawing.Point(12, 356);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.RowHeadersWidth = 62;
            this.dgvDanhMuc.RowTemplate.Height = 28;
            this.dgvDanhMuc.Size = new System.Drawing.Size(1219, 272);
            this.dgvDanhMuc.TabIndex = 16;
            // 
            // MaDM
            // 
            this.MaDM.DataPropertyName = "MaDM";
            this.MaDM.HeaderText = "Mã Danh Mục";
            this.MaDM.MinimumWidth = 8;
            this.MaDM.Name = "MaDM";
            this.MaDM.Width = 150;
            // 
            // TenDM
            // 
            this.TenDM.DataPropertyName = "TenDM";
            this.TenDM.HeaderText = "Tên Danh Mục";
            this.TenDM.MinimumWidth = 8;
            this.TenDM.Name = "TenDM";
            this.TenDM.Width = 150;
            // 
            // Loai
            // 
            this.Loai.DataPropertyName = "Loai";
            this.Loai.HeaderText = "Loại";
            this.Loai.MinimumWidth = 8;
            this.Loai.Name = "Loai";
            this.Loai.Width = 150;
            // 
<<<<<<< HEAD
            // cboLoai
            // 
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Items.AddRange(new object[] {
            "Thu",
            "Chi"});
            this.cboLoai.Location = new System.Drawing.Point(612, 220);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(276, 28);
            this.cboLoai.TabIndex = 17;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(386, 97);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(147, 26);
            this.txt.TabIndex = 18;
            this.txt.Text = "Mã Danh Mục";
            this.txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
=======
            // cmbLoaiDM
            // 
            this.cmbLoaiDM.FormattingEnabled = true;
            this.cmbLoaiDM.Items.AddRange(new object[] {
            "Thu",
            "Chi"});
            this.cmbLoaiDM.Location = new System.Drawing.Point(612, 220);
            this.cmbLoaiDM.Name = "cmbLoaiDM";
            this.cmbLoaiDM.Size = new System.Drawing.Size(276, 28);
            this.cmbLoaiDM.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(386, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 26);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = "Mã Danh Mục";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
>>>>>>> 798e8a9f334982c33736b203d52b74438e164729
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(386, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(147, 26);
            this.textBox3.TabIndex = 19;
            this.textBox3.Text = "Tên Danh Mục";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(386, 222);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(147, 26);
            this.textBox4.TabIndex = 20;
            this.textBox4.Text = "Loại";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
<<<<<<< HEAD
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Location = new System.Drawing.Point(612, 155);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(276, 26);
            this.txtTenDanhMuc.TabIndex = 21;
            this.txtTenDanhMuc.Text = "\r\n";
            this.txtTenDanhMuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaDanhMuc
            // 
            this.txtMaDanhMuc.Location = new System.Drawing.Point(612, 97);
            this.txtMaDanhMuc.Name = "txtMaDanhMuc";
            this.txtMaDanhMuc.Size = new System.Drawing.Size(276, 26);
            this.txtMaDanhMuc.TabIndex = 22;
            this.txtMaDanhMuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
=======
            // txtTenDM
            // 
            this.txtTenDM.Location = new System.Drawing.Point(612, 155);
            this.txtTenDM.Name = "txtTenDM";
            this.txtTenDM.Size = new System.Drawing.Size(276, 26);
            this.txtTenDM.TabIndex = 21;
            this.txtTenDM.Text = "\r\n";
            this.txtTenDM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaDM
            // 
            this.txtMaDM.Location = new System.Drawing.Point(612, 97);
            this.txtMaDM.Name = "txtMaDM";
            this.txtMaDM.Size = new System.Drawing.Size(276, 26);
            this.txtMaDM.TabIndex = 22;
            this.txtMaDM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
>>>>>>> 798e8a9f334982c33736b203d52b74438e164729
            // 
            // btnThemDM
            // 
            this.btnThemDM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemDM.BackgroundImage")));
            this.btnThemDM.Location = new System.Drawing.Point(356, 281);
            this.btnThemDM.Name = "btnThemDM";
            this.btnThemDM.Size = new System.Drawing.Size(75, 41);
            this.btnThemDM.TabIndex = 30;
            this.btnThemDM.Text = "Thêm";
            this.btnThemDM.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            this.btnThemDM.Click += new System.EventHandler(this.btnThemDM_Click);
=======
>>>>>>> 798e8a9f334982c33736b203d52b74438e164729
            // 
            // btnXoaDM
            // 
            this.btnXoaDM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaDM.BackgroundImage")));
            this.btnXoaDM.Location = new System.Drawing.Point(488, 281);
            this.btnXoaDM.Name = "btnXoaDM";
            this.btnXoaDM.Size = new System.Drawing.Size(75, 41);
            this.btnXoaDM.TabIndex = 30;
            this.btnXoaDM.Text = "Xóa";
            this.btnXoaDM.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            this.btnXoaDM.Click += new System.EventHandler(this.btnXoaDM_Click);
=======
>>>>>>> 798e8a9f334982c33736b203d52b74438e164729
            // 
            // btnSuaDM
            // 
            this.btnSuaDM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuaDM.BackgroundImage")));
            this.btnSuaDM.Location = new System.Drawing.Point(612, 281);
            this.btnSuaDM.Name = "btnSuaDM";
            this.btnSuaDM.Size = new System.Drawing.Size(75, 41);
            this.btnSuaDM.TabIndex = 30;
            this.btnSuaDM.Text = "Sửa";
            this.btnSuaDM.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            this.btnSuaDM.Click += new System.EventHandler(this.btnSuaDM_Click);
=======
>>>>>>> 798e8a9f334982c33736b203d52b74438e164729
            // 
            // btnDocFile
            // 
            this.btnDocFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDocFile.BackgroundImage")));
            this.btnDocFile.Location = new System.Drawing.Point(730, 281);
            this.btnDocFile.Name = "btnDocFile";
            this.btnDocFile.Size = new System.Drawing.Size(75, 41);
            this.btnDocFile.TabIndex = 34;
            this.btnDocFile.Text = "Đọc File";
            this.btnDocFile.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            this.btnDocFile.Click += new System.EventHandler(this.btnDocFile_Click);
=======
>>>>>>> 798e8a9f334982c33736b203d52b74438e164729
            // 
            // btnGhiFile
            // 
            this.btnGhiFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGhiFile.BackgroundImage")));
            this.btnGhiFile.Location = new System.Drawing.Point(849, 281);
            this.btnGhiFile.Name = "btnGhiFile";
            this.btnGhiFile.Size = new System.Drawing.Size(75, 41);
            this.btnGhiFile.TabIndex = 35;
            this.btnGhiFile.Text = "Ghi File";
            this.btnGhiFile.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            this.btnGhiFile.Click += new System.EventHandler(this.btnGhiFile_Click);
=======
>>>>>>> 798e8a9f334982c33736b203d52b74438e164729
            // 
            // QuanLyDanhMucThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 639);
            this.Controls.Add(this.btnGhiFile);
            this.Controls.Add(this.btnDocFile);
            this.Controls.Add(this.btnSuaDM);
            this.Controls.Add(this.btnXoaDM);
            this.Controls.Add(this.btnThemDM);
<<<<<<< HEAD
            this.Controls.Add(this.txtMaDanhMuc);
            this.Controls.Add(this.txtTenDanhMuc);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.cboLoai);
=======
            this.Controls.Add(this.txtMaDM);
            this.Controls.Add(this.txtTenDM);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cmbLoaiDM);
>>>>>>> 798e8a9f334982c33736b203d52b74438e164729
            this.Controls.Add(this.dgvDanhMuc);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "QuanLyDanhMucThuChi";
            this.Text = "QuanLyDanhMucThuChi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
<<<<<<< HEAD
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtTenDanhMuc;
        private System.Windows.Forms.TextBox txtMaDanhMuc;
=======
        private System.Windows.Forms.ComboBox cmbLoaiDM;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtTenDM;
        private System.Windows.Forms.TextBox txtMaDM;
>>>>>>> 798e8a9f334982c33736b203d52b74438e164729
        private System.Windows.Forms.Button btnThemDM;
        private System.Windows.Forms.Button btnXoaDM;
        private System.Windows.Forms.Button btnSuaDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
        private System.Windows.Forms.Button btnDocFile;
        private System.Windows.Forms.Button btnGhiFile;
    }
}