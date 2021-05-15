
namespace KR1
{
    partial class PurchasesWithEditingForm
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
            this.formLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bD_KRDataSet = new KR1.BD_KRDataSet();
            this.purchasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchasesTableAdapter = new KR1.BD_KRDataSetTableAdapters.PurchasesTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efficiencyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.providerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guaranteePeriodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_KRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formLabel.Location = new System.Drawing.Point(67, 24);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(118, 31);
            this.formLabel.TabIndex = 2;
            this.formLabel.Text = "Закупки";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.efficiencyDataGridViewCheckBoxColumn,
            this.providerDataGridViewTextBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn,
            this.guaranteePeriodDataGridViewTextBoxColumn,
            this.purchaseAmountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.purchasesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(73, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // bD_KRDataSet
            // 
            this.bD_KRDataSet.DataSetName = "BD_KRDataSet";
            this.bD_KRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchasesBindingSource
            // 
            this.purchasesBindingSource.DataMember = "Purchases";
            this.purchasesBindingSource.DataSource = this.bD_KRDataSet;
            // 
            // purchasesTableAdapter
            // 
            this.purchasesTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // efficiencyDataGridViewCheckBoxColumn
            // 
            this.efficiencyDataGridViewCheckBoxColumn.DataPropertyName = "Efficiency";
            this.efficiencyDataGridViewCheckBoxColumn.HeaderText = "Efficiency";
            this.efficiencyDataGridViewCheckBoxColumn.Name = "efficiencyDataGridViewCheckBoxColumn";
            // 
            // providerDataGridViewTextBoxColumn
            // 
            this.providerDataGridViewTextBoxColumn.DataPropertyName = "Provider";
            this.providerDataGridViewTextBoxColumn.HeaderText = "Provider";
            this.providerDataGridViewTextBoxColumn.Name = "providerDataGridViewTextBoxColumn";
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            // 
            // guaranteePeriodDataGridViewTextBoxColumn
            // 
            this.guaranteePeriodDataGridViewTextBoxColumn.DataPropertyName = "GuaranteePeriod";
            this.guaranteePeriodDataGridViewTextBoxColumn.HeaderText = "GuaranteePeriod";
            this.guaranteePeriodDataGridViewTextBoxColumn.Name = "guaranteePeriodDataGridViewTextBoxColumn";
            // 
            // purchaseAmountDataGridViewTextBoxColumn
            // 
            this.purchaseAmountDataGridViewTextBoxColumn.DataPropertyName = "PurchaseAmount";
            this.purchaseAmountDataGridViewTextBoxColumn.HeaderText = "PurchaseAmount";
            this.purchaseAmountDataGridViewTextBoxColumn.Name = "purchaseAmountDataGridViewTextBoxColumn";
            // 
            // PurchasesWithEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.formLabel);
            this.Name = "PurchasesWithEditingForm";
            this.Text = "PurchasesWithEditingForm";
            this.Load += new System.EventHandler(this.PurchasesWithEditingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_KRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BD_KRDataSet bD_KRDataSet;
        private System.Windows.Forms.BindingSource purchasesBindingSource;
        private BD_KRDataSetTableAdapters.PurchasesTableAdapter purchasesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn efficiencyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guaranteePeriodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseAmountDataGridViewTextBoxColumn;
    }
}