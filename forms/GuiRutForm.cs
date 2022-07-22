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
    public partial class GuiRutForm : DevExpress.XtraEditors.XtraForm
    {
        public GuiRutForm()
        {
            InitializeComponent();
        }

        private void GuiRutForm_Load(object sender, EventArgs e)
        {
            this.sP_DS_TAIKHOANTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DS_TAIKHOANTableAdapter.Fill(this.nGANHANGDataSet.SP_DS_TAIKHOAN);
            // TODO: This line of code loads data into the 'nGANHANGDataSet.TaiKhoan' table. You can move, or remove it, as needed.

            if (Program.mGroup == "NGANHANG")
            {
                btnGuiRut.Enabled = false;
            }

            txtMANV.Text = Program.username;
            txtNgayGD.Text = DateTime.Now.ToString("yyyy-MM-dd");

            txtSoTien.Focus();

        }

        private void btnGuiRut_Click(object sender, EventArgs e)
        {
            string loaiGD = "GT";
            if (txtSoTK.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập số tài khoản", "", MessageBoxButtons.OK);
                txtSoTK.Focus();
                return;
            }
            else if (txtSoTien.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập số tiền chuyển", "", MessageBoxButtons.OK);
                txtSoTien.Focus();
                return;
            }
            else if (!Extra_function.check_ID_TK(txtSoTK.Text.Trim()))
            {
                MessageBox.Show("Số tài khoản không tồn tại", "", MessageBoxButtons.OK);
                txtSoTK.Focus();
                return;
            }
            int soTien = 0;
            try
            {
                soTien = Int32.Parse(txtSoTien.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Số tiền không hợp lệ", "", MessageBoxButtons.OK);
                txtSoTien.Focus();
                return;
            }
            if (soTien < 100000)
            {
                MessageBox.Show("Số tiền giao dịch không hợp lệ. Số tiền > 100000", "", MessageBoxButtons.OK);
                txtSoTien.Focus();
                return;
            }
            else if (rbRut.Checked)
            {
                if (!Extra_function.check_SODU(txtSoTK.Text.Trim(), soTien))
                {
                    MessageBox.Show("Tài khoản không đủ tiền để thực hiện giao dịch", "", MessageBoxButtons.OK);
                    txtSoTK.Focus();
                    return;
                }
                loaiGD = "RT";
            }

            string date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            bool status = GuiRut(txtSoTK.Text.Trim(), loaiGD, soTien, Program.username, date);
            if (status)
            {
                MessageBox.Show("Giao dịch thành công", "", MessageBoxButtons.OK);
                try
                {
                    this.sP_DS_TAIKHOANTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_DS_TAIKHOANTableAdapter.Fill(this.nGANHANGDataSet.SP_DS_TAIKHOAN);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    return;
                }
            }
        }




        public bool GuiRut(string soTK, string loaiGD, int soTien, string maNV, string ngayGD)
        {
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            string str_sp = "dbo.SP_GUIRUT";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = str_sp;
            Program.sqlcmd.Parameters.Add("@SOTK", SqlDbType.NChar).Value = soTK;
            Program.sqlcmd.Parameters.Add("@LOAIGD", SqlDbType.NChar).Value = loaiGD;
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