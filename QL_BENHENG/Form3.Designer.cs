
namespace QL_BENHENG
{
    partial class Form3
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
            this.QLBHDataSet1 = new QL_BENHENG.QLBHDataSet1();
            this.CTPXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CTPXTableAdapter = new QL_BENHENG.QLBHDataSet1TableAdapters.CTPXTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLBHDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTPXBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CTPXBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL_BENHENG.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(554, 476);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLBHDataSet1
            // 
            this.QLBHDataSet1.DataSetName = "QLBHDataSet1";
            this.QLBHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CTPXBindingSource
            // 
            this.CTPXBindingSource.DataMember = "CTPX";
            this.CTPXBindingSource.DataSource = this.QLBHDataSet1;
            // 
            // CTPXTableAdapter
            // 
            this.CTPXTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 476);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLBHDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTPXBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CTPXBindingSource;
        private QLBHDataSet1 QLBHDataSet1;
        private QLBHDataSet1TableAdapters.CTPXTableAdapter CTPXTableAdapter;
    }
}