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
            // TODO: This line of code loads data into the 'nGANHANGDataSet.SP_DS_TAIKHOAN' table. You can move, or remove it, as needed.
            this.sP_DS_TAIKHOANTableAdapter.Fill(this.nGANHANGDataSet.SP_DS_TAIKHOAN);
            // TODO: This line of code loads data into the 'nGANHANGDataSet.SP_DS_TAIKHOAN' table. You can move, or remove it, as needed.
            this.sP_DS_TAIKHOANTableAdapter.Fill(this.nGANHANGDataSet.SP_DS_TAIKHOAN);
            // TODO: This line of code loads data into the 'nGANHANGDataSet.SP_DS_TAIKHOAN' table. You can move, or remove it, as needed.
            this.sP_DS_TAIKHOANTableAdapter.Fill(this.nGANHANGDataSet.SP_DS_TAIKHOAN);
            // TODO: This line of code loads data into the 'nGANHANGDataSet.SP_DS_TAIKHOAN' table. You can move, or remove it, as needed.
            this.sP_DS_TAIKHOANTableAdapter.Fill(this.nGANHANGDataSet.SP_DS_TAIKHOAN);
            // TODO: This line of code loads data into the 'nGANHANGDataSet.TaiKhoan' table. You can move, or remove it, as needed.

            if (Program.mGroup == "NGANHANG")
            {
                btnChuyen.Enabled = false;
            }

            txtMANV.Text = Program.username;
            txtNgayChuyen.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

            txtTKNhan.Focus();

        }


    }
}