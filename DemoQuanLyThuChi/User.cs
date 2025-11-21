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
        public User(string tenND, string matKhau)
>>>>>>> 798e8a9f334982c33736b203d52b74438e164729
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
            set { this.tenND = value; }
>>>>>>> 798e8a9f334982c33736b203d52b74438e164729
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
    }
}
