using NGANHANG.reports;
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
    public partial class Frpt_KhachHangTheoHoTen : Form
    {
        

        public Frpt_KhachHangTheoHoTen()
        {
            InitializeComponent();
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
            }
            catch(Exception)
            {

            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            Xrpt_KhachHangTheoHoTen rpt = new Xrpt_KhachHangTheoHoTen();
            String t = cmbChinhNhanh.Text.ToUpper();
            rpt.lblTieuDe.Text = "DANH SÁCH KHÁCH HÀNG "+t;
            DevExpress.XtraReports.UI.ReportPrintTool print = new DevExpress.XtraReports.UI.ReportPrintTool(rpt);
            print.ShowPreviewDialog();


        }

        private void Frpt_KhachHangTheoHoTen_Load(object sender, EventArgs e)
        {
            cmbChinhNhanh.DataSource = Program.bds_dspm;
            cmbChinhNhanh.DisplayMember = "TENCN";
            cmbChinhNhanh.ValueMember = "TENSERVER";
            cmbChinhNhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "NGANHANG")
            {
                cmbChinhNhanh.Enabled = true;
            }
            else
            {
                cmbChinhNhanh.Enabled = false;
            }
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
