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
    }
}
