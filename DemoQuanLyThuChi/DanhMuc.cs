using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQuanLiChiTieu
{
    [Serializable]
    internal class DanhMuc
    {
        private string maDM;
        private string tenDM;
        private bool laThu; //True là Thu, False là Chi
        //Khởi tạo hàm không tham số
        public DanhMuc()
        {
            this.maDM = null;
            this.laThu = true;   
            this.tenDM = null;
        }
        //Khởi tạo hàm có tham số
        public DanhMuc(string maDM, bool laThu, string tenDM)
        {
            this.maDM = maDM;
            this.laThu = laThu;
            this.tenDM = tenDM;
        }
        //Property
        public string MaGD
        {
            get { return this.maDM; }
            set { this.maDM = value; }
        }
        public string Loai
        {
            get { return LayLoaiDanhMuc(); }
        }
        public string LayLoaiDanhMuc()
        {
            if (this.laThu == true)
                return "Thu";
            else
                return "Chi";
        }
        public string TenDM
        {
            get { return this.tenDM; }
            set { this.tenDM = value; }
        }

    }
}
