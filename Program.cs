using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;
using System.Data;
using DevExpress.XtraEditors;
using NGANHANG.forms;

namespace NGANHANG
{
    static class Program
    {
        /// <summary>
        public static SqlConnection conn = new SqlConnection();
        public static SqlCommand sqlcmd = new SqlCommand();
        public static String connstr;
        public static SqlDataReader myReader;
        public static string servername;
        public static string database = "NGANHANG";
        public static int mChinhanh = 0;

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
        public static BindingSource bds_dspm = new BindingSource();

        public static FormLogin login;
        public static MainForm main;
        //public static NhanVien formNhanVien;
        //public static KhachHang formKhachHang;

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Bạn xem lại user name và password.", "Lỗi đăng nhập", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Program.login = new FormLogin()
            Application.Run(new FormLogin());
        }
    }
}
