using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;

namespace NGANHANG
{
    static class Program
    {
        /// <summary>
        public static string connectionstring;
        public static string TenServer;
        public static string TenDataBase = "NGANHANG";
        public static BindingSource ChiNhanhbds;
        public static SqlDataReader myReader;

        //Tên login đang đăng nhập
        public static String loginDN = "";
        public static String passwordDN = "";

        //Tài khoản HTKN
        public static String remotelogin = "HTKN";
        public static String remotepassword = "hanh123";
        public static String mlogin = "";
        public static String password = "";

        public static String username = "";
        public static String mGroup = "";
        public static String mHoten = "";

        //public static NhanVien formNhanVien;
        //public static KhachHang formKhachHang;

        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
