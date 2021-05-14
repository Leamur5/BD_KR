
namespace KR1
{
    partial class ComputersForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OSTextBox = new System.Windows.Forms.TextBox();
            this.lifeTimeTextBox = new System.Windows.Forms.TextBox();
            this.maxLifeTimeTextBox = new System.Windows.Forms.TextBox();
            this.costNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.networkComboBox = new System.Windows.Forms.ComboBox();
            this.accessoriesComboBox = new System.Windows.Forms.ComboBox();
            this.purchaseComboBox = new System.Windows.Forms.ComboBox();
            this.repairComboBox = new System.Windows.Forms.ComboBox();
            this.computerDataGridView = new System.Windows.Forms.DataGridView();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.bD_KRDataSet1 = new KR1.BD_KRDataSet();
            this.computerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computerTableAdapter1 = new KR1.BD_KRDataSetTableAdapters.ComputerTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationTableAdapter1 = new KR1.BD_KRDataSetTableAdapters.LocationTableAdapter();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter1 = new KR1.BD_KRDataSetTableAdapters.EmployeeTableAdapter();
            this.bDKRDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.networkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.networkTableAdapter1 = new KR1.BD_KRDataSetTableAdapters.NetworkTableAdapter();
            this.accessoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accessoriesTableAdapter1 = new KR1.BD_KRDataSetTableAdapters.AccessoriesTableAdapter();
            this.purchasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchasesTableAdapter1 = new KR1.BD_KRDataSetTableAdapters.PurchasesTableAdapter();
            this.repairBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairTableAdapter1 = new KR1.BD_KRDataSetTableAdapters.RepairTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.costNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerDataGridView)).BeginInit();
            this.controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD_KRDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDKRDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.networkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 42);
            this.label1.TabIndex = 35;
            this.label1.Text = "Компьютеры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Местонахождение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "ОС";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Стоимость";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Срок службы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Макс. срок службы";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // OSTextBox
            // 
            this.OSTextBox.Location = new System.Drawing.Point(159, 99);
            this.OSTextBox.Name = "OSTextBox";
            this.OSTextBox.Size = new System.Drawing.Size(152, 20);
            this.OSTextBox.TabIndex = 47;
            // 
            // lifeTimeTextBox
            // 
            this.lifeTimeTextBox.Location = new System.Drawing.Point(159, 167);
            this.lifeTimeTextBox.Name = "lifeTimeTextBox";
            this.lifeTimeTextBox.Size = new System.Drawing.Size(152, 20);
            this.lifeTimeTextBox.TabIndex = 49;
            // 
            // maxLifeTimeTextBox
            // 
            this.maxLifeTimeTextBox.Location = new System.Drawing.Point(159, 204);
            this.maxLifeTimeTextBox.Name = "maxLifeTimeTextBox";
            this.maxLifeTimeTextBox.Size = new System.Drawing.Size(152, 20);
            this.maxLifeTimeTextBox.TabIndex = 50;
            // 
            // costNumericUpDown
            // 
            this.costNumericUpDown.Location = new System.Drawing.Point(159, 132);
            this.costNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.costNumericUpDown.Name = "costNumericUpDown";
            this.costNumericUpDown.Size = new System.Drawing.Size(152, 20);
            this.costNumericUpDown.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 97;
            this.label7.Text = "Пользователь";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(408, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 98;
            this.label8.Text = "Номер сети";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(408, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 99;
            this.label9.Text = "Комплектующие";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(408, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 100;
            this.label10.Text = "Номер закупки";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(408, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 101;
            this.label11.Text = "Номер ремонта";
            // 
            // userComboBox
            // 
            this.userComboBox.DataSource = this.employeeBindingSource;
            this.userComboBox.DisplayMember = "Surname";
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(513, 66);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(121, 21);
            this.userComboBox.TabIndex = 102;
            this.userComboBox.ValueMember = "UnitId";
            // 
            // networkComboBox
            // 
            this.networkComboBox.DataSource = this.networkBindingSource;
            this.networkComboBox.DisplayMember = "ID";
            this.networkComboBox.FormattingEnabled = true;
            this.networkComboBox.Location = new System.Drawing.Point(513, 99);
            this.networkComboBox.Name = "networkComboBox";
            this.networkComboBox.Size = new System.Drawing.Size(121, 21);
            this.networkComboBox.TabIndex = 103;
            this.networkComboBox.ValueMember = "UnitId";
            // 
            // accessoriesComboBox
            // 
            this.accessoriesComboBox.DataSource = this.accessoriesBindingSource;
            this.accessoriesComboBox.DisplayMember = "View";
            this.accessoriesComboBox.FormattingEnabled = true;
            this.accessoriesComboBox.Location = new System.Drawing.Point(513, 132);
            this.accessoriesComboBox.Name = "accessoriesComboBox";
            this.accessoriesComboBox.Size = new System.Drawing.Size(121, 21);
            this.accessoriesComboBox.TabIndex = 104;
            this.accessoriesComboBox.ValueMember = "UnitId";
            // 
            // purchaseComboBox
            // 
            this.purchaseComboBox.DataSource = this.purchasesBindingSource;
            this.purchaseComboBox.DisplayMember = "ID";
            this.purchaseComboBox.FormattingEnabled = true;
            this.purchaseComboBox.Location = new System.Drawing.Point(513, 166);
            this.purchaseComboBox.Name = "purchaseComboBox";
            this.purchaseComboBox.Size = new System.Drawing.Size(121, 21);
            this.purchaseComboBox.TabIndex = 105;
            this.purchaseComboBox.ValueMember = "UnitId";
            // 
            // repairComboBox
            // 
            this.repairComboBox.DataSource = this.repairBindingSource;
            this.repairComboBox.DisplayMember = "ID";
            this.repairComboBox.FormattingEnabled = true;
            this.repairComboBox.Location = new System.Drawing.Point(513, 203);
            this.repairComboBox.Name = "repairComboBox";
            this.repairComboBox.Size = new System.Drawing.Size(121, 21);
            this.repairComboBox.TabIndex = 106;
            this.repairComboBox.ValueMember = "UnitId";
            // 
            // computerDataGridView
            // 
            this.computerDataGridView.AutoGenerateColumns = false;
            this.computerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.computerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.computerDataGridView.DataSource = this.computerBindingSource;
            this.computerDataGridView.Location = new System.Drawing.Point(12, 259);
            this.computerDataGridView.Name = "computerDataGridView";
            this.computerDataGridView.Size = new System.Drawing.Size(776, 189);
            this.computerDataGridView.TabIndex = 107;
            this.computerDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.computerDataGridView_RowHeaderMouseClick);
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.deleteButton);
            this.controlsPanel.Controls.Add(this.addButton);
            this.controlsPanel.Controls.Add(this.closeButton);
            this.controlsPanel.Controls.Add(this.saveButton);
            this.controlsPanel.Location = new System.Drawing.Point(166, 454);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(471, 109);
            this.controlsPanel.TabIndex = 108;
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
            // locationComboBox
            // 
            this.locationComboBox.DataSource = this.locationBindingSource;
            this.locationComboBox.DisplayMember = "ID";
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Location = new System.Drawing.Point(159, 64);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(152, 21);
            this.locationComboBox.TabIndex = 109;
            this.locationComboBox.ValueMember = "UnitId";
            // 
            // bD_KRDataSet1
            // 
            this.bD_KRDataSet1.DataSetName = "BD_KRDataSet";
            this.bD_KRDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // computerBindingSource
            // 
            this.computerBindingSource.DataMember = "Computer";
            this.computerBindingSource.DataSource = this.bD_KRDataSet1;
            // 
            // computerTableAdapter1
            // 
            this.computerTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Location";
            this.dataGridViewTextBoxColumn2.HeaderText = "Location";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OperatingSystem";
            this.dataGridViewTextBoxColumn3.HeaderText = "OperatingSystem";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cost";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cost";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LifeTime";
            this.dataGridViewTextBoxColumn5.HeaderText = "LifeTime";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MaxLifeTime";
            this.dataGridViewTextBoxColumn6.HeaderText = "MaxLifeTime";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "User";
            this.dataGridViewTextBoxColumn7.HeaderText = "User";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NetworkNumber";
            this.dataGridViewTextBoxColumn8.HeaderText = "NetworkNumber";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Accessories";
            this.dataGridViewTextBoxColumn9.HeaderText = "Accessories";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Purchase_ID";
            this.dataGridViewTextBoxColumn10.HeaderText = "Purchase_ID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Repair_ID";
            this.dataGridViewTextBoxColumn11.HeaderText = "Repair_ID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataMember = "Location";
            this.locationBindingSource.DataSource = this.bD_KRDataSet1;
            // 
            // locationTableAdapter1
            // 
            this.locationTableAdapter1.ClearBeforeFill = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.bD_KRDataSet1;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // bDKRDataSet1BindingSource
            // 
            this.bDKRDataSet1BindingSource.DataSource = this.bD_KRDataSet1;
            this.bDKRDataSet1BindingSource.Position = 0;
            // 
            // networkBindingSource
            // 
            this.networkBindingSource.DataMember = "Network";
            this.networkBindingSource.DataSource = this.bD_KRDataSet1;
            // 
            // networkTableAdapter1
            // 
            this.networkTableAdapter1.ClearBeforeFill = true;
            // 
            // accessoriesBindingSource
            // 
            this.accessoriesBindingSource.DataMember = "Accessories";
            this.accessoriesBindingSource.DataSource = this.bD_KRDataSet1;
            // 
            // accessoriesTableAdapter1
            // 
            this.accessoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // purchasesBindingSource
            // 
            this.purchasesBindingSource.DataMember = "Purchases";
            this.purchasesBindingSource.DataSource = this.bD_KRDataSet1;
            // 
            // purchasesTableAdapter1
            // 
            this.purchasesTableAdapter1.ClearBeforeFill = true;
            // 
            // repairBindingSource
            // 
            this.repairBindingSource.DataMember = "Repair";
            this.repairBindingSource.DataSource = this.bD_KRDataSet1;
            // 
            // repairTableAdapter1
            // 
            this.repairTableAdapter1.ClearBeforeFill = true;
            // 
            // ComputersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 575);
            this.Controls.Add(this.locationComboBox);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.computerDataGridView);
            this.Controls.Add(this.repairComboBox);
            this.Controls.Add(this.purchaseComboBox);
            this.Controls.Add(this.accessoriesComboBox);
            this.Controls.Add(this.networkComboBox);
            this.Controls.Add(this.userComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.costNumericUpDown);
            this.Controls.Add(this.maxLifeTimeTextBox);
            this.Controls.Add(this.lifeTimeTextBox);
            this.Controls.Add(this.OSTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ComputersForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ComputersForm_Load);
            this.Click += new System.EventHandler(this.ComputersForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.costNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerDataGridView)).EndInit();
            this.controlsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bD_KRDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDKRDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.networkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox OSTextBox;
        private System.Windows.Forms.TextBox lifeTimeTextBox;
        private System.Windows.Forms.TextBox maxLifeTimeTextBox;
        private System.Windows.Forms.NumericUpDown costNumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.ComboBox networkComboBox;
        private System.Windows.Forms.ComboBox accessoriesComboBox;
        private System.Windows.Forms.ComboBox purchaseComboBox;
        private System.Windows.Forms.ComboBox repairComboBox;
        private System.Windows.Forms.DataGridView computerDataGridView;
        private BD_KRDataSet bD_KRDataSet;
        private BD_KRDataSetTableAdapters.ComputerTableAdapter computerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatingSystemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lifeTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxLifeTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn networkNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessoriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox locationComboBox;
        private BD_KRDataSetTableAdapters.LocationTableAdapter locationTableAdapter;
        private BD_KRDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private BD_KRDataSetTableAdapters.NetworkTableAdapter networkTableAdapter;
        private BD_KRDataSetTableAdapters.AccessoriesTableAdapter accessoriesTableAdapter;
        private BD_KRDataSetTableAdapters.PurchasesTableAdapter purchasesTableAdapter;
        private BD_KRDataSetTableAdapters.RepairTableAdapter repairTableAdapter;
        private BD_KRDataSet bD_KRDataSet1;
        private System.Windows.Forms.BindingSource computerBindingSource;
        private BD_KRDataSetTableAdapters.ComputerTableAdapter computerTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private BD_KRDataSetTableAdapters.LocationTableAdapter locationTableAdapter1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private BD_KRDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter1;
        private System.Windows.Forms.BindingSource bDKRDataSet1BindingSource;
        private System.Windows.Forms.BindingSource networkBindingSource;
        private BD_KRDataSetTableAdapters.NetworkTableAdapter networkTableAdapter1;
        private System.Windows.Forms.BindingSource accessoriesBindingSource;
        private BD_KRDataSetTableAdapters.AccessoriesTableAdapter accessoriesTableAdapter1;
        private System.Windows.Forms.BindingSource purchasesBindingSource;
        private BD_KRDataSetTableAdapters.PurchasesTableAdapter purchasesTableAdapter1;
        private System.Windows.Forms.BindingSource repairBindingSource;
        private BD_KRDataSetTableAdapters.RepairTableAdapter repairTableAdapter1;
    }
}