
namespace KR1
{
    partial class ReportPurchasesSumForm
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
            this.PurchasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PurchasesTableAdapter = new KR1.BD_KRDataSetTableAdapters.PurchasesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BD_KRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchasesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.PurchasesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KR1.ReportPurchasesSum.rdlc";
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
            // PurchasesBindingSource
            // 
            this.PurchasesBindingSource.DataMember = "Purchases";
            this.PurchasesBindingSource.DataSource = this.BD_KRDataSet;
            // 
            // PurchasesTableAdapter
            // 
            this.PurchasesTableAdapter.ClearBeforeFill = true;
            // 
            // ReportPurchasesSumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportPurchasesSumForm";
            this.Text = "ReportPurchasesSumForm";
            this.Load += new System.EventHandler(this.ReportPurchasesSumForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BD_KRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchasesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PurchasesBindingSource;
        private BD_KRDataSet BD_KRDataSet;
        private BD_KRDataSetTableAdapters.PurchasesTableAdapter PurchasesTableAdapter;
    }
}