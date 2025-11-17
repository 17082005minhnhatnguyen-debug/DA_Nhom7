using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChiTieu
{
    [Serializable]
    internal class GiaoDich
    {
        private string maGD;
        private DateTime ngay;
        private string danhMuc;
        private string moTa;
        private double soTien;
        private bool laThu; //true=Thu,false=Chi

        public GiaoDich()
        {
            this.maGD = null;
            this.ngay = DateTime.Now;
            this.danhMuc = null;
            this.moTa = null;
            this.soTien = 0;
            this.laThu = false;
            
        }
        public GiaoDich(string maGD, DateTime ngay, string danhMuc, string moTa, double soTien, bool laThu)
        {
            this.maGD = maGD;
            this.ngay = ngay;
            this.danhMuc = danhMuc;
            this.moTa = moTa;
            this.soTien = soTien;
            this.laThu = laThu;
        }
        public string MaGD
        {
            get { return this.maGD; }
            set { this.maGD = value; }
        }
        public DateTime Ngay
        {
            get { return this.ngay; }
            set { this.ngay = value; }
        }
        public string DanhMuc
        {
            get { return this.danhMuc; }
            set { this.danhMuc = value;}
        }
        public string MoTa
        {
            get { return this.moTa; }
            set { this.moTa = value; }
        }
        public double SoTien
        {
            get { return this.soTien; }
            set { this.soTien = value; }
        }
        public bool LaThu
        {
            get { return this.laThu; }
            set { this.laThu = value; }
        }
            public string Loai
        {
            get { return LayLoaiGiaoDich(); }
        }
        public string LayLoaiGiaoDich()
        {
            if (this.laThu == true)
                return "Thu";
            else
                return "Chi";
        }
    
    }
}
