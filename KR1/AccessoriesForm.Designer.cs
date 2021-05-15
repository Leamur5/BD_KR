
namespace KR1
{
    partial class AccessoriesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ViewTextBox = new System.Windows.Forms.TextBox();
            this.costNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.purchaseComboBox = new System.Windows.Forms.ComboBox();
            this.purchasesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.purchasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AccessoriesDataGridView = new System.Windows.Forms.DataGridView();
            this.accessoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accessoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.PurchaseDataGridView = new System.Windows.Forms.DataGridView();
            this.changePurchaseButton = new System.Windows.Forms.Button();
            this.bD_KRDataSet3 = new KR1.BD_KRDataSet();
            this.accessoriesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.accessoriesTableAdapter3 = new KR1.BD_KRDataSetTableAdapters.AccessoriesTableAdapter();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.purchasesTableAdapter3 = new KR1.BD_KRDataSetTableAdapters.PurchasesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.costNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessoriesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoriesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoriesBindingSource)).BeginInit();
            this.controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_KRDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoriesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 42);
            this.label1.TabIndex = 37;
            this.label1.Text = "Комплектующие";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Вид";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Стоимость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Номер закупки";
            // 
            // ViewTextBox
            // 
            this.ViewTextBox.Location = new System.Drawing.Point(156, 72);
            this.ViewTextBox.Name = "ViewTextBox";
            this.ViewTextBox.Size = new System.Drawing.Size(152, 20);
            this.ViewTextBox.TabIndex = 42;
            // 
            // costNumericUpDown
            // 
            this.costNumericUpDown.Location = new System.Drawing.Point(156, 108);
            this.costNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.costNumericUpDown.Name = "costNumericUpDown";
            this.costNumericUpDown.Size = new System.Drawing.Size(152, 20);
            this.costNumericUpDown.TabIndex = 97;
            // 
            // purchaseComboBox
            // 
            this.purchaseComboBox.DataSource = this.purchasesBindingSource2;
            this.purchaseComboBox.DisplayMember = "ID";
            this.purchaseComboBox.FormattingEnabled = true;
            this.purchaseComboBox.Location = new System.Drawing.Point(156, 144);
            this.purchaseComboBox.Name = "purchaseComboBox";
            this.purchaseComboBox.Size = new System.Drawing.Size(152, 21);
            this.purchaseComboBox.TabIndex = 106;
            this.purchaseComboBox.ValueMember = "UnitId";
            // 
            // purchasesBindingSource1
            // 
            this.purchasesBindingSource1.DataMember = "Purchases";
            // 
            // purchasesBindingSource
            // 
            this.purchasesBindingSource.DataMember = "Purchases";
            // 
            // AccessoriesDataGridView
            // 
            this.AccessoriesDataGridView.AutoGenerateColumns = false;
            this.AccessoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccessoriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.AccessoriesDataGridView.DataSource = this.accessoriesBindingSource2;
            this.AccessoriesDataGridView.Location = new System.Drawing.Point(345, 72);
            this.AccessoriesDataGridView.Name = "AccessoriesDataGridView";
            this.AccessoriesDataGridView.Size = new System.Drawing.Size(457, 150);
            this.AccessoriesDataGridView.TabIndex = 107;
            this.AccessoriesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccessoriesDataGridView_CellContentClick);
            this.AccessoriesDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AccessoriesDataGridView_RowHeaderMouseClick);
            // 
            // accessoriesBindingSource1
            // 
            this.accessoriesBindingSource1.DataMember = "Accessories";
            // 
            // accessoriesBindingSource
            // 
            this.accessoriesBindingSource.DataMember = "Accessories";
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.deleteButton);
            this.controlsPanel.Controls.Add(this.addButton);
            this.controlsPanel.Controls.Add(this.closeButton);
            this.controlsPanel.Controls.Add(this.saveButton);
            this.controlsPanel.Location = new System.Drawing.Point(165, 429);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(471, 114);
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
            // PurchaseDataGridView
            // 
            this.PurchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchaseDataGridView.Location = new System.Drawing.Point(131, 269);
            this.PurchaseDataGridView.Name = "PurchaseDataGridView";
            this.PurchaseDataGridView.Size = new System.Drawing.Size(547, 127);
            this.PurchaseDataGridView.TabIndex = 110;
            // 
            // changePurchaseButton
            // 
            this.changePurchaseButton.Location = new System.Drawing.Point(131, 219);
            this.changePurchaseButton.Name = "changePurchaseButton";
            this.changePurchaseButton.Size = new System.Drawing.Size(122, 23);
            this.changePurchaseButton.TabIndex = 111;
            this.changePurchaseButton.Text = "Закупка";
            this.changePurchaseButton.UseVisualStyleBackColor = true;
            this.changePurchaseButton.Click += new System.EventHandler(this.changePurchaseButton_Click);
            // 
            // bD_KRDataSet3
            // 
            this.bD_KRDataSet3.DataSetName = "BD_KRDataSet";
            this.bD_KRDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accessoriesBindingSource2
            // 
            this.accessoriesBindingSource2.DataMember = "Accessories";
            this.accessoriesBindingSource2.DataSource = this.bD_KRDataSet3;
            // 
            // accessoriesTableAdapter3
            // 
            this.accessoriesTableAdapter3.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn9.HeaderText = "ID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "View";
            this.dataGridViewTextBoxColumn10.HeaderText = "View";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Cost";
            this.dataGridViewTextBoxColumn11.HeaderText = "Cost";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Purchase_ID";
            this.dataGridViewTextBoxColumn12.HeaderText = "Purchase_ID";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // purchasesBindingSource2
            // 
            this.purchasesBindingSource2.DataMember = "Purchases";
            this.purchasesBindingSource2.DataSource = this.bD_KRDataSet3;
            // 
            // purchasesTableAdapter3
            // 
            this.purchasesTableAdapter3.ClearBeforeFill = true;
            // 
            // AccessoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 555);
            this.Controls.Add(this.changePurchaseButton);
            this.Controls.Add(this.PurchaseDataGridView);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.AccessoriesDataGridView);
            this.Controls.Add(this.purchaseComboBox);
            this.Controls.Add(this.costNumericUpDown);
            this.Controls.Add(this.ViewTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AccessoriesForm";
            this.Text = "AccessoriesForm";
            this.Load += new System.EventHandler(this.AccessoriesForm_Load);
            this.Click += new System.EventHandler(this.AccessoriesForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.costNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccessoriesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoriesBindingSource)).EndInit();
            this.controlsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_KRDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoriesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ViewTextBox;
        private System.Windows.Forms.NumericUpDown costNumericUpDown;
        private System.Windows.Forms.ComboBox purchaseComboBox;
        private System.Windows.Forms.DataGridView AccessoriesDataGridView;
        private BD_KRDataSet bD_KRDataSet;
        private BD_KRDataSetTableAdapters.AccessoriesTableAdapter accessoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveButton;
        private BD_KRDataSetTableAdapters.PurchasesTableAdapter purchasesTableAdapter;
        private System.Windows.Forms.DataGridView PurchaseDataGridView;
        private BD_KRDataSet bD_KRDataSet1;
        private System.Windows.Forms.BindingSource accessoriesBindingSource;
        private BD_KRDataSetTableAdapters.AccessoriesTableAdapter accessoriesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource purchasesBindingSource;
        private BD_KRDataSetTableAdapters.PurchasesTableAdapter purchasesTableAdapter1;
        private System.Windows.Forms.Button changePurchaseButton;
        private BD_KRDataSet bD_KRDataSet2;
        private System.Windows.Forms.BindingSource accessoriesBindingSource1;
        private BD_KRDataSetTableAdapters.AccessoriesTableAdapter accessoriesTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource purchasesBindingSource1;
        private BD_KRDataSetTableAdapters.PurchasesTableAdapter purchasesTableAdapter2;
        private BD_KRDataSet bD_KRDataSet3;
        private System.Windows.Forms.BindingSource accessoriesBindingSource2;
        private BD_KRDataSetTableAdapters.AccessoriesTableAdapter accessoriesTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.BindingSource purchasesBindingSource2;
        private BD_KRDataSetTableAdapters.PurchasesTableAdapter purchasesTableAdapter3;
    }
}