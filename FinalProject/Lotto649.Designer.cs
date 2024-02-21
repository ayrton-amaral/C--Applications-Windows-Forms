namespace FinalProject
{
    partial class Lotto649
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lotto649));
            this.labelLotto649 = new System.Windows.Forms.Label();
            this.pictureBoxLotto649 = new System.Windows.Forms.PictureBox();
            this.listBoxLotto649 = new System.Windows.Forms.ListBox();
            this.btnGenerate649 = new System.Windows.Forms.Button();
            this.btnRead649 = new System.Windows.Forms.Button();
            this.btnExitLotto649 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLotto649)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLotto649
            // 
            this.labelLotto649.AutoSize = true;
            this.labelLotto649.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLotto649.Location = new System.Drawing.Point(28, 26);
            this.labelLotto649.Name = "labelLotto649";
            this.labelLotto649.Size = new System.Drawing.Size(177, 18);
            this.labelLotto649.TabIndex = 0;
            this.labelLotto649.Text = "The winning numbers are:";
            // 
            // pictureBoxLotto649
            // 
            this.pictureBoxLotto649.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLotto649.Image")));
            this.pictureBoxLotto649.Location = new System.Drawing.Point(31, 60);
            this.pictureBoxLotto649.Name = "pictureBoxLotto649";
            this.pictureBoxLotto649.Size = new System.Drawing.Size(271, 161);
            this.pictureBoxLotto649.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLotto649.TabIndex = 1;
            this.pictureBoxLotto649.TabStop = false;
            // 
            // listBoxLotto649
            // 
            this.listBoxLotto649.FormattingEnabled = true;
            this.listBoxLotto649.Location = new System.Drawing.Point(343, 26);
            this.listBoxLotto649.Name = "listBoxLotto649";
            this.listBoxLotto649.Size = new System.Drawing.Size(76, 264);
            this.listBoxLotto649.TabIndex = 2;
            // 
            // btnGenerate649
            // 
            this.btnGenerate649.Location = new System.Drawing.Point(31, 309);
            this.btnGenerate649.Name = "btnGenerate649";
            this.btnGenerate649.Size = new System.Drawing.Size(109, 39);
            this.btnGenerate649.TabIndex = 3;
            this.btnGenerate649.Text = "&Generate";
            this.btnGenerate649.UseVisualStyleBackColor = true;
            this.btnGenerate649.Click += new System.EventHandler(this.btnGenerate649_Click);
            // 
            // btnRead649
            // 
            this.btnRead649.Location = new System.Drawing.Point(193, 308);
            this.btnRead649.Name = "btnRead649";
            this.btnRead649.Size = new System.Drawing.Size(109, 41);
            this.btnRead649.TabIndex = 4;
            this.btnRead649.Text = "&Read File";
            this.btnRead649.UseVisualStyleBackColor = true;
            this.btnRead649.Click += new System.EventHandler(this.btnRead649_Click);
            // 
            // btnExitLotto649
            // 
            this.btnExitLotto649.Location = new System.Drawing.Point(326, 309);
            this.btnExitLotto649.Name = "btnExitLotto649";
            this.btnExitLotto649.Size = new System.Drawing.Size(109, 39);
            this.btnExitLotto649.TabIndex = 5;
            this.btnExitLotto649.Text = "E&xit";
            this.btnExitLotto649.UseVisualStyleBackColor = true;
            this.btnExitLotto649.Click += new System.EventHandler(this.btnExitLotto649_Click);
            // 
            // Lotto649
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 375);
            this.Controls.Add(this.btnExitLotto649);
            this.Controls.Add(this.btnRead649);
            this.Controls.Add(this.btnGenerate649);
            this.Controls.Add(this.listBoxLotto649);
            this.Controls.Add(this.pictureBoxLotto649);
            this.Controls.Add(this.labelLotto649);
            this.Name = "Lotto649";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lotto 649 - Ayrton";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLotto649)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLotto649;
        private System.Windows.Forms.PictureBox pictureBoxLotto649;
        private System.Windows.Forms.ListBox listBoxLotto649;
        private System.Windows.Forms.Button btnGenerate649;
        private System.Windows.Forms.Button btnRead649;
        private System.Windows.Forms.Button btnExitLotto649;
    }
}