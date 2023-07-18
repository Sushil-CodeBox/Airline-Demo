using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AirlineManagement.Models
{
    public class RegisterUser:IdentityUser
    {

        public string Gender { get; set; }

        public string? Address { get; set; }
        public long MobileNumber { get; set; }
    }
}
