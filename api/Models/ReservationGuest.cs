namespace api.Models
{
    public class ReservationGuest
    {
        public int ReservationId { get; set; }
        public Reservation? Reservation { get; set; }
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string LastName { get; set; }
        public string? MiddleName { get; set; }
        public bool IsChild { get; set; }
        public int? Age { get; set; }
    }
}