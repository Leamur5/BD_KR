
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
            this.purchaseDataGridView = new System.Windows.Forms.DataGridView();
            this.bD_KRDataSet = new KR1.BD_KRDataSet();
            this.purchasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchasesTableAdapter = new KR1.BD_KRDataSetTableAdapters.PurchasesTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efficiencyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.providerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guaranteePeriodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.providerComboBox = new System.Windows.Forms.ComboBox();
            this.deliveryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.guaranteeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.costNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Efficiency = new System.Windows.Forms.CheckBox();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providerTableAdapter = new KR1.BD_KRDataSetTableAdapters.ProviderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_KRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource)).BeginInit();
            this.controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
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
            // purchaseDataGridView
            // 
            this.purchaseDataGridView.AutoGenerateColumns = false;
            this.purchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.efficiencyDataGridViewCheckBoxColumn,
            this.providerDataGridViewTextBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn,
            this.guaranteePeriodDataGridViewTextBoxColumn,
            this.purchaseAmountDataGridViewTextBoxColumn});
            this.purchaseDataGridView.DataSource = this.purchasesBindingSource;
            this.purchaseDataGridView.Location = new System.Drawing.Point(73, 220);
            this.purchaseDataGridView.Name = "purchaseDataGridView";
            this.purchaseDataGridView.Size = new System.Drawing.Size(645, 150);
            this.purchaseDataGridView.TabIndex = 3;
            this.purchaseDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.purchaseDataGridView_RowHeaderMouseClick);
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
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.deleteButton);
            this.controlsPanel.Controls.Add(this.addButton);
            this.controlsPanel.Controls.Add(this.closeButton);
            this.controlsPanel.Controls.Add(this.saveButton);
            this.controlsPanel.Location = new System.Drawing.Point(165, 376);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(471, 108);
            this.controlsPanel.TabIndex = 109;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(347, 6);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(81, 41);
            this.deleteButton.TabIndex = 57;
            this.deleteButton.Text = "Удалить запись";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(18, 6);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(98, 40);
            this.addButton.TabIndex = 54;
            this.addButton.Text = "Добавить запись";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(186, 54);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(81, 49);
            this.closeButton.TabIndex = 55;
            this.closeButton.Text = "Закрыть форму";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(186, 6);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(84, 40);
            this.saveButton.TabIndex = 53;
            this.saveButton.Text = "Сохранить Запись";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 110;
            this.label3.Text = "Поставщик";
            // 
            // providerComboBox
            // 
            this.providerComboBox.DataSource = this.providerBindingSource;
            this.providerComboBox.DisplayMember = "ProviderName";
            this.providerComboBox.FormattingEnabled = true;
            this.providerComboBox.Location = new System.Drawing.Point(129, 67);
            this.providerComboBox.Name = "providerComboBox";
            this.providerComboBox.Size = new System.Drawing.Size(152, 21);
            this.providerComboBox.TabIndex = 111;
            this.providerComboBox.ValueMember = "UnitId";
            // 
            // deliveryDateTimePicker
            // 
            this.deliveryDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.deliveryDateTimePicker.Location = new System.Drawing.Point(129, 107);
            this.deliveryDateTimePicker.Name = "deliveryDateTimePicker";
            this.deliveryDateTimePicker.Size = new System.Drawing.Size(152, 20);
            this.deliveryDateTimePicker.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 113;
            this.label1.Text = "Дата поставки";
            // 
            // guaranteeTextBox
            // 
            this.guaranteeTextBox.Location = new System.Drawing.Point(129, 148);
            this.guaranteeTextBox.Name = "guaranteeTextBox";
            this.guaranteeTextBox.Size = new System.Drawing.Size(152, 20);
            this.guaranteeTextBox.TabIndex = 114;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 115;
            this.label2.Text = "Гарантия";
            // 
            // costNumericUpDown
            // 
            this.costNumericUpDown.Location = new System.Drawing.Point(484, 67);
            this.costNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.costNumericUpDown.Name = "costNumericUpDown";
            this.costNumericUpDown.Size = new System.Drawing.Size(152, 20);
            this.costNumericUpDown.TabIndex = 116;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 117;
            this.label4.Text = "Сумма закупки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 118;
            this.label5.Text = "Работоспособность";
            // 
            // Efficiency
            // 
            this.Efficiency.AutoSize = true;
            this.Efficiency.Location = new System.Drawing.Point(484, 106);
            this.Efficiency.Name = "Efficiency";
            this.Efficiency.Size = new System.Drawing.Size(15, 14);
            this.Efficiency.TabIndex = 119;
            this.Efficiency.UseVisualStyleBackColor = true;
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataMember = "Provider";
            this.providerBindingSource.DataSource = this.bD_KRDataSet;
            // 
            // providerTableAdapter
            // 
            this.providerTableAdapter.ClearBeforeFill = true;
            // 
            // PurchasesWithEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 489);
            this.Controls.Add(this.Efficiency);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.costNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guaranteeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deliveryDateTimePicker);
            this.Controls.Add(this.providerComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.purchaseDataGridView);
            this.Controls.Add(this.formLabel);
            this.Name = "PurchasesWithEditingForm";
            this.Text = "PurchasesWithEditingForm";
            this.Load += new System.EventHandler(this.PurchasesWithEditingForm_Load);
            this.Click += new System.EventHandler(this.PurchasesForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_KRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource)).EndInit();
            this.controlsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.costNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.DataGridView purchaseDataGridView;
        private BD_KRDataSet bD_KRDataSet;
        private System.Windows.Forms.BindingSource purchasesBindingSource;
        private BD_KRDataSetTableAdapters.PurchasesTableAdapter purchasesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn efficiencyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guaranteePeriodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox providerComboBox;
        private System.Windows.Forms.DateTimePicker deliveryDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox guaranteeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown costNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Efficiency;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private BD_KRDataSetTableAdapters.ProviderTableAdapter providerTableAdapter;
    }
}