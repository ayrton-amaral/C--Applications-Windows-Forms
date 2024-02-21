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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject
{
    public partial class IP4validator : Form
    {
        public IP4validator()
        {
            InitializeComponent();
        }

        // Global variables
        string currentDateTime = DateTime.Now.ToLongDateString();
        DateTime openingTime;

        private void IP4validator_Load(object sender, EventArgs e)
        {
            // Display current date and time in the label
            label1.Text = currentDateTime;

            // Save the exactly hour when the form is loaded
            openingTime = DateTime.Now;
        }

        private void btnValidateIP_Click(object sender, EventArgs e)
        {
            string ipToValidate = textBox1.Text.Trim();

            Regex myRegex = new Regex(@"^(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}$");

            // Check if the input matches the regular expression
            bool isValid = myRegex.IsMatch(ipToValidate);

            if (isValid)
            {
                MessageBox.Show(ipToValidate + "\nThe IP is correct", "Valid IP");

                // Write the validated IP in a binary file:          
                string bPath = @".\binaryValidIP.txt";

                FileStream fs = null;

                try
                {
                    fs = new FileStream(bPath, FileMode.Append, FileAccess.Write);

                    // create the output stream for a binary file that exists
                    BinaryWriter binaryOut = new BinaryWriter(fs);

                    // write the fields into text file
                    binaryOut.Write(textBox1.Text.Trim() + currentDateTime);

                    // close the output stream for the text file
                    binaryOut.Close();
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

            else
            {
                MessageBox.Show(ipToValidate + "\nThe IP must have 4 bytes\ninteger number between 0 to 255\nseparated by a dot (255.255.255.255)", "Error");
            }
        }

        private void btnResetIP_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            textBox1.Focus();
        }

        private void btnExitIP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application? ", "Exit ?", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                // Calculating the time spent between opening and closing the application:
                TimeSpan usageTime = DateTime.Now - openingTime;

                // Show the time spent using the application:
                MessageBox.Show("The usage time of IP validator was:\n" + usageTime.Minutes + " minutes and " + usageTime.Seconds + " seconds.", "Usage Time");

                this.Close();
            }
        }
    }
}
