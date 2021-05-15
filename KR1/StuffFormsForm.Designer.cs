
namespace KR1
{
    partial class StuffFormsForm
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
            this.providerBtn = new System.Windows.Forms.Button();
            this.repairBtn = new System.Windows.Forms.Button();
            this.locationBtn = new System.Windows.Forms.Button();
            this.purchasesBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // providerBtn
            // 
            this.providerBtn.Location = new System.Drawing.Point(33, 22);
            this.providerBtn.Name = "providerBtn";
            this.providerBtn.Size = new System.Drawing.Size(126, 49);
            this.providerBtn.TabIndex = 13;
            this.providerBtn.Text = "Поставщики";
            this.providerBtn.UseVisualStyleBackColor = true;
            this.providerBtn.Click += new System.EventHandler(this.providerBtn_Click);
            // 
            // repairBtn
            // 
            this.repairBtn.Location = new System.Drawing.Point(33, 95);
            this.repairBtn.Name = "repairBtn";
            this.repairBtn.Size = new System.Drawing.Size(126, 49);
            this.repairBtn.TabIndex = 14;
            this.repairBtn.Text = "Ремонт";
            this.repairBtn.UseVisualStyleBackColor = true;
            this.repairBtn.Click += new System.EventHandler(this.repairBtn_Click);
            // 
            // locationBtn
            // 
            this.locationBtn.Location = new System.Drawing.Point(33, 170);
            this.locationBtn.Name = "locationBtn";
            this.locationBtn.Size = new System.Drawing.Size(126, 49);
            this.locationBtn.TabIndex = 15;
            this.locationBtn.Text = "Местоположение";
            this.locationBtn.UseVisualStyleBackColor = true;
            this.locationBtn.Click += new System.EventHandler(this.locationBtn_Click);
            // 
            // purchasesBtn
            // 
            this.purchasesBtn.Location = new System.Drawing.Point(33, 248);
            this.purchasesBtn.Name = "purchasesBtn";
            this.purchasesBtn.Size = new System.Drawing.Size(126, 49);
            this.purchasesBtn.TabIndex = 16;
            this.purchasesBtn.Text = "Закупки";
            this.purchasesBtn.UseVisualStyleBackColor = true;
            this.purchasesBtn.Click += new System.EventHandler(this.purchasesBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(33, 325);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(126, 49);
            this.backBtn.TabIndex = 18;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // StuffFormsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 410);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.purchasesBtn);
            this.Controls.Add(this.locationBtn);
            this.Controls.Add(this.repairBtn);
            this.Controls.Add(this.providerBtn);
            this.Name = "StuffFormsForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button providerBtn;
        private System.Windows.Forms.Button repairBtn;
        private System.Windows.Forms.Button locationBtn;
        private System.Windows.Forms.Button purchasesBtn;
        private System.Windows.Forms.Button backBtn;
    }
}