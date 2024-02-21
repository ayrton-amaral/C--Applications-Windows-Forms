namespace FinalProject
{
    partial class SimpleCalc
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
            this.txtboxCurrentCalc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExitCalc = new System.Windows.Forms.Button();
            this.textBoxHistoric = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtboxCurrentCalc
            // 
            this.txtboxCurrentCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCurrentCalc.Location = new System.Drawing.Point(24, 54);
            this.txtboxCurrentCalc.Name = "txtboxCurrentCalc";
            this.txtboxCurrentCalc.ReadOnly = true;
            this.txtboxCurrentCalc.Size = new System.Drawing.Size(300, 38);
            this.txtboxCurrentCalc.TabIndex = 0;
            this.txtboxCurrentCalc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonNbrs_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(80, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonNbrs_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(136, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonNbrs_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(24, 151);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 47);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonNbrs_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(80, 151);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 47);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonNbrs_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(136, 151);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 47);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonNbrs_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(24, 204);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 47);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonNbrs_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(80, 204);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 47);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonNbrs_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(136, 204);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 47);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonNbrs_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(24, 257);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(50, 47);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.buttonNbrs_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(80, 257);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(50, 47);
            this.btnPoint.TabIndex = 11;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.buttonNbrs_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(218, 98);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(50, 47);
            this.btnPlus.TabIndex = 12;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(218, 151);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(50, 47);
            this.btnMinus.TabIndex = 13;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(218, 204);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(50, 47);
            this.btnMultiply.TabIndex = 14;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(218, 257);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(50, 47);
            this.btnDivision.TabIndex = 15;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(274, 98);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(50, 206);
            this.btnResult.TabIndex = 16;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(24, 310);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(162, 47);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExitCalc
            // 
            this.btnExitCalc.Location = new System.Drawing.Point(218, 310);
            this.btnExitCalc.Name = "btnExitCalc";
            this.btnExitCalc.Size = new System.Drawing.Size(106, 47);
            this.btnExitCalc.TabIndex = 18;
            this.btnExitCalc.Text = "E&xit";
            this.btnExitCalc.UseVisualStyleBackColor = true;
            this.btnExitCalc.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBoxHistoric
            // 
            this.textBoxHistoric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHistoric.Location = new System.Drawing.Point(24, 12);
            this.textBoxHistoric.Name = "textBoxHistoric";
            this.textBoxHistoric.ReadOnly = true;
            this.textBoxHistoric.Size = new System.Drawing.Size(300, 23);
            this.textBoxHistoric.TabIndex = 19;
            this.textBoxHistoric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SimpleCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 378);
            this.Controls.Add(this.textBoxHistoric);
            this.Controls.Add(this.btnExitCalc);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtboxCurrentCalc);
            this.Name = "SimpleCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calc - Ayrton";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxCurrentCalc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExitCalc;
        private System.Windows.Forms.TextBox textBoxHistoric;
    }
}