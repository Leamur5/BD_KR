
namespace KR1
{
    partial class NetworkForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.communicationTypeTextBox = new System.Windows.Forms.TextBox();
            this.topologyTextBox = new System.Windows.Forms.TextBox();
            this.ipAdressTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.InternetAccess = new System.Windows.Forms.CheckBox();
            this.networkDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.networkBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bD_KRDataSet3 = new KR1.BD_KRDataSet();
            this.networkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.networkTableAdapter3 = new KR1.BD_KRDataSetTableAdapters.NetworkTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.networkDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.networkBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_KRDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.networkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 42);
            this.label1.TabIndex = 35;
            this.label1.Text = "Сеть";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Тип связи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Топология";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "IP-адрес";
            // 
            // communicationTypeTextBox
            // 
            this.communicationTypeTextBox.Location = new System.Drawing.Point(145, 81);
            this.communicationTypeTextBox.Name = "communicationTypeTextBox";
            this.communicationTypeTextBox.Size = new System.Drawing.Size(152, 20);
            this.communicationTypeTextBox.TabIndex = 40;
            // 
            // topologyTextBox
            // 
            this.topologyTextBox.Location = new System.Drawing.Point(145, 119);
            this.topologyTextBox.Name = "topologyTextBox";
            this.topologyTextBox.Size = new System.Drawing.Size(152, 20);
            this.topologyTextBox.TabIndex = 41;
            // 
            // ipAdressTextBox
            // 
            this.ipAdressTextBox.Location = new System.Drawing.Point(145, 155);
            this.ipAdressTextBox.Name = "ipAdressTextBox";
            this.ipAdressTextBox.Size = new System.Drawing.Size(152, 20);
            this.ipAdressTextBox.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Доступ к интернету";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.deleteButton);
            this.controlsPanel.Controls.Add(this.addButton);
            this.controlsPanel.Controls.Add(this.closeButton);
            this.controlsPanel.Controls.Add(this.saveButton);
            this.controlsPanel.Location = new System.Drawing.Point(165, 341);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(471, 106);
            this.controlsPanel.TabIndex = 99;
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
            // InternetAccess
            // 
            this.InternetAccess.AutoSize = true;
            this.InternetAccess.Location = new System.Drawing.Point(479, 119);
            this.InternetAccess.Name = "InternetAccess";
            this.InternetAccess.Size = new System.Drawing.Size(15, 14);
            this.InternetAccess.TabIndex = 100;
            this.InternetAccess.UseVisualStyleBackColor = true;
            // 
            // networkDataGridView
            // 
            this.networkDataGridView.AutoGenerateColumns = false;
            this.networkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.networkDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn8});
            this.networkDataGridView.DataSource = this.networkBindingSource1;
            this.networkDataGridView.Location = new System.Drawing.Point(129, 185);
            this.networkDataGridView.Name = "networkDataGridView";
            this.networkDataGridView.Size = new System.Drawing.Size(546, 150);
            this.networkDataGridView.TabIndex = 101;
            this.networkDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.networkDataGridView_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CommunicationType";
            this.dataGridViewTextBoxColumn6.HeaderText = "CommunicationType";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Topology";
            this.dataGridViewTextBoxColumn7.HeaderText = "Topology";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "InternetAccess";
            this.dataGridViewCheckBoxColumn2.HeaderText = "InternetAccess";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IPAdress";
            this.dataGridViewTextBoxColumn8.HeaderText = "IPAdress";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // networkBindingSource1
            // 
            this.networkBindingSource1.DataMember = "Network";
            this.networkBindingSource1.DataSource = this.bD_KRDataSet3;
            // 
            // bD_KRDataSet3
            // 
            this.bD_KRDataSet3.DataSetName = "BD_KRDataSet";
            this.bD_KRDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // networkBindingSource
            // 
            this.networkBindingSource.DataMember = "Network";
            // 
            // networkTableAdapter3
            // 
            this.networkTableAdapter3.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 34);
            this.button1.TabIndex = 102;
            this.button1.Text = "Отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KR1.Properties.Resources.img_87385;
            this.pictureBox1.Location = new System.Drawing.Point(12, 302);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.TabIndex = 112;
            this.pictureBox1.TabStop = false;
            // 
            // NetworkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 459);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.networkDataGridView);
            this.Controls.Add(this.InternetAccess);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipAdressTextBox);
            this.Controls.Add(this.topologyTextBox);
            this.Controls.Add(this.communicationTypeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "NetworkForm";
            this.Text = "NetworkForm";
            this.Load += new System.EventHandler(this.NetworkForm_Load);
            this.Click += new System.EventHandler(this.NetworkForm_Click);
            this.controlsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.networkDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.networkBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_KRDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.networkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox communicationTypeTextBox;
        private System.Windows.Forms.TextBox topologyTextBox;
        private System.Windows.Forms.TextBox ipAdressTextBox;
        private BD_KRDataSet bD_KRDataSet;
        private BD_KRDataSetTableAdapters.NetworkTableAdapter networkTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckBox InternetAccess;
        private System.Windows.Forms.DataGridView networkDataGridView;
        private BD_KRDataSet bD_KRDataSet1;
        private BD_KRDataSetTableAdapters.NetworkTableAdapter networkTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn communicationTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn topologyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn internetAccessDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPAdressDataGridViewTextBoxColumn;
        private BD_KRDataSet bD_KRDataSet2;
        private System.Windows.Forms.BindingSource networkBindingSource;
        private BD_KRDataSetTableAdapters.NetworkTableAdapter networkTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private BD_KRDataSet bD_KRDataSet3;
        private System.Windows.Forms.BindingSource networkBindingSource1;
        private BD_KRDataSetTableAdapters.NetworkTableAdapter networkTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}