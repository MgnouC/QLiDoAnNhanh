namespace QuanLyBanDoAnNhanh
{
    partial class fReport1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fReport1));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.quanLyBanDoAnNhanhDataSet = new QuanLyBanDoAnNhanh.QuanLyBanDoAnNhanhDataSet();
            this.uSPGetListBillByDateReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_GetListBillByDateReportTableAdapter = new QuanLyBanDoAnNhanh.QuanLyBanDoAnNhanhDataSetTableAdapters.USP_GetListBillByDateReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanDoAnNhanhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListBillByDateReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uSPGetListBillByDateReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBanDoAnNhanh.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(28, 82);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(750, 356);
            this.reportViewer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Đến ngày: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Từ ngày: ";
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.Location = new System.Drawing.Point(296, 41);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(240, 20);
            this.dtpkToDate.TabIndex = 5;
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.Location = new System.Drawing.Point(28, 41);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(247, 20);
            this.dtpkFromDate.TabIndex = 4;
            // 
            // btnViewReport
            // 
            this.btnViewReport.BackColor = System.Drawing.Color.Yellow;
            this.btnViewReport.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReport.Location = new System.Drawing.Point(583, 12);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(154, 55);
            this.btnViewReport.TabIndex = 8;
            this.btnViewReport.Text = "Xuất";
            this.btnViewReport.UseVisualStyleBackColor = false;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // quanLyBanDoAnNhanhDataSet
            // 
            this.quanLyBanDoAnNhanhDataSet.DataSetName = "QuanLyBanDoAnNhanhDataSet";
            this.quanLyBanDoAnNhanhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPGetListBillByDateReportBindingSource
            // 
            this.uSPGetListBillByDateReportBindingSource.DataMember = "USP_GetListBillByDateReport";
            this.uSPGetListBillByDateReportBindingSource.DataSource = this.quanLyBanDoAnNhanhDataSet;
            // 
            // uSP_GetListBillByDateReportTableAdapter
            // 
            this.uSP_GetListBillByDateReportTableAdapter.ClearBeforeFill = true;
            // 
            // fReport1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpkToDate);
            this.Controls.Add(this.dtpkFromDate);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fReport1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Thống kê";
            this.Load += new System.EventHandler(this.fReport1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanDoAnNhanhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListBillByDateReportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.BindingSource uSPGetListBillByDateReportBindingSource;
        private QuanLyBanDoAnNhanhDataSet quanLyBanDoAnNhanhDataSet;
        private QuanLyBanDoAnNhanhDataSetTableAdapters.USP_GetListBillByDateReportTableAdapter uSP_GetListBillByDateReportTableAdapter;
    }
}