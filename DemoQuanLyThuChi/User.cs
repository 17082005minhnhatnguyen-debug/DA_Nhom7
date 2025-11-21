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
        public User(string tenND, string matKhau)
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
            set { this.tenND = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
    }
}
