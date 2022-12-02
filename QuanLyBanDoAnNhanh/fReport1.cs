using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanDoAnNhanh
{
    public partial class fReport1 : Form
    {
        public fReport1()
        {
            InitializeComponent();
            LoadDateTimePickerReport();
        }

        private void fReport1_Load(object sender, EventArgs e)
        {
            this.uSP_GetListBillByDateReportTableAdapter.Fill(this.quanLyBanDoAnNhanhDataSet.USP_GetListBillByDateReport, dtpkFromDate.Value, dtpkToDate.Value);
            this.reportViewer1.RefreshReport();
        }
      

        void LoadDateTimePickerReport()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            this.uSP_GetListBillByDateReportTableAdapter.Fill(this.quanLyBanDoAnNhanhDataSet.USP_GetListBillByDateReport, dtpkFromDate.Value, dtpkToDate.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}
