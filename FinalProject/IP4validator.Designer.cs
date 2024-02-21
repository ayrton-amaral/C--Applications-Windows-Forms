namespace FinalProject
{
    partial class IP4validator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnExitIP = new System.Windows.Forms.Button();
            this.btnResetIP = new System.Windows.Forms.Button();
            this.btnValidateIP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Today:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter IP address :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnExitIP
            // 
            this.btnExitIP.Location = new System.Drawing.Point(254, 130);
            this.btnExitIP.Name = "btnExitIP";
            this.btnExitIP.Size = new System.Drawing.Size(103, 30);
            this.btnExitIP.TabIndex = 7;
            this.btnExitIP.Text = "E&xit";
            this.btnExitIP.UseVisualStyleBackColor = true;
            this.btnExitIP.Click += new System.EventHandler(this.btnExitIP_Click);
            // 
            // btnResetIP
            // 
            this.btnResetIP.Location = new System.Drawing.Point(135, 130);
            this.btnResetIP.Name = "btnResetIP";
            this.btnResetIP.Size = new System.Drawing.Size(103, 30);
            this.btnResetIP.TabIndex = 6;
            this.btnResetIP.Text = "&Reset";
            this.btnResetIP.UseVisualStyleBackColor = true;
            this.btnResetIP.Click += new System.EventHandler(this.btnResetIP_Click);
            // 
            // btnValidateIP
            // 
            this.btnValidateIP.Location = new System.Drawing.Point(15, 130);
            this.btnValidateIP.Name = "btnValidateIP";
            this.btnValidateIP.Size = new System.Drawing.Size(103, 30);
            this.btnValidateIP.TabIndex = 5;
            this.btnValidateIP.Text = "&Validate IP";
            this.btnValidateIP.UseVisualStyleBackColor = true;
            this.btnValidateIP.Click += new System.EventHandler(this.btnValidateIP_Click);
            // 
            // IP4validator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 187);
            this.Controls.Add(this.btnExitIP);
            this.Controls.Add(this.btnResetIP);
            this.Controls.Add(this.btnValidateIP);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IP4validator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP4-Validator";
            this.Load += new System.EventHandler(this.IP4validator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnExitIP;
        private System.Windows.Forms.Button btnResetIP;
        private System.Windows.Forms.Button btnValidateIP;
    }
}