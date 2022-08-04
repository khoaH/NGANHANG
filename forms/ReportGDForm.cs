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
using NGANHANG.reports;
using DevExpress.XtraReports.UI;

namespace NGANHANG.forms
{
    public partial class ReportGDForm : DevExpress.XtraEditors.XtraForm
    {
        public ReportGDForm()
        {
            InitializeComponent();
            dateStart.DateTime = DateTime.Now.AddMonths(-1);
            dateEnd.DateTime = DateTime.Now;
        }

        private void btnTaoBaoCao_Click(object sender, EventArgs e)
        {
            if (txtSoTK.Text.Trim().Equals(""))
            {
                MessageBox.Show("Hãy nhập số tài khoản", "", MessageBoxButtons.OK);
                return;
            }
            else if (!Extra_function.check_ID_TK(txtSoTK.Text.Trim()))
            {
                MessageBox.Show("Số tài khoản không tồn tại", "", MessageBoxButtons.OK);
                txtSoTK.Focus();
                return;
            }
            else if (DateTime.Compare(dateStart.DateTime, dateEnd.DateTime) > 0)
            {
                MessageBox.Show("Thời gian không hợp lệ", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                ReportGD rpt = new ReportGD(txtSoTK.Text.Trim(), dateStart.DateTime.ToString("yyyy-MM-dd"), dateEnd.DateTime.ToString("yyyy-MM-dd"));
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowRibbonPreview();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}