using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NGANHANG.forms
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            stripMANV.Text = "Mã Nhân Viên: " + Program.username;
            stripHoTen.Text = "Họ Tên: " + Program.mHoten;
            stripNhom.Text = "Nhóm: " + Program.mGroup;
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.conn.Close();
            if (Program.login != null)
                Program.login.Close();

        }

        private void btnChuyenTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(ChuyenTienForm));
            if (frm != null) frm.Activate();
            else
            {
                Program.chuyenTien = new ChuyenTienForm();
                Program.chuyenTien.MdiParent = this;
                Program.chuyenTien.Show();
            }

        }

        private void btnGuiRut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(GuiRutForm));
            if (frm != null) frm.Activate();
            else
            {
                Program.guiRut = new GuiRutForm();
                Program.guiRut.MdiParent = this;
                Program.guiRut.Show();
            }
        }

        private void btnTaoLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(TaoAccountForm));
            if (frm != null) frm.Activate();
            else
            {
                Program.taoAccount = new TaoAccountForm();
                Program.taoAccount.MdiParent = this;
                Program.taoAccount.Show();
            }

        }

        private void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormKhachHang));
            if (frm != null) frm.Activate();
            else
            {
                Program.formKhachHang = new FormKhachHang();
                Program.formKhachHang.MdiParent = this;
                Program.formKhachHang.Show();
            }
        }

        private void btnTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(TaiKhoanForm));
            if (frm != null) frm.Activate();
            else
            {
                Program.taiKhoan = new TaiKhoanForm();
                Program.taiKhoan.MdiParent = this;
                Program.taiKhoan.Show();
            }
        }

        private void btnReportGD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(ReportGDForm));
            if (frm != null) frm.Activate();
            else
            {
                Program.reportGD = new ReportGDForm();
                Program.reportGD.MdiParent = this;
                Program.reportGD.Show();
            }
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormNV));
            if (frm != null) frm.Activate();
            else
            {
                Program.formNV = new FormNV();
                Program.formNV.MdiParent = this;
                Program.formNV.Show();
            }
        }

        private void btnReportKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Frpt_KhachHangTheoHoTen));
            if (frm != null) frm.Activate();
            else
            {
                Program.reportKH = new Frpt_KhachHangTheoHoTen();
                Program.reportKH.MdiParent = this;
                Program.reportKH.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult ds = XtraMessageBox.Show("Bạn chắc chắn muốn đăng xuất không ?", "Thông báo !", MessageBoxButtons.YesNo);
            if (ds == DialogResult.Yes)
            {
                Close();

                Program.login.Visible = true;
                Program.bds_dspm.RemoveFilter();
                Program.login.loadAgain();
            }

        }
    }
}
