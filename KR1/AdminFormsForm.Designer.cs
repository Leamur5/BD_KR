
namespace KR1
{
    partial class AdminFormsForm
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
            this.computersBtn = new System.Windows.Forms.Button();
            this.networkBtn = new System.Windows.Forms.Button();
            this.employeeBtn = new System.Windows.Forms.Button();
            this.accessoriesBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // computersBtn
            // 
            this.computersBtn.Location = new System.Drawing.Point(73, 22);
            this.computersBtn.Name = "computersBtn";
            this.computersBtn.Size = new System.Drawing.Size(149, 54);
            this.computersBtn.TabIndex = 11;
            this.computersBtn.Text = "Компьютеры";
            this.computersBtn.UseVisualStyleBackColor = true;
            this.computersBtn.Click += new System.EventHandler(this.computersBtn_Click);
            // 
            // networkBtn
            // 
            this.networkBtn.Location = new System.Drawing.Point(73, 99);
            this.networkBtn.Name = "networkBtn";
            this.networkBtn.Size = new System.Drawing.Size(149, 54);
            this.networkBtn.TabIndex = 12;
            this.networkBtn.Text = "Сеть";
            this.networkBtn.UseVisualStyleBackColor = true;
            this.networkBtn.Click += new System.EventHandler(this.networkBtn_Click);
            // 
            // employeeBtn
            // 
            this.employeeBtn.Location = new System.Drawing.Point(73, 180);
            this.employeeBtn.Name = "employeeBtn";
            this.employeeBtn.Size = new System.Drawing.Size(149, 54);
            this.employeeBtn.TabIndex = 13;
            this.employeeBtn.Text = "Сотрудники";
            this.employeeBtn.UseVisualStyleBackColor = true;
            this.employeeBtn.Click += new System.EventHandler(this.employeeBtn_Click);
            // 
            // accessoriesBtn
            // 
            this.accessoriesBtn.Location = new System.Drawing.Point(73, 257);
            this.accessoriesBtn.Name = "accessoriesBtn";
            this.accessoriesBtn.Size = new System.Drawing.Size(149, 54);
            this.accessoriesBtn.TabIndex = 14;
            this.accessoriesBtn.Text = "Комплектующие";
            this.accessoriesBtn.UseVisualStyleBackColor = true;
            this.accessoriesBtn.Click += new System.EventHandler(this.accessoriesBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(73, 330);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(149, 54);
            this.backBtn.TabIndex = 15;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // AdminFormsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 396);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.accessoriesBtn);
            this.Controls.Add(this.employeeBtn);
            this.Controls.Add(this.networkBtn);
            this.Controls.Add(this.computersBtn);
            this.Name = "AdminFormsForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button computersBtn;
        private System.Windows.Forms.Button networkBtn;
        private System.Windows.Forms.Button employeeBtn;
        private System.Windows.Forms.Button accessoriesBtn;
        private System.Windows.Forms.Button backBtn;
    }
}