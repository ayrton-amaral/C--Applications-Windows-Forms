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

namespace FinalProject
{
    public partial class MoneyExchange : Form
    {
        public MoneyExchange()
        {
            InitializeComponent();
        }

        string pathMoneyEx = @".\MoneyConversions.txt";

        private void MoneyExchange_Load(object sender, EventArgs e)
        {
            radioFromCAD.Checked = true;
            radioToCAD.Checked = true;

            textBox1.Text = "0";
        }

        private void btnConvertMoney_Click(object sender, EventArgs e)
        {
            // Instanciating objects of currency:
            Currency cad = new Currency(1, "CAD");
            Currency usd = new Currency(1.36, "USD");
            Currency eur = new Currency(1.50, "EUR");
            Currency gbp = new Currency(1.65, "GBP");
            Currency brl = new Currency(0.28, "BRL");

            double valueInserted = Convert.ToDouble(textBox1.Text);
            double valueIncad = 0;
            double convertedValue = 0;

            string currencyDisplayFrom = "";
            string currencyDisplayTo = "";

            // From:
            if (radioFromCAD.Checked)
            {
                valueIncad = cad.ConvertToCAD(valueInserted);
                currencyDisplayFrom = cad.CurrencyName;
            }
            if (radioFromUSD.Checked)
            {
                valueIncad = usd.ConvertToCAD(valueInserted);
                currencyDisplayFrom = usd.CurrencyName;
            }
            if (radioFromEUR.Checked)
            {
                valueIncad = eur.ConvertToCAD(valueInserted);
                currencyDisplayFrom = eur.CurrencyName;
            }
            if (radioFromGBP.Checked)
            {
                valueIncad = gbp.ConvertToCAD(valueInserted);
                currencyDisplayFrom = gbp.CurrencyName;
            }
            if (radioFromBRL.Checked)
            {
                valueIncad = brl.ConvertToCAD(valueInserted);
                currencyDisplayFrom = brl.CurrencyName;
            }

            // To:
            if (radioToCAD.Checked)
            {
                convertedValue = cad.FromCADtoCurrency(valueIncad);
                currencyDisplayTo = cad.CurrencyName;
            }
            if (radioToUSD.Checked)
            {
                convertedValue = usd.FromCADtoCurrency(valueIncad);
                currencyDisplayTo = usd.CurrencyName;
            }
            if (radioToEUR.Checked)
            {
                convertedValue = eur.FromCADtoCurrency(valueIncad);
                currencyDisplayTo = eur.CurrencyName;
            }
            if (radioToGBP.Checked)
            {
                convertedValue = gbp.FromCADtoCurrency(valueIncad);
                currencyDisplayTo = gbp.CurrencyName;
            }
            if (radioToBRL.Checked)
            {
                convertedValue = brl.FromCADtoCurrency(valueIncad);
                currencyDisplayTo = brl.CurrencyName;
            }

            textBox2.Text = Math.Round(convertedValue, 2).ToString();


            // Organize the text file:
            DateTime currentDateTime = DateTime.Now;

            // 100 EUR = 85 USD, 2023 / 3 / 29 10:07:03 AM
            string textRows = $"{valueInserted} {currencyDisplayFrom} = {textBox2.Text} {currencyDisplayTo}, {currentDateTime}";


            // Write in Text File:
            FileStream fs = null;

            try
            {
                fs = new FileStream(pathMoneyEx, FileMode.Append, FileAccess.Write);

                // Create the output stream for a text file that exists
                StreamWriter textOut = new StreamWriter(fs);

                // Write the following fields into text file:
                textOut.WriteLine(textRows);
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

        private void btnReadMoneyEx_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            fs = new FileStream(pathMoneyEx, FileMode.OpenOrCreate, FileAccess.Read);

            string textToDisplay = "";

            // Create the object for the input stream for a text file
            StreamReader streamReader = new StreamReader(fs);

            // Read the data from the file:
            while (streamReader.Peek() != -1)
            {
                string row = streamReader.ReadLine();

                textToDisplay += row + "\n";
            }

            streamReader.Close();
            fs.Close();

            MessageBox.Show(textToDisplay, "MoneyEx - Ayrton");
        }

        private void btnExitMoneyEx_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want\nto quit the application\nMoney Exchange?", "Exit ?", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void radioFrom_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
        }

        private void radioTo_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
        }
    }
}
