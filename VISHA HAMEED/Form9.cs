using System;
using System.IO;
using System.Windows.Forms;

namespace VISHA_HAMEED
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        // Method to check ticket details
        void CheckTicket(int pnr, string flightType)
        {
            try
            {
                bool found = false;
                string details = "";
                string fileName = flightType == "Domestic Flight" ? "booking_data.txt" : "FlightInformation.txt";

                // Read from the respective file
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Check if the line contains the PNR string
                        if (line.Contains("PNR: " + pnr))
                        {
                            // If found, extract and concatenate the flight details
                            details = line + Environment.NewLine;
                            for (int i = 0; i < 5; i++)
                            {
                                details += reader.ReadLine() + Environment.NewLine;
                            }
                            found = true;
                            break;
                        }
                    }
                }

                if (found)
                {
                    // If details were found, display them in a message box
                    MessageBox.Show(details, "Ticket Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // If no matching record is found, display a message
                    MessageBox.Show("This PNR number does not exist in the selected flight type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for the Check button click
        private void button1_Click(object sender, EventArgs e)
        {
            // Get the PNR number from the text box
            int pnr;
            if (int.TryParse(txtPnr.Text, out pnr))
            {
                // Get the selected flight type from the combo box
                string flightType = comboBox1.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(flightType))
                {
                    // Call the CheckTicket method to display the passenger details
                    CheckTicket(pnr, flightType);
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
    }
}
