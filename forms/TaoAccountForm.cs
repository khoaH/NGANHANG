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
    public partial class TaoAccountForm : DevExpress.XtraEditors.XtraForm
    {
        public TaoAccountForm()
        {
            InitializeComponent();
        }

        private void TaoAccountForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nGANHANGDataSet.vDS_NV' table. You can move, or remove it, as needed.
            this.vDS_NVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vDS_NVTableAdapter.Fill(this.nGANHANGDataSet.vDS_NV);
            cbChiNhanh.DataSource = Program.bds_dspm;
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.ValueMember = "TENSERVER";
            cbChiNhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "NGANHANG")
                txtNhomQuyen.Text = "Ngân Hàng";
            else if (Program.mGroup == "CHINHANH")
                txtNhomQuyen.Text = "Chi Nhánh";
        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (cbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                    return;
                // Gán chi nhánh mới
                Program.servername = cbChiNhanh.SelectedValue.ToString();
                // Dùng htkn để kết nối tới server mới thay cho login cũ nếu như thay đổi chi nhánh mới trên comboBoxBranch
                if (Program.mChinhanh != cbChiNhanh.SelectedIndex)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                // Dung tài khoản khi đăng nhập nếu như chọn lại chi nhánh chọn khi đăng nhập
                else
                {
                    Program.mlogin = Program.loginDN;
                    Program.password = Program.passwordDN;
                }
                if (Program.KetNoi() == 0)
                    MessageBox.Show($"Không thể kết nối đến server {Program.servername}", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    this.vDS_NVTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.vDS_NVTableAdapter.Fill(this.nGANHANGDataSet.vDS_NV);
                    lookUpNhanVien.EditValue = null;
                }

            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnTaoLogin_Click(object sender, EventArgs e)
        {
            if(lookUpNhanVien.EditValue == null)
            {
                MessageBox.Show("Bạn chưa chọn mã nhân viên", "", MessageBoxButtons.OK);
                lookUpNhanVien.Focus();
                return;
            }
            else if (txtLoginName.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập login name", "", MessageBoxButtons.OK);
                txtLoginName.Focus();
                return;
            }
            else if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "", MessageBoxButtons.OK);
                txtPassword.Focus();
                return;
            }
            else if (txtConfirm.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập xác nhận lại mật khẩu", "", MessageBoxButtons.OK);
                txtConfirm.Focus();
                return;
            }
            else if (!txtPassword.Text.Equals(txtConfirm.Text))
            {
                MessageBox.Show("Mật khẩu và xác nhận phải giống nhat!", "", MessageBoxButtons.OK);
                txtPassword.Focus();
                return;
            }
            else if (txtLoginName.Text.Trim().Contains(" "))
            {
                MessageBox.Show("Login name không được có khoảng trắng", "", MessageBoxButtons.OK);
                txtLoginName.Focus();
                return;
            }
            else
            {
                int status = TaoLogin(txtLoginName.Text.Trim(), lookUpNhanVien.EditValue.ToString().Trim(), txtPassword.Text.Trim(), Program.mGroup);
                if (status == 1)
                {
                    MessageBox.Show("Tạo tài khoản thành công cho nhân viên: " + lookUpNhanVien.EditValue.ToString().Trim(), "", MessageBoxButtons.OK);
                    return;
                }
                else if (status == -1)
                {
                    MessageBox.Show("Login name bị trùng", "", MessageBoxButtons.OK);
                    txtLoginName.Focus();
                    return;
                }
                else if (status == -2)
                {
                    MessageBox.Show("Nhân viên đã có login khác", "", MessageBoxButtons.OK);
                    txtLoginName.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("Đã có lỗi trong quá trình tạo tài khoản", "", MessageBoxButtons.OK);
                    return;
                }
            }

        }

        public int TaoLogin(string loginName, string maNV, string pass, string nhomQuyen)
        {
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            string str_sp = "dbo.SP_TAOLOGIN";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = str_sp;
            Program.sqlcmd.Parameters.Add("@LGNAME", SqlDbType.VarChar).Value = loginName;
            Program.sqlcmd.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = maNV;
            Program.sqlcmd.Parameters.Add("@PASS", SqlDbType.VarChar).Value = pass;
            Program.sqlcmd.Parameters.Add("@ROLE", SqlDbType.VarChar).Value = nhomQuyen;
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            String ret = Program.sqlcmd.Parameters["@RET"].Value.ToString();
            if (ret == "1")
                return 1; //Đã tạo
            else if (ret == "-1")
                return -1;
            else if (ret == "-2")
                return -2;
            else
                return 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}