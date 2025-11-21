using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQuanLiChiTieu
{
    [Serializable]
    internal class GiaoDich
    {
        private string maGD;
        private DateTime ngay;
        private bool laThu;
        private string danhMuc;
        private string noiDung;
        private decimal soTien;
        //Khởi tạo hàm không tham số
        public GiaoDich()
        {
            this.maGD = null;
            this.ngay = DateTime.Now;
            this.laThu = true;   //true là thu, false chi
            this.danhMuc = null;
            this.noiDung = null;
            this.soTien = 0m;
            
        }
        //Khởi tạo hàm có tham số
        public GiaoDich(string maGD, DateTime ngay,bool laThu, string danhMuc, string noiDung, decimal soTien)
        {
            this.maGD = maGD;
            this.ngay = ngay;
            this.laThu = laThu;
            this.danhMuc = danhMuc;
            this.noiDung = noiDung;
            this.soTien = soTien;
        }
        //Property
        public string MaGD
        {
            get { return this.maGD; }
            set { this.maGD = value; }
        }
        public DateTime NgayGD
        {
            get { return this.ngay; }
            set { this.ngay = value; }
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
        public string DanhMuc
        {
            get { return this.danhMuc; }
            set { this.danhMuc = value;}
        }
        public string NoiDung
        {
            get { return this.noiDung; }
            set { this.noiDung = value; }
        }
        public decimal SoTien
        {
            get { return this.soTien; }
            set { this.soTien = value; }
        }
       
    }
}
