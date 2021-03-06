
namespace KR1
{
    partial class ReportProviderForm
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
            this.BD_KRDataSet = new KR1.BD_KRDataSet();
            this.ProviderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProviderTableAdapter = new KR1.BD_KRDataSetTableAdapters.ProviderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BD_KRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProviderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.ProviderBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KR1.ReportProvider.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // BD_KRDataSet
            // 
            this.BD_KRDataSet.DataSetName = "BD_KRDataSet";
            this.BD_KRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProviderBindingSource
            // 
            this.ProviderBindingSource.DataMember = "Provider";
            this.ProviderBindingSource.DataSource = this.BD_KRDataSet;
            // 
            // ProviderTableAdapter
            // 
            this.ProviderTableAdapter.ClearBeforeFill = true;
            // 
            // ReportProviderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportProviderForm";
            this.Text = "ReportProviderForm";
            this.Load += new System.EventHandler(this.ReportProviderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BD_KRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProviderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProviderBindingSource;
        private BD_KRDataSet BD_KRDataSet;
        private BD_KRDataSetTableAdapters.ProviderTableAdapter ProviderTableAdapter;
    }
}