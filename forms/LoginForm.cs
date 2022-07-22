using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace NGANHANG.forms
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nGANHANGDataSet.Get_Subcribes' table. You can move, or remove it, as needed.
            this.get_SubcribesTableAdapter.Fill(this.nGANHANGDataSet.Get_Subcribes);
            Program.bds_dspm = this.getSubcribesBindingSource;
            Program.bds_dspm.Sort = "TENCN ASC";
            comboBoxChiNhanh.SelectedIndex = Program.mChinhanh;
            Program.login = this;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Login name và mật khẩu không được trống ", "", MessageBoxButtons.OK);
                return;
            }

            Program.servername = comboBoxChiNhanh.SelectedValue.ToString();
            Program.mChinhanh = comboBoxChiNhanh.SelectedIndex;
            Program.mlogin = Program.loginDN = txtTaiKhoan.Text;
            Program.password = Program.passwordDN = txtMatKhau.Text;

            if (Program.KetNoi() == 0) return;
            MessageBox.Show("Đăng nhập thành công");
            string strLenh = "EXEC SP_Lay_Thong_Tin_NV_Tu_Login '" + Program.mlogin + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Tên đăng nhập không có quyền truy cập dữ liệu.\nBạn xem lại Tên đăng nhập và Mật khẩu", "Thông báo !", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();

            Program.main = new MainForm();
            Program.login.Visible = false;
            Program.main.Show();
        }

        private void comboBoxChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = comboBoxChiNhanh.SelectedValue.ToString();
            }
            catch
            {
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Program.conn.Close();
            if (Program.login != null)
                Program.login.Close();
            Close();
        }
    }
}