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
    public partial class LottoMax : Form
    {
        public LottoMax()
        {
            InitializeComponent();
        }

        string path = @".\LottoNbrs.txt";

        private void btnGenerateMax_Click(object sender, EventArgs e)
        {
            listBoxLottoMax.Items.Clear();

            Random random = new Random();

            // HashSet is a type of collection that doesn't allow to repeat numbers
            HashSet<int> numbersGenerated = new HashSet<int>();

            // Genrating random numbers:
            do
            {
                numbersGenerated.Add(random.Next(1, 50));
            } while (numbersGenerated.Count < 8);

            // Inserting each element generated in the listBox:
            foreach (int element in numbersGenerated)
            {
                listBoxLottoMax.Items.Add(element);
            }

            // To organize the rows of the Text File:
            int[] arrNumbers = numbersGenerated.ToArray(); // To access each element as index

            DateTime currentDateTime = DateTime.Now;

            // Max, 2023/3/20 2:17:36 PM, 31,36,3,39,24,42,4 Bonus 30
            string textRows = $"Max, {currentDateTime}, {arrNumbers[0]}, {arrNumbers[1]}, {arrNumbers[2]}, " +
                                    $"{arrNumbers[3]}, {arrNumbers[4]}, {arrNumbers[5]}, {arrNumbers[6]}, Bonus {arrNumbers[7]}";

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

        private void btnReadMax_Click(object sender, EventArgs e)
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

            MessageBox.Show(textToDisplay, "LottoMax - Ayrton");
        }

        private void btnExitLottoMax_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application? ", "Exit ?", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }
    }
}
