using System;
using System.IO;
using System.Linq;

namespace VISHA_HAMEED
{
    public class dom_booking : bookingBase
    {
        private static int dom_pnr = 100; // Starting PNR code

        public int d_pnr { get; private set; }
        public string flight_dom { get; private set; }
        public string date_dom { get; private set; }
        public string dom_dep { get; private set; }
        public string dom_arr { get; private set; }
        public string meal1 { get; private set; }

        // Constructor to generate unique PNR
        public dom_booking()
        {
            int maxPnr = GetMaxPnr();
            if (maxPnr >= dom_pnr)
                dom_pnr = maxPnr + 1;

            d_pnr = dom_pnr++;
        }

        // Method to get travel details
        public void travel_details_dom(DateTime date, string source, string destination, string flight)
        {
            date_dom = date.ToString("dd/MM/yyyy");
            flight_dom = flight;

            if (flight.Contains("Air India"))
            {
                dom_dep = "08:00";
                dom_arr = "11:05";
            }
            else if (flight.Contains("IndiGo"))
            {
                dom_dep = "14:00";
                dom_arr = "17:05";
            }
            else if (flight.Contains("SpiceJet"))
            {
                dom_dep = "19:00";
                dom_arr = "22:05";
            }
        }

        // Method to select meals
        public void dom_meals(string meal)
        {
            meal1 = meal;
        }

        // Method to get the maximum existing PNR from file
        private int GetMaxPnr()
        {
            string filePath = "booking_data.txt";
            if (!File.Exists(filePath))
                return dom_pnr;

            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length == 0)
                return dom_pnr;

            int maxPnr = lines
                .Where(line => line.StartsWith("PNR: "))
                .Select(line => int.Parse(line.Split(':')[1].Trim()))
                .Max();

            return maxPnr;
        }

        // Override method to provide specific implementation for domestic booking
        public override void GetBookingDetails()
        {
            Console.WriteLine($"PNR: {d_pnr}, Flight: {flight_dom}, Date: {date_dom}, Departure: {dom_dep}, Arrival: {dom_arr}, Meal: {meal1}");
        }
    }
}
