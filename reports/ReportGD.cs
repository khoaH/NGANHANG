using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace NGANHANG.reports
{
    public partial class ReportGD : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportGD(String soTK, String start, String end)
        {
            InitializeComponent();
            this.sP_REPORT_GDTableAdapter.Connection.ConnectionString = Program.connstr;
            String endFull = end + " 23:59:59";
            String startFull = start + " 00:00:00";
            try
            {
                this.sP_REPORT_GDTableAdapter.Fill(nganhangDataSet11.SP_REPORT_GD, startFull, endFull, soTK);
                lblStart.Text = DateTime.Parse(start).ToString("dd/MM/yyyy");
                lblEnd.Text = DateTime.Parse(end).ToString("dd/MM/yyyy");
                lblSoTK.Text = soTK;
                lblHoTenNV.Text = Program.mHoten;
                lblChiNhanh.Text = (Program.mChinhanh == 0 ? "Bến Thành" : "Tân Định");

                String cmnd = "";
                string strLenh = "EXEC SP_GET_TK '" + soTK + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                else
                {
                    Program.myReader.Read();
                    Decimal sodu = Program.myReader.GetDecimal(2);
                    if (sodu == 0)
                        lblSoDu.Text = "0 VND";
                    else
                        lblSoDu.Text = string.Format("{0:#,### VND}", sodu);
                    cmnd = Program.myReader.GetString(1);
                }
                Program.myReader.Close();

                strLenh = "EXEC SP_GET_KH '" + cmnd + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                else
                {
                    Program.myReader.Read();
                    lblCMND.Text = cmnd;
                    lblHoTen.Text = Program.myReader.GetString(1) + " " + Program.myReader.GetString(2);
                }
                Program.myReader.Close();
            }
            catch(Exception)
            {

            }
        }

    }
}
