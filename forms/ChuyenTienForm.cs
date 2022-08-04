using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace NGANHANG.forms
{
    public partial class ChuyenTienForm : DevExpress.XtraEditors.XtraForm
    {
        public ChuyenTienForm()
        {
            InitializeComponent();
        }

        private void taiKhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.nGANHANGDataSet);

        }

        private void ChuyenTienForm_Load(object sender, EventArgs e)
        {
            this.sP_DS_TAIKHOANTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DS_TAIKHOANTableAdapter.Fill(this.nGANHANGDataSet.SP_DS_TAIKHOAN);
            // TODO: This line of code loads data into the 'nGANHANGDataSet.TaiKhoan' table. You can move, or remove it, as needed.

            if (Program.mGroup == "NGANHANG")
            {
                btnChuyen.Enabled = false;
            }

            txtMANV.Text = Program.username;
            txtNgayChuyen.Text = DateTime.Now.ToString("yyyy-MM-dd");

            txtTKNhan.Focus();

        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            if (txtTKChuyen.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập số tài khoản chuyển", "", MessageBoxButtons.OK);
                txtTKChuyen.Focus();
                return;
            }
            else if (txtTKChuyen.Text.Trim().Length > 9)
            {
                MessageBox.Show("Số tài khoản chuyển tối đa là 9 số");
                txtTKChuyen.Focus();
                return;
            }
            else if (txtTKNhan.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập số tài khoản nhận", "", MessageBoxButtons.OK);
                txtTKNhan.Focus();
                return;
            }
            else if (txtTKNhan.Text.Trim().Length > 9)
            {
                MessageBox.Show("Số tài khoản nhận tối đa là 9 số");
                txtTKNhan.Focus();
                return;
            }
            else if (txtTKNhan.Text.Trim() == txtTKChuyen.Text.Trim())
            {
                MessageBox.Show("Trùng số tài khoản", "", MessageBoxButtons.OK);
                txtTKNhan.Focus();
                return;
            }
            else if (txtTienChuyen.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập số tiền chuyển", "", MessageBoxButtons.OK);
                txtTienChuyen.Focus();
                return;
            }
            else if (!Extra_function.check_ID_TK(txtTKChuyen.Text.Trim()))
            {
                MessageBox.Show("Số tài khoản chuyển không tồn tại", "", MessageBoxButtons.OK);
                txtTKChuyen.Focus();
                return;
            }
            else if (!Extra_function.check_ID_TK(txtTKNhan.Text.Trim()))
            {
                MessageBox.Show("Số tài khoản nhận không tồn tại", "", MessageBoxButtons.OK);
                txtTKNhan.Focus();
                return;
            }
            
            int soTien = 0;
            try
            {
                soTien = Int32.Parse(txtTienChuyen.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Số tiền chuyển không hợp lệ", "", MessageBoxButtons.OK);
                txtTienChuyen.Focus();
                return;
            }
            if (soTien <= 0)
            {
                MessageBox.Show("Số tiền chuyển không hợp lệ. Số tiền > 0", "", MessageBoxButtons.OK);
                txtTienChuyen.Focus();
                return;
            }
            else if (!Extra_function.check_SODU(txtTKChuyen.Text.Trim(), soTien))
            {
                MessageBox.Show("Tài khoản không đủ tiền để thực hiện giao dịch", "", MessageBoxButtons.OK);
                txtTKChuyen.Focus();
                return;
            }

            string date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            bool status = ChuyenTien(txtTKChuyen.Text.Trim(), txtTKNhan.Text.Trim(), soTien, Program.username, date);
            if (status)
            {
                MessageBox.Show("Giao dịch thành công", "", MessageBoxButtons.OK);
                try
                {
                    this.sP_DS_TAIKHOANTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_DS_TAIKHOANTableAdapter.Fill(this.nGANHANGDataSet.SP_DS_TAIKHOAN);
                }
                catch(System.Data.SqlClient.SqlException ex)
                {
                    return;
                }
            }


        }

        public bool ChuyenTien(string tkChuyen, string tkNhan, int soTien, string maNV, string ngayGD)
        {
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            string str_sp = "dbo.SP_CHUYENTIEN";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = str_sp;
            Program.sqlcmd.Parameters.Add("@TKChuyen", SqlDbType.NChar).Value = tkChuyen;
            Program.sqlcmd.Parameters.Add("@TKNhan", SqlDbType.NChar).Value = tkNhan;
            Program.sqlcmd.Parameters.Add("@SOTIEN", SqlDbType.Money).Value = soTien;
            Program.sqlcmd.Parameters.Add("@MANV", SqlDbType.NChar).Value = maNV;
            Program.sqlcmd.Parameters.Add("@NGAYGD", SqlDbType.DateTime).Value = ngayGD;
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            String ret = Program.sqlcmd.Parameters["@RET"].Value.ToString();
            if (ret == "1")
            {
                return true; //Đã chuyển
            }
            return false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}