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
    public partial class TaiKhoanForm : DevExpress.XtraEditors.XtraForm
    {
        public TaiKhoanForm()
        {
            InitializeComponent();
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
        }

        private void taiKhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void TaiKhoanForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nGANHANGDataSet1.SP_DS_KHACHHANG' table. You can move, or remove it, as needed.
            this.sP_DS_KHACHHANGTableAdapter.Fill(this.nGANHANGDataSet1.SP_DS_KHACHHANG);
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'nGANHANGDataSet1.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.nGANHANGDataSet1.TaiKhoan);
            if (Program.mGroup == "NGANHANG")
                btnThemTK.Enabled = false;
        }

        private void taiKhoanBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.taiKhoanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nGANHANGDataSet1);

        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            btnThemTK.Enabled = btnThoat.Enabled = false;
            btnHuy.Enabled = btnLuuTK.Enabled = txtSoTK.Enabled = lookupKH.Enabled = txtSoDu.Enabled = true;
            taiKhoanGridControl.Enabled = false;
            taiKhoanBindingSource.AddNew();
            this.txtNgayTao.Text = DateTime.Now.ToString("yyyy-MM-dd");
            this.txtChiNhanhTK.Text = (Program.mChinhanh == 0 ? "BENTHANH" : "TANDINH");
            return;
        }

        private void btnLuuTK_Click(object sender, EventArgs e)
        {
            if (txtSoTK.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập số tài khoản");
                txtSoTK.Focus();
                return;
            }
            else if (txtSoTK.Text.Trim().Length > 9)
            {
                MessageBox.Show("Số tài khoản tối đa là 9 số");
                txtSoTK.Focus();
                return;
            }
            else if(lookupKH.EditValue == null)
            {
                MessageBox.Show("Bạn chưa chọn khách hàng", "", MessageBoxButtons.OK);
                lookupKH.Focus();
                return;
            }
            else if (Extra_function.check_ID_TK(txtSoTK.Text.Trim()))
            {
                MessageBox.Show("Số tài khoản này đã tồn tại");
                txtSoTK.Focus();
                return;
            }
            else
            {
                try //kiem tra so tai khoan co hop le khong
                {
                    int soTK = Int32.Parse(txtSoTK.Text.Trim());
                    if(soTK <= 0)
                    {
                        MessageBox.Show("Số tài khoản nhập vào không hợp lệ");
                        txtSoTK.Focus();
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Số tài khoản nhập vào không hợp lệ");
                    txtSoTK.Focus();
                    return;
                }
                //Kiem tra so du
                int soDu = 0;
                try
                {
                    soDu = Int32.Parse(txtSoDu.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("Số dư nhập vào không hợp lệ");
                    txtSoDu.Focus();
                    return;
                }
                txtChiNhanhTK.Text = (Program.mChinhanh == 0 ? "BENTHANH" : "TANDINH");
                this.txtNgayTao.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                this.taiKhoanBindingSource.EndEdit();
                this.taiKhoanBindingSource.ResetCurrentItem();

                if (this.taiKhoanTableAdapter.Update(this.nGANHANGDataSet1.TaiKhoan) == 1)
                {
                    MessageBox.Show("Tạo tài khoản thành công", "", MessageBoxButtons.OK);
                    taiKhoanGridControl.Enabled = true;
                    btnThemTK.Enabled = btnThoat.Enabled = true;
                    btnHuy.Enabled = btnLuuTK.Enabled = txtSoTK.Enabled = lookupKH.Enabled = txtSoDu.Enabled = false;
                    return;
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản thất bại", "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            taiKhoanBindingSource.CancelEdit();
            taiKhoanGridControl.Enabled = true;
            this.taiKhoanTableAdapter.Fill(this.nGANHANGDataSet1.TaiKhoan);
            btnThemTK.Enabled = btnThoat.Enabled = true;
            btnHuy.Enabled = btnLuuTK.Enabled = txtSoTK.Enabled = lookupKH.Enabled = txtSoDu.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lookupKH_EditValueChanged(object sender, EventArgs e)
        {
            this.txtCMND.Text = this.lookupKH.EditValue.ToString();
        }
    }
}