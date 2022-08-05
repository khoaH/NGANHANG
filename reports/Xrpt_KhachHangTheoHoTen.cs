using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace NGANHANG.reports
{
    public partial class Xrpt_KhachHangTheoHoTen : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_KhachHangTheoHoTen()
        {
            InitializeComponent();
            this.sqlDataSource2.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource2.Fill();
        }

    }
}
