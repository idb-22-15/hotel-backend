using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=db.db");
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationBooker> ReservationBookers { get; set; }
        public DbSet<ReservationGuest> ReservationGuests { get; set; }

    }
}