using System;

namespace VISHA_HAMEED
{
    public partial class int_booking : bookingBase
    {
        public int PnrInt { get; set; }
        public string FlightInt { get; set; }
        public string DateInt { get; set; }
        public string IntDep { get; set; }
        public string IntArr { get; set; }
        public string Meal2 { get; set; }
        public string ModeOfPayment { get; set; }
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string Cvv { get; set; }

        // Override method to provide specific implementation for international booking
        public override void GetBookingDetails()
        {
            Console.WriteLine($"PNR: {PnrInt}, Flight: {FlightInt}, Date: {DateInt}, Departure: {IntDep}, Arrival: {IntArr}, Meal: {Meal2}, Payment: {ModeOfPayment}");
        }
    }
}
