using DemoQuanLiChiTieu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoQuanLyThuChi
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WelcomeForm());
            //Application.Run(new QuanLyThuChi());
            //Application.Run(new DangNhap());

        }
    }
}
