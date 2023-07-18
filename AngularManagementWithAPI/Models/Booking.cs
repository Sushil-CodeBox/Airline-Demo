using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirlineManagement.Models
{
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FlightID { get; set; }
        public string FlightName { get; set; }
        public string Departure { get; set; }

        [DisplayFormat(DataFormatString = "d/M/yyyy")]
        public DateTime DepartureDate { get; set; }
        public string Arrival { get; set; }

        [DisplayFormat(DataFormatString = "d/M/yyyy")]
        public DateTime ArrivalDate { get; set; }

        [DisplayFormat(DataFormatString = "d/M/yyyy")]
        public DateTime BookingDate { get; set; }
        public string? BookerName { get; set; }
        public int BookingAmount { get; set; }
    }
}
