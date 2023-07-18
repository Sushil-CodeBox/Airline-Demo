using AirlineManagement.Identity;
using AirlineManagement.Models;
using AirlineManagement.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AirlineManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private ApplicationDbContext db;

        public BookingController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        [Route("booking")]
       // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult Get()
        {
            //System.Threading.Thread.Sleep(1000);
            List<Booking> bookings =db.tbl_bookings.ToList();

            List<BookingViewModel> projectsViewModel = new List<BookingViewModel>();
            foreach (var booking in bookings)
            {
               projectsViewModel.Add(new BookingViewModel() 
               { FlightID = booking.FlightID, FlightName=booking.FlightName , Departure=booking.Departure, DepartureDate=booking.DepartureDate, Arrival=booking.Arrival,ArrivalDate=booking.ArrivalDate,BookerName=booking.BookerName,BookingAmount=booking.BookingAmount,BookingDate=booking.BookingDate});
            }
            return Ok(projectsViewModel);
        }

        [HttpGet]
        [Route("booking/{searchby}/{searchtext}")]
        public List<Booking> Search(string searchBy, string searchText)
        {
            List<Booking> bookings = new List<Booking>();
            if (searchBy == "flightID")
                bookings = db.tbl_bookings.Where(temp => temp.FlightID.ToString().Contains(searchText)).ToList();
            else if (searchBy == "flightName")
                bookings = db.tbl_bookings.Where(temp => temp.FlightName.Contains(searchText)).ToList();
            if (searchBy == "bookerName")
                bookings = db.tbl_bookings.Where(temp => temp.BookerName.Contains(searchText)).ToList();
            if (searchBy == "bookingAmount")
                bookings = db.tbl_bookings.Where(temp => temp.BookingAmount.ToString().Contains(searchText)).ToList();

            return bookings;
        }
    }
}
