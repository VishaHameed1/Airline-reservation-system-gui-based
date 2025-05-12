using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VISHA_HAMEED
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Handle text changes for textBox1 here
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // Handle Form5 load event here
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle meal preference selection if needed
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null ||
                comboBox3.SelectedItem == null || comboBox4.SelectedItem == null ||
                string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime selectedDate = dateTimePicker1.Value.Date;
            if (selectedDate < DateTime.Today)
            {
                MessageBox.Show("Please select a date from today onwards.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create an instance of dom_booking class using polymorphism
            bookingBase booking = new dom_booking();

            DateTime date = dateTimePicker1.Value;
            string source = comboBox1.SelectedItem.ToString();
            string destination = comboBox2.SelectedItem.ToString();
            string flight = comboBox3.SelectedItem.ToString();
            string meal = comboBox4.SelectedItem.ToString();

            ((dom_booking)booking).travel_details_dom(date, source, destination, flight);
            ((dom_booking)booking).dom_meals(meal);

            MessageBox.Show($"Generated PNR: {((dom_booking)booking).d_pnr}\nFlight: {((dom_booking)booking).flight_dom}\nDate: {((dom_booking)booking).date_dom}\nDeparture: {((dom_booking)booking).dom_dep}\nArrival: {((dom_booking)booking).dom_arr}\nMeal: {((dom_booking)booking).meal1}");

            SaveBookingToFile((dom_booking)booking);
        }

        private void SaveBookingToFile(dom_booking booking)
        {
            string filePath = "booking_data.txt";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"PNR: {booking.d_pnr}");
                writer.WriteLine($"Date: {booking.date_dom}");
                writer.WriteLine($"Flight: {booking.flight_dom}");
                writer.WriteLine($"Departure: {booking.dom_dep}");
                writer.WriteLine($"Arrival: {booking.dom_arr}");
                writer.WriteLine($"Meal: {booking.meal1}");
                writer.WriteLine("-----");
            }
        }
    }
}
