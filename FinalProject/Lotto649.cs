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
    public partial class Lotto649 : Form
    {
        public Lotto649()
        {
            InitializeComponent();
        }

        string path = @".\LottoNbrs.txt";

        private void btnGenerate649_Click(object sender, EventArgs e)
        {
            listBoxLotto649.Items.Clear();

            Random random = new Random();

            // HashSet is a type of collection that doesn't allow to repeat numbers
            HashSet<int> numbersGenerated = new HashSet<int>();

            // Genrating random numbers:
            do
            {
                numbersGenerated.Add(random.Next(1, 49));
            } while (numbersGenerated.Count < 7);

            // Inserting each element generated in the listBox:
            foreach (int element in numbersGenerated)
            {
                listBoxLotto649.Items.Add(element);
            }

            // To organize the rows of the Text File:
            int[] arrNumbers = numbersGenerated.ToArray(); // To access each element as index

            DateTime currentDateTime = DateTime.Now;

            // 649, 2023/3/20 2:17:42 PM, 29,45,42,22,41,18 Bonus 11
            string textRows = $"649, {currentDateTime}, {arrNumbers[0]}, {arrNumbers[1]}, {arrNumbers[2]}, " +
                                    $"{arrNumbers[3]}, {arrNumbers[4]}, {arrNumbers[5]}, Bonus {arrNumbers[6]}";

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

        private void btnRead649_Click(object sender, EventArgs e)
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

            MessageBox.Show(textToDisplay, "Lotto649 - Ayrton");
        }

        private void btnExitLotto649_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application? ", "Exit ?", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }
    }
}
