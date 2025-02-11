namespace min
{
    partial class rpt_goto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpt_goto));
            this.ttgotoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EMSDataSet = new min.EMSDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ttgotoTableAdapter = new min.EMSDataSetTableAdapters.ttgotoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ttgotoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ttgotoBindingSource
            // 
            this.ttgotoBindingSource.DataMember = "ttgoto";
            this.ttgotoBindingSource.DataSource = this.EMSDataSet;
            // 
            // EMSDataSet
            // 
            this.EMSDataSet.DataSetName = "EMSDataSet";
            this.EMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ttgotoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "min.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(639, 445);
            this.reportViewer1.TabIndex = 0;
            // 
            // ttgotoTableAdapter
            // 
            this.ttgotoTableAdapter.ClearBeforeFill = true;
            // 
            // rpt_goto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 445);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "rpt_goto";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقراير غياب و إجازة";
            this.Load += new System.EventHandler(this.rpt_goto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ttgotoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ttgotoBindingSource;
        private EMSDataSet EMSDataSet;
        private EMSDataSetTableAdapters.ttgotoTableAdapter ttgotoTableAdapter;
    }
}