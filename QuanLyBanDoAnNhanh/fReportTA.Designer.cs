namespace QuanLyBanDoAnNhanh
{
    partial class fReportTA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fReportTA));
            this.uSPGetListFoodByCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanDoAnNhanhDataSet1 = new QuanLyBanDoAnNhanh.QuanLyBanDoAnNhanhDataSet1();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uSP_GetListFoodByCategoryTableAdapter = new QuanLyBanDoAnNhanh.QuanLyBanDoAnNhanhDataSet1TableAdapters.USP_GetListFoodByCategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListFoodByCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanDoAnNhanhDataSet1)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // uSPGetListFoodByCategoryBindingSource
            // 
            this.uSPGetListFoodByCategoryBindingSource.DataMember = "USP_GetListFoodByCategory";
            this.uSPGetListFoodByCategoryBindingSource.DataSource = this.quanLyBanDoAnNhanhDataSet1;
            // 
            // quanLyBanDoAnNhanhDataSet1
            // 
            this.quanLyBanDoAnNhanhDataSet1.DataSetName = "QuanLyBanDoAnNhanhDataSet1";
            this.quanLyBanDoAnNhanhDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbCategory);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(250, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(320, 47);
            this.panel7.TabIndex = 5;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(111, 17);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(188, 21);
            this.cbCategory.TabIndex = 1;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbFoodCategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh mục:";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSett";
            reportDataSource1.Value = this.uSPGetListFoodByCategoryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBanDoAnNhanh.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(18, 79);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(770, 353);
            this.reportViewer1.TabIndex = 7;
            // 
            // uSP_GetListFoodByCategoryTableAdapter
            // 
            this.uSP_GetListFoodByCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // fReportTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fReportTA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report món";
            this.Load += new System.EventHandler(this.fReportTA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSPGetListFoodByCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanDoAnNhanhDataSet1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPGetListFoodByCategoryBindingSource;
        private QuanLyBanDoAnNhanhDataSet1 quanLyBanDoAnNhanhDataSet1;
        private QuanLyBanDoAnNhanhDataSet1TableAdapters.USP_GetListFoodByCategoryTableAdapter uSP_GetListFoodByCategoryTableAdapter;
    }
}