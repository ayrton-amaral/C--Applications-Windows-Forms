namespace FinalProject
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLotto649 = new System.Windows.Forms.Button();
            this.btnLottoMax = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTemperatureConverter = new System.Windows.Forms.Button();
            this.btnMoneyExchange = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnIPvalidator = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(31, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(489, 296);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(481, 270);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generated Numbers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLotto649);
            this.groupBox1.Controls.Add(this.btnLottoMax);
            this.groupBox1.Location = new System.Drawing.Point(32, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lotto";
            // 
            // btnLotto649
            // 
            this.btnLotto649.Image = ((System.Drawing.Image)(resources.GetObject("btnLotto649.Image")));
            this.btnLotto649.Location = new System.Drawing.Point(231, 48);
            this.btnLotto649.Name = "btnLotto649";
            this.btnLotto649.Size = new System.Drawing.Size(124, 120);
            this.btnLotto649.TabIndex = 1;
            this.btnLotto649.UseVisualStyleBackColor = true;
            this.btnLotto649.Click += new System.EventHandler(this.btnLotto649_Click);
            // 
            // btnLottoMax
            // 
            this.btnLottoMax.Image = ((System.Drawing.Image)(resources.GetObject("btnLottoMax.Image")));
            this.btnLottoMax.Location = new System.Drawing.Point(54, 48);
            this.btnLottoMax.Name = "btnLottoMax";
            this.btnLottoMax.Size = new System.Drawing.Size(124, 120);
            this.btnLottoMax.TabIndex = 0;
            this.btnLottoMax.UseVisualStyleBackColor = true;
            this.btnLottoMax.Click += new System.EventHandler(this.btnLottoMax_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(481, 270);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Conversions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTemperatureConverter);
            this.groupBox2.Controls.Add(this.btnMoneyExchange);
            this.groupBox2.Location = new System.Drawing.Point(34, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 210);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conversions";
            // 
            // btnTemperatureConverter
            // 
            this.btnTemperatureConverter.Image = ((System.Drawing.Image)(resources.GetObject("btnTemperatureConverter.Image")));
            this.btnTemperatureConverter.Location = new System.Drawing.Point(228, 45);
            this.btnTemperatureConverter.Name = "btnTemperatureConverter";
            this.btnTemperatureConverter.Size = new System.Drawing.Size(129, 119);
            this.btnTemperatureConverter.TabIndex = 1;
            this.btnTemperatureConverter.UseVisualStyleBackColor = true;
            this.btnTemperatureConverter.Click += new System.EventHandler(this.btnTemperatureConverter_Click);
            // 
            // btnMoneyExchange
            // 
            this.btnMoneyExchange.Image = ((System.Drawing.Image)(resources.GetObject("btnMoneyExchange.Image")));
            this.btnMoneyExchange.Location = new System.Drawing.Point(56, 45);
            this.btnMoneyExchange.Name = "btnMoneyExchange";
            this.btnMoneyExchange.Size = new System.Drawing.Size(129, 119);
            this.btnMoneyExchange.TabIndex = 0;
            this.btnMoneyExchange.UseVisualStyleBackColor = true;
            this.btnMoneyExchange.Click += new System.EventHandler(this.btnMoneyExchange_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCalculator);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(481, 270);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Simple Calculator";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCalculator
            // 
            this.btnCalculator.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculator.Image")));
            this.btnCalculator.Location = new System.Drawing.Point(162, 50);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(136, 164);
            this.btnCalculator.TabIndex = 0;
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnIPvalidator);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(481, 270);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "IP v4 validator";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnIPvalidator
            // 
            this.btnIPvalidator.Image = ((System.Drawing.Image)(resources.GetObject("btnIPvalidator.Image")));
            this.btnIPvalidator.Location = new System.Drawing.Point(158, 44);
            this.btnIPvalidator.Name = "btnIPvalidator";
            this.btnIPvalidator.Size = new System.Drawing.Size(145, 164);
            this.btnIPvalidator.TabIndex = 0;
            this.btnIPvalidator.UseVisualStyleBackColor = true;
            this.btnIPvalidator.Click += new System.EventHandler(this.btnIPvalidator_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(401, 344);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 34);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 393);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmDashboard";
            this.Text = "Dashboard - Ayrton Amaral";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLotto649;
        private System.Windows.Forms.Button btnLottoMax;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTemperatureConverter;
        private System.Windows.Forms.Button btnMoneyExchange;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnIPvalidator;
        private System.Windows.Forms.Button btnExit;
    }
}

