using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGANHANG.forms
{
    public partial class FormKhachHang : Form
    {
        int vitri = 0;
        String macn = "";
        Boolean check = false;

        public FormKhachHang()
        {
            InitializeComponent();
        }
        public static bool Check_CMND(string CMND)
        {
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            string str_sp = "dbo.SP_CHECK_CMND";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = str_sp;
            Program.sqlcmd.Parameters.Add("@CMND", SqlDbType.NChar).Value = CMND;
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            String ret = Program.sqlcmd.Parameters["@RET"].Value.ToString();
            if (ret == "1")
            {
                return true; //đã có
            }
            return false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS1);

        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS1.TaiKhoan' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'dS1.ChiNhanh' table. You can move, or remove it, as needed.

            dS1.EnforceConstraints = false;
           // this.chiNhanhTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.chiNhanhTableAdapter.Fill(this.dS1.ChiNhanh);
            this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khachHangTableAdapter.Fill(this.dS1.KhachHang);
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.dS1.TaiKhoan);        
            //macn = ((DataRowView)bdsCN[0])["MACN"].ToString();
            cmbChinhNhanh.DataSource = Program.bds_dspm;
            cmbChinhNhanh.DisplayMember = "TENCN";
            cmbChinhNhanh.ValueMember = "TENSERVER";
            cmbChinhNhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "NGANHANG")
            {
                cmbChinhNhanh.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnUndo.Enabled = false;
                btnReload.Enabled = true;
                groupBox1.Enabled = false;
            }
            else
            {
                cmbChinhNhanh.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnChuyen.Enabled = btnThoat.Enabled = btnReload.Enabled = true;
                btnGhi.Enabled = btnUndo.Enabled = false;
                groupBox1.Enabled = false;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKH.Position;
            groupBox1.Enabled = true;
            bdsKH.AddNew();
            txtMACN.Text = (Program.mChinhanh == 0 ? "BENTHANH" : "TANDINH"); //macn;
            cmbPhai.Text = "Nam";
            DateEditNgaycap.DateTime=DateTime.Today;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnChuyen.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcKhachhang.Enabled = false;
            check = true;
            txtCMND.Enabled = true;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKH.CancelEdit();
            if (btnThem.Enabled == false) bdsKH.Position = vitri;
            this.khachHangTableAdapter.Fill(this.dS1.KhachHang);
            gcKhachhang.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled  = btnReload.Enabled = btnThoat.Enabled = true;
            btnUndo.Enabled = btnGhi.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtCMND.Enabled = false;
            vitri = bdsKH.Position;
            groupBox1.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled  = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcKhachhang.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khachHangTableAdapter.Fill(this.dS1.KhachHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int32 cmnd = 0;
            if (bdsTK.Count > 0)
            {
                MessageBox.Show("Không thể xóa khách hàng đã mở tài khoản", "", MessageBoxButtons.OK);
                return;
            }
           
            if (MessageBox.Show("Bạn có thật sự muốn xóa khách hàng này ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    cmnd = int.Parse(((DataRowView)bdsKH[bdsKH.Position])["CMND"].ToString());
                    bdsKH.RemoveCurrent();
                    this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khachHangTableAdapter.Update(this.dS1.KhachHang);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên! " + ex.Message, "", MessageBoxButtons.OK);
                    this.khachHangTableAdapter.Fill(this.dS1.KhachHang);
                    bdsKH.Position = bdsKH.Find("CMND", cmnd);
                    return;
                }
            }
            if (bdsKH.Count == 0) btnXoa.Enabled = btnSua.Enabled = false;
        }

        private void cmbChinhNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbChinhNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                    return;
                Program.servername = cmbChinhNhanh.SelectedValue.ToString();
                if (cmbChinhNhanh.SelectedIndex != Program.mChinhanh)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                else
                {
                    Program.mlogin = Program.loginDN;
                    Program.password = Program.passwordDN;
                }
                if (Program.KetNoi() == 0)
                    MessageBox.Show("Lỗi kết nối về chi nhánh mới! ", "", MessageBoxButtons.OK);
                else
                {
                    this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khachHangTableAdapter.Fill(this.dS1.KhachHang);
                    this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.taiKhoanTableAdapter.Fill(this.dS1.TaiKhoan);
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ khách hàng không được thiếu!", "", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên khách hàng không được thiếu!", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
            if (txtDiachi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ khách hàng không được thiếu!", "", MessageBoxButtons.OK);
                txtDiachi.Focus();
                return;
            }
            if (txtSDT.Text.Trim() == "")
            {
                MessageBox.Show("Số điện thoại khách hàng không được thiếu!", "", MessageBoxButtons.OK);
                txtSDT.Focus();
                return;
            }
            if (txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("CMND khách hàng không được thiếu!", "", MessageBoxButtons.OK);
                txtCMND.Focus();
                return;
            }
            //kt cmnd
            if(check&&Check_CMND(txtCMND.Text.Trim()))
            {
                MessageBox.Show("CMND đã tồn tại!", "", MessageBoxButtons.OK);
                txtCMND.Focus();
                return;
            }
            

            
            try
            {
                bdsKH.EndEdit();
                bdsKH.ResetCurrentItem();
                this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khachHangTableAdapter.Update(this.dS1.KhachHang);//
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi nhân viên! " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcKhachhang.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnUndo.Enabled = btnGhi.Enabled = false;
            groupBox1.Enabled = false;
            check = false;
        }

        private void txtSDT_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void chiNhanhBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
