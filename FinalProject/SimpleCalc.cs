using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject
{
    public partial class SimpleCalc : Form
    {
        public SimpleCalc()
        {
            InitializeComponent();
        }

        private CalculatorClass calculator = new CalculatorClass(); // global object to calculate in each event/method.

        private void buttonNbrs_Click(object sender, EventArgs e)
        {
            // An event is generated for all numbers (and point) Buttons at once below:
            txtboxCurrentCalc.Text += ((System.Windows.Forms.Button)sender).Text; // the object sender is 'Button type'.
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (Decimal.TryParse(txtboxCurrentCalc.Text, out decimal displayValue))
            {
                calculator.Add(displayValue);

                textBoxHistoric.Text = calculator.Operand1.ToString() + " + ";
                txtboxCurrentCalc.Text = "";
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (Decimal.TryParse(txtboxCurrentCalc.Text, out decimal displayValue))
            {
                calculator.Subtract(displayValue);

                textBoxHistoric.Text = calculator.Operand1.ToString() + " - ";
                txtboxCurrentCalc.Text = "";
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (Decimal.TryParse(txtboxCurrentCalc.Text, out decimal displayValue))
            {
                calculator.Multiply(displayValue);

                textBoxHistoric.Text = calculator.Operand1.ToString() + " * ";
                txtboxCurrentCalc.Text = "";
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (Decimal.TryParse(txtboxCurrentCalc.Text, out decimal displayValue))
            {
                calculator.Divide(displayValue);

                textBoxHistoric.Text = calculator.Operand1.ToString() + " / ";
                txtboxCurrentCalc.Text = "";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e) 
        {
            if (Decimal.TryParse(txtboxCurrentCalc.Text, out decimal displayValue))
            {
                calculator.EqualsOp(displayValue); // here the object calculator came with the properties values populated.
                textBoxHistoric.Text += (txtboxCurrentCalc.Text) + " = " + calculator.CurrentValue.ToString();

                calculator.Clear();
                txtboxCurrentCalc.Text = "";


                // Write in Text File:
                FileStream fs = null;

                try
                {
                    fs = new FileStream(@".\Calculator.txt", FileMode.Append, FileAccess.Write);

                    // Create the output stream for a text file that exists
                    StreamWriter textOut = new StreamWriter(fs);

                    // Write the following fields into text file:
                    textOut.WriteLine(textBoxHistoric.Text);
                    textOut.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (fs != null) fs.Close();
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            calculator.Clear();
            txtboxCurrentCalc.Text = "";
            textBoxHistoric.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application? ", "Exit ?", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }
    }
}
