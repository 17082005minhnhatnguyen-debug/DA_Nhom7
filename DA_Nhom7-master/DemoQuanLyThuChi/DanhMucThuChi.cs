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
    internal class DanhMucThuChi
    {
        private List<DanhMuc> ds;
        public DanhMucThuChi()
        {
            this.ds = new List<DanhMuc>();
        }
        public DanhMucThuChi(List<DanhMuc> list)
        {
            this.ds = list;
        }
        public List<DanhMuc> DSGiaoDich
        {
            get { return this.ds; }
            set { this.ds = value; }
        }
        //Kiểm tra mã
        public bool KiemTraMa(string ma)
        {
            foreach (DanhMuc dm in this.ds)
                if (dm.MaGD.Equals(ma))
                { return true; }
            return false;
        }
        //Thêm
        public bool ThemGiaoDich(DanhMuc dm)
        {
            if (KiemTraMa(dm.MaGD))
                return false;

            this.ds.Add(dm);
            return true;
        }
        //Xóa
        public bool XoaGiaoDich(int viTri)
        {
            if (viTri < 0 || viTri >= this.ds.Count)
                return false;
            this.ds.RemoveAt(viTri);
            return true;
        }
        //Cập nhật
        public bool CapNhatGiaoDich(DanhMuc dm, int viTri)
        {
            if (viTri < 0 || viTri >= this.ds.Count)
                return false;
            this.ds[viTri] = dm;
            return true;
        }
        //GhiFile
        public bool GhiFile(string tenFile)
        {
            try
            {
                FileStream fs = new FileStream(tenFile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, ds);
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
                ds = (List<DanhMuc>)bf.Deserialize(fs);
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}