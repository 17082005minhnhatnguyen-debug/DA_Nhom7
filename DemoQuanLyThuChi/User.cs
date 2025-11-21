using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQuanLyThuChi
{
    internal class User
    {
        private string tenND;
        private string matKhau;
        private string email;
        public User()
        {
            this.tenND = null;
            this.matKhau = null;
            this.email = null;
        }
<<<<<<< HEAD
        public User(string tenND, string matKhau,string email)
=======
<<<<<<< HEAD
        public User(string tenND, string matKhau,string email)
=======
        public User(string tenND, string matKhau)
>>>>>>> 798e8a9f334982c33736b203d52b74438e164729
>>>>>>> 6c1d7c4ef02174d5f7abd43df847e177a126e1b4
        {
            this.tenND = tenND;
            this.matKhau = matKhau;
            this.email = email;
        }
        public string TenND
        {
            get { return this.tenND; }
            set { this.tenND = value; }
        }
        public string MatKhau
        {
            get { return this.matKhau; }
<<<<<<< HEAD
            set { this.matKhau = value; }
=======
<<<<<<< HEAD
            set { this.matKhau = value; }
=======
            set { this.tenND = value; }
>>>>>>> 798e8a9f334982c33736b203d52b74438e164729
>>>>>>> 6c1d7c4ef02174d5f7abd43df847e177a126e1b4
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
    }
}
