using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class TemperatureConverter : Form
    {
        public TemperatureConverter()
        {
            InitializeComponent();
        }

        string path = @".\TempConversions.txt";

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label3.Text = "C";
                label4.Text = "F";
                textBox2.Clear();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label3.Text = "F";
                label4.Text = "C";
                textBox2.Clear();
            }
        }

        private void btnConvertTemp_Click(object sender, EventArgs e)
        {
            double tempToConvert, convertedTemp;
            string textRows = "";
            DateTime currentDateTime = DateTime.Now;

            Regex myRegex = new Regex(@"^-?\d+(?:\.\d)?$");
            if (myRegex.IsMatch(textBox1.Text.Trim()) == true)
            {
                tempToConvert = Convert.ToDouble(textBox1.Text.Trim());

                if (radioButton1.Checked)
                {
                    // Celsius to Fahrenheit:
                    // (°C × 9/5) + 32 = °F
                    convertedTemp = (tempToConvert * 9 / 5) + 32;
                    convertedTemp = Math.Round(convertedTemp, 1);
                    textBox2.Text = convertedTemp.ToString();

                    if(convertedTemp == 212)
                    {
                        richTextBox.Text = "Water boils";
                        richTextBox.ForeColor = Color.DarkRed;
                    }
                    else if (convertedTemp == 104)
                    {
                        richTextBox.Text = "Hot Bath";
                        richTextBox.ForeColor = Color.Red;
                    }
                    else if (convertedTemp == 98.6)
                    {
                        richTextBox.Text = "Body temperature";
                        richTextBox.ForeColor = Color.DarkOrange;
                    }
                    else if (convertedTemp == 86)
                    {
                        richTextBox.Text = "Beach weather";
                        richTextBox.ForeColor = Color.Orange;
                    }
                    else if (convertedTemp > 50 && convertedTemp < 86)
                    {
                        richTextBox.Text = "Room temperature";
                        richTextBox.ForeColor = Color.Green;
                    }
                    else if (convertedTemp == 50)
                    {
                        richTextBox.Text = "Cool Day";
                        richTextBox.ForeColor = Color.DodgerBlue;
                    }
                    else if (convertedTemp == 32)
                    {
                        richTextBox.Text = "Freezing point of water";
                        richTextBox.ForeColor = Color.DarkBlue;
                    }
                    else if (convertedTemp > -40 && convertedTemp < 32)
                    {
                        richTextBox.Text = "Very Cold Day";
                        richTextBox.ForeColor = Color.DarkBlue;
                    }
                    else if (convertedTemp == -40)
                    {
                        richTextBox.Text = "Extremely Cold Day\n(and the same number!)";
                        richTextBox.ForeColor = Color.Purple;
                    }

                    textRows = $"{tempToConvert} C = {convertedTemp} F,\t{currentDateTime}\t{richTextBox.Text.Replace("\n", " ")}";
                }

                if (radioButton2.Checked)
                {
                    // Fahrenheit to Celsius:
                    // (°F − 32) x 5/9 = °C
                    convertedTemp = (tempToConvert - 32) * 5 / 9;
                    convertedTemp = Math.Round(convertedTemp, 1);
                    textBox2.Text = convertedTemp.ToString();

                    if (convertedTemp == 100)
                    {
                        richTextBox.Text = "Water boils";
                        richTextBox.ForeColor = Color.DarkRed;
                    }
                    else if (convertedTemp == 40)
                    {
                        richTextBox.Text = "Hot Bath";
                        richTextBox.ForeColor = Color.Red;
                    }
                    else if (convertedTemp == 37)
                    {
                        richTextBox.Text = "Body temperature";
                        richTextBox.ForeColor = Color.DarkOrange;
                    }
                    else if (convertedTemp == 30)
                    {
                        richTextBox.Text = "Beach weather";
                        richTextBox.ForeColor = Color.Orange;
                    }
                    else if (convertedTemp < 30 && convertedTemp > 10)
                    {
                        richTextBox.Text = "Room temperature";
                        richTextBox.ForeColor = Color.Green;
                    }
                    else if (convertedTemp == 10)
                    {
                        richTextBox.Text = "Cool Day";
                        richTextBox.ForeColor = Color.DodgerBlue;
                    }
                    else if (convertedTemp == 0)
                    {
                        richTextBox.Text = "Freezing point of water";
                        richTextBox.ForeColor = Color.DarkBlue;
                    }
                    else if (convertedTemp > -40 && convertedTemp < 0)
                    {
                        richTextBox.Text = "Very Cold Day";
                        richTextBox.ForeColor = Color.DarkBlue;
                    }
                    else if (convertedTemp == -40)
                    {
                        richTextBox.Text = "Extremely Cold Day\n(and the same number!)";
                        richTextBox.ForeColor = Color.Purple;
                    }

                    textRows = $"{tempToConvert} F = {convertedTemp} C,\t{currentDateTime}\t{richTextBox.Text.Replace("\n", " ")}";
                }
            }

            // Write in Text File:
            FileStream fs = null;

            try
            {
                fs = new FileStream(path, FileMode.Append, FileAccess.Write);

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

        private void btnReadTemp_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);

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

            MessageBox.Show(textToDisplay, "TempApp - Ayrton");
        }

        private void btnExitTemp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application? ", "Exit ?", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }
    }
}
