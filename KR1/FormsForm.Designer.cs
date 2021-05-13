
namespace KR1
{
    partial class FormsForm
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
            this.adminFormsBtn = new System.Windows.Forms.Button();
            this.stuffFormsBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminFormsBtn
            // 
            this.adminFormsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminFormsBtn.Location = new System.Drawing.Point(66, 31);
            this.adminFormsBtn.Name = "adminFormsBtn";
            this.adminFormsBtn.Size = new System.Drawing.Size(192, 57);
            this.adminFormsBtn.TabIndex = 7;
            this.adminFormsBtn.Text = "Формы Администрирования";
            this.adminFormsBtn.UseVisualStyleBackColor = true;
            this.adminFormsBtn.Click += new System.EventHandler(this.adminFormsBtn_Click);
            // 
            // stuffFormsBtn
            // 
            this.stuffFormsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stuffFormsBtn.Location = new System.Drawing.Point(66, 123);
            this.stuffFormsBtn.Name = "stuffFormsBtn";
            this.stuffFormsBtn.Size = new System.Drawing.Size(192, 61);
            this.stuffFormsBtn.TabIndex = 8;
            this.stuffFormsBtn.Text = "Формы Обслуживания";
            this.stuffFormsBtn.UseVisualStyleBackColor = true;
            this.stuffFormsBtn.Click += new System.EventHandler(this.stuffFormsBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBtn.Location = new System.Drawing.Point(66, 222);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(192, 56);
            this.backBtn.TabIndex = 9;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // FormsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 349);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.stuffFormsBtn);
            this.Controls.Add(this.adminFormsBtn);
            this.Name = "FormsForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adminFormsBtn;
        private System.Windows.Forms.Button stuffFormsBtn;
        private System.Windows.Forms.Button backBtn;
    }
}