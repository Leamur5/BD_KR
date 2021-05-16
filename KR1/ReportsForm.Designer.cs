
namespace KR1
{
    partial class ReportsForm
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
            this.employeesListBtn = new System.Windows.Forms.Button();
            this.dishesListBtn = new System.Windows.Forms.Button();
            this.positionsListBtn = new System.Windows.Forms.Button();
            this.providersListBtn = new System.Windows.Forms.Button();
            this.NDSForeachDishBtn = new System.Windows.Forms.Button();
            this.tablesListBtn = new System.Windows.Forms.Button();
            this.productsListBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeesListBtn
            // 
            this.employeesListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeesListBtn.Location = new System.Drawing.Point(25, 30);
            this.employeesListBtn.Name = "employeesListBtn";
            this.employeesListBtn.Size = new System.Drawing.Size(134, 59);
            this.employeesListBtn.TabIndex = 20;
            this.employeesListBtn.Text = "Комплектующие";
            this.employeesListBtn.UseVisualStyleBackColor = true;
            this.employeesListBtn.Click += new System.EventHandler(this.employeesListBtn_Click);
            // 
            // dishesListBtn
            // 
            this.dishesListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dishesListBtn.Location = new System.Drawing.Point(204, 30);
            this.dishesListBtn.Name = "dishesListBtn";
            this.dishesListBtn.Size = new System.Drawing.Size(134, 59);
            this.dishesListBtn.TabIndex = 21;
            this.dishesListBtn.Text = "Компьютеры";
            this.dishesListBtn.UseVisualStyleBackColor = true;
            this.dishesListBtn.Click += new System.EventHandler(this.dishesListBtn_Click);
            // 
            // positionsListBtn
            // 
            this.positionsListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positionsListBtn.Location = new System.Drawing.Point(25, 117);
            this.positionsListBtn.Name = "positionsListBtn";
            this.positionsListBtn.Size = new System.Drawing.Size(134, 59);
            this.positionsListBtn.TabIndex = 22;
            this.positionsListBtn.Text = "Ремонт";
            this.positionsListBtn.UseVisualStyleBackColor = true;
            this.positionsListBtn.Click += new System.EventHandler(this.positionsListBtn_Click);
            // 
            // providersListBtn
            // 
            this.providersListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.providersListBtn.Location = new System.Drawing.Point(25, 205);
            this.providersListBtn.Name = "providersListBtn";
            this.providersListBtn.Size = new System.Drawing.Size(134, 59);
            this.providersListBtn.TabIndex = 24;
            this.providersListBtn.Text = "Поставщики";
            this.providersListBtn.UseVisualStyleBackColor = true;
            // 
            // NDSForeachDishBtn
            // 
            this.NDSForeachDishBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NDSForeachDishBtn.Location = new System.Drawing.Point(204, 205);
            this.NDSForeachDishBtn.Name = "NDSForeachDishBtn";
            this.NDSForeachDishBtn.Size = new System.Drawing.Size(134, 59);
            this.NDSForeachDishBtn.TabIndex = 25;
            this.NDSForeachDishBtn.Text = "НДС для каждого блюда";
            this.NDSForeachDishBtn.UseVisualStyleBackColor = true;
            // 
            // tablesListBtn
            // 
            this.tablesListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tablesListBtn.Location = new System.Drawing.Point(25, 288);
            this.tablesListBtn.Name = "tablesListBtn";
            this.tablesListBtn.Size = new System.Drawing.Size(134, 59);
            this.tablesListBtn.TabIndex = 26;
            this.tablesListBtn.Text = "Столики";
            this.tablesListBtn.UseVisualStyleBackColor = true;
            // 
            // productsListBtn
            // 
            this.productsListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productsListBtn.Location = new System.Drawing.Point(204, 117);
            this.productsListBtn.Name = "productsListBtn";
            this.productsListBtn.Size = new System.Drawing.Size(134, 59);
            this.productsListBtn.TabIndex = 27;
            this.productsListBtn.Text = "Продукты на складе";
            this.productsListBtn.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBtn.Location = new System.Drawing.Point(204, 288);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(134, 59);
            this.backBtn.TabIndex = 28;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 378);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.productsListBtn);
            this.Controls.Add(this.tablesListBtn);
            this.Controls.Add(this.NDSForeachDishBtn);
            this.Controls.Add(this.providersListBtn);
            this.Controls.Add(this.positionsListBtn);
            this.Controls.Add(this.dishesListBtn);
            this.Controls.Add(this.employeesListBtn);
            this.Name = "ReportsForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button employeesListBtn;
        private System.Windows.Forms.Button dishesListBtn;
        private System.Windows.Forms.Button positionsListBtn;
        private System.Windows.Forms.Button providersListBtn;
        private System.Windows.Forms.Button NDSForeachDishBtn;
        private System.Windows.Forms.Button tablesListBtn;
        private System.Windows.Forms.Button productsListBtn;
        private System.Windows.Forms.Button backBtn;
    }
}