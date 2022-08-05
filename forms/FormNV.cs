using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGANHANG
{
    public partial class FormNV : Form
    {
        int vitri = 0;
        String macn = "";
        Boolean check = false;
        public FormNV()
        {
            InitializeComponent();
        }
        public static bool Check_MANV(string MANV)
        {
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            string str_sp = "dbo.SP_Tim_MANV";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = str_sp;
            Program.sqlcmd.Parameters.Add("@MANV", SqlDbType.NChar).Value = MANV;
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            String ret = Program.sqlcmd.Parameters["@RET"].Value.ToString();
            if (ret == "1")
            {
                return true; //đã có
            }
            return false;
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void FormNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.ChiNhanh' table. You can move, or remove it, as needed.
            
            dS.EnforceConstraints = false;
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);

            this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);
            //this.chiNhanhTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.chiNhanhTableAdapter.Fill(this.dS.ChiNhanh);
            //macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
            //macn =((DataRowView)bdsCN[0])["MACN"].ToString();
            cmbChinhNhanh.DataSource = Program.bds_dspm;
            cmbChinhNhanh.DisplayMember = "TENCN";
            cmbChinhNhanh.ValueMember = "TENSERVER";
            cmbChinhNhanh.SelectedIndex = Program.mChinhanh;
            if(Program.mGroup=="NGANHANG")
            {
                cmbChinhNhanh.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnChuyen.Enabled = btnUndo.Enabled  = false;
                btnReload.Enabled = true;
                groupBox1.Enabled = false;
            }
            else
            {
                cmbChinhNhanh.Enabled = false;
                btnThem.Enabled = btnSua.Enabled =  btnXoa.Enabled = btnChuyen.Enabled =btnThoat.Enabled=btnReload.Enabled=  true;
                btnGhi.Enabled = btnUndo.Enabled = false;
                groupBox1.Enabled = false;
            }


        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void nhanVienBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void nhanVienBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            groupBox1.Enabled = true;
            bdsNV.AddNew();
            txtMACN.Text = (Program.mChinhanh == 0 ? "BENTHANH" : "TANDINH"); //macn;
            cmbPhai.Text = "Nam";
            trangThaiXoa.Value = 0;
            btnThem.Enabled = btnSua.Enabled= btnXoa.Enabled = btnChuyen.Enabled =btnReload.Enabled = btnThoat.Enabled= false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcNhanvien.Enabled = false;
            check = true;
            txtMANV.Enabled = true;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNV.CancelEdit();
            if (btnThem.Enabled == false) bdsNV.Position = vitri;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            gcNhanvien.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnChuyen.Enabled= btnReload.Enabled = btnThoat.Enabled = true;
            btnUndo.Enabled = btnGhi.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            groupBox1.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnChuyen.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcNhanvien.Enabled = false;
            txtMANV.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int32 manv = 0;
            if(bdsGoirut.Count>0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã có giao dịch gởi rút", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsChuyentien.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã có giao dịch chuyển tiền", "", MessageBoxButtons.OK);
                return;
            }
            if(MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này ?", "Xác nhận", MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                try
                {
                    manv = int.Parse(((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString());
                    bdsNV.RemoveCurrent();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.dS.NhanVien);

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên! " + ex.Message, "", MessageBoxButtons.OK);
                    this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                    bdsNV.Position = bdsNV.Find("MANV", manv);
                    return;
                }
            }
            if (bdsNV.Count == 0) btnXoa.Enabled =btnSua.Enabled= false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMANV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                txtMANV.Focus();
                return;
            }
            if (check&&Check_MANV(txtMANV.Text.Trim()))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!", "", MessageBoxButtons.OK);
                txtMANV.Focus();
                return;
            }
            if (txtHo.Text.Trim()=="")
            {
                MessageBox.Show("Họ nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
            if (txtDiachi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                txtDiachi.Focus();
                return;
            }
            if (txtSDT.Text.Trim() == "")
            {
                MessageBox.Show("Số điện thoại nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                txtSDT.Focus();
                return;
            }
            try
            {
                bdsNV.EndEdit();
                bdsNV.ResetCurrentItem();
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Update(this.dS.NhanVien);//
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ghi nhân viên! " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcNhanvien.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnChuyen.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnUndo.Enabled = btnGhi.Enabled = false;
            groupBox1.Enabled = false;
            check = false;
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
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

                    this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);

                    this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);
                }
            }
            catch (Exception)
            {
                return;
            }
        
        }

        private void gcNhanvien_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
           
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSDT_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
