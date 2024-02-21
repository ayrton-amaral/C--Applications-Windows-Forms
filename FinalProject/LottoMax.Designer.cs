namespace FinalProject
{
    partial class LottoMax
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LottoMax));
            this.labelLottoMax = new System.Windows.Forms.Label();
            this.btnGenerateMax = new System.Windows.Forms.Button();
            this.btnReadMax = new System.Windows.Forms.Button();
            this.btnExitLottoMax = new System.Windows.Forms.Button();
            this.listBoxLottoMax = new System.Windows.Forms.ListBox();
            this.pictureBoxLottoMax = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLottoMax)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLottoMax
            // 
            this.labelLottoMax.AutoSize = true;
            this.labelLottoMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLottoMax.Location = new System.Drawing.Point(32, 26);
            this.labelLottoMax.Name = "labelLottoMax";
            this.labelLottoMax.Size = new System.Drawing.Size(177, 18);
            this.labelLottoMax.TabIndex = 0;
            this.labelLottoMax.Text = "The winning numbers are:";
            // 
            // btnGenerateMax
            // 
            this.btnGenerateMax.Location = new System.Drawing.Point(35, 309);
            this.btnGenerateMax.Name = "btnGenerateMax";
            this.btnGenerateMax.Size = new System.Drawing.Size(109, 39);
            this.btnGenerateMax.TabIndex = 1;
            this.btnGenerateMax.Text = "&Generate";
            this.btnGenerateMax.UseVisualStyleBackColor = true;
            this.btnGenerateMax.Click += new System.EventHandler(this.btnGenerateMax_Click);
            // 
            // btnReadMax
            // 
            this.btnReadMax.Location = new System.Drawing.Point(197, 309);
            this.btnReadMax.Name = "btnReadMax";
            this.btnReadMax.Size = new System.Drawing.Size(109, 39);
            this.btnReadMax.TabIndex = 2;
            this.btnReadMax.Text = "&Read File";
            this.btnReadMax.UseVisualStyleBackColor = true;
            this.btnReadMax.Click += new System.EventHandler(this.btnReadMax_Click);
            // 
            // btnExitLottoMax
            // 
            this.btnExitLottoMax.Location = new System.Drawing.Point(328, 309);
            this.btnExitLottoMax.Name = "btnExitLottoMax";
            this.btnExitLottoMax.Size = new System.Drawing.Size(109, 39);
            this.btnExitLottoMax.TabIndex = 3;
            this.btnExitLottoMax.Text = "E&xit";
            this.btnExitLottoMax.UseVisualStyleBackColor = true;
            this.btnExitLottoMax.Click += new System.EventHandler(this.btnExitLottoMax_Click);
            // 
            // listBoxLottoMax
            // 
            this.listBoxLottoMax.FormattingEnabled = true;
            this.listBoxLottoMax.Location = new System.Drawing.Point(349, 26);
            this.listBoxLottoMax.Name = "listBoxLottoMax";
            this.listBoxLottoMax.Size = new System.Drawing.Size(76, 264);
            this.listBoxLottoMax.TabIndex = 4;
            // 
            // pictureBoxLottoMax
            // 
            this.pictureBoxLottoMax.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLottoMax.Image")));
            this.pictureBoxLottoMax.Location = new System.Drawing.Point(35, 63);
            this.pictureBoxLottoMax.Name = "pictureBoxLottoMax";
            this.pictureBoxLottoMax.Size = new System.Drawing.Size(271, 161);
            this.pictureBoxLottoMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLottoMax.TabIndex = 5;
            this.pictureBoxLottoMax.TabStop = false;
            // 
            // LottoMax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 372);
            this.Controls.Add(this.pictureBoxLottoMax);
            this.Controls.Add(this.listBoxLottoMax);
            this.Controls.Add(this.btnExitLottoMax);
            this.Controls.Add(this.btnReadMax);
            this.Controls.Add(this.btnGenerateMax);
            this.Controls.Add(this.labelLottoMax);
            this.Name = "LottoMax";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lotto Max - Ayrton";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLottoMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLottoMax;
        private System.Windows.Forms.Button btnGenerateMax;
        private System.Windows.Forms.Button btnReadMax;
        private System.Windows.Forms.Button btnExitLottoMax;
        private System.Windows.Forms.ListBox listBoxLottoMax;
        private System.Windows.Forms.PictureBox pictureBoxLottoMax;
    }
}