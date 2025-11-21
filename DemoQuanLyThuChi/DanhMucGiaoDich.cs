using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;


namespace DemoQuanLiChiTieu
{
    internal class DanhMucGiaoDich
    {
        private List<GiaoDich> dsGiaoDich;

        public DanhMucGiaoDich()
        {
            this.dsGiaoDich = new List<GiaoDich>();
        }
        public DanhMucGiaoDich(List<GiaoDich> list)
        {
            this.dsGiaoDich = list;
        }
        public List<GiaoDich> DSGiaoDich
        {
            get {  return this.dsGiaoDich; }
            set {  this.dsGiaoDich = value;}
        }
        //Kiểm tra mã
        public bool KiemTraMa(string ma)
        {
            foreach(GiaoDich gd in this.dsGiaoDich)
                if(gd.MaGD.Equals(ma))
                    { return true; }
            return false;
        }
        //Thêm
        public bool ThemGiaoDich(GiaoDich gd)
        {
            if (KiemTraMa(gd.MaGD))
                return false;

            this.dsGiaoDich.Add(gd);
            return true;
        }
        //Xóa
        public bool XoaGiaoDich(int viTri)
        {
            if (viTri < 0 || viTri >= this.dsGiaoDich.Count)
                return false;
            this.dsGiaoDich.RemoveAt(viTri);
            return true;
        }
        //Cập nhật
        public bool CapNhatGiaoDich(GiaoDich gd ,int viTri)
        {
            if (viTri < 0 || viTri >= this.dsGiaoDich.Count)
                return false;
            this.dsGiaoDich[viTri] = gd;
            return true;
        }
        //GhiFile
        public bool GhiFile(string tenFile)
        {
            try
            {
                FileStream fs = new FileStream(tenFile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dsGiaoDich);
                fs.Close();
                return true;
            }
            catch 
            { 
                return false;
            }
        }
        //Đọc file
        public bool DocFile(string tenFile)
        {
            try
            {
                FileStream fs = new FileStream(tenFile, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                dsGiaoDich = (List<GiaoDich>)bf.Deserialize(fs);
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Lọc theo tháng
        public List<GiaoDich>LocTheoThang(int thang)
        {
            List<GiaoDich>kq=new List<GiaoDich>();
            foreach(GiaoDich gd in this.dsGiaoDich)
                if(gd.Ngay.Month==thang)
                    kq.Add(gd);
            return kq;
        }
        //Lọc theo danh mục
        public List<GiaoDich>LocTheoDanhMuc(string dm)
        {
            List<GiaoDich>kq=new List<GiaoDich>();
            foreach(GiaoDich gd in this.dsGiaoDich)
                if(gd.DanhMuc.Equals(dm))
                    kq.Add(gd);
            return kq;
        }
        
    }
}
