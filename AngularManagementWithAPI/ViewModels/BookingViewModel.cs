namespace AirlineManagement.ViewModels
{
    public class BookingViewModel
    {
        public int FlightID { get; set; }
        public string FlightName { get; set; }
        public string Departure { get; set; }
        public DateTime DepartureDate { get; set; }
        public string Arrival { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime BookingDate { get; set; }
        public string? BookerName { get; set;}
        public int BookingAmount { get; set;}
         
    }
}
