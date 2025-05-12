using System;
using System.IO;
using System.Windows.Forms;

namespace VISHA_HAMEED
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // This event handler is for deleting the PNR when the text changes. 
            // You can leave it as it is.
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This event handler is for deleting the PNR when the text changes. 
            // You can leave it as it is.
        }
        private void label2_Click(object sender, EventArgs e)
        {
            // This event handler is for deleting the PNR when the text changes. 
            // You can leave it as it is.
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // This event handler is for deleting the PNR when the text changes. 
            // You can leave it as it is.
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // This event handler is for deleting the PNR when the text changes. 
            // You can leave it as it is.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This event handler is for the "Delete" button click.
            // Get the PNR from the text box
            string pnrText = textBox1.Text.Trim();
            int pnrToDelete;

            if (int.TryParse(pnrText, out pnrToDelete))
            {
                // Get the selected flight type from the combo box
                string flightType = comboBox1.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(flightType))
                {
                    bool deleted = DeletePnr(pnrToDelete, flightType);
                    if (deleted)
                    {
                        MessageBox.Show("PNR deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The PNR number does not exist in the selected flight type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a flight type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid PNR number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool DeletePnr(int pnr, string flightType)
        {
            try
            {
                bool found = DeletePnrFromFile(flightType == "Domestic Flight" ? "booking_data.txt" : "FlightInformation.txt", pnr);
                return found;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool DeletePnrFromFile(string fileName, int pnr)
        {
            string tempFileName = Path.GetTempFileName();
            bool found = false;

            using (StreamReader reader = new StreamReader(fileName))
            using (StreamWriter writer = new StreamWriter(tempFileName))
            {
                string line;
                bool skipLines = false;

                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("PNR: " + pnr))
                    {
                        // Once a match is found, mark as found and start skipping lines
                        found = true;
                        skipLines = true;
                        continue;
                    }

                    if (skipLines)
                    {
                        // Skip the lines until the next PNR is found
                        if (line.StartsWith("PNR:"))
                        {
                            skipLines = false; // Stop skipping lines once the next PNR is encountered
                            writer.WriteLine(line); // Write the next PNR line as well
                        }
                        continue;
                    }

                    // Write the line to the temporary file
                    writer.WriteLine(line);
                }
            }

            // Replace the original file with the temporary file
            if (found)
            {
                File.Delete(fileName);
                File.Move(tempFileName, fileName);
            }
            else
            {
                // Delete the temporary file if no PNR was found
                File.Delete(tempFileName);
            }

            return found;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
