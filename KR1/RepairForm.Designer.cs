
namespace KR1
{
    partial class RepairForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.costNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NeedToWriteOff = new System.Windows.Forms.CheckBox();
            this.repairDataGridView = new System.Windows.Forms.DataGridView();
            this.bD_KRDataSet = new KR1.BD_KRDataSet();
            this.repairBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairTableAdapter = new KR1.BD_KRDataSetTableAdapters.RepairTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.needToWriteOffDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.computerDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.costNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_KRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairBindingSource)).BeginInit();
            this.controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(64, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 42);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ремонт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 114;
            this.label2.Text = "Дата начала";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 115;
            this.label3.Text = "Дата окончания";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 117;
            this.label5.Text = "Стоимость";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 39);
            this.label6.TabIndex = 118;
            this.label6.Text = "Необходимость \r\nсписания\r\n\r\n";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startDateTimePicker.Location = new System.Drawing.Point(153, 82);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(152, 20);
            this.startDateTimePicker.TabIndex = 119;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endDateTimePicker.Location = new System.Drawing.Point(153, 117);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(152, 20);
            this.endDateTimePicker.TabIndex = 120;
            // 
            // costNumericUpDown
            // 
            this.costNumericUpDown.Location = new System.Drawing.Point(153, 157);
            this.costNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.costNumericUpDown.Name = "costNumericUpDown";
            this.costNumericUpDown.Size = new System.Drawing.Size(152, 20);
            this.costNumericUpDown.TabIndex = 122;
            // 
            // NeedToWriteOff
            // 
            this.NeedToWriteOff.AutoSize = true;
            this.NeedToWriteOff.Location = new System.Drawing.Point(153, 194);
            this.NeedToWriteOff.Name = "NeedToWriteOff";
            this.NeedToWriteOff.Size = new System.Drawing.Size(15, 14);
            this.NeedToWriteOff.TabIndex = 123;
            this.NeedToWriteOff.UseVisualStyleBackColor = true;
            // 
            // repairDataGridView
            // 
            this.repairDataGridView.AutoGenerateColumns = false;
            this.repairDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.repairDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.needToWriteOffDataGridViewCheckBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.repairDataGridView.DataSource = this.repairBindingSource;
            this.repairDataGridView.Location = new System.Drawing.Point(327, 83);
            this.repairDataGridView.Name = "repairDataGridView";
            this.repairDataGridView.Size = new System.Drawing.Size(548, 150);
            this.repairDataGridView.TabIndex = 124;
            this.repairDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RepairDataGridView_RowHeaderMouseClick);
            // 
            // bD_KRDataSet
            // 
            this.bD_KRDataSet.DataSetName = "BD_KRDataSet";
            this.bD_KRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repairBindingSource
            // 
            this.repairBindingSource.DataMember = "Repair";
            this.repairBindingSource.DataSource = this.bD_KRDataSet;
            // 
            // repairTableAdapter
            // 
            this.repairTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // needToWriteOffDataGridViewCheckBoxColumn
            // 
            this.needToWriteOffDataGridViewCheckBoxColumn.DataPropertyName = "NeedToWriteOff";
            this.needToWriteOffDataGridViewCheckBoxColumn.HeaderText = "NeedToWriteOff";
            this.needToWriteOffDataGridViewCheckBoxColumn.Name = "needToWriteOffDataGridViewCheckBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.deleteButton);
            this.controlsPanel.Controls.Add(this.addButton);
            this.controlsPanel.Controls.Add(this.closeButton);
            this.controlsPanel.Controls.Add(this.saveButton);
            this.controlsPanel.Location = new System.Drawing.Point(165, 424);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(471, 108);
            this.controlsPanel.TabIndex = 125;
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
            // computerDataGridView
            // 
            this.computerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.computerDataGridView.Location = new System.Drawing.Point(107, 262);
            this.computerDataGridView.Name = "computerDataGridView";
            this.computerDataGridView.Size = new System.Drawing.Size(613, 150);
            this.computerDataGridView.TabIndex = 126;
            // 
            // RepairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 544);
            this.Controls.Add(this.computerDataGridView);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.repairDataGridView);
            this.Controls.Add(this.NeedToWriteOff);
            this.Controls.Add(this.costNumericUpDown);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RepairForm";
            this.Text = "RepairForm";
            this.Load += new System.EventHandler(this.RepairForm_Load);
            this.Click += new System.EventHandler(this.RepairForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.costNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_KRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairBindingSource)).EndInit();
            this.controlsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.computerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.NumericUpDown costNumericUpDown;
        private System.Windows.Forms.CheckBox NeedToWriteOff;
        private System.Windows.Forms.DataGridView repairDataGridView;
        private BD_KRDataSet bD_KRDataSet;
        private System.Windows.Forms.BindingSource repairBindingSource;
        private BD_KRDataSetTableAdapters.RepairTableAdapter repairTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn needToWriteOffDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView computerDataGridView;
    }
}