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
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.MaDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.txtTenDanhMuc = new System.Windows.Forms.TextBox();
            this.txtMaDanhMuc = new System.Windows.Forms.TextBox();
            this.btnThemDM = new System.Windows.Forms.Button();
            this.btnXoaDM = new System.Windows.Forms.Button();
            this.btnSuaDM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1250, 640);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.dgvDanhMuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.ReadOnly = true;
            this.dgvDanhMuc.RowHeadersWidth = 62;
            this.dgvDanhMuc.RowTemplate.Height = 28;
            this.dgvDanhMuc.Size = new System.Drawing.Size(1220, 272);
            this.dgvDanhMuc.TabIndex = 16;
            // 
            // MaDM
            // 
            this.MaDM.DataPropertyName = "MaDM";
            this.MaDM.HeaderText = "Mã Danh Mục";
            this.MaDM.MinimumWidth = 8;
            this.MaDM.Name = "MaDM";
            this.MaDM.ReadOnly = true;
            this.MaDM.Width = 150;
            // 
            // TenDM
            // 
            this.TenDM.DataPropertyName = "TenDM";
            this.TenDM.HeaderText = "Tên Danh Mục";
            this.TenDM.MinimumWidth = 8;
            this.TenDM.Name = "TenDM";
            this.TenDM.ReadOnly = true;
            this.TenDM.Width = 150;
            // 
            // Loai
            // 
            this.Loai.DataPropertyName = "Loai";
            this.Loai.HeaderText = "Loại";
            this.Loai.MinimumWidth = 8;
            this.Loai.Name = "Loai";
            this.Loai.ReadOnly = true;
            this.Loai.Width = 150;
            // 
            // cboLoai
            // 
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Items.AddRange(new object[] {
            "Thu",
            "Chi"});
            this.cboLoai.Location = new System.Drawing.Point(612, 220);
            this.cboLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(276, 28);
            this.cboLoai.TabIndex = 17;
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Location = new System.Drawing.Point(612, 155);
            this.txtTenDanhMuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(276, 26);
            this.txtTenDanhMuc.TabIndex = 21;
            this.txtTenDanhMuc.Text = "\r\n";
            this.txtTenDanhMuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaDanhMuc
            // 
            this.txtMaDanhMuc.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaDanhMuc.Location = new System.Drawing.Point(612, 98);
            this.txtMaDanhMuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaDanhMuc.Name = "txtMaDanhMuc";
            this.txtMaDanhMuc.ReadOnly = true;
            this.txtMaDanhMuc.Size = new System.Drawing.Size(276, 26);
            this.txtMaDanhMuc.TabIndex = 22;
            this.txtMaDanhMuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMaDanhMuc.Click += new System.EventHandler(this.txtMaDanhMuc_Click);
            // 
            // btnThemDM
            // 
            this.btnThemDM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemDM.BackgroundImage")));
            this.btnThemDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDM.Location = new System.Drawing.Point(407, 281);
            this.btnThemDM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemDM.Name = "btnThemDM";
            this.btnThemDM.Size = new System.Drawing.Size(75, 41);
            this.btnThemDM.TabIndex = 30;
            this.btnThemDM.Text = "Thêm";
            this.btnThemDM.UseVisualStyleBackColor = true;
            this.btnThemDM.Click += new System.EventHandler(this.btnThemDM_Click);
            // 
            // btnXoaDM
            // 
            this.btnXoaDM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaDM.BackgroundImage")));
            this.btnXoaDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDM.Location = new System.Drawing.Point(576, 281);
            this.btnXoaDM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaDM.Name = "btnXoaDM";
            this.btnXoaDM.Size = new System.Drawing.Size(75, 41);
            this.btnXoaDM.TabIndex = 30;
            this.btnXoaDM.Text = "Xóa";
            this.btnXoaDM.UseVisualStyleBackColor = true;
            this.btnXoaDM.Click += new System.EventHandler(this.btnXoaDM_Click);
            // 
            // btnSuaDM
            // 
            this.btnSuaDM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuaDM.BackgroundImage")));
            this.btnSuaDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDM.Location = new System.Drawing.Point(740, 281);
            this.btnSuaDM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaDM.Name = "btnSuaDM";
            this.btnSuaDM.Size = new System.Drawing.Size(75, 41);
            this.btnSuaDM.TabIndex = 30;
            this.btnSuaDM.Text = "Sửa";
            this.btnSuaDM.UseVisualStyleBackColor = true;
            this.btnSuaDM.Click += new System.EventHandler(this.btnSuaDM_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 26);
            this.label1.TabIndex = 35;
            this.label1.Text = "Mã danh mục";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 30);
            this.label2.TabIndex = 35;
            this.label2.Text = "Loại";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 30);
            this.label3.TabIndex = 35;
            this.label3.Text = "Tên danh mục";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(-2, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1250, 58);
            this.label4.TabIndex = 36;
            this.label4.Text = "QUẢN LÝ DANH MỤC THU / CHI";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QuanLyDanhMucThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1243, 639);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSuaDM);
            this.Controls.Add(this.btnXoaDM);
            this.Controls.Add(this.btnThemDM);
            this.Controls.Add(this.txtMaDanhMuc);
            this.Controls.Add(this.txtTenDanhMuc);
            this.Controls.Add(this.cboLoai);
            this.Controls.Add(this.dgvDanhMuc);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLyDanhMucThuChi";
            this.Text = "QuanLyDanhMucThuChi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.TextBox txtTenDanhMuc;
        private System.Windows.Forms.TextBox txtMaDanhMuc;
        private System.Windows.Forms.Button btnThemDM;
        private System.Windows.Forms.Button btnXoaDM;
        private System.Windows.Forms.Button btnSuaDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}