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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    Id = 1,
                    Title = "Базовый",
                    Price = 1000,
                    Square = 15,
                    MaxGuests = 3,
                    BedsSingle = 1,
                    BedsDouble = 0,
                    HasSafe = false,
                    HasConditioner = false,
                    HasShower = true,
                    HasTub = false,
                    Images = [],
                    Reservations = []
                },
                new Room
                {
                    Id = 2,
                    Title = "Средний",
                    Price = 2000,
                    Square = 20,
                    MaxGuests = 3,
                    BedsSingle = 0,
                    BedsDouble = 1,
                    HasSafe = true,
                    HasConditioner = false,
                    HasShower = true,
                    HasTub = false,
                    Images = [],
                    Reservations = []
                },
                new Room
                {
                    Id = 3,
                    Title = "Люкс",
                    Price = 5000,
                    Square = 35,
                    MaxGuests = 5,
                    BedsSingle = 1,
                    BedsDouble = 1,
                    HasSafe = true,
                    HasConditioner = false,
                    HasShower = false,
                    HasTub = true,
                    Images = [],
                    Reservations = []
                },
                new Room
                {
                    Id = 4,
                    Title = "Делюкс",
                    Price = 7000,
                    Square = 45,
                    MaxGuests = 6,
                    BedsSingle = 1,
                    BedsDouble = 2,
                    HasSafe = true,
                    HasConditioner = true,
                    HasShower = true,
                    HasTub = true,
                    Images = [],
                    Reservations = []
                }
            );
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationBooker> ReservationBookers { get; set; }
        public DbSet<ReservationGuest> ReservationGuests { get; set; }

    }
}