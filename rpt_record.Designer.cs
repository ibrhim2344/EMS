namespace min
{
    partial class rpt_record
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EMSDataSet = new min.EMSDataSet();
            this.rbcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rbcTableAdapter = new min.EMSDataSetTableAdapters.rbcTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbcBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.rbcBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "min.Attendance_departure.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(668, 456);
            this.reportViewer1.TabIndex = 0;
            // 
            // EMSDataSet
            // 
            this.EMSDataSet.DataSetName = "EMSDataSet";
            this.EMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rbcBindingSource
            // 
            this.rbcBindingSource.DataMember = "rbc";
            this.rbcBindingSource.DataSource = this.EMSDataSet;
            // 
            // rbcTableAdapter
            // 
            this.rbcTableAdapter.ClearBeforeFill = true;
            // 
            // rpt_record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 456);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rpt_record";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تقرير السجلات";
            this.Load += new System.EventHandler(this.rpt_record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbcBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rbcBindingSource;
        private EMSDataSet EMSDataSet;
        private EMSDataSetTableAdapters.rbcTableAdapter rbcTableAdapter;
    }
}