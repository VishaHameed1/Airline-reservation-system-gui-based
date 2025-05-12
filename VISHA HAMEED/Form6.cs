using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VISHA_HAMEED
{
    public partial class Form6 : Form
    {
        private static int int_pnr = 200; // Starting PNR code for international flights
        private bool bookingSaved = false; // Flag to track whether booking information has been saved
        private const string FileName = "FlightInformation.txt"; // File to store booking information

        public Form6()
        {
            InitializeComponent();
            // Subscribe to the button click event
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Check if booking information has already been saved
            if (!bookingSaved)
            {
                SaveFlightInformation();
            }
        }

        private void SaveFlightInformation()
        {
            try
            {
                // Ensure all ComboBox and TextBox controls have selected items or text
                if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || comboBox3.SelectedItem == null ||
                    comboBox4.SelectedItem == null || comboBox5.SelectedItem == null || string.IsNullOrWhiteSpace(textBox1.Text) ||
                    string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("Please select all required fields and fill in all required information.", "Error");
                    return;
                }

                // Ensure the selected date is not in the past
                if (dateTimePicker1.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("Please select a future date.", "Error");
                    return;
                }

                // Create a new booking instance using polymorphism
                bookingBase booking = new int_booking
                {
                    PnrInt = GenerateIntPnr(),
                    DateInt = dateTimePicker1.Value.ToShortDateString(),
                    IntDep = comboBox1.SelectedItem.ToString(),
                    IntArr = comboBox2.SelectedItem.ToString(),
                    FlightInt = comboBox3.SelectedItem.ToString(),
                    Meal2 = comboBox4.SelectedItem.ToString(),
                    ModeOfPayment = comboBox5.SelectedItem.ToString(),
                    CardNumber = textBox1.Text,
                    ExpiryDate = textBox2.Text,
                    Cvv = textBox3.Text
                };

                // Write booking information to the file
                using (StreamWriter writer = new StreamWriter(FileName, true))
                {
                    writer.WriteLine("PNR: " + ((int_booking)booking).PnrInt);
                    writer.WriteLine("Date: " + ((int_booking)booking).DateInt);
                    writer.WriteLine("Source: " + ((int_booking)booking).IntDep);
                    writer.WriteLine("Destination: " + ((int_booking)booking).IntArr);
                    writer.WriteLine("Flight: " + ((int_booking)booking).FlightInt);
                    writer.WriteLine("Meal Preference: " + ((int_booking)booking).Meal2);
                    writer.WriteLine("Mode of Payment: " + ((int_booking)booking).ModeOfPayment);
                    writer.WriteLine("Card Number: " + ((int_booking)booking).CardNumber);
                    writer.WriteLine("Expiry Date: " + ((int_booking)booking).ExpiryDate);
                    writer.WriteLine("CVV: " + ((int_booking)booking).Cvv);
                    writer.WriteLine();
                }

                string ticketDetails = $"PNR: {((int_booking)booking).PnrInt}\nDate: {((int_booking)booking).DateInt}\nSource: {((int_booking)booking).IntDep}\nDestination: {((int_booking)booking).IntArr}\nFlight: {((int_booking)booking).FlightInt}\nMeal Preference: {((int_booking)booking).Meal2}\nMode of Payment: {((int_booking)booking).ModeOfPayment}\nCard Number: {((int_booking)booking).CardNumber}\nExpiry Date: {((int_booking)booking).ExpiryDate}\nCVV: {((int_booking)booking).Cvv}";

                // Display ticket details and booking success message in a single message box
                MessageBox.Show(ticketDetails + "\n\nTicket booked successfully!", "Ticket Details");

                // Update flag to indicate that booking information has been saved
                bookingSaved = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private int GenerateIntPnr()
        {
            int newPnr;
            do
            {
                int_pnr++;
                newPnr = int_pnr;
            } while (PnrExists(newPnr));
            return newPnr;
        }

        private bool PnrExists(int pnr)
        {
            if (!File.Exists(FileName))
                return false;

            string[] lines = File.ReadAllLines(FileName);
            return lines.Any(line => line.Contains($"PNR: {pnr}"));
        }
    }
}
