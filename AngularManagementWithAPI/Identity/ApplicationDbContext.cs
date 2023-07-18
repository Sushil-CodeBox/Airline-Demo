using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AirlineManagement.Models;

namespace AirlineManagement.Identity
{
  public class ApplicationDbContext : IdentityDbContext<RegisterUser>
  {
        
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Booking> tbl_bookings { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
    }
  }
}
